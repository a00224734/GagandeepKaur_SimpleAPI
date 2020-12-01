using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GagandeepKaur_A00224734_SimpleAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        Random random = new Random();
        [HttpGet]
        public int Get()
        {
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            return shift;
        }

        [HttpPost]
        public double Post()
        {
            double flt = random.NextDouble();
            return flt;
        }

        [HttpPut]
        public String Put()
        {
            return "Thank you for the new number!";
        }

        [HttpDelete]
        public String Delete()
        {
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            char letter = Convert.ToChar(shift + 65);
            return letter.ToString();
        }

        [HttpPatch]
        public String Patch()
        {
            DateTime date = DateTime.Now;
            return date.ToString();
        }

        [HttpOptions]
        public String Options()
        {
            var option = "GET: Return a Random Integer.\n" + "POST: Return a Random Double.\n" + "PUT: Return a String.\n" + "DELETE: Return a Random Character.\n" + "PATCH: Gives the Current Date.\n" + "OPTIONS: Return Some Text About What Each Method Returned.";
            return option;
        }
    }
}