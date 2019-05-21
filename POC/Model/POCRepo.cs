using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Collections.Generic;
namespace POC.Model
{
    public class POCRepo:IPOCRepo

    {
        private readonly IPOCContext context1;
        
        public POCRepo(IPOCContext context)
        {
            context1 = context;
        }

        public async Task<IEnumerable<POC>> GetALL()
        {
            return await context1.POCs.Find(_ => true).ToListAsync();
            
        }
        public Task<POC> GetName(string name)
        {
            FilterDefinition<POC> filter = Builders<POC>.Filter.Eq(m => m.Name, name);
            return context1.POCs.Find(filter).FirstOrDefaultAsync();
        }

        public async Task Create(POC poc)
        {
            await context1.POCs.InsertOneAsync(poc);

        }

        public async Task<bool> Update(POC poc)
        {
            ReplaceOneResult updated = await context1.POCs.ReplaceOneAsync(filter
                : g => g.Id == poc.Id,
                replacement: poc);
            return updated.IsAcknowledged && updated.ModifiedCount > 0;

        }

        Task<POC> IPOCRepo.GetALL()
        {
            throw new NotImplementedException();
        }
    }
}
