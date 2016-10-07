using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Input;
namespace ControlDemos
{
    /// <summary>
    /// Interaction logic for Label.xaml
    /// </summary>

    public partial class Label : Window
    {

        public Label()
        {
            InitializeComponent();
        }
        private void sl1_ValueChanged(object sender, EventArgs e)
        {
            if (sl1.Value < sl1.SelectionStart)
                sl1.Value = sl1.SelectionStart;

            if (sl1.Value > sl1.SelectionEnd)
                sl1.Value = sl1.SelectionEnd;
        }

    }
}