/* 
 * Web of Science API Lite
 *
 * A responsive API that supports rich searching across the Web of Science Core Collection to retrieve core article metadata.  This service provides a great way to reuse Web of Science data both internally and externally to enhance  institutional repositories and research networking systems with best-in-class data. This API supports searching across the Web of Science to retrieve item-level metadata with limited fields:  - UT (Unique Identifier) - Authors - Author keywords - Document type - Title - Issue - Pages - Publication date - Source title - Volume - DOI - ISBN - ISSN   The API supports JSON and XML responses, and this documentation supports trying both response types. 
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing IntegrationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class IntegrationApiTests
    {
        private IntegrationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IntegrationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IntegrationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' IntegrationApi
            //Assert.IsInstanceOfType(typeof(IntegrationApi), instance, "instance is a IntegrationApi");
        }

        /// <summary>
        /// Test IdUniqueIdGet
        /// </summary>
        [Test]
        public void IdUniqueIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string databaseId = null;
            //string uniqueId = null;
            //int? count = null;
            //int? firstRecord = null;
            //string lang = null;
            //string sortField = null;
            //var response = instance.IdUniqueIdGet(databaseId, uniqueId, count, firstRecord, lang, sortField);
            //Assert.IsInstanceOf<WosLiteResponse> (response, "response is WosLiteResponse");
        }
    }

}
