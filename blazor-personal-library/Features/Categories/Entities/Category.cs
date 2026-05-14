using System.ComponentModel.DataAnnotations;

namespace blazor_personal_library.Features.Categories.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The field {0} is required")]
        public string? Name { get; set; }
    }
}
