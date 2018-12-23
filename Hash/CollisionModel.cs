using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAttack.Hash
{
    class CollisionModel
    {
        public string Filename { get; set; }
        public List<ResultJsonModel> Data { get; set; }
        public bool HasCollision { get; set; }
        public int NumberOfCollisions {
            get
            {
                return Data.Count/2;
            }
        }

    }
}
