using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AGL.Code.Test.Model;
using System.Net;
using Microsoft.AspNetCore.Http;
using AGL.Code.Test.BusinessServices;

namespace AGL.Code.Test.Controllers
{
    
    [ApiController]
    public class PetController : ControllerBase
    {

        private readonly IPetService _petSvc;

        public PetController(IPetService petSvc)
        {
            this._petSvc = petSvc;
        }
        // GET api/values
        [HttpGet]
        [Route("pets")]
        public async Task<PetServiceResult> Get()
        {
            return  await _petSvc.GetPets();
        }
    }

        
}
