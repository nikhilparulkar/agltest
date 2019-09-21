using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AGL.Code.Test.Model
{
    public enum gender
     
    {
        [Description("Male")]
        male =0,

        [Description("Female")]
        female = 0,

    };

    public class PeopleList
    {
        public List<People> list { get; set; }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    public class Pet
    {
        public string name { get; set; }
        public string type { get; set; }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    public class People
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public List<Pet> pets  { get; set; }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
