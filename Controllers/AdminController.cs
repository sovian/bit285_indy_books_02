using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IndyBooks.Models;
using IndyBooks.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IndyBooks.Controllers
{
    public class AdminController : Controller
    {
        private IndyBooksDataContext _dbc;
        public AdminController(IndyBooksDataContext dbc) { _dbc = dbc; }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(SearchViewModel searchVM)
        {
            // Add the entire set of books to the Results View Model
            // TODO: Include the Author data with the books 
            ResultsViewModel results = new ResultsViewModel { BookList = _dbc.Books };

            //Filter the collection when there is a non-empty Field as noted

            //Title Contains
            if (searchVM.Title != null)
            {
                results.BookList = results.BookList
                             .Where(b => b.Title.Contains(searchVM.Title));
            }

            //TODO: Author's Last Name Search
            if (searchVM.AuthorLastName != null)
            {

            }
            //TODO: Priced Between Search (both min and max price entered)
            if (searchVM.MinPrice > 0 && searchVM.MaxPrice > 0)
            {

            }

            return View("SearchResults", results);
        }
    }
}
