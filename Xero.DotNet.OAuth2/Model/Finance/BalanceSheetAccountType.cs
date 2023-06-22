/* 
 * Xero Finance API
 *
 * The Finance API is a collection of endpoints which customers can use in the course of a loan application, which may assist lenders to gain the confidence they need to provide capital.
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.DotNet.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.DotNet.OAuth2.Model.Finance
{
    /// <summary>
    /// BalanceSheetAccountType
    /// </summary>
    [DataContract]
    public partial class BalanceSheetAccountType :  IEquatable<BalanceSheetAccountType>, IValidatableObject
    {
        
        /// <summary>
        /// The type of the account. See &lt;a href&#x3D;&#39;https://developer.xero.com/documentation/api/types#AccountTypes&#39;&gt;Account Types&lt;/a&gt;
        /// </summary>
        /// <value>The type of the account. See &lt;a href&#x3D;&#39;https://developer.xero.com/documentation/api/types#AccountTypes&#39;&gt;Account Types&lt;/a&gt;</value>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// A list of all accounts of this type. Refer to the Account section below for each account element detail.
        /// </summary>
        /// <value>A list of all accounts of this type. Refer to the Account section below for each account element detail.</value>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<BalanceSheetAccountDetail> Accounts { get; set; }

        /// <summary>
        /// Total value of all the accounts in this type
        /// </summary>
        /// <value>Total value of all the accounts in this type</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BalanceSheetAccountType {\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BalanceSheetAccountType);
        }

        /// <summary>
        /// Returns true if BalanceSheetAccountType instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceSheetAccountType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceSheetAccountType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
