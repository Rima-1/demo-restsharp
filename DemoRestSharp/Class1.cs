using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DemoRestSharp
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void getListOfUsers()
        {
            var client = new RestClient("https://reqres.in/api");
            IRestRequest request = new RestRequest("users?page=2", Method.GET);
            var response = client.Execute(request);
            Console.WriteLine("Status Code : " + (int)response.StatusCode + " " + response.StatusCode.ToString());
            //To check if the status code is 200
            //Assert.AreEqual(200, (int)response.StatusCode, "Status Code is 200");
            //The following line makes the test negative
            //Assert.AreEqual(400, (int)response.StatusCode, "Actual Status Code received from response is 200");
        }

        [Test]
        public void getSingleUser()
        {
            var client = new RestClient("https://reqres.in/api");
            IRestRequest request = new RestRequest("users/2", Method.GET);
            var response = client.Execute(request);
            Console.WriteLine("Status Code : " + (int)response.StatusCode + " " + response.StatusCode.ToString());
        }

        [Test]
        public void singleUserNotFound()
        {
            var client = new RestClient("https://reqres.in/api");
            IRestRequest request = new RestRequest("users/23", Method.GET);
            var response = client.Execute(request);
            Console.WriteLine("Status Code : " + (int)response.StatusCode + " " + response.StatusCode.ToString());
        }

        [Test]
        public void getListOfResource()
        {
            var client = new RestClient("https://reqres.in/api");
            IRestRequest request = new RestRequest("unknown", Method.GET);
            var response = client.Execute(request);
            Console.WriteLine("Status Code : " + (int)response.StatusCode + " " + response.StatusCode.ToString());
        }

        [Test]
        public void getSingleResource()
        {
            var client = new RestClient("https://reqres.in/api");
            IRestRequest request = new RestRequest("unknown/2", Method.GET);
            var response = client.Execute(request);
            Console.WriteLine("Status Code : " + (int)response.StatusCode + " " + response.StatusCode.ToString());
        }

        [Test]
        public void singleResourceNotFound()
        {
            var client = new RestClient("https://reqres.in/api");
            IRestRequest request = new RestRequest("unknown/23", Method.GET);
            var response = client.Execute(request);
            Console.WriteLine("Status Code : " + (int)response.StatusCode + " " + response.StatusCode.ToString());
        }
    }
}
