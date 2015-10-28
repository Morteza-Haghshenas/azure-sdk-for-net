// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes Compute Resource Usage.
    /// </summary>
    public partial class Usage
    {
        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        public Usage() { }

        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        public Usage(UsageUnit? unit = default(UsageUnit?), int? currentValue = default(int?), long? limit = default(long?), UsageName name = default(UsageName))
        {
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary>
        /// Gets or sets an enum describing the unit of measurement. Possible
        /// values for this property include: 'Count'.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public UsageUnit? Unit { get; set; }

        /// <summary>
        /// Gets or sets the current value of the usage.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public int? CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets the limit of usage.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// Gets or sets the name of the type of usage.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public UsageName Name { get; set; }

    }
}