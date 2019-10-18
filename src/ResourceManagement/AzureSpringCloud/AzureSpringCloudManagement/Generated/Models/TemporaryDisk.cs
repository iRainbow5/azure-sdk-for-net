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
    /// Temporary disk payload
    /// </summary>
    public partial class TemporaryDisk
    {
        /// <summary>
        /// Initializes a new instance of the TemporaryDisk class.
        /// </summary>
        public TemporaryDisk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TemporaryDisk class.
        /// </summary>
        /// <param name="sizeInGB">Size of the temporary disk in GB</param>
        /// <param name="mountPath">Mount path of the temporary disk</param>
        public TemporaryDisk(int? sizeInGB = default(int?), string mountPath = default(string))
        {
            SizeInGB = sizeInGB;
            MountPath = mountPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets size of the temporary disk in GB
        /// </summary>
        [JsonProperty(PropertyName = "sizeInGB")]
        public int? SizeInGB { get; set; }

        /// <summary>
        /// Gets or sets mount path of the temporary disk
        /// </summary>
        [JsonProperty(PropertyName = "mountPath")]
        public string MountPath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SizeInGB > 5)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "SizeInGB", 5);
            }
            if (SizeInGB < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "SizeInGB", 0);
            }
        }
    }
}
