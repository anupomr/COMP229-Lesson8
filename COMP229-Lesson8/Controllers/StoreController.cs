using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP229_Lesson8.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public String Index()
        {
            return "This is my Store Index Page! ";
        }
        // GET: Store/Browse?genre=Rock
        public String Browse(String genre)
        {
            String message = HttpUtility.HtmlEncode("Store.Browse, Genre="+genre);
            return message;
        }
        // GET: Store/Details/5
        public String Details(int id)
        {
            String message = HttpUtility.HtmlEncode("Store.Details, ID=" + id);
            return message;
        }
    }
}