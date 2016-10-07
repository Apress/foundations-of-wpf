using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ControlDemos
{
    /// <summary>
    /// Interaction logic for RadioButton.xaml
    /// </summary>

    public partial class RadioButton : Window
    {

        public RadioButton()
        {
            InitializeComponent();
        }
        public void HandleSelection(Object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.RadioButton b = (sender as System.Windows.Controls.RadioButton);
            StackPanel d = (StackPanel)b.Content;
            TextBlock t = (TextBlock)d.Children[1];
            string strTest = t.Text;
            string strTest2 = strTest;
        }

    }
}