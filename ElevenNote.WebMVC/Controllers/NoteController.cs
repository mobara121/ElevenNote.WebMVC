using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    [Authorize]  //Controllerの前のNoteが、localhost:xxx/Note
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index() // localhost:xxx/Note/IndexにいくとViewを返してくれる。
        {
            var model = new NoteListItem[0];
            return View(model);
        }
    }
}