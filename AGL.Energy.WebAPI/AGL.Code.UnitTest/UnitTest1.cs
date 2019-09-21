using AGL.Code.Test.BusinessServices;
using NUnit.Framework;
using Moq;
using AGL.Code.Test.Model;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        // When a People data has generic People data mix of male and female owners. refer TestData1.json
        public void Test1()
        {
            var jsonText = File.ReadAllText(System.IO.Path.GetFullPath(@"..\..\..\TestData\TestData1.json")); 
            var sponsors = JsonConvert.DeserializeObject<List<People>>(jsonText);
            var mock = new Mock<IPeopleService>();
            mock.Setup( x => x.GetPeopleData()).Returns(Task.FromResult(sponsors));

            var sv = new PetService(mock.Object);
            var result = sv.GetPets().Result;

            var sonresult = File.ReadAllText(System.IO.Path.GetFullPath(@"..\..\..\TestData\ResultTestData1.json"));
            var expectedResult = JsonConvert.DeserializeObject<PetServiceResult>(sonresult);

            Assert.AreEqual(result.petsWithfemalesOwner, expectedResult.petsWithfemalesOwner);
            Assert.AreEqual(result.petsWithMaleOwner, expectedResult.petsWithMaleOwner);
        }

        [Test]
        ////When People Data All pet with owner as Male. TestData2.json
        public void Test2()
        {
            var jsonText = File.ReadAllText(System.IO.Path.GetFullPath(@"..\..\..\TestData\TestData2.json"));
            var sponsors = JsonConvert.DeserializeObject<List<People>>(jsonText);
            var mock = new Mock<IPeopleService>();
            mock.Setup(x => x.GetPeopleData()).Returns(Task.FromResult(sponsors));

            var sv = new PetService(mock.Object);
            var result = sv.GetPets().Result;

            var sonresult = File.ReadAllText(System.IO.Path.GetFullPath(@"..\..\..\TestData\ResultTestData2.json"));
            var expectedResult = JsonConvert.DeserializeObject<PetServiceResult>(sonresult);

            Assert.AreEqual(result.petsWithfemalesOwner, expectedResult.petsWithfemalesOwner);
            Assert.AreEqual(result.petsWithMaleOwner, expectedResult.petsWithMaleOwner);
        }

        [Test]
        //When People Data is NULL refer TestData3.json
        public void Test3()
        {
            var jsonText = File.ReadAllText(System.IO.Path.GetFullPath(@"..\..\..\TestData\TestData3.json"));
            var sponsors = JsonConvert.DeserializeObject<List<People>>(jsonText);
            var mock = new Mock<IPeopleService>();
            mock.Setup(x => x.GetPeopleData()).Returns(Task.FromResult(sponsors));

            var sv = new PetService(mock.Object);
            var result = sv.GetPets().Result;

            var sonresult = File.ReadAllText(System.IO.Path.GetFullPath(@"..\..\..\TestData\ResultTestData3.json"));
            var expectedResult = JsonConvert.DeserializeObject<PetServiceResult>(sonresult);

            Assert.AreEqual(result.petsWithfemalesOwner, expectedResult.petsWithfemalesOwner);
            Assert.AreEqual(result.petsWithMaleOwner, expectedResult.petsWithMaleOwner);
        }
    }
}