using Data.Repositories;
using Domain.Repositories;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Configuration;
using Xunit;

namespace Test
{
    class ProductRepositoryTest
    {
        private readonly IProductRepository _productRepo; 
        public ProductRepositoryTest()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connection = new MySqlConnection(config.GetConnectionString("bestbuy_empty"));
            _productRepo = new ProductRepository(connection);
        }


    }
}
