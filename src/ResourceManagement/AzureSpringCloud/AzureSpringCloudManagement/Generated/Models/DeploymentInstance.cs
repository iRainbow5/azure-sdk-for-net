// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deployment instance payload
    /// </summary>
    public partial class DeploymentInstance
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentInstance class.
        /// </summary>
        public DeploymentInstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentInstance class.
        /// </summary>
        /// <param name="name">Name of the deployment instance</param>
        /// <param name="status">Status of the deployment instance</param>
        /// <param name="reason">Failed reason of the deployment
        /// instance</param>
        /// <param name="discoveryStatus">Discovery status of the deployment
        /// instance</param>
        public DeploymentInstance(string name = default(string), string status = default(string), string reason = default(string), string discoveryStatus = default(string))
        {
            Name = name;
            Status = status;
            Reason = reason;
            DiscoveryStatus = discoveryStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the deployment instance
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets status of the deployment instance
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets failed reason of the deployment instance
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; private set; }

        /// <summary>
        /// Gets discovery status of the deployment instance
        /// </summary>
        [JsonProperty(PropertyName = "discoveryStatus")]
        public string DiscoveryStatus { get; private set; }

    }
}
