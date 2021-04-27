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
    /// An action that can be access controlled
    /// </summary>
    [DataContract]
    public partial class AccessControlledAction :  IEquatable<AccessControlledAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlledAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessControlledAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlledAction" /> class.
        /// </summary>
        /// <param name="description">The description of the action (required).</param>
        /// <param name="action">action (required).</param>
        /// <param name="limitedSet">When populated, the provided values are the limited set of resources that are allowed to be specified for  access control for this action.</param>
        /// <param name="links">links.</param>
        public AccessControlledAction(string description = default(string), ActionId action = default(ActionId), List<IdSelectorDefinition> limitedSet = default(List<IdSelectorDefinition>), List<Link> links = default(List<Link>))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for AccessControlledAction and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for AccessControlledAction and cannot be null");
            }
            else
            {
                this.Action = action;
            }
            
            this.LimitedSet = limitedSet;
            this.Links = links;
            this.LimitedSet = limitedSet;
            this.Links = links;
        }
        
        /// <summary>
        /// The description of the action
        /// </summary>
        /// <value>The description of the action</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionId Action { get; set; }

        /// <summary>
        /// When populated, the provided values are the limited set of resources that are allowed to be specified for  access control for this action
        /// </summary>
        /// <value>When populated, the provided values are the limited set of resources that are allowed to be specified for  access control for this action</value>
        [DataMember(Name="limitedSet", EmitDefaultValue=true)]
        public List<IdSelectorDefinition> LimitedSet { get; set; }

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
            sb.Append("class AccessControlledAction {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  LimitedSet: ").Append(LimitedSet).Append("\n");
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
            return this.Equals(input as AccessControlledAction);
        }

        /// <summary>
        /// Returns true if AccessControlledAction instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessControlledAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessControlledAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.LimitedSet == input.LimitedSet ||
                    this.LimitedSet != null &&
                    input.LimitedSet != null &&
                    this.LimitedSet.SequenceEqual(input.LimitedSet)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.LimitedSet != null)
                    hashCode = hashCode * 59 + this.LimitedSet.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}