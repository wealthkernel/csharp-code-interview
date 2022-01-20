using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace WealthKernel.ShoppingCart.IntegrationTests
{
    public class ShoppingCartTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public ShoppingCartTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public void First_Test()
        {
            var client = _factory.CreateClient();

            // e.g.
            // client.PostAsJsonAsync("/some/url", new {})
        }


    }
}
