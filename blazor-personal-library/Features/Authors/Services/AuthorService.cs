using blazor_personal_library.Features.Authors.Entities;
using blazor_personal_library.Features.Authors.Interfaces;

namespace blazor_personal_library.Features.Authors.Services
{
    public class AuthorService : IAuthorService
    {

        private List<Author> _authors;

        public AuthorService()
        {
            _authors = new List<Author>()
            {
            new Author
            {
                Id = 1,
                Name = "Gabriel García Márquez",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0f/Gabriel_Garcia_Marquez.jpg"
            },
            new Author
            {
                Id = 2,
                Name = "Jane Austen",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cc/CassandraAusten-JaneAusten%28c.1810%29_hires.jpg"
            },
            new Author
            {
                Id = 3,
                Name = "J. R. R. Tolkien",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d4/J._R._R._Tolkien%2C_ca._1925.jpg"
            },
            new Author
            {
                Id = 4,
                Name = "Agatha Christie",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/f/f7/Agatha_Christie_in_Nederland_%28detectiveschrijfster%29%2C_bij_aankomst_op_Schiphol_me%2C_Bestanddeelnr_916-8898_%28cropped%29.jpg"
            },
            new Author
            {
                Id = 5,
                Name = "Haruki Murakami",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/51/Conversatorio_Haruki_Murakami_%2812_de_12%29_%2845747009452%29_%28cropped%29.jpg/250px-Conversatorio_Haruki_Murakami_%2812_de_12%29_%2845747009452%29_%28cropped%29.jpg"
            }

            };
        }

        public List<Author> GetAuthors()
        {
            return _authors;
        }

        public void AddAuthor(Author author)
        {
            _authors.Add(author);
        }
    }
}
