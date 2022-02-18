using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentGames.Repository
{
    public class StockRepository
    {
        public string ConnectionString = Environment.GetEnvironmentVariable("");
        public IMongoDatabase _database;
        public StockRepository()
        {
            var client = new MongoClient(ConnectionString);
            _database = client.GetDatabase("StockRepository");

        }

        public async Task<List<RentGamesStockData>> GetStock(bool all)
        {

            var collection = _database.GetCollection<RentGamesStockData>("StockData");
            if (all)
            {
                var get =await  collection.FindAsync(_ => true);
                return get.ToList();
            }
            else
            {
                var get =await  collection.FindAsync(c => c.IsInStock == true);
                return get.ToList();
            }
        }
    }
}
