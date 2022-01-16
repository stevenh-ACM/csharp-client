# IO.Swagger.Api.AuthApi

All URIs are relative to *http://acu-demos.us*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthLogin**](AuthApi.md#authlogin) | **POST** /entity/auth/login | Logs in to the system.
[**AuthLogout**](AuthApi.md#authlogout) | **POST** /entity/auth/logout | Logs out from the system.


<a name="authlogin"></a>
# **AuthLogin**
> void AuthLogin (Credentials credentials)

Logs in to the system.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthLoginExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var credentials = new Credentials(); // Credentials | 

            try
            {
                // Logs in to the system.
                apiInstance.AuthLogin(credentials);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.AuthLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credentials** | [**Credentials**](Credentials.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authlogout"></a>
# **AuthLogout**
> void AuthLogout ()

Logs out from the system.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthLogoutExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();

            try
            {
                // Logs out from the system.
                apiInstance.AuthLogout();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.AuthLogout: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

