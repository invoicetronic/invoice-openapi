/*
 * Italian Invoice API
 *
 *  ## Overview  The Invoice API is a RESTful API that allows you to send and receive invoices through the Italian Servizio di Interscambio (Interchange Service).  ### Authentication  The Invoicetronic API uses API keys to authenticate requests. If you don't have any API Key, you can request one by registering with the [Invoicetronic Developer Portal][1].  Test mode secret keys have the prefix `ik_test_` and live mode secret keys have the prefix `ik_live_`. Make sure to use the correct key for each environment.  > Your API keys carry many privileges, so be sure to keep them secure! Do not share your secret API keys in publicly > accessible areas such as GitHub, client-side code, and so forth.  All API requests must be made over HTTPS. Calls made over plain HTTP will fail. API requests without authentication will also fail.  #### Basic Authentication  Basic Authentication is how you authenticate with the API. Use your API Key as the username and leave the password empty. If your client does not allow empty passwords, you can use any value as the password. Here's an example of how to authenticate with Basic Authentication and curl:  ```curl curl https://api.invoicetronic.com/invoice/v1/send \\     -u ik_test_1234567890abcdefg:  # The colon prevents curl from asking for a password. ```  [1]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: v1
 * Contact: support@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Api;
// uncomment below to import models
//using Invoicetronic.InvoiceApi.Model;

namespace Invoicetronic.InvoiceApi.Test.Api
{
    /// <summary>
    ///  Class for testing UpdateApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UpdateApiTests : IDisposable
    {
        private UpdateApi instance;

        public UpdateApiTests()
        {
            instance = new UpdateApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UpdateApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UpdateApi
            //Assert.IsType<UpdateApi>(instance);
        }

        /// <summary>
        /// Test InvoiceV1UpdateGet
        /// </summary>
        [Fact]
        public void InvoiceV1UpdateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? companyId = null;
            //string identifier = null;
            //bool? unread = null;
            //int? sendId = null;
            //string state = null;
            //DateTime? lastUpdateFrom = null;
            //DateTime? lastUpdateTo = null;
            //DateTime? dateSentFrom = null;
            //DateTime? dateSentTo = null;
            //int? page = null;
            //int? pageSize = null;
            //var response = instance.InvoiceV1UpdateGet(companyId, identifier, unread, sendId, state, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, page, pageSize);
            //Assert.IsType<List<Update>>(response);
        }

        /// <summary>
        /// Test InvoiceV1UpdateIdGet
        /// </summary>
        [Fact]
        public void InvoiceV1UpdateIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.InvoiceV1UpdateIdGet(id);
            //Assert.IsType<Update>(response);
        }
    }
}
