# The C# library for the Web of Science API Lite

A responsive API that supports rich searching across the Web of Science Core Collection to retrieve core article metadata.  This service provides a great way to reuse Web of Science data both internally and externally to enhance  institutional repositories and research networking systems with best-in-class data. This API supports searching across the Web of Science to retrieve item-level metadata with limited fields:  
- UT (Unique Identifier) 
- Authors 
- Author keywords 
- Document type 
- Title 
- Issue 
- Pages 
- Publication date 
- Source title 
- Volume 
- DOI 
- ISBN 
- ISSN   
The API supports JSON and XML responses, and this documentation supports trying both response types. We recommend that you use JSON only with this client.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure API key authorization: key
            Configuration.Default.ApiKey.Add("X-ApiKey", "YOUR_API_KEY");
            
            var apiInstance = new IntegrationApi();
            var databaseId = "WOS";  // string | Database to search. Must be a valid database ID, one of the following: BCI/BIOABS/BIOSIS/CCC/DCI/DIIDW/MEDLINE/WOK/WOS/ZOOREC. WOK represents all databases.
            var uniqueId = "WOS:000270372400005";  // string | Primary item(s) id to be searched, ex: WOS:000270372400005. Cannot be null or an empty string. Multiple values are separated by comma.
            var count = 10;  // int? | Number of records to return, must be 0-100.
            var firstRecord = 1;  // int? | Specific record, if any within the result set to return. Cannot be less than 1 and greater than 100000

            try
            {
                // Find record(s) by specific id
                WosLiteResponse result = apiInstance.IdUniqueIdGet(databaseId, uniqueId, count, firstRecord, lang, sortField);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.IdUniqueIdGet: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.clarivate.com/api/woslite*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*IntegrationApi* | [**IdUniqueIdGet**](docs/IntegrationApi.md#iduniqueidget) | **GET** /id/{uniqueId} | Find record(s) by specific id
*SearchApi* | [**QueryQueryIdGet**](docs/SearchApi.md#queryqueryidget) | **GET** /query/{queryId} | Fetch record(s) by query identifier
*SearchApi* | [**RootGet**](docs/SearchApi.md#rootget) | **GET** / | Submits a user query and returns results

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Author](docs/Author.md)
 - [Model.Doctype](docs/Doctype.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.Keyword](docs/Keyword.md)
 - [Model.Other](docs/Other.md)
 - [Model.QueryResult](docs/QueryResult.md)
 - [Model.Source](docs/Source.md)
 - [Model.WosLiteRecord](docs/WosLiteRecord.md)
 - [Model.WosLiteRecordTitle](docs/WosLiteRecordTitle.md)
 - [Model.WosLiteResponse](docs/WosLiteResponse.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="key"></a>
### key

- **Type**: API key
- **API key parameter name**: X-ApiKey
- **Location**: HTTP header

## Licence
MIT

