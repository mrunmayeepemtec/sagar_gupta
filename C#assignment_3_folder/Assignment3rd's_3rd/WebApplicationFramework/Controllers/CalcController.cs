using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CalculatorStandard2;


namespace WebApplicationFramework.Controllers
{
    public class CalcController : ApiController
    {
        [HttpGet]
        [Route("api/calc/add")]
        public int add(int num1, int num2)
        {
            return new Calc().add(4, 5);
            
        }
    }
}
