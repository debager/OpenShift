using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayHistory.Models;

namespace PayHistory.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class PayHistoryController : ControllerBase
    {
      

       


        [HttpPost]
        [Produces("application/json")]
        public  PayResponse PostPayRequest([FromBody] PayRequest payRequest)
        {
            PayResponse payResponse = new PayResponse();


            return payResponse;

        }




    }
}
