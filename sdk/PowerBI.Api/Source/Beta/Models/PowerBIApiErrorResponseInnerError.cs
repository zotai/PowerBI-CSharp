// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.Beta.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class PowerBIApiErrorResponseInnerError
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PowerBIApiErrorResponseInnerError class.
        /// </summary>
        public PowerBIApiErrorResponseInnerError() { }

        /// <summary>
        /// Initializes a new instance of the
        /// PowerBIApiErrorResponseInnerError class.
        /// </summary>
        public PowerBIApiErrorResponseInnerError(string trace = default(string), string context = default(string))
        {
            Trace = trace;
            Context = context;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "trace")]
        public string Trace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public string Context { get; set; }

    }
}