// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the ARM Resource ID for the linked endpoints
    /// </summary>
    public partial class CdnEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the CdnEndpoint class.
        /// </summary>
        public CdnEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CdnEndpoint class.
        /// </summary>
        /// <param name="id">ARM Resource ID string.</param>
        public CdnEndpoint(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ARM Resource ID string.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
