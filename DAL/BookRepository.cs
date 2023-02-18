using HW9.Models;

namespace HW9.DAL
{
    public class BookRepository
    {
        private static List<Book> books = new List<Book>
        {
            new Book{Id = 1, Name = "Harry potter", Author = "J. K. Rowling",Genre = Genre.Novel,CreatedTime = DateTime.Today,BorrowedTime = DateTime.Parse("2/16/2020") },
            new Book{Id = 2, Name = "For Dummies", Author = "Various",Genre = Genre.Cooking,CreatedTime = DateTime.Today,BorrowedTime = DateTime.Parse("2/16/2021") },
            new Book{Id = 3, Name = "Guns, Germs, and Steel", Author = "Jared Diamond",Genre = Genre.History,CreatedTime = DateTime.Today,BorrowedTime = null },
            new Book{Id = 4, Name = "Silent Spring", Author = "Rachel Carson",Genre = Genre.Science,CreatedTime = DateTime.Today,BorrowedTime = null },

        };
        public static List<Book> List()
        {
            return books;
        }
        public static int Count() { return books.Count(); }
        public static DateTime? LastBorrowed()
        {
            var sortedBooks = books.OrderBy(x => x.BorrowedTime).ToList();
            return sortedBooks.Last().BorrowedTime;
        }
        public static Book Get(int id)
        {
            var book = books.First(x => x.Id == id);
            return book;
        }
        public static Book Borrow(int id)
        {
            var book = Get(id);
            book.BorrowedTime = DateTime.Now;
            return book;
        }
        public static Book Return(int id)
        {
            var book = Get(id);
            book.BorrowedTime = null;
            return book;
        }
        public static void Edit(int id, string name, string author, Genre genre)
        {
            var book = Get(id);
            book.Name = name;
            book.Author = author;
            book.Genre = genre;
        }
        public static void Delete(int id)
        {
            var book = Get(id);
            books.Remove(book);
        }

        public static List<Book> BorrowedList()
        {
            var books = List();
            var borrowedBooks = books.Where(x => x.BorrowedTime != null).ToList();
            return borrowedBooks;
        }
    }
}
