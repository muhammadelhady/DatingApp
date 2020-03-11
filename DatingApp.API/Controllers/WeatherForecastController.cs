using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Values : ControllerBase
    {
        private readonly DataContext _context; 
        public Values(DataContext context)
        {
            _context=context;
        }

     

        [HttpGet]
        public ActionResult GetValues()
        {
           var Values = _context.Values.ToList();
           return Ok(Values);
        }



         [HttpGet("{id}")]
        public ActionResult GetValues(int id)
        {
           var Values = _context.Values.FirstOrDefault(x=>x.Id==id);
           return Ok(Values);
        }
    }
}
