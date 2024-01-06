using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcbooks.Models;

namespace mvcbooks.Controllers
{
    public class BookController : Controller
    {
        
        public IActionResult Index()
        {
            var book = new Book();
            book.Id =1;
            book.Title = "Bilincaltinin Gucu";
            book.Image="bilinaltiningucu.jpg";
            book.Author="Joseph Murphy";
            book.Description ="Zihniniz, anbean yaşadıklarınızı işleyip kendinizi gerçekleştirme yolculuğunuzda gideceğiniz yönü belirlemenizi sağlıyor.";
            
            return View(book);
        }
        public IActionResult Details(int id)
        {
            var book = Repository.GetCourseById(id);
            return View(book);
        }
        [HttpGet]
         public IActionResult List()
        {
           return View("BookList",Repository.Books);
           
        }     
        
    }
}