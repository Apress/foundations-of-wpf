using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Data;
using System.Text;
using System.Xml;

namespace BikeBrowser
{
	public partial class Scene1
	{
		
		public Scene1()
		{
			// This assumes that you are navigating to this scene.
			// If you will normally instantiate it via code and display it
			// manually, you either have to call InitializeComponent by hand or
			// uncomment the following line.
			// this.InitializeComponent();

			// Insert code required on object creation below this point.
            InitializeComponent();
            using (BikeServiceProxy proxy = new BikeServiceProxy("default"))
            {
                string s1 = proxy.GetData();
                DataSet d = ConvertXMLToDataSet(s1);
                DataTable t = d.Tables[0];
                DataContext = t;
                

            }
		}
		
		protected override void OnInitialized(EventArgs e)
		{
			Reflection.Fill = new VisualBrush(ProductGrid);	
		}
        public DataSet ConvertXMLToDataSet(string xmlData)
        {
            StringReader stream = null;
            XmlTextReader reader = null;
            try
            {
                DataSet xmlDS = new DataSet();
                stream = new StringReader(xmlData);
                // Load the XmlTextReader from the stream
                reader = new XmlTextReader(stream);
                xmlDS.ReadXml(reader);
                return xmlDS;
            }
            catch (Exception ex)
            {
                string strTest = ex.Message;
                return null;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        private void ProductList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            /*using (AdwServiceProxy proxy =
                new AdwServiceProxy("default"))
            {
                int nID = recs[lstBox1.SelectedIndex].nID;
                fullRecord theRecord = proxy.GetFullRecordDetails(nID);


                BitmapImage myBitmapImage = new BitmapImage();
                myBitmapImage.BeginInit();
                myBitmapImage.StreamSource = new System.IO.MemoryStream(theRecord.bLargePhoto);
                myBitmapImage.EndInit();
                imgProduct.Source = myBitmapImage;

                lblName.Content = theRecord.strName;
                lblColor.Content = "Color : " + theRecord.strColor;
                lblPrice.Content = "Cost : " + String.Format("{0:C}", theRecord.nListPrice);
                lblProductNumber.Content = "Product Number : " + theRecord.strProductNumber;
                lblSize.Content = "Size : " + theRecord.strSize;

            }*/
            DataRowView x = (DataRowView) ProductList.SelectedItem;
            string y = x.Row[0].ToString();

        }

	}
}
