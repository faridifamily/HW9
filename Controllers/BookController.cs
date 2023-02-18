using HW9.DAL;
using HW9.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW9.Controllers
{
    public class BookController : Controller
    {
        public IActionResult List()
        {
            var books = BookRepository.List();
            return View(books);
        }


        public IActionResult Borrow(int id)
        {
            var books = BookRepository.Borrow(id);
            return RedirectToAction("List");
        }


        public IActionResult Return(int id)
        {
            var books = BookRepository.Return(id);
            return RedirectToAction("List");
        }

        public IActionResult ReturnBorrowed(int id)
        {
            var books = BookRepository.Return(id);
            return RedirectToAction("BorrowedList");
        }


        public IActionResult BorrowedList()
        {
            var borrowedBooks = BookRepository.BorrowedList();
            return View(borrowedBooks);
        }


        public IActionResult Edit(int id)
        {
            var book = BookRepository.Get(id);
            return View(book);
        }


        [HttpPost]
        public IActionResult Edit(int id, string name, string author, Genre genre)
        {
            BookRepository.Edit(id, name, author, genre);
            return RedirectToAction("List");
        }


        public IActionResult Delete(int id)
        {
            BookRepository.Delete(id);
            return RedirectToAction("List");
        }
    }
}
