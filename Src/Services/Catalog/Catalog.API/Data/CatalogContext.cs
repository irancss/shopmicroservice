using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {

        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DataBaseSetting:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DataBaseSettings:DataBaseName"));

            GetAllProducts = database.GetCollection<Product>(configuration.GetValue<string>("DataBaseSettings:CollectionName"));
        }

        public IMongoCollection<Product> GetAllProducts { get; }
    }
}
