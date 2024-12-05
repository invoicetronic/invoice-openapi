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
    ///  Class for testing Contatti
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ContattiTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Contatti
        //private Contatti instance;

        public ContattiTests()
        {
            // TODO uncomment below to create an instance of Contatti
            //instance = new Contatti();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Contatti
        /// </summary>
        [Fact]
        public void ContattiInstanceTest()
        {
            // TODO uncomment below to test "IsType" Contatti
            //Assert.IsType<Contatti>(instance);
        }

        /// <summary>
        /// Test the property 'Telefono'
        /// </summary>
        [Fact]
        public void TelefonoTest()
        {
            // TODO unit test for the property 'Telefono'
        }

        /// <summary>
        /// Test the property 'Fax'
        /// </summary>
        [Fact]
        public void FaxTest()
        {
            // TODO unit test for the property 'Fax'
        }

        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
    }
}
