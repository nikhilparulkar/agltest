using AGL.Code.Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGL.Code.Test.BusinessServices
{
    public interface IPeopleService
    {
        Task <List<People>> GetPeopleData();
    }
}
