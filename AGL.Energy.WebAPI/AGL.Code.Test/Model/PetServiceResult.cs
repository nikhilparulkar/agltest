using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGL.Code.Test.Model
{
    public class PetServiceResult
    {
        public List<string> petsWithMaleOwner { get; set; } = new List<string>();
        public List<string> petsWithfemalesOwner { get; set; } = new List<string>();
    }
}
