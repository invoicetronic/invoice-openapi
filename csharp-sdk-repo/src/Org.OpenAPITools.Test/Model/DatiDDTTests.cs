/*
 * Italian Invoice API
 *
 *  ## Overview  The Invoice API is a RESTful API that allows you to send and receive invoices through the Italian Servizio di Interscambio (Interchange Service).  ### Authentication  The Invoicetronic API uses API keys to authenticate requests. If you don't have any API Key, you can request one by registering with the [Invoicetronic Developer Portal][1].  Test mode secret keys have the prefix `ik_test_` and live mode secret keys have the prefix `ik_live_`. Make sure to use the correct key for each environment.  > Your API keys carry many privileges, so be sure to keep them secure! Do not share your secret API keys in publicly > accessible areas such as GitHub, client-side code, and so forth.  All API requests must be made over HTTPS. Calls made over plain HTTP will fail. API requests without authentication will also fail.  #### Basic Authentication  Basic Authentication is how you authenticate with the API. Use your API Key as the username and leave the password empty. If your client does not allow empty passwords, you can use any value as the password. Here's an example of how to authenticate with Basic Authentication and curl:  ```curl curl https://api.invoicetronic.com/invoice/v1/send \\     -u ik_test_1234567890abcdefg:  # The colon prevents curl from asking for a password. ```  [1]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: v1
 * Contact: support@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing DatiDDT
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DatiDDTTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DatiDDT
        //private DatiDDT instance;

        public DatiDDTTests()
        {
            // TODO uncomment below to create an instance of DatiDDT
            //instance = new DatiDDT();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatiDDT
        /// </summary>
        [Fact]
        public void DatiDDTInstanceTest()
        {
            // TODO uncomment below to test "IsType" DatiDDT
            //Assert.IsType<DatiDDT>(instance);
        }

        /// <summary>
        /// Test the property 'NumeroDdt'
        /// </summary>
        [Fact]
        public void NumeroDdtTest()
        {
            // TODO unit test for the property 'NumeroDdt'
        }

        /// <summary>
        /// Test the property 'DataDdt'
        /// </summary>
        [Fact]
        public void DataDdtTest()
        {
            // TODO unit test for the property 'DataDdt'
        }

        /// <summary>
        /// Test the property 'RiferimentoNumeroLinea'
        /// </summary>
        [Fact]
        public void RiferimentoNumeroLineaTest()
        {
            // TODO unit test for the property 'RiferimentoNumeroLinea'
        }
    }
}
