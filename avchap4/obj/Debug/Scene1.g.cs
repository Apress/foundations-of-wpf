//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.91
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
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


namespace BikeBrowser {
    
    
    /// <summary>
    /// Scene1
    /// </summary>
    public partial class Scene1 : System.Windows.Controls.Grid, System.Windows.Markup.IComponentConnector {
        
        internal BikeBrowser.Scene1 DocumentRoot;
        
        internal System.Windows.Media.Animation.BeginStoryboard OnLoaded_BeginStoryboard;
        
        internal System.Windows.Controls.Grid ProductGrid;
        
        internal System.Windows.Controls.ContentControl Master;
        
        internal System.Windows.Controls.ListBox ProductList;
        
        internal System.Windows.Controls.ContentControl Details;
        
        internal System.Windows.Controls.Grid Grid;
        
        internal System.Windows.Controls.TextBlock Price;
        
        internal System.Windows.Controls.TextBlock Description;
        
        internal System.Windows.Controls.Image Pic;
        
        internal System.Windows.Controls.GridSplitter GridSplitter;
        
        internal System.Windows.Shapes.Rectangle Reflection;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DevxBrowser;component/scene1.xaml", System.UriKind.Relative);
            System.Windows.Application.LoadComponent(this, resourceLocater);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DocumentRoot = ((BikeBrowser.Scene1)(target));
            return;
            case 2:
            this.OnLoaded_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 3:
            this.ProductGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.Master = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 5:
            this.ProductList = ((System.Windows.Controls.ListBox)(target));
            
            #line 150 "..\..\Scene1.xaml"
            this.ProductList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Details = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 7:
            this.Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.Price = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.Description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.Pic = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.GridSplitter = ((System.Windows.Controls.GridSplitter)(target));
            return;
            case 12:
            this.Reflection = ((System.Windows.Shapes.Rectangle)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
