/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.DotNet.OAuth2.Api;
using Xero.DotNet.OAuth2.Model.PayrollAu;
using Xero.DotNet.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Xero.DotNet.OAuth2.Test.Model.PayrollAu
{
    /// <summary>
    ///  Class for testing Payslip
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PayslipTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'Wages'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void WagesTest(string input)
        {
            JsonDoc.Assert<Payslip, decimal?>(
                input: new JsonDoc.Number(nameof(Payslip.Wages), input),
                toProperty: x => x.Wages,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'Deductions'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void DeductionsTest(string input)
        {
            JsonDoc.Assert<Payslip, decimal?>(
                input: new JsonDoc.Number(nameof(Payslip.Deductions), input),
                toProperty: x => x.Deductions,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'Tax'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void TaxTest(string input)
        {
            JsonDoc.Assert<Payslip, decimal?>(
                input: new JsonDoc.Number(nameof(Payslip.Tax), input),
                toProperty: x => x.Tax,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'Super'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void SuperTest(string input)
        {
            JsonDoc.Assert<Payslip, decimal?>(
                input: new JsonDoc.Number(nameof(Payslip.Super), input),
                toProperty: x => x.Super,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'Reimbursements'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void ReimbursementsTest(string input)
        {
            JsonDoc.Assert<Payslip, decimal?>(
                input: new JsonDoc.Number(nameof(Payslip.Reimbursements), input),
                toProperty: x => x.Reimbursements,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'NetPay'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void NetPayTest(string input)
        {
            JsonDoc.Assert<Payslip, decimal?>(
                input: new JsonDoc.Number(nameof(Payslip.NetPay), input),
                toProperty: x => x.NetPay,
                shouldBe: 20
            );
        }
    }
}
