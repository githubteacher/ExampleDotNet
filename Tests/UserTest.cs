using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class UserTest
    {
        [Fact]
        public void NameTest()
        {
            User user = new User()
            {
                Name = "Brent Beer"
            };
            Assert.Equal("Brent Beer", user.Name);
        }
    }
}
