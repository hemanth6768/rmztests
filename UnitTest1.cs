using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using RMZ.Controllers;
using RMZ.Servicelayer;
using Xunit;

namespace RMZtest
{
    public class rmztests
    {
        private readonly Iinformation _service;
        private readonly RMZ1Controller _rmz1controller;
        public rmztests()
        {
            _service= A.Fake<Iinformation>(); 
            //sut 
            _rmz1controller = new RMZ1Controller(_service);
        }
        [Fact]
        public void rmzcontroller_getbuilding_returnsok()
        {
            //arrange
            string facility = "marthalli";
            string data = "saikrupa";
            string zoneid = "s201";
            var o = new
            {
                facilityname = "marthalli",
                buildingname = "saikrupa",
                zoneid = "s201",
                floornumber = "2",
                electricmeter = 234.5,
                watermeter = 234.6
            };
            
            A.CallTo(() => _service.getbuilding(A<string>.Ignored,A<string>.Ignored)).Returns(o);
     
            //Act 
            var result = _rmz1controller.gethh(facility,data,zoneid);

            //assert
            result.Should().NotBeNull();

            result.Should().BeOfType(typeof(OkObjectResult));

        }

        [Fact]
        public void rmzcontroller_getfacility_returnsok()
        {

            string facility = "marthalli";
            string data = "saikrupa";
            string zoneid = "s201";
            var o = new
            {
                facilityname = "marthalli",
                buildingname = "saikrupa",
                zoneid = "s201",
                floornumber = "2",
                electricmeter = 234.5,
                watermeter = 234.6
            };
            
            A.CallTo(() => _service.getfacility(A<string>.Ignored, A<string>.Ignored)).Returns(o);

            //Act 
            var result = _rmz1controller.gethh(facility, data, zoneid);

            //assert
            result.Should().NotBeNull();

            result.Should().BeOfType(typeof(OkObjectResult));

        }
        [Fact]
        public void rmzcontroller_getzone_returnsok()
        {
            string facility = "marthalli";
            string data = "saikrupa";
            string zoneid = "s201";
            var o = new
            {
                facilityname = "marthalli",
                buildingname = "saikrupa",
                zoneid = "s201",
                floornumber = "2",
                electricmeter = 234.5,
                watermeter = 234.6
            };

            //A.CallTo(() => _context.facility.FirstOrDefault(x => x.Facilityname==data)).Returns(typeof(Facility));
            A.CallTo(() => _service.getzone(A<string>.Ignored, A<string>.Ignored,A<string>.Ignored)).Returns(o);

            //Act 
            var result = _rmz1controller.gethh(facility, data, zoneid);

            //assert
            result.Should().NotBeNull();

            result.Should().BeOfType(typeof(OkObjectResult));

        }

    }
}
