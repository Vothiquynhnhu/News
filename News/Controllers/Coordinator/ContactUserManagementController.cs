using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using System.Linq;

namespace News.Controllers.Coordinator
{
    [Authorize(Roles = "Admin,Coordinator")]
    public class ContactUserManagementController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactUserManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: ContactUserManagementController
        [Route("contactusermanagement")]
        public ActionResult Index()
        {
            var query = _context.ContactEmail;
            return View(query);
        }

        [Route("contactusermanagement/delete")]
        [HttpGet("{id}")]
        public ActionResult Delete(string id)
        {
            var query = _context.ContactEmail.FirstOrDefault(a =>a.Id == id);
            _context.ContactEmail.Remove(query);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
