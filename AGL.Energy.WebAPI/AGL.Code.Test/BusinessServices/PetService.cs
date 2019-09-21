using AGL.Code.Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AGL.Code.Test.BusinessServices
{
    public class PetService : IPetService
    {
        private readonly IPeopleService svc;

        public PetService(IPeopleService pplsvc)
        {
            this.svc = pplsvc;
        }

        // all execeptions are handled in gloabal exception handler : ExceptionMiddleware
        public async Task<PetServiceResult> GetPets()
        {
            var peopleList = await svc.GetPeopleData();

            var result = new PetServiceResult();

            //var peopleList = JsonConvert.DeserializeObject<List<People>>(peopleData);
            foreach (var people in peopleList)
            {
                if (people.gender.ToLower() == "male" && people.pets !=null)
                {
                    result.petsWithMaleOwner.AddRange(people.pets.Where(y => y.type.ToLower() == "cat").Select(x => x.name).ToList());
                }
                else if (people.gender.ToLower() == "female" && people.pets != null)
                {
                    result.petsWithfemalesOwner.AddRange(people.pets.Where(y => y.type.ToLower() == "cat").Select(x => x.name).ToList());
                }
                else
                {
                    // error
                }
            }
            return  result;
        }


    }
}
