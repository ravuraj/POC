using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace POC.Model
{
    public class POC
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Topics { get; set; }
        public string Query { get; set; }
    }
}
