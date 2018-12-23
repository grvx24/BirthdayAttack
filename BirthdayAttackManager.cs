using BirthdayAttack.FileFactory;
using BirthdayAttack.Hash;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace BirthdayAttack
{
    class BirthdayAttackManager
    {
        public delegate void UpdateStep(int counter, int max);
        public delegate void CompleteStep();
        public event UpdateStep UpdateEvent;
        public event CompleteStep CompleteEvent;

        public event UpdateStep SearchCollisionUpdateEvent;
        public event CompleteStep SearchCollisionCompleteEvent;

        public CollisionModel FindCollision(ResultJsonModel[] loadedHashes,string filename)
        {
            Array.Sort(loadedHashes, delegate (ResultJsonModel x, ResultJsonModel y) { return x.HexHash.CompareTo(y.HexHash); });

            CollisionModel collisionModel = new CollisionModel()
            {
                Filename = filename,
                Data = new List<ResultJsonModel>()
            };
           
            for (int i = 0; i < loadedHashes.Length - 1; i++)
            {
                if (loadedHashes[i].HexHash == loadedHashes[i + 1].HexHash)
                {
                    collisionModel.HasCollision = true;

                    if(!collisionModel.Data.Contains(loadedHashes[i]))
                        collisionModel.Data.Add(loadedHashes[i]);

                    if (!collisionModel.Data.Contains(loadedHashes[i+1]))
                        collisionModel.Data.Add(loadedHashes[i+1]);
                }

                if (i % 1000 == 0)
                {
                    if (SearchCollisionUpdateEvent != null)
                    {
                        SearchCollisionUpdateEvent.Invoke(i,loadedHashes.Length);
                    }
                }

            }

            if (SearchCollisionCompleteEvent != null)
            {
                SearchCollisionCompleteEvent.Invoke();
            }

            return collisionModel;
        }

        public void GenerateJsonHashes(LoadingFileDto[] loadedData, string filename,int hashIndex)
        {
            for (int i = 0; i < loadedData.Length; i++)
            {
                byte[] _4bytes = new byte[4];

                ResultJsonModel[] jsonModel =
                    new ResultJsonModel[loadedData[i].LoadedData.Length / 4];

                var len = loadedData[i].LoadedData.Length;
                for (int j = 0; j < len; j += 4)
                {
                    Array.Copy(loadedData[i].LoadedData, j, _4bytes, 0, 4);
                    var result = HashManager.ShortCutMessageBySpecificFunction(_4bytes, hashIndex);
                    jsonModel[j / 4] = new ResultJsonModel()
                    {
                        HexInput = Helpers.ByteArrayToHex(_4bytes),
                        HexHash = result
                    };

                    if (j % 1000 == 0)
                    {
                        if (UpdateEvent != null)
                            UpdateEvent.Invoke(j, len);
                    }
                }
                var serializer = new JavaScriptSerializer();
                serializer.MaxJsonLength = int.MaxValue;
                var jsonString = serializer.Serialize(jsonModel);

                File.WriteAllText(filename + "_" + i, jsonString);

                if (CompleteEvent != null)
                {
                    CompleteEvent.Invoke();
                }
            }
        }

    }
}
