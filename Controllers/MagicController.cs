// Jasmine Leek
// 27oct2022
// Magic 8 Ball - Endpoints
// this is a web api that generates a fortune message for the user at random
// peer review: By Kenneth Fujimura -- Eveyrthing works well! The RNG to determine the output works properly and cycles through all possible responses. The little emoji flourish for the text output is really cute. The program is set up to take ana input for the question but doesn't do anything with it (not that it actually needs to) but if you were looking to simplify code, you could just remove that part. Other than that, it's really good! Kudos Jasmine!


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LeekJMagic8BallEP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MagicController : ControllerBase
    {
        string[] text = new string[] { "I don't think so!", "No way, dude.", "It could be so.", "Ask again later.", "Definitely!", "Who knows?", "Maybe?", "In due time!", "Certainly.", "In your dreams!", "Are you sure?" };
        int index = 0;
        Random rand = new Random();

        [HttpGet]
        [Route("fortune/{originalInput}")]

        public string EightBall(string originalInput)
        {

            index = rand.Next(text.Length);
            string message = text[index];
            return $"🔮 {message} 🔮";

        }
    }
}
