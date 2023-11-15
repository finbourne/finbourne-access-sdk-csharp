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
    /// Dto used to request updating a user&#39;s role
    /// </summary>
    [DataContract(Name = "UserRoleUpdateRequest")]
    public partial class UserRoleUpdateRequest : IEquatable<UserRoleUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserRoleUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleUpdateRequest" /> class.
        /// </summary>
        /// <param name="resource">resource (required).</param>
        public UserRoleUpdateRequest(PolicyIdRoleResource resource = default(PolicyIdRoleResource))
        {
            // to ensure "resource" is required (not null)
            if (resource == null)
            {
                throw new ArgumentNullException("resource is a required property for UserRoleUpdateRequest and cannot be null");
            }
            this.Resource = resource;
        }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", IsRequired = true, EmitDefaultValue = true)]
        public PolicyIdRoleResource Resource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserRoleUpdateRequest {\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
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
            return this.Equals(input as UserRoleUpdateRequest);
        }

        /// <summary>
        /// Returns true if UserRoleUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UserRoleUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRoleUpdateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
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
                if (this.Resource != null)
                {
                    hashCode = (hashCode * 59) + this.Resource.GetHashCode();
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
            yield break;
        }
    }
}