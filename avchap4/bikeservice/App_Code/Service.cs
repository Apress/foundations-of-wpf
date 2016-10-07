using System;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using System.Text;

using System.Collections;
using System.Runtime.Serialization;

// A WinFX service consists of a contract (defined below as IMyService), 
// a class which implements that interface (see MyService), 
// and configuration entries that specify behaviors associated with 
// that implementation (see <system.serviceModel> in web.config)

[ServiceContract()]
public interface IBikeService
{
    [OperationContract]
    string GetData();
    [OperationContract]
    ProductRecord GetProductDetails(string strID);
}

[DataContract()]
public class ProductRecord
{
    [DataMember]
    public int ID;
    [DataMember]
    public string Name;
    [DataMember]
    public string ListPrice;
    [DataMember]
    public byte[] Photo;
}


public class BikeService : IBikeService
{
    public ProductRecord GetProductDetails(string strID)
    {
        ProductDetailsTableAdapters.DataTable1TableAdapter da =
            new ProductDetailsTableAdapters.DataTable1TableAdapter();
        ProductDetails.DataTable1DataTable dt = da.GetData(Convert.ToInt16(strID));
        ProductRecord pReturn = new ProductRecord();
        ProductDetails.DataTable1Row theRow = (ProductDetails.DataTable1Row) dt.Rows[0];
        pReturn.ID = theRow.ProductID;
        pReturn.ListPrice = theRow.ListPrice.ToString();
        pReturn.Name = theRow.Name;
        pReturn.Photo = theRow.LargePhoto;
        return pReturn;

    }

    public string GetData()
    {
        BikesTableAdapters.DataTable1TableAdapter da =
            new BikesTableAdapters.DataTable1TableAdapter();
        Bikes.DataTable1DataTable dt = da.GetData();
        string st = ConvertDataTableToXML(dt);
        return st;
    }
    // Function to convert passed dataset to xml data
    private string ConvertDataTableToXML(DataTable xmlDS)
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
