using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController: ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
             string rep = string.Empty;
            switch(id)
            {
                case 1:
                    rep = "Canada";
                break;
                case 5:
                    rep = "France";   
                break;
                case 10:
                    rep =  "USA";
                    break;
                default:
                    rep = "Belgique";
                    break;
            }
                return Ok(rep);
        }
        
    }
}