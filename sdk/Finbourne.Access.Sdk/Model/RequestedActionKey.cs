/*
 * FINBOURNE Access Management API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Access.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Access.Sdk.Model
{
    /// <summary>
    /// A fully qualified action identifier
    /// </summary>
    [DataContract(Name = "RequestedActionKey")]
    public partial class RequestedActionKey : IEquatable<RequestedActionKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestedActionKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestedActionKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestedActionKey" /> class.
        /// </summary>
        /// <param name="entityCode">The type of the resource on which the activity would be performed (required).</param>
        /// <param name="scope">The scope/provider/vendor of the activity (required).</param>
        /// <param name="activity">The identifier of the action to be performed on the resource (required).</param>
        public RequestedActionKey(string entityCode = default(string), string scope = default(string), string activity = default(string))
        {
            // to ensure "entityCode" is required (not null)
            if (entityCode == null)
            {
                throw new ArgumentNullException("entityCode is a required property for RequestedActionKey and cannot be null");
            }
            this.EntityCode = entityCode;
            // to ensure "scope" is required (not null)
            if (scope == null)
            {
                throw new ArgumentNullException("scope is a required property for RequestedActionKey and cannot be null");
            }
            this.Scope = scope;
            // to ensure "activity" is required (not null)
            if (activity == null)
            {
                throw new ArgumentNullException("activity is a required property for RequestedActionKey and cannot be null");
            }
            this.Activity = activity;
        }

        /// <summary>
        /// The type of the resource on which the activity would be performed
        /// </summary>
        /// <value>The type of the resource on which the activity would be performed</value>
        [DataMember(Name = "entityCode", IsRequired = true, EmitDefaultValue = true)]
        public string EntityCode { get; set; }

        /// <summary>
        /// The scope/provider/vendor of the activity
        /// </summary>
        /// <value>The scope/provider/vendor of the activity</value>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = true)]
        public string Scope { get; set; }

        /// <summary>
        /// The identifier of the action to be performed on the resource
        /// </summary>
        /// <value>The identifier of the action to be performed on the resource</value>
        [DataMember(Name = "activity", IsRequired = true, EmitDefaultValue = true)]
        public string Activity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestedActionKey {\n");
            sb.Append("  EntityCode: ").Append(EntityCode).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequestedActionKey);
        }

        /// <summary>
        /// Returns true if RequestedActionKey instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestedActionKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestedActionKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EntityCode == input.EntityCode ||
                    (this.EntityCode != null &&
                    this.EntityCode.Equals(input.EntityCode))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Activity == input.Activity ||
                    (this.Activity != null &&
                    this.Activity.Equals(input.Activity))
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
                if (this.EntityCode != null)
                {
                    hashCode = (hashCode * 59) + this.EntityCode.GetHashCode();
                }
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }
                if (this.Activity != null)
                {
                    hashCode = (hashCode * 59) + this.Activity.GetHashCode();
                }
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
            // EntityCode (string) maxLength
            if (this.EntityCode != null && this.EntityCode.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EntityCode, length must be less than 100.", new [] { "EntityCode" });
            }

            // EntityCode (string) minLength
            if (this.EntityCode != null && this.EntityCode.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EntityCode, length must be greater than 3.", new [] { "EntityCode" });
            }

            // EntityCode (string) pattern
            Regex regexEntityCode = new Regex(@"^(?=.*[a-zA-Z])[\w][\w +-]{2,100}$", RegexOptions.CultureInvariant);
            if (false == regexEntityCode.Match(this.EntityCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EntityCode, must match a pattern of " + regexEntityCode, new [] { "EntityCode" });
            }

            // Scope (string) maxLength
            if (this.Scope != null && this.Scope.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, length must be less than 100.", new [] { "Scope" });
            }

            // Scope (string) minLength
            if (this.Scope != null && this.Scope.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, length must be greater than 3.", new [] { "Scope" });
            }

            // Scope (string) pattern
            Regex regexScope = new Regex(@"^(?=.*[a-zA-Z])[\w][\w +-]{2,100}$", RegexOptions.CultureInvariant);
            if (false == regexScope.Match(this.Scope).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, must match a pattern of " + regexScope, new [] { "Scope" });
            }

            // Activity (string) maxLength
            if (this.Activity != null && this.Activity.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Activity, length must be less than 100.", new [] { "Activity" });
            }

            // Activity (string) minLength
            if (this.Activity != null && this.Activity.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Activity, length must be greater than 3.", new [] { "Activity" });
            }

            yield break;
        }
    }
}
