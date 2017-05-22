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
    /// Replication protected item custom data details.
    /// </summary>
    public partial class ProtectableItemProperties
    {
        /// <summary>
        /// Initializes a new instance of the ProtectableItemProperties class.
        /// </summary>
        public ProtectableItemProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProtectableItemProperties class.
        /// </summary>
        /// <param name="friendlyName">The name.</param>
        /// <param name="protectionStatus">The protection status.</param>
        /// <param name="replicationProtectedItemId">The ARM resource of
        /// protected items.</param>
        /// <param name="recoveryServicesProviderId">The recovery provider ARM
        /// Id.</param>
        /// <param name="protectionReadinessErrors">The Current protection
        /// readiness errors.</param>
        /// <param name="supportedReplicationProviders">The list of replication
        /// providers supported for the protectable item.</param>
        /// <param name="customDetails">The Replication provider custom
        /// settings.</param>
        public ProtectableItemProperties(string friendlyName = default(string), string protectionStatus = default(string), string replicationProtectedItemId = default(string), string recoveryServicesProviderId = default(string), IList<string> protectionReadinessErrors = default(IList<string>), IList<string> supportedReplicationProviders = default(IList<string>), ConfigurationSettings customDetails = default(ConfigurationSettings))
        {
            FriendlyName = friendlyName;
            ProtectionStatus = protectionStatus;
            ReplicationProtectedItemId = replicationProtectedItemId;
            RecoveryServicesProviderId = recoveryServicesProviderId;
            ProtectionReadinessErrors = protectionReadinessErrors;
            SupportedReplicationProviders = supportedReplicationProviders;
            CustomDetails = customDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the protection status.
        /// </summary>
        [JsonProperty(PropertyName = "protectionStatus")]
        public string ProtectionStatus { get; set; }

        /// <summary>
        /// Gets or sets the ARM resource of protected items.
        /// </summary>
        [JsonProperty(PropertyName = "replicationProtectedItemId")]
        public string ReplicationProtectedItemId { get; set; }

        /// <summary>
        /// Gets or sets the recovery provider ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryServicesProviderId")]
        public string RecoveryServicesProviderId { get; set; }

        /// <summary>
        /// Gets or sets the Current protection readiness errors.
        /// </summary>
        [JsonProperty(PropertyName = "protectionReadinessErrors")]
        public IList<string> ProtectionReadinessErrors { get; set; }

        /// <summary>
        /// Gets or sets the list of replication providers supported for the
        /// protectable item.
        /// </summary>
        [JsonProperty(PropertyName = "supportedReplicationProviders")]
        public IList<string> SupportedReplicationProviders { get; set; }

        /// <summary>
        /// Gets or sets the Replication provider custom settings.
        /// </summary>
        [JsonProperty(PropertyName = "customDetails")]
        public ConfigurationSettings CustomDetails { get; set; }

    }
}
