// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Deployment resource properties payload
    /// </summary>
    public partial class DeploymentResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentResourceProperties
        /// class.
        /// </summary>
        public DeploymentResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentResourceProperties
        /// class.
        /// </summary>
        /// <param name="source">Uploaded source information of the
        /// deployment.</param>
        /// <param name="appName">App name of the deployment</param>
        /// <param name="deploymentSettings">Deployment settings of the
        /// Deployment</param>
        /// <param name="provisioningState">Provisioning state of the
        /// Deployment. Possible values include: 'Creating', 'Processing',
        /// 'Succeeded', 'Failed'</param>
        /// <param name="status">Status of the Deployment. Possible values
        /// include: 'Unknown', 'Stopped', 'Running', 'Failed', 'Processing',
        /// 'Allocating', 'Upgrading', 'Compiling'</param>
        /// <param name="active">Indicates whether the Deployment is
        /// active</param>
        /// <param name="createdTime">Date time when the resource is
        /// created</param>
        /// <param name="instances">Collection of instances belong to the
        /// Deployment</param>
        public DeploymentResourceProperties(UserSourceInfo source = default(UserSourceInfo), string appName = default(string), DeploymentSettings deploymentSettings = default(DeploymentSettings), string provisioningState = default(string), string status = default(string), bool? active = default(bool?), System.DateTime? createdTime = default(System.DateTime?), IList<DeploymentInstance> instances = default(IList<DeploymentInstance>))
        {
            Source = source;
            AppName = appName;
            DeploymentSettings = deploymentSettings;
            ProvisioningState = provisioningState;
            Status = status;
            Active = active;
            CreatedTime = createdTime;
            Instances = instances;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets uploaded source information of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public UserSourceInfo Source { get; set; }

        /// <summary>
        /// Gets app name of the deployment
        /// </summary>
        [JsonProperty(PropertyName = "appName")]
        public string AppName { get; private set; }

        /// <summary>
        /// Gets or sets deployment settings of the Deployment
        /// </summary>
        [JsonProperty(PropertyName = "deploymentSettings")]
        public DeploymentSettings DeploymentSettings { get; set; }

        /// <summary>
        /// Gets provisioning state of the Deployment. Possible values include:
        /// 'Creating', 'Processing', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets status of the Deployment. Possible values include: 'Unknown',
        /// 'Stopped', 'Running', 'Failed', 'Processing', 'Allocating',
        /// 'Upgrading', 'Compiling'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets indicates whether the Deployment is active
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; private set; }

        /// <summary>
        /// Gets date time when the resource is created
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets collection of instances belong to the Deployment
        /// </summary>
        [JsonProperty(PropertyName = "instances")]
        public IList<DeploymentInstance> Instances { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DeploymentSettings != null)
            {
                DeploymentSettings.Validate();
            }
        }
    }
}
