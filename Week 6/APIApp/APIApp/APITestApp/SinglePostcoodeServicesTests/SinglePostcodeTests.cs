
global using NUnit.Framework;
global using System;
global using Newtonsoft.Json.Linq;
global using RestSharp;
global using APIClientApp;



namespace APITestApp
{
    public class SinglePostcodeTests
    {

        SinglePostcodeService _singlePostcodeService;
        [SetUp]
        public async void Setup()
        {
            _singlePostcodeService = new SinglePostcodeService();
            await _singlePostcodeService.MakesRequestAsync("EC2Y 5AS");
        }

        [Test]
        public void StatusIs200_InJSONResponse()
        {
            Assert.That(_singlePostcodeService.ResponseContent["status"].ToString(), Is.EqualTo("200"));
        }
    }
}