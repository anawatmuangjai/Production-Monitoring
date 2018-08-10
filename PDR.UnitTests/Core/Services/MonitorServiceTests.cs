using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PDR.Core.Interfaces;
using PDR.Core.Models;
using PDR.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDR.UnitTests.Core.Services
{
    [TestClass]
    public class MonitorServiceTests
    {
        private List<MonitorDetail> _monitorDetails;
        private Mock<IMonitorRepository> _mockRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _monitorDetails = new List<MonitorDetail>
            {
                new MonitorDetail
                {
                    LineName = "A01",
                    StatusId = 1,
                    PlanShot = 999,
                    ActualShot = 999,
                    DefectQty = 999,
                    LossTime = 999,
                    PlanDiff = 999,
                    PlanId = 999,
                    IsUrgent = false,
                    UpdateDate = "2018/01/01",
                    Zone = "A1",
                    Status = new Status()
                }
            };

            _mockRepository = new Mock<IMonitorRepository>();

            _mockRepository.Setup(x => x.GetAllAsync()).ReturnsAsync(_monitorDetails);
        }

        [TestMethod]
        public async Task GetMonitorDetails_WhenCall_ShouldNotNull()
        {
            var monitorService = new MonitorService(_mockRepository.Object);

            var result = await monitorService.GetMonitorDetails();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetMonitorDetails_WhenCall_ShouldHaveOneRecord()
        {
            var monitorService = new MonitorService(_mockRepository.Object);

            var result = await monitorService.GetMonitorDetails();

            Assert.IsTrue(result.Count == 1);
        }
    }
}
