//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.91
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnimTest {
    using System;
    using System.Windows.Input;
    using System.Windows.Data;
    using System.Windows.Navigation;
    using System.Windows.Controls.Primitives;
    using System.Windows;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;
    using System.Windows.Documents;
    using System.Windows.Controls;
    using System.Windows.Media.Effects;
    using System.Windows.Media.Imaging;
    using System.Windows.Media.TextFormatting;
    using System.Windows.Automation;
    using System.Windows.Media;
    using System.Windows.Media.Media3D;
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        internal System.Windows.Controls.ContentControl Cont;
        
        private bool _contentLoaded;
        
        internal MyApp MyApplication {
            get {
                return ((MyApp)(System.Windows.Application.Current));
            }
        }
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("window1.baml", System.UriKind.RelativeOrAbsolute);
            System.Windows.Application.LoadComponent(this, resourceLocater);
        }
        
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Cont = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
