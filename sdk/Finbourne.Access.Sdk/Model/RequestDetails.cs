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
    /// The details of the requested evaluation
    /// </summary>
    [DataContract]
    public partial class RequestDetails :  IEquatable<RequestDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDetails" /> class.
        /// </summary>
        /// <param name="action">action (required).</param>
        /// <param name="fromEffectiveDate">The start date for the requested effective date range for the resource (if null, UtcNow).</param>
        /// <param name="toEffectiveDate">The end date for the requested effective date range for the resource (if null, same as from date).</param>
        /// <param name="fromAsAt">The requested AsAt date for the resource (if null, Latest). If specifying a range of AsAt dates, this is the lower bounds..</param>
        /// <param name="toAsAt">Upper bound if specifying a request that requires a range of AsAt dates. This is used if specifying the desire to grant access for a user between an AsAt range..</param>
        public RequestDetails(RequestedActionKey action = default(RequestedActionKey), DateTimeOffset? fromEffectiveDate = default(DateTimeOffset?), DateTimeOffset? toEffectiveDate = default(DateTimeOffset?), DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?))
        {
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for RequestDetails and cannot be null");
            }
            else
            {
                this.Action = action;
            }
            
            this.FromEffectiveDate = fromEffectiveDate;
            this.ToEffectiveDate = toEffectiveDate;
            this.FromAsAt = fromAsAt;
            this.ToAsAt = toAsAt;
            this.FromEffectiveDate = fromEffectiveDate;
            this.ToEffectiveDate = toEffectiveDate;
            this.FromAsAt = fromAsAt;
            this.ToAsAt = toAsAt;
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public RequestedActionKey Action { get; set; }

        /// <summary>
        /// The start date for the requested effective date range for the resource (if null, UtcNow)
        /// </summary>
        /// <value>The start date for the requested effective date range for the resource (if null, UtcNow)</value>
        [DataMember(Name="fromEffectiveDate", EmitDefaultValue=true)]
        public DateTimeOffset? FromEffectiveDate { get; set; }

        /// <summary>
        /// The end date for the requested effective date range for the resource (if null, same as from date)
        /// </summary>
        /// <value>The end date for the requested effective date range for the resource (if null, same as from date)</value>
        [DataMember(Name="toEffectiveDate", EmitDefaultValue=true)]
        public DateTimeOffset? ToEffectiveDate { get; set; }

        /// <summary>
        /// The requested AsAt date for the resource (if null, Latest). If specifying a range of AsAt dates, this is the lower bounds.
        /// </summary>
        /// <value>The requested AsAt date for the resource (if null, Latest). If specifying a range of AsAt dates, this is the lower bounds.</value>
        [DataMember(Name="fromAsAt", EmitDefaultValue=true)]
        public DateTimeOffset? FromAsAt { get; set; }

        /// <summary>
        /// Upper bound if specifying a request that requires a range of AsAt dates. This is used if specifying the desire to grant access for a user between an AsAt range.
        /// </summary>
        /// <value>Upper bound if specifying a request that requires a range of AsAt dates. This is used if specifying the desire to grant access for a user between an AsAt range.</value>
        [DataMember(Name="toAsAt", EmitDefaultValue=true)]
        public DateTimeOffset? ToAsAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestDetails {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  FromEffectiveDate: ").Append(FromEffectiveDate).Append("\n");
            sb.Append("  ToEffectiveDate: ").Append(ToEffectiveDate).Append("\n");
            sb.Append("  FromAsAt: ").Append(FromAsAt).Append("\n");
            sb.Append("  ToAsAt: ").Append(ToAsAt).Append("\n");
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
            return this.Equals(input as RequestDetails);
        }

        /// <summary>
        /// Returns true if RequestDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.FromEffectiveDate == input.FromEffectiveDate ||
                    (this.FromEffectiveDate != null &&
                    this.FromEffectiveDate.Equals(input.FromEffectiveDate))
                ) && 
                (
                    this.ToEffectiveDate == input.ToEffectiveDate ||
                    (this.ToEffectiveDate != null &&
                    this.ToEffectiveDate.Equals(input.ToEffectiveDate))
                ) && 
                (
                    this.FromAsAt == input.FromAsAt ||
                    (this.FromAsAt != null &&
                    this.FromAsAt.Equals(input.FromAsAt))
                ) && 
                (
                    this.ToAsAt == input.ToAsAt ||
                    (this.ToAsAt != null &&
                    this.ToAsAt.Equals(input.ToAsAt))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.FromEffectiveDate != null)
                    hashCode = hashCode * 59 + this.FromEffectiveDate.GetHashCode();
                if (this.ToEffectiveDate != null)
                    hashCode = hashCode * 59 + this.ToEffectiveDate.GetHashCode();
                if (this.FromAsAt != null)
                    hashCode = hashCode * 59 + this.FromAsAt.GetHashCode();
                if (this.ToAsAt != null)
                    hashCode = hashCode * 59 + this.ToAsAt.GetHashCode();
                return hashCode;
            }
        }
    }

}