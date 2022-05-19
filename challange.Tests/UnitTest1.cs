using challange.Controllers;
using Microsoft.Extensions.Logging;
using Xunit;

namespace challange.Tests
{
    public class AddressBookChallangeTests
    {
        private readonly ILogger<AddressBookController> _logger;
        
        public AddressBookChallangeTests()
        {
            _logger = new Logger<AddressBookController>(new LoggerFactory());
        }

        [Fact]
        public void Test1()
        {
            //test ze api
            var controller = new AddressBookController(_logger);
            var result = controller.Get();
            Assert.NotNull(result);
        }
    }
}