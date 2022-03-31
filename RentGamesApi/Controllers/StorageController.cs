using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentGamesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StorageController : ControllerBase
    {

        public StorageController()
        {

        }
       

        [HttpGet]
        public int GetAll([FromRoute] bool? all)
        {
            //TokenAuth0

            //CallTheService

            return 1;
        }

    }
}
