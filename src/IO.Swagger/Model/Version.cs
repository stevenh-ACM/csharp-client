/* 
 * Some version
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Version
    /// </summary>
    [DataContract]
    public partial class Version :  IEquatable<Version>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Version" /> class.
        /// </summary>
        /// <param name="acumaticaBuildVersion">acumaticaBuildVersion.</param>
        /// <param name="oemBuildVersion">oemBuildVersion.</param>
        /// <param name="databaseVersion">databaseVersion.</param>
        public Version(string acumaticaBuildVersion = default(string), string oemBuildVersion = default(string), string databaseVersion = default(string))
        {
            this.AcumaticaBuildVersion = acumaticaBuildVersion;
            this.OemBuildVersion = oemBuildVersion;
            this.DatabaseVersion = databaseVersion;
        }
        
        /// <summary>
        /// Gets or Sets AcumaticaBuildVersion
        /// </summary>
        [DataMember(Name="acumaticaBuildVersion", EmitDefaultValue=false)]
        public string AcumaticaBuildVersion { get; set; }

        /// <summary>
        /// Gets or Sets OemBuildVersion
        /// </summary>
        [DataMember(Name="oemBuildVersion", EmitDefaultValue=false)]
        public string OemBuildVersion { get; set; }

        /// <summary>
        /// Gets or Sets DatabaseVersion
        /// </summary>
        [DataMember(Name="databaseVersion", EmitDefaultValue=false)]
        public string DatabaseVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Version {\n");
            sb.Append("  AcumaticaBuildVersion: ").Append(AcumaticaBuildVersion).Append("\n");
            sb.Append("  OemBuildVersion: ").Append(OemBuildVersion).Append("\n");
            sb.Append("  DatabaseVersion: ").Append(DatabaseVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Version);
        }

        /// <summary>
        /// Returns true if Version instances are equal
        /// </summary>
        /// <param name="input">Instance of Version to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Version input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcumaticaBuildVersion == input.AcumaticaBuildVersion ||
                    (this.AcumaticaBuildVersion != null &&
                    this.AcumaticaBuildVersion.Equals(input.AcumaticaBuildVersion))
                ) && 
                (
                    this.OemBuildVersion == input.OemBuildVersion ||
                    (this.OemBuildVersion != null &&
                    this.OemBuildVersion.Equals(input.OemBuildVersion))
                ) && 
                (
                    this.DatabaseVersion == input.DatabaseVersion ||
                    (this.DatabaseVersion != null &&
                    this.DatabaseVersion.Equals(input.DatabaseVersion))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AcumaticaBuildVersion != null)
                    hashCode = hashCode * 59 + this.AcumaticaBuildVersion.GetHashCode();
                if (this.OemBuildVersion != null)
                    hashCode = hashCode * 59 + this.OemBuildVersion.GetHashCode();
                if (this.DatabaseVersion != null)
                    hashCode = hashCode * 59 + this.DatabaseVersion.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}