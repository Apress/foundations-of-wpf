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
    using ControlDemos;
    
    
    /// <summary>
    /// ObjectDataBinding
    /// </summary>
    public partial class ObjectDataBinding : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
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
            System.Uri resourceLocater = new System.Uri("objectdatabinding.baml", System.UriKind.RelativeOrAbsolute);
            System.Windows.Application.LoadComponent(this, resourceLocater);
        }
        
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            this._contentLoaded = true;
        }
    }
}
namespace _Generated {
    
    
    /// <summary>
    /// GeneratedInternalTypeHelper
    /// </summary>
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class GeneratedInternalTypeHelper : System.Windows.Markup.InternalTypeHelper {
        
        /// <summary>
        /// CreateInstance
        /// </summary>
        protected override object CreateInstance(System.Type type, System.Globalization.CultureInfo culture) {
            return System.Activator.CreateInstance(type, ((System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic) 
                            | (System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.CreateInstance)), null, null, culture);
        }
        
        /// <summary>
        /// GetPropertyValue
        /// </summary>
        protected override object GetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, System.Globalization.CultureInfo culture) {
            return propertyInfo.GetValue(target, System.Reflection.BindingFlags.Default, null, null, culture);
        }
        
        /// <summary>
        /// SetPropertyValue
        /// </summary>
        protected override void SetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, object value, System.Globalization.CultureInfo culture) {
            propertyInfo.SetValue(target, value, System.Reflection.BindingFlags.Default, null, null, culture);
        }
        
        /// <summary>
        /// CreateDelegate
        /// </summary>
        protected override System.Delegate CreateDelegate(System.Type delegateType, object target, string handler) {
            return ((System.Delegate)(target.GetType().InvokeMember("_CreateDelegate", (System.Reflection.BindingFlags.InvokeMethod 
                            | (System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)), null, target, new object[] {
                        delegateType,
                        handler})));
        }
        
        /// <summary>
        /// AddEventHandler
        /// </summary>
        protected override void AddEventHandler(System.Reflection.EventInfo eventInfo, object target, System.Delegate handler) {
            eventInfo.AddEventHandler(target, handler);
        }
    }
}
