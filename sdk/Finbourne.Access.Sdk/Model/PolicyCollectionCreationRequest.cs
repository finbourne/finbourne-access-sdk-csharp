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
    /// Create a PolicyCollection, a logical group of Policies or other PolicyCollections
    /// </summary>
    [DataContract(Name = "PolicyCollectionCreationRequest")]
    public partial class PolicyCollectionCreationRequest : IEquatable<PolicyCollectionCreationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyCollectionCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PolicyCollectionCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyCollectionCreationRequest" /> class.
        /// </summary>
        /// <param name="code">The identifier for the PolicyCollection being created (required).</param>
        /// <param name="policies">The identifiers of the Policies in this collection.</param>
        /// <param name="metadata">Any relevant metadata associated with this resource for controlling access to this resource.</param>
        /// <param name="policyCollections">The identifiers of the PolicyCollections in this collection.</param>
        /// <param name="description">A description of this policy collection.</param>
        public PolicyCollectionCreationRequest(string code = default(string), List<PolicyId> policies = default(List<PolicyId>), Dictionary<string, List<EntitlementMetadata>> metadata = default(Dictionary<string, List<EntitlementMetadata>>), List<PolicyCollectionId> policyCollections = default(List<PolicyCollectionId>), string description = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for PolicyCollectionCreationRequest and cannot be null");
            }
            this.Code = code;
            this.Policies = policies;
            this.Metadata = metadata;
            this.PolicyCollections = policyCollections;
            this.Description = description;
        }

        /// <summary>
        /// The identifier for the PolicyCollection being created
        /// </summary>
        /// <value>The identifier for the PolicyCollection being created</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// The identifiers of the Policies in this collection
        /// </summary>
        /// <value>The identifiers of the Policies in this collection</value>
        [DataMember(Name = "policies", EmitDefaultValue = true)]
        public List<PolicyId> Policies { get; set; }

        /// <summary>
        /// Any relevant metadata associated with this resource for controlling access to this resource
        /// </summary>
        /// <value>Any relevant metadata associated with this resource for controlling access to this resource</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, List<EntitlementMetadata>> Metadata { get; set; }

        /// <summary>
        /// The identifiers of the PolicyCollections in this collection
        /// </summary>
        /// <value>The identifiers of the PolicyCollections in this collection</value>
        [DataMember(Name = "policyCollections", EmitDefaultValue = true)]
        public List<PolicyCollectionId> PolicyCollections { get; set; }

        /// <summary>
        /// A description of this policy collection
        /// </summary>
        /// <value>A description of this policy collection</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PolicyCollectionCreationRequest {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PolicyCollections: ").Append(PolicyCollections).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as PolicyCollectionCreationRequest);
        }

        /// <summary>
        /// Returns true if PolicyCollectionCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyCollectionCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyCollectionCreationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.PolicyCollections == input.PolicyCollections ||
                    this.PolicyCollections != null &&
                    input.PolicyCollections != null &&
                    this.PolicyCollections.SequenceEqual(input.PolicyCollections)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.PolicyCollections != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyCollections.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
            // Code (string) maxLength
            if (this.Code != null && this.Code.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 100.", new [] { "Code" });
            }

            // Code (string) minLength
            if (this.Code != null && this.Code.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 3.", new [] { "Code" });
            }

            // Code (string) pattern
            Regex regexCode = new Regex(@"^(?=.*[a-zA-Z])[\w][\w +-]{2,100}$", RegexOptions.CultureInvariant);
            if (false == regexCode.Match(this.Code).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, must match a pattern of " + regexCode, new [] { "Code" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            yield break;
        }
    }
}
