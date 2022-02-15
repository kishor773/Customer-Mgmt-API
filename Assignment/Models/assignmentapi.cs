using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment.Models
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class assignmentapi : ControllerBase
    {
        // GET: api/<assignmentapi>
       /* [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/
        [HttpGet]
        public string viewcus()
        {
            DBHandle db = new DBHandle();
            return db.viewcustomer();
        }

        // GET api/<assignmentapi>/5
       /* [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/<assignmentapi>
        [HttpPost]
        [Route("register")]
        public void Post(Customer c)
        {
            DBHandle db = new DBHandle();
            db.addcustomer(c);
            return;

        }

        // PUT api/<assignmentapi>/5
        [HttpPut]
        public void Put(Customer c)
        {
            DBHandle db = new DBHandle();
            db.updatecustomer(c);
            return;
        }

        // DELETE api/<assignmentapi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DBHandle db = new DBHandle();
            db.deletecus(id);
            return;
        }
        [HttpGet]
        [Route("getrecord")]
        public Customer Get(int CustomerId)
        {
            DBHandle db = new DBHandle();
            Customer cus = db.getcusonID(CustomerId);
            return cus;
        }


    }
}
