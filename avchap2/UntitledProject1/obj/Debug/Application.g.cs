//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.91
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UntitledProject1 {
    using System;
    using System.Windows.Media.Effects;
    using System.Windows.Media.Imaging;
    using System.Windows.Input;
    using System.Windows.Media.TextFormatting;
    using System.Windows.Automation;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Media.Media3D;
    using System.Windows.Data;
    using System.Windows.Navigation;
    using System.Windows.Controls.Primitives;
    using System.Windows.Shapes;
    using System.Windows.Documents;
    using System.Windows.Controls;
    
    
    /// <summary>
    /// MainApplication
    /// </summary>
    public partial class MainApplication : System.Windows.Application {
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        public void InitializeComponent() {
            this.StartupUri = new System.Uri("Scene1.xaml", System.UriKind.Relative);
        }
        
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [System.STAThreadAttribute()]
        public static void Main() {
            System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA);
            UntitledProject1.MainApplication app = new UntitledProject1.MainApplication();
            app.InitializeComponent();
            app.Run();
        }
    }
}
