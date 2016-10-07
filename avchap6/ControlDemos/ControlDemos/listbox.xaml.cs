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
    /// Interaction logic for listbox.xaml
    /// </summary>

    public partial class listbox : Window
    {

        public listbox()
        {
            InitializeComponent();
        }
        public void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            int nCount = listBox1.SelectedItems.Count;
            string strTest = "";
            for (int lp = 0; lp < nCount; lp++)
                strTest = listBox1.SelectedItems[lp].ToString();


        }

    }
}