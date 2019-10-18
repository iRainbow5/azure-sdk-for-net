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
    /// Test keys payload
    /// </summary>
    public partial class TestKeys
    {
        /// <summary>
        /// Initializes a new instance of the TestKeys class.
        /// </summary>
        public TestKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestKeys class.
        /// </summary>
        /// <param name="primaryKey">Primary key</param>
        /// <param name="secondaryKey">Secondary key</param>
        /// <param name="primaryTestEndpoint">Primary test endpoint</param>
        /// <param name="secondaryTestEndpoint">Secondary test endpoint</param>
        /// <param name="enabled">Indicates whether the test endpoint feature
        /// enabled or not</param>
        public TestKeys(string primaryKey = default(string), string secondaryKey = default(string), string primaryTestEndpoint = default(string), string secondaryTestEndpoint = default(string), bool? enabled = default(bool?))
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            PrimaryTestEndpoint = primaryTestEndpoint;
            SecondaryTestEndpoint = secondaryTestEndpoint;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets primary key
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets secondary key
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; set; }

        /// <summary>
        /// Gets or sets primary test endpoint
        /// </summary>
        [JsonProperty(PropertyName = "primaryTestEndpoint")]
        public string PrimaryTestEndpoint { get; set; }

        /// <summary>
        /// Gets or sets secondary test endpoint
        /// </summary>
        [JsonProperty(PropertyName = "secondaryTestEndpoint")]
        public string SecondaryTestEndpoint { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the test endpoint feature enabled or
        /// not
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

    }
}