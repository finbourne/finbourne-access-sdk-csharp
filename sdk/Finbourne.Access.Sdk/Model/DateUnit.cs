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
    /// Defines DateUnit
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DateUnit
    {
        /// <summary>
        /// Enum Undefined for value: Undefined
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined = 1,

        /// <summary>
        /// Enum Minute for value: Minute
        /// </summary>
        [EnumMember(Value = "Minute")]
        Minute = 2,

        /// <summary>
        /// Enum Hour for value: Hour
        /// </summary>
        [EnumMember(Value = "Hour")]
        Hour = 3,

        /// <summary>
        /// Enum Day for value: Day
        /// </summary>
        [EnumMember(Value = "Day")]
        Day = 4,

        /// <summary>
        /// Enum BusinessDay for value: BusinessDay
        /// </summary>
        [EnumMember(Value = "BusinessDay")]
        BusinessDay = 5,

        /// <summary>
        /// Enum Weeks for value: Weeks
        /// </summary>
        [EnumMember(Value = "Weeks")]
        Weeks = 6,

        /// <summary>
        /// Enum Months for value: Months
        /// </summary>
        [EnumMember(Value = "Months")]
        Months = 7,

        /// <summary>
        /// Enum Years for value: Years
        /// </summary>
        [EnumMember(Value = "Years")]
        Years = 8
    }

}
