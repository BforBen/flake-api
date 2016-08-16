using System;
using Flake.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http.Results;

namespace Flake.Tests
{
    [TestClass]
    public class GenTest
    {
        [TestMethod]
        public void GetId()
        {
            var controller = new IdController();

            var Tests = controller.GetId() as OkNegotiatedContentResult<string>;

            Assert.IsNotNull(Tests.Content);
        }
    }
}
