using ContactsAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace ContactsAPI.Controllers
{

    [ApiController]
    [Route("")]
    public class ContactsController : Controller
    {

        // creating private property so can talk to db
        private readonly ContactsAPIDbContext dbContext;

        // create a constructer and inject the db cotect
        public ContactsController (ContactsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetContacts()
        {
            return Ok(dbContext.Contacts.ToList());
        }
    }
}
