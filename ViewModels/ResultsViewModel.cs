using System;
using System.Linq;
using IndyBooks.Models;

namespace IndyBooks.ViewModels
{
	public class ResultsViewModel
	{
		public IQueryable<Book> BookList { get; set; }
	}
}

