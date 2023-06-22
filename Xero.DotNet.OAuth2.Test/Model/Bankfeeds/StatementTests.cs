/* 
 * Bank Feeds API
 *
 * This specifing endpoints Xero Bank feeds API
 *
 * The version of the OpenAPI document: 2.6.1
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.DotNet.OAuth2.Api;
using Xero.DotNet.OAuth2.Model.Bankfeeds;
using Xero.DotNet.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;
using RestSharp;

namespace Xero.DotNet.OAuth2.Test.Model.Bankfeeds
{
    /// <summary>
    ///  Class for testing Statement
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class StatementTests : IDisposable
    {
        public StatementTests()
        {
            // TODO uncomment below to create an instance of Statement
            //instance = new Statement();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'Status' deserialises from valid inputs
        /// </summary>
        [Theory]
        [InlineData("PENDING", Statement.StatusEnum.PENDING)]
        [InlineData("REJECTED", Statement.StatusEnum.REJECTED)]
        [InlineData("DELIVERED", Statement.StatusEnum.DELIVERED)]
        public void Status_ValidInput_Deserialises(string input, Statement.StatusEnum expected)
        {
            var response = new RestResponse();
            response.Content = $@"{{
                ""Status"": ""{input}""
            }}";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<Statement>(response);

            Assert.Equal(expected, actual.Status);
        }
        /// <summary>
        /// Test the property 'Status' deserialises from null input to 0
        /// </summary>
        [Fact]
        public void Status_NullInput_DeserialisesTo0()
        {
            var response = new RestResponse();
            response.Content = $@"{{
                ""Status"": null
            }}";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<Statement>(response);

            Assert.Equal(0, (int) actual.Status);
        }
        /// <summary>
        /// Test the property 'Status' deserialises to 0 when not present
        /// </summary>
        [Fact]
        public void Status_NotPresentInInput_DeserialisesTo0()
        {
            var response = new RestResponse();
            response.Content = "{}";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<Statement>(response);

            Assert.Equal(0, (int) actual.Status);
        }
        /// <summary>
        /// Test the property 'Errors' deserialises from an array of Error objects
        /// </summary>
        [Fact]
        public void Errors_GivenValidInput_Deserialises()
        {
            var response = new RestResponse();
            response.Content = $@"{{
                ""Errors"": [
                    {{
                        ""type"": ""invalid-end-balance"",
                        ""title"": ""Invalid End Balance"",
                        ""status"": 422,
                        ""detail"": ""Detail""
                    }}
                ]
            }}";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<Statement>(response);

            Assert.Single(actual.Errors);
            var error = actual.Errors.First();

            Assert.Equal(Error.TypeEnum.InvalidEndBalance, error.Type);
            Assert.Equal("Invalid End Balance", error.Title);
            Assert.Equal(422, error.Status);
            Assert.Equal("Detail", error.Detail);
        }
    }
}
