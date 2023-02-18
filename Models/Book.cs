using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HW9.Models
{
    public class Book
    {
        public int Id { get; set; }


        [Display(Name = "Book Name")]
        public string Name { get; set; }


        [Display(Name = "Author Name")]
        public string Author { get; set; }


        [Display(Name = "Genre")]
        public Genre Genre { get; set; }


        [Display(Name = "Creation Date")]
        public DateTime CreatedTime { get; set; }


        [Display(Name = "Borrowed Time")]
        public DateTime? BorrowedTime  { get; set; }
    }
    public enum Genre
    {
        Science = 1,
        Novel = 2,
        History = 3,
        Cooking = 4,
    }
}
