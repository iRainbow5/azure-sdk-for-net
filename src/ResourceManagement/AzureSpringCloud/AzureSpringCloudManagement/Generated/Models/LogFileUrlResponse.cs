// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AppPlatform.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Log file URL payload
    /// </summary>
    public partial class LogFileUrlResponse
    {
        /// <summary>
        /// Initializes a new instance of the LogFileUrlResponse class.
        /// </summary>
        public LogFileUrlResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogFileUrlResponse class.
        /// </summary>
        /// <param name="url">URL of the log file</param>
        public LogFileUrlResponse(string url)
        {
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URL of the log file
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}