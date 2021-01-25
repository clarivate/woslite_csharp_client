/* 
 * Web of Science API Lite
 *
 * A responsive API that supports rich searching across the Web of Science Core Collection to retrieve core article metadata.  This service provides a great way to reuse Web of Science data both internally and externally to enhance  institutional repositories and research networking systems with best-in-class data. This API supports searching across the Web of Science to retrieve item-level metadata with limited fields:  - UT (Unique Identifier) - Authors - Author keywords - Document type - Title - Issue - Pages - Publication date - Source title - Volume - DOI - ISBN - ISSN   The API supports JSON and XML responses, and this documentation supports trying both response types. 
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing WosLiteResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class WosLiteResponseTests
    {
        // TODO uncomment below to declare an instance variable for WosLiteResponse
        //private WosLiteResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of WosLiteResponse
            //instance = new WosLiteResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WosLiteResponse
        /// </summary>
        [Test]
        public void WosLiteResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" WosLiteResponse
            //Assert.IsInstanceOfType<WosLiteResponse> (instance, "variable 'instance' is a WosLiteResponse");
        }


        /// <summary>
        /// Test the property 'QueryResult'
        /// </summary>
        [Test]
        public void QueryResultTest()
        {
            // TODO unit test for the property 'QueryResult'
        }
        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }

    }

}
