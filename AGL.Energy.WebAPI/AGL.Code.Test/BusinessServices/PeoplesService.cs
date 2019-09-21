using AGL.Code.Test.Model;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AGL.Code.Test.BusinessServices
{
    public class PeopleService :IPeopleService
    {

        private readonly IOptions<Myconfig> config;

        public PeopleService(IOptions<Myconfig> config)
        {
            this.config = config;
        }

        // all execeptions are handled in gloabal exception handler : ExceptionMiddleware
        public async Task <List<People>> GetPeopleData()
        {
            List<People> temp;
            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync(config.Value.PeopleURL);
                temp = JsonConvert.DeserializeObject<List<People>>(content);
            }
            return temp; ;
        }
    }
}
