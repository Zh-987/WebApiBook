using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication5.Models;
using System.Data;
using System.Data.Entity;

namespace WebApplication5.Controllers
{

    public class ValuesController : ApiController
    {
        BookContext dbbook = new BookContext(); 
        // GET api/values
        public IEnumerable<Book> GetBooks()
        {
            return dbbook.book;
        }

        // GET api/values/5
        public Book GetBook(int id)
        {
            Book bookID = dbbook.book.Find(id);
            return bookID;
        }

        [HttpPost]
        // POST api/values
        public void CreatePost([FromBody] Book postbook)
        {
            dbbook.book.Add(postbook);
            dbbook.SaveChanges();
        }

        [HttpPut]
        // PUT api/values/5
        public void EditBook(int id, [FromBody] Book editbook)
        {
            if(id == editbook.id)
            {
                dbbook.Entry(editbook).State = EntityState.Modified;
                dbbook.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Book deletebook = dbbook.book.Find(id);
            if (deletebook != null)
            {
                dbbook.book.Remove(deletebook);
                dbbook.SaveChanges();
            }
        }
    }
}
