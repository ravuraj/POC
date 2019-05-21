using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace POC.Model
{
    public class POCContext: IPOCContext
    {
        private readonly IMongoDatabase db;
        public POCContext(IOptions<Settings> options, IMongoClient client)
        {
            db = client.GetDatabase(options.Value.Database);
        }
        public IMongoCollection<POC> POCs => db.GetCollection<POC>("POCs");

      //  IMongoCollection<POC>POCs => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
