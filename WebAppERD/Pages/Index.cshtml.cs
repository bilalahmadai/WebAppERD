using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppERD.Model;
using WebAppERD.Services;

namespace WebAppERD.Pages
{
    public class IndexModel : PageModel
    {
        //VAR FOR SERVICE 
        JsonFileBookService BookService;
        // var for book records

        public IEnumerable<Book> Books;
        private readonly ILogger<IndexModel> _logger;

        // added , JsonFileBookService services
        public IndexModel(ILogger<IndexModel> logger,
           JsonFileBookService services)
        {
            _logger = logger;
            //added
            BookService = services;
        }

        public void OnGet()
        {

        }
    }
}
