/* 
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.1105
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Finbourne.Access.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Access.Sdk.Model
{
    /// <summary>
    /// RoleCreationRequest
    /// </summary>
    [DataContract]
    public partial class RoleCreationRequest :  IEquatable<RoleCreationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoleCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleCreationRequest" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        /// <param name="description">description.</param>
        /// <param name="resource">resource (required).</param>
        /// <param name="when">when (required).</param>
        public RoleCreationRequest(string code = default(string), string description = default(string), RoleResourceRequest resource = default(RoleResourceRequest), WhenSpec when = default(WhenSpec))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for RoleCreationRequest and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            
            this.Description = description;
            // to ensure "resource" is required (not null)
            if (resource == null)
            {
                throw new InvalidDataException("resource is a required property for RoleCreationRequest and cannot be null");
            }
            else
            {
                this.Resource = resource;
            }
            
            // to ensure "when" is required (not null)
            if (when == null)
            {
                throw new InvalidDataException("when is a required property for RoleCreationRequest and cannot be null");
            }
            else
            {
                this.When = when;
            }
            
            this.Description = description;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public RoleResourceRequest Resource { get; set; }

        /// <summary>
        /// Gets or Sets When
        /// </summary>
        [DataMember(Name="when", EmitDefaultValue=false)]
        public WhenSpec When { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleCreationRequest {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  When: ").Append(When).Append("\n");
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
            return this.Equals(input as RoleCreationRequest);
        }

        /// <summary>
        /// Returns true if RoleCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleCreationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.When == input.When ||
                    (this.When != null &&
                    this.When.Equals(input.When))
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
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.When != null)
                    hashCode = hashCode * 59 + this.When.GetHashCode();
                return hashCode;
            }
        }
    }

}
