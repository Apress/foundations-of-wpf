using System;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;


// A WinFX service consists of a contract (defined below as IMyService), 
// a class which implements that interface (see MyService), 
// and configuration entries that specify behaviors associated with 
// that implementation (see <system.serviceModel> in web.config)

[ServiceContract()]
public interface IBikeService
{
    [OperationContract]
    string MyOperation1(string myValue1);
}

public class MyService : IMyService
{
    public string MyOperation1(string myValue1) 
    {
        return "Hello: " + myValue1;
        
    }
}

