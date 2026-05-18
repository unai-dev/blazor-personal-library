using blazor_personal_library.Features.Authors.Entities;

namespace blazor_personal_library.Features.Authors.Interfaces
{
    public interface IAuthorService
    {
        public List<Author> GetAuthors();

        public void AddAuthor(Author author);
    }
}
