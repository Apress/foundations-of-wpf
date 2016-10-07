using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.ServiceModel;
using System.IO;
using System.Text;
using System.Xml;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string strT = GetData();
        string strT2 = strT;
    }

    public string GetData()
    {
        BikesTableAdapters.DataTable1TableAdapter da =
            new BikesTableAdapters.DataTable1TableAdapter();
        Bikes.DataTable1DataTable dt = da.GetData();
        string strReturn = ConvertDataSetToXML(dt);
        return strReturn;
    }
    // Function to convert passed dataset to xml data
    private string ConvertDataSetToXML(DataTable xmlDS)
    {
        MemoryStream stream = null;
        XmlTextWriter writer = null;
        try
        {
            stream = new MemoryStream();
            // Load the XmlTextReader from the stream
            writer = new XmlTextWriter(stream, Encoding.Unicode);
            // Write to the file with the WriteXml method.
            xmlDS.WriteXml(writer);
            int count = (int)stream.Length;
            byte[] arr = new byte[count];
            stream.Seek(0, SeekOrigin.Begin);
            stream.Read(arr, 0, count);
            UnicodeEncoding utf = new UnicodeEncoding();
            return utf.GetString(arr).Trim();
        }
        catch
        {
            return String.Empty;
        }
        finally
        {
            if (writer != null) writer.Close();
        }
    }
}
