﻿using System;
using MAVN.Service.Kyc.Client.Models.Enums;

namespace MAVN.Service.Kyc.Client.Models.Responses
{
    /// <summary>
    /// Response model holding KYC info
    /// </summary>
    public class KycInformationResponse
    {
        /// <summary>
        /// Id of the partner
        /// </summary>
        public Guid PartnerId { get; set; }
        /// <summary>
        /// Id of the admin user
        /// </summary>
        public Guid AdminUserId { get; set; }
        /// <summary>
        /// Timestamp
        /// </summary>
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Current status
        /// </summary>
        public KycStatus KycStatus { get; set; }
    }
}
