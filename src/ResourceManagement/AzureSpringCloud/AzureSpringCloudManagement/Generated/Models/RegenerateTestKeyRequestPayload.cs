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
    /// Regenerate test key request payload
    /// </summary>
    public partial class RegenerateTestKeyRequestPayload
    {
        /// <summary>
        /// Initializes a new instance of the RegenerateTestKeyRequestPayload
        /// class.
        /// </summary>
        public RegenerateTestKeyRequestPayload()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegenerateTestKeyRequestPayload
        /// class.
        /// </summary>
        /// <param name="keyType">Type of the test key. Possible values
        /// include: 'Primary', 'Secondary'</param>
        public RegenerateTestKeyRequestPayload(string keyType)
        {
            KeyType = keyType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of the test key. Possible values include:
        /// 'Primary', 'Secondary'
        /// </summary>
        [JsonProperty(PropertyName = "keyType")]
        public string KeyType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyType");
            }
        }
    }
}