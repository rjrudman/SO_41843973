using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace _41843973.Controllers
{
	[Route("api/[controller]")]
    public class UserController : Controller
    {
        // GET: api/values
        [HttpGet(nameof(ContactsPreview))]
        public IEnumerable<string> ContactsPreview()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
