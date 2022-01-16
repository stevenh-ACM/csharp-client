# IO.Swagger.Api.RootApi

All URIs are relative to *http://acu-demos.us*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RootGet**](RootApi.md#rootget) | **GET** /entity | Returns the version of the Acumatica ERP instance and the endpoints available in this instance.


<a name="rootget"></a>
# **RootGet**
> VersionAndEndpoints RootGet ()

Returns the version of the Acumatica ERP instance and the endpoints available in this instance.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RootGetExample
    {
        public void main()
        {
            var apiInstance = new RootApi();

            try
            {
                // Returns the version of the Acumatica ERP instance and the endpoints available in this instance.
                VersionAndEndpoints result = apiInstance.RootGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RootApi.RootGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**VersionAndEndpoints**](VersionAndEndpoints.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

