using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tec.CloudApp.Api.Controllers
{
    using Tec.CloudApp.Commons.Contracts.Business;

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UserController> _logger;

        /// <summary>
        /// The user business.
        /// </summary>
        private readonly IUserBusiness userBusiness;
        public UserController(ILogger<UserController> logger, IUserBusiness userBusiness)
        {
            _logger = logger;
            this.userBusiness = userBusiness;
        }

        [HttpGet]
        [Route("GetUsers")]
        public IActionResult Get()
        {

           return this.Ok(this.userBusiness.GetUsers());
        }

        [HttpPost]
        [Route("Insert")]
        public IActionResult Insert()
        {

            return this.Ok("Registro insertado correctamente");
        }
        
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            return this.Ok("Registro insertado correctamente");
        }
    }
}
