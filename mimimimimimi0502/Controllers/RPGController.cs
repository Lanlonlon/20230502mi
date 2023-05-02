using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mimimimimimi0502.Services;

namespace mimimimimimi0502.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RPGController : ControllerBase
    {

        private RPGService _service;

        public RPGController() //建構方法
        {
            _service = new RPGService();
        }
        
        [HttpGet]
        [Route("{id}")]
        public RPG Get(int id)
        {
            RPG result = null;

            result = _service.Get(id:id);

            return result;
        }
        
        
        
    }
}
