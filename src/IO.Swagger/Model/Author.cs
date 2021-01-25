/* 
 * Web of Science API Lite
 *
 * A responsive API that supports rich searching across the Web of Science Core Collection to retrieve core article metadata.  This service provides a great way to reuse Web of Science data both internally and externally to enhance  institutional repositories and research networking systems with best-in-class data. This API supports searching across the Web of Science to retrieve item-level metadata with limited fields:  - UT (Unique Identifier) - Authors - Author keywords - Document type - Title - Issue - Pages - Publication date - Source title - Volume - DOI - ISBN - ISSN   The API supports JSON and XML responses, and this documentation supports trying both response types. 
 *
 * OpenAPI spec version: 1.0
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
    /// The source authors
    /// </summary>
    [DataContract]
        public partial class Author :  IEquatable<Author>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Author" /> class.
        /// </summary>
        /// <param name="authors">authors.</param>
        /// <param name="bookAuthors">bookAuthors.</param>
        /// <param name="bookGroupAuthors">Book authors if In case of a book series.</param>
        public Author(List<string> authors = default(List<string>), List<string> bookAuthors = default(List<string>), List<string> bookGroupAuthors = default(List<string>))
        {
            this.Authors = authors;
            this.BookAuthors = bookAuthors;
            this.BookGroupAuthors = bookGroupAuthors;
        }
        
        /// <summary>
        /// Gets or Sets Authors
        /// </summary>
        [DataMember(Name="Authors", EmitDefaultValue=false)]
        public List<string> Authors { get; set; }

        /// <summary>
        /// Gets or Sets BookAuthors
        /// </summary>
        [DataMember(Name="BookAuthors", EmitDefaultValue=false)]
        public List<string> BookAuthors { get; set; }

        /// <summary>
        /// Book authors if In case of a book series
        /// </summary>
        /// <value>Book authors if In case of a book series</value>
        [DataMember(Name="BookGroupAuthors", EmitDefaultValue=false)]
        public List<string> BookGroupAuthors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Author {\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("  BookAuthors: ").Append(BookAuthors).Append("\n");
            sb.Append("  BookGroupAuthors: ").Append(BookGroupAuthors).Append("\n");
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
            return this.Equals(input as Author);
        }

        /// <summary>
        /// Returns true if Author instances are equal
        /// </summary>
        /// <param name="input">Instance of Author to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Author input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authors == input.Authors ||
                    this.Authors != null &&
                    input.Authors != null &&
                    this.Authors.SequenceEqual(input.Authors)
                ) && 
                (
                    this.BookAuthors == input.BookAuthors ||
                    this.BookAuthors != null &&
                    input.BookAuthors != null &&
                    this.BookAuthors.SequenceEqual(input.BookAuthors)
                ) && 
                (
                    this.BookGroupAuthors == input.BookGroupAuthors ||
                    this.BookGroupAuthors != null &&
                    input.BookGroupAuthors != null &&
                    this.BookGroupAuthors.SequenceEqual(input.BookGroupAuthors)
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
                if (this.Authors != null)
                    hashCode = hashCode * 59 + this.Authors.GetHashCode();
                if (this.BookAuthors != null)
                    hashCode = hashCode * 59 + this.BookAuthors.GetHashCode();
                if (this.BookGroupAuthors != null)
                    hashCode = hashCode * 59 + this.BookGroupAuthors.GetHashCode();
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