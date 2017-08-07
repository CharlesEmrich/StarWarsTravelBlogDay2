using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TravelBlog.Models;
using Microsoft.AspNetCore.Identity;

namespace TravelBlog.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        private readonly TravelBlogContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public CommentController(UserManager<ApplicationUser> userManager, TravelBlogContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            //We need to get access to the userId and the targetId here somehow
            _db.Comments.Add(comment);
            _db.SaveChanges();
            //this return line needs to Redirect not to index but back to the particular detail view
            return RedirectToAction("Index");

        }
    }
}