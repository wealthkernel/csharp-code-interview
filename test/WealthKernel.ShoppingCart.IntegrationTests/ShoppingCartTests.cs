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
    }
}
