//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.91
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlDemos {
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
    /// RadioButton
    /// </summary>
    public partial class RadioButton : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        internal System.Windows.Controls.RadioButton r1;
        
        internal System.Windows.Controls.RadioButton r2;
        
        internal System.Windows.Controls.RadioButton r3;
        
        internal System.Windows.Controls.Menu menu1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// MyApplication Property.
        /// </summary>
        public MyApp MyApplication {
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
            System.Uri resourceLocater = new System.Uri("radiobutton.baml", System.UriKind.RelativeOrAbsolute);
            System.Windows.Application.LoadComponent(this, resourceLocater);
        }
        
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.r1 = ((System.Windows.Controls.RadioButton)(target));
            this.r1.Click += new System.Windows.RoutedEventHandler(this.HandleSelection);
            return;
            case 2:
            this.r2 = ((System.Windows.Controls.RadioButton)(target));
            this.r2.Click += new System.Windows.RoutedEventHandler(this.HandleSelection);
            return;
            case 3:
            this.r3 = ((System.Windows.Controls.RadioButton)(target));
            this.r3.Click += new System.Windows.RoutedEventHandler(this.HandleSelection);
            return;
            case 4:
            this.menu1 = ((System.Windows.Controls.Menu)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}