﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Box.V2.Models
{
    public class BoxCollaborationRequest : BoxRequestEntity
    {

        /// <summary>
        /// The item to add the collaboration on
        /// The ID and Type are required. The Type MUST also be folder
        /// </summary>
        [JsonProperty(PropertyName = "item")]
        public BoxRequestEntity Item { get; set; }

        /// <summary>
        /// The user who this collaboration applies to
        /// </summary>
        [JsonProperty(PropertyName = "accessible_by")]
        public BoxCollaborationUserRequest AccessibleBy { get; set; }

        /// <summary>
        /// The access level of this collaboration
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Whether this collaboration has been accepted
        /// This can be set to ‘accepted’ or ‘rejected’ by the ‘accessible_by’ user if the status is ‘pending’
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
