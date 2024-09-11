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
    /// Defines Grant
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Grant
    {
        /// <summary>
        /// Enum Allow for value: Allow
        /// </summary>
        [EnumMember(Value = "Allow")]
        Allow = 1,

        /// <summary>
        /// Enum Deny for value: Deny
        /// </summary>
        [EnumMember(Value = "Deny")]
        Deny = 2

    }

}
