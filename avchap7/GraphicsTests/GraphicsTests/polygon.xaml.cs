using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GraphicsTests
{
    /// <summary>
    /// Interaction logic for polygon.xaml
    /// </summary>

    public partial class polygon : Window
    {

        public polygon()
        {
            InitializeComponent();
            
        }
        private void bPlay_Click(Object sender, EventArgs e)
        {
            mdElement.Play();
        }
        private void bPause_Click(Object sender, EventArgs e)
        {
            mdElement.Pause();
        }
        private void bStop_Click(Object sender, EventArgs e)
        {
            mdElement.Stop();
        }
    }
}