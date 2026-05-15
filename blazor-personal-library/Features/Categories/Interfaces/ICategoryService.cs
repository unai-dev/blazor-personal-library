using blazor_personal_library.Features.Categories.Entities;

namespace blazor_personal_library.Features.Categories.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        void AddCategory(Category category);
    }
}
