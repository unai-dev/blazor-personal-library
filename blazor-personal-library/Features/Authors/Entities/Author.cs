using blazor_personal_library.Features.Books.Entities;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace blazor_personal_library.Features.Authors.Entities
{
    public class Author
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public IBrowserFile? ImageFile { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
