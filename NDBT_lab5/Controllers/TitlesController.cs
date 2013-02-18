using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using NDBT_lab5.Models;

namespace NDBT_lab5.Controllers
{
    public class TitlesController : ApiController
    {
        private LibraryContext db = new LibraryContext();

        // GET api/Titles
        public IEnumerable<Title> GetTitles()
        {
            return db.Titles.AsEnumerable();
        }

        // GET api/Titles/5
        public Title GetTitle(int id)
        {
            Title title = db.Titles
                .Include(t => t.Copies)
                .Where(t => t.TitleId == id)
                .First();

            if (title == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return title;
        }

        // PUT api/Titles/5
        public HttpResponseMessage PutTitle(Title title)
        {     
            return Request.CreateResponse(HttpStatusCode.NotImplemented);
        }

        // POST api/Titles
        public HttpResponseMessage PostTitle(Title title)
        {
            if (ModelState.IsValid)
            {
                db.Titles.Add(title);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, title);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = title.TitleId }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Titles/5
        public HttpResponseMessage DeleteTitle(int id)
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}