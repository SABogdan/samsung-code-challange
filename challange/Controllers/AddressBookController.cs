using Microsoft.AspNetCore.Mvc;

namespace challange.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressBookController : ControllerBase
    {
        private static readonly string[] Names = new[]
        {
        "Alex", "Bob", "Charlie", "David", "Eddie", "Fred", "Gordon", "Helen", "Ivan", "James", "Kevin", "Linda", "Michael", "Nancy", "Oscar", "Pat", "Quinn", "Robert", "Sarah", "Tim", "Uma", "Victor", "Wendy", "Xavier", "Yvonne", "Zach"
        };

        private static readonly string[] Addresses = new[]
        {
            "210 Beachcomber Drive", "Pismo Beach", "711 Tashanna Lane", "37600 Sycamore Street"
        };

        private readonly ILogger<AddressBookController> _logger;

        public AddressBookController(ILogger<AddressBookController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<AddressBook> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new AddressBook
            {
                Name = Names[Random.Shared.Next(Names.Length)] + " " + Names[Random.Shared.Next(Names.Length)],
                Address = Addresses[Random.Shared.Next(Addresses.Length)],
            })
            .ToArray();
        }

        //[HttpGet]
        //public IEnumerable<AddressBook> GetAddress()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new AddressBook
        //    {
        //        Name = Names[Random.Shared.Next(Names.Length)] + " " + Names[Random.Shared.Next(Names.Length)],
        //    })
        //    .ToArray();
        //}
    }
}
