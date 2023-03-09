using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoCarioca
{
    public class XmlClient
    {
        [BsonId]
        public string IdClient { get; set; }
        public string IdRefLogin => new XmlLogin().IdLogin;
        public string NameClient { get; set; }
        public string InscricaoClient { get; set; }
        public XmlClient()
        {
            IdClient = Guid.NewGuid().ToString();
        }
    }
}
