using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Test
{
    public class WeatherForeCastTest
    {
       
       CountryController controller = new CountryController();
        //  controller = new WeatherForeCastController();

        [Fact]
        public void GetCountryNameFrance()
        {
           var okResult = controller.Get(6) as OkObjectResult;
           var country = okResult.Value;
            Assert.Equal("France", country);
        }
        
        [Fact]
        public void Test1()
        {

        }
    }
}
