using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoCarioca
{
    public class XmlLogin
    {
        [BsonId]
        public string IdLogin { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public XmlLogin()
        {
            IdLogin = Guid.NewGuid().ToString();
        }
    }
}
