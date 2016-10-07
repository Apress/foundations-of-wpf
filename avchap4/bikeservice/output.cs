﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;



[System.Runtime.Serialization.DataContractAttribute()]
public partial class ProductRecord : object, System.Runtime.Serialization.IExtensibleDataObject
{
    
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    
    private int IDField;
    
    private string ListPriceField;
    
    private string NameField;
    
    private byte[] PhotoField;
    
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
        get
        {
            return this.extensionDataField;
        }
        set
        {
            this.extensionDataField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public int ID
    {
        get
        {
            return this.IDField;
        }
        set
        {
            this.IDField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string ListPrice
    {
        get
        {
            return this.ListPriceField;
        }
        set
        {
            this.ListPriceField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string Name
    {
        get
        {
            return this.NameField;
        }
        set
        {
            this.NameField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte[] Photo
    {
        get
        {
            return this.PhotoField;
        }
        set
        {
            this.PhotoField = value;
        }
    }
}

[System.ServiceModel.MessageContractAttribute()]
public class GetDataRequest
{
    
    [System.ServiceModel.MessageBodyAttribute(Name="GetData", Namespace="http://tempuri.org/", Order=0)]
    public GetDataRequestBody Body;
    
    public GetDataRequest()
    {
    }
    
    public GetDataRequest(GetDataRequestBody Body)
    {
        this.Body = Body;
    }
}

[System.Runtime.Serialization.DataContractAttribute()]
public class GetDataRequestBody
{
    
    public GetDataRequestBody()
    {
    }
}

[System.ServiceModel.MessageContractAttribute()]
public class GetDataResponse
{
    
    [System.ServiceModel.MessageBodyAttribute(Name="GetDataResponse", Namespace="http://tempuri.org/", ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Order=0)]
    public GetDataResponseBody Body;
    
    public GetDataResponse()
    {
    }
    
    public GetDataResponse(GetDataResponseBody Body)
    {
        this.Body = Body;
    }
}

[System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
public class GetDataResponseBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public string GetDataResult;
    
    public GetDataResponseBody()
    {
    }
    
    public GetDataResponseBody(string GetDataResult)
    {
        this.GetDataResult = GetDataResult;
    }
}

[System.ServiceModel.MessageContractAttribute()]
public class GetProductDetailsRequest
{
    
    [System.ServiceModel.MessageBodyAttribute(Name="GetProductDetails", Namespace="http://tempuri.org/", ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Order=0)]
    public GetProductDetailsRequestBody Body;
    
    public GetProductDetailsRequest()
    {
    }
    
    public GetProductDetailsRequest(GetProductDetailsRequestBody Body)
    {
        this.Body = Body;
    }
}

[System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
public class GetProductDetailsRequestBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public string strID;
    
    public GetProductDetailsRequestBody()
    {
    }
    
    public GetProductDetailsRequestBody(string strID)
    {
        this.strID = strID;
    }
}

[System.ServiceModel.MessageContractAttribute()]
public class GetProductDetailsResponse
{
    
    [System.ServiceModel.MessageBodyAttribute(Name="GetProductDetailsResponse", Namespace="http://tempuri.org/", ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Order=0)]
    public GetProductDetailsResponseBody Body;
    
    public GetProductDetailsResponse()
    {
    }
    
    public GetProductDetailsResponse(GetProductDetailsResponseBody Body)
    {
        this.Body = Body;
    }
}

[System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
public class GetProductDetailsResponseBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public ProductRecord GetProductDetailsResult;
    
    public GetProductDetailsResponseBody()
    {
    }
    
    public GetProductDetailsResponseBody(ProductRecord GetProductDetailsResult)
    {
        this.GetProductDetailsResult = GetProductDetailsResult;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute()]
public interface IBikeService
{
    
    // CODEGEN: Generating message contract since message part GetDataResult requires protection.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBikeService/GetData", ReplyAction="http://tempuri.org/IBikeService/GetDataResponse")]
    GetDataResponse GetData(GetDataRequest request);
    
    // CODEGEN: Generating message contract since message part GetProductDetailsResult requires protection.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBikeService/GetProductDetails", ReplyAction="http://tempuri.org/IBikeService/GetProductDetailsResponse")]
    GetProductDetailsResponse GetProductDetails(GetProductDetailsRequest request);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IBikeServiceChannel : IBikeService, System.ServiceModel.IClientChannel
{
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class BikeServiceProxy : System.ServiceModel.ClientBase<IBikeService>, IBikeService
{
    
    public BikeServiceProxy()
    {
    }
    
    public BikeServiceProxy(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public BikeServiceProxy(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BikeServiceProxy(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BikeServiceProxy(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    GetDataResponse IBikeService.GetData(GetDataRequest request)
    {
        return base.InnerProxy.GetData(request);
    }
    
    public string GetData()
    {
        GetDataRequest inValue = new GetDataRequest();
        inValue.Body = new GetDataRequestBody();
        GetDataResponse retVal = ((IBikeService)(this)).GetData(inValue);
        return retVal.Body.GetDataResult;
    }
    
    GetProductDetailsResponse IBikeService.GetProductDetails(GetProductDetailsRequest request)
    {
        return base.InnerProxy.GetProductDetails(request);
    }
    
    public ProductRecord GetProductDetails(string strID)
    {
        GetProductDetailsRequest inValue = new GetProductDetailsRequest();
        inValue.Body = new GetProductDetailsRequestBody();
        inValue.Body.strID = strID;
        GetProductDetailsResponse retVal = ((IBikeService)(this)).GetProductDetails(inValue);
        return retVal.Body.GetProductDetailsResult;
    }
}