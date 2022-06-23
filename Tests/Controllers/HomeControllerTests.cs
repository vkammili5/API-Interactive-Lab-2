﻿using API_Interactive_Lab_2.Controllers;
using NUnit.Framework;
namespace API_Interactive_Lab_2.Tests
{
        public class HomeControllerTests
        {
            [Test]
            public void TestGetHome()
            {
                string expectedContent = "Welcome to the Drinks API!";
                var controller = new HomeController();
                var result = controller.Get();
                Assert.AreEqual(expectedContent, result);
            }
        }
}

