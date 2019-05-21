using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace POC.Model
{
    public interface IPOCContext
    {
        IMongoCollection<POC> POCs { get;
            set;
        }
    }
}
