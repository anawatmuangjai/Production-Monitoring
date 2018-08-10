using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PDR.Infrastructure.Context;
using PDR.Infrastructure.Repsoitories;
using System.Threading.Tasks;

namespace PDR.IntegrationTests.Repsoitories
{
    [TestClass]
    public class MonitorRepositoryTests
    {
        private PDRContext _context;
        private MonitorRepository _monitorRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            var option = new DbContextOptionsBuilder<PDRContext>()
                .UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=PROD;Integrated Security=True")
                .Options;

            _context = new PDRContext(option);
            _monitorRepository = new MonitorRepository(_context);
        }

        [TestMethod]
        public async Task GetAll_WhenCall_ShouldNotNull()
        {
            // Act
            var result = await _monitorRepository.GetAllAsync();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetByZone_WhenCall_ShouldNotNull()
        {
            // Arrange
            var zone = "A1";

            // Act
            var result = await _monitorRepository.GetByZoneAsync(zone);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _context.Dispose();
        }
    }
}
