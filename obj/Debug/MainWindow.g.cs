﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EA605DCFA523D07AB4BBC0B008AE7B02039636FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BirthdayAttack;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BirthdayAttack {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabItems;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox message_num;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListOfHashes;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GenerateHashesBtn;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchCollisionBtn;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox collisions_num;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hash_num;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar Generation_loading;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Loading_percents;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label JsonHashesWarningLabel;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numFilesToGenerate;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button plusBtn;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minusBtn;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FilesGrid;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BAttackLoadedFilesLabel;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar GenerateHashesLoading;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label HashesLoadingPercents;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label generationTimeLabel;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox generationTimeText;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GenerationTime;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox generationHashTime;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label generatingDataLabel;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label hashingDataLabel;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LoadingFilesToHashLabel;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar findCollisionLoading;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label findCollisionLabel;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchingCollisionsTime;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HashDescription;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CollisionsTable;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox FilesWithCollision;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock StatisticsLabel;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock StatisticsLabelPercents;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CollisionsSaveToFileBtn;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RowsInfo;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Paulina;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PaulinaLabel;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Kamil;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock KamilLabel;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Hubert;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HubertLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BirthdayAttack;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tabItems = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.message_num = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 35 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GenerateMessage_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListOfHashes = ((System.Windows.Controls.ListBox)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.ListOfHashes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListOfHashes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 55 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadMessages_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GenerateHashesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.GenerateHashesBtn.Click += new System.Windows.RoutedEventHandler(this.GenerateHashes_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 58 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadHashes_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SearchCollisionBtn = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.SearchCollisionBtn.Click += new System.Windows.RoutedEventHandler(this.SearchCollision_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.collisions_num = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.hash_num = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 65 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SeeMore_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Generation_loading = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 13:
            this.Loading_percents = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.JsonHashesWarningLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.numFilesToGenerate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.plusBtn = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\MainWindow.xaml"
            this.plusBtn.Click += new System.Windows.RoutedEventHandler(this.plusBtn_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.minusBtn = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\MainWindow.xaml"
            this.minusBtn.Click += new System.Windows.RoutedEventHandler(this.minusBtn_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.FilesGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 19:
            this.BAttackLoadedFilesLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 20:
            this.GenerateHashesLoading = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 21:
            this.HashesLoadingPercents = ((System.Windows.Controls.Label)(target));
            return;
            case 22:
            this.generationTimeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 23:
            this.generationTimeText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 24:
            this.GenerationTime = ((System.Windows.Controls.Label)(target));
            return;
            case 25:
            this.generationHashTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 26:
            this.generatingDataLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 27:
            this.hashingDataLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 28:
            this.LoadingFilesToHashLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 29:
            this.findCollisionLoading = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 30:
            this.findCollisionLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 31:
            this.searchingCollisionsTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 32:
            this.HashDescription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 33:
            this.CollisionsTable = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 34:
            this.FilesWithCollision = ((System.Windows.Controls.ListBox)(target));
            
            #line 111 "..\..\MainWindow.xaml"
            this.FilesWithCollision.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilesWithCollision_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 35:
            this.StatisticsLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 36:
            this.StatisticsLabelPercents = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 37:
            this.CollisionsSaveToFileBtn = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\MainWindow.xaml"
            this.CollisionsSaveToFileBtn.Click += new System.Windows.RoutedEventHandler(this.CollisionsSaveToFileBtn_Click);
            
            #line default
            #line hidden
            return;
            case 38:
            this.RowsInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 39:
            this.Paulina = ((System.Windows.Controls.Image)(target));
            
            #line 131 "..\..\MainWindow.xaml"
            this.Paulina.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ImageMouseEnter_event);
            
            #line default
            #line hidden
            
            #line 131 "..\..\MainWindow.xaml"
            this.Paulina.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ImageMouseLeave_event);
            
            #line default
            #line hidden
            return;
            case 40:
            this.PaulinaLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 41:
            this.Kamil = ((System.Windows.Controls.Image)(target));
            
            #line 144 "..\..\MainWindow.xaml"
            this.Kamil.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ImageMouseEnter_event);
            
            #line default
            #line hidden
            
            #line 144 "..\..\MainWindow.xaml"
            this.Kamil.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ImageMouseLeave_event);
            
            #line default
            #line hidden
            return;
            case 42:
            this.KamilLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 43:
            this.Hubert = ((System.Windows.Controls.Image)(target));
            
            #line 157 "..\..\MainWindow.xaml"
            this.Hubert.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ImageMouseEnter_event);
            
            #line default
            #line hidden
            
            #line 157 "..\..\MainWindow.xaml"
            this.Hubert.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ImageMouseLeave_event);
            
            #line default
            #line hidden
            return;
            case 44:
            this.HubertLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

