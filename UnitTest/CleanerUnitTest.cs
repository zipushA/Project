using Microsoft.AspNetCore.Mvc;
using Project.Controllers;
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class CleanerUnitTest
    {
        [Fact]
        public void GetAll_ReturnListCleaners()
        {
            var controller = new CleanerController();
            var res = controller.Get();
            Assert.IsType<List<Cleaner>>(res);
        }
        [Fact]
        public void GetById_ReturnIsOk()
        {
            var id = 0;
            var controller = new CleanerController();
            var result = controller.Get(id);
            Assert.IsType<OkResult>(result);

        }
        [Fact]
        public void GetById_returnsNotFound()
        {
            int id = 5;
            var controller = new CleanerController();
            var result = controller.Get(id);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
