using blazor_personal_library.Features.Books.Entities;

namespace blazor_personal_library.Features.Books.Interfaces
{
    public interface IBookService
    {
        public List<Book> GetBooks();
        public void AddNewBook(Book book);
    }
}
