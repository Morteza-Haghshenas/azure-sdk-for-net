// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This class represents details for export jobs workflow.
    /// </summary>
    public partial class ExportJobDetails : JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the ExportJobDetails class.
        /// </summary>
        public ExportJobDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportJobDetails class.
        /// </summary>
        /// <param name="affectedObjectDetails">The affected object properties
        /// like source server, source cloud, target
        /// server, target cloud etc. based on the workflow object
        /// details.</param>
        /// <param name="blobUri">BlobUri of the exported jobs.</param>
        /// <param name="sasToken">The sas token to access blob.</param>
        public ExportJobDetails(IDictionary<string, string> affectedObjectDetails = default(IDictionary<string, string>), string blobUri = default(string), string sasToken = default(string))
            : base(affectedObjectDetails)
        {
            BlobUri = blobUri;
            SasToken = sasToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets blobUri of the exported jobs.
        /// </summary>
        [JsonProperty(PropertyName = "blobUri")]
        public string BlobUri { get; set; }

        /// <summary>
        /// Gets or sets the sas token to access blob.
        /// </summary>
        [JsonProperty(PropertyName = "sasToken")]
        public string SasToken { get; set; }

    }
}
