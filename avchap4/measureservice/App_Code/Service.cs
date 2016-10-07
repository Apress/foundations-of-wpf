using System;
using System.ServiceModel;

// A WinFX service consists of a contract (defined below as IMyService), 
// a class which implements that interface (see MyService), 
// and configuration entries that specify behaviors associated with 
// that implementation (see <system.serviceModel> in web.config)


[ServiceContract()]
public interface IMetricImperial
{
    [OperationContract]
    double ftom(double f);

    [OperationContract]
    double mtof(double m);

}

public class MetricImperial : IMetricImperial
{
    public double ftom(double f)
    {
        return f / 3.3;
    }
    public double mtof(double m)
    {
        return m * 3.3;
    }
}
