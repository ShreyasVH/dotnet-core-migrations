using DotnetCoreMssql.Requests;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DotnetCoreMssql.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(25)]
        public string Author { get; set; }
        // Add more properties as needed

        [JsonConstructor]
        public Book()
        {
            // Parameterless constructor required by Entity Framework Core
        }

        public Book(CreateRequest bookRequest)
        {
            Name = bookRequest.Name;
            Author = bookRequest.Author;
        }
    }
}
