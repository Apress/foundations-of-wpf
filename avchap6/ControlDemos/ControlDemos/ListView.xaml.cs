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
    /// Interaction logic for ListView_.xaml
    /// </summary>

    public partial class ListView_ : Window
    {

        public ListView_()
        {
            InitializeComponent();
        }
        void OnSelected(object sender, SelectionChangedEventArgs e)
        {
            int x = lvwEmps.Items.Count;
            int y = lvwEmps.SelectedItems.Count;
        }

    }
}