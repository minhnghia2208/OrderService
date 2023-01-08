using Dapr;
using Dapr.Client;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using OrderService.Model;
using System.Text.Json;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // POST api/<OrderController>
        [HttpPost]
        public async Task Post(Order data)
        {
            data.toString();
        }
    }
}
