using Elsa.Activities.Signaling.Services;
using Elsa.Models;
using ElsaTest.Workflows;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Elsa.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly ISignaler _signaler;

        public  ValuesController(ISignaler signaler)
        {
            _signaler = signaler;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<string>> GetAsync()
        {
            var extractionObjectDetail = new ExtractionObjectModel
            {
                ServerName = "ftp://testserver.com",
                PortNumber = 22,
                RemotePath = "Test",
                TargetLocation = "Target",
                DirectoryName = "Directory",
                UserName = "Sachin",
                Password = "password"
            };

            var input = new Variables();
            input.Set("ExtractionObjectModel", extractionObjectDetail);

            await _signaler.TriggerSignalAsync("TriggerProcess");
            return new string[] { "value1", "value2" };
        }

      
    }
}
