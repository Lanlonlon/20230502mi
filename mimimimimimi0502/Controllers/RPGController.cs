using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mimimimimimi0502.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RPGController : ControllerBase
    {

        [HttpGet]
        public RPG Get()
        {
            RPG result = null;

            result = new RPG() { id = 0, name = "mi", lv = 999 };

            return result;
        }
        
        
        
    }
}
