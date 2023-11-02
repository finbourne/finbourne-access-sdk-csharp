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
    /// Defines PolicyType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PolicyType
    {
        /// <summary>
        /// Enum Undefined for value: Undefined
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined = 1,

        /// <summary>
        /// Enum Entitlement for value: Entitlement
        /// </summary>
        [EnumMember(Value = "Entitlement")]
        Entitlement = 2,

        /// <summary>
        /// Enum Licence for value: Licence
        /// </summary>
        [EnumMember(Value = "Licence")]
        Licence = 3

    }

}
