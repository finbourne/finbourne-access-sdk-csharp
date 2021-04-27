/* 
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.1085
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
    /// RoleResponse
    /// </summary>
    [DataContract]
    public partial class RoleResponse :  IEquatable<RoleResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoleResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="roleHierarchyIndex">roleHierarchyIndex (required).</param>
        /// <param name="description">description.</param>
        /// <param name="resource">resource (required).</param>
        /// <param name="when">when (required).</param>
        /// <param name="permission">permission (required).</param>
        /// <param name="limit">limit.</param>
        /// <param name="links">links.</param>
        public RoleResponse(RoleId id = default(RoleId), int? roleHierarchyIndex = default(int?), string description = default(string), RoleResourceRequest resource = default(RoleResourceRequest), WhenSpec when = default(WhenSpec), string permission = default(string), Dictionary<string, string> limit = default(Dictionary<string, string>), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for RoleResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "roleHierarchyIndex" is required (not null)
            if (roleHierarchyIndex == null)
            {
                throw new InvalidDataException("roleHierarchyIndex is a required property for RoleResponse and cannot be null");
            }
            else
            {
                this.RoleHierarchyIndex = roleHierarchyIndex;
            }
            
            this.Description = description;
            // to ensure "resource" is required (not null)
            if (resource == null)
            {
                throw new InvalidDataException("resource is a required property for RoleResponse and cannot be null");
            }
            else
            {
                this.Resource = resource;
            }
            
            // to ensure "when" is required (not null)
            if (when == null)
            {
                throw new InvalidDataException("when is a required property for RoleResponse and cannot be null");
            }
            else
            {
                this.When = when;
            }
            
            // to ensure "permission" is required (not null)
            if (permission == null)
            {
                throw new InvalidDataException("permission is a required property for RoleResponse and cannot be null");
            }
            else
            {
                this.Permission = permission;
            }
            
            this.Limit = limit;
            this.Links = links;
            this.Description = description;
            this.Limit = limit;
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public RoleId Id { get; set; }

        /// <summary>
        /// Gets or Sets RoleHierarchyIndex
        /// </summary>
        [DataMember(Name="roleHierarchyIndex", EmitDefaultValue=false)]
        public int? RoleHierarchyIndex { get; set; }

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
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public string Permission { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=true)]
        public Dictionary<string, string> Limit { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RoleHierarchyIndex: ").Append(RoleHierarchyIndex).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  When: ").Append(When).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as RoleResponse);
        }

        /// <summary>
        /// Returns true if RoleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RoleHierarchyIndex == input.RoleHierarchyIndex ||
                    (this.RoleHierarchyIndex != null &&
                    this.RoleHierarchyIndex.Equals(input.RoleHierarchyIndex))
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
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit != null &&
                    input.Limit != null &&
                    this.Limit.SequenceEqual(input.Limit)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RoleHierarchyIndex != null)
                    hashCode = hashCode * 59 + this.RoleHierarchyIndex.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.When != null)
                    hashCode = hashCode * 59 + this.When.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}