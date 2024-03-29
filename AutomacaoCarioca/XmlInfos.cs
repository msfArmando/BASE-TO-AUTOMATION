﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoCarioca
{
    public class XmlInfos
    {
        [BsonId]
        public string IdNota { get; set; }
        public string IdRefClient => new XmlClient().IdClient;
        public string Numero { get; set; }
        public string CodigoVerificacao { get; set; }
        public string DataEmissao { get; set; }
        public string ValorServicos { get; set; }
        public string CpfCnpjPrest { get; set; }
        public string RzPrest { get; set; }
        public string CnpjTom { get; set; }
        public string RzTom { get; set; }
        public XmlInfos(string numero, string codigoverificacao, string dataemissao, string valorservicos, string cpfcnpjprest, string rzprest, string cnpjtom, string rztom)
        {
            IdNota = Guid.NewGuid().ToString();
            Numero = numero;
            CodigoVerificacao = codigoverificacao;
            DataEmissao = dataemissao;
            ValorServicos = valorservicos;
            CpfCnpjPrest = cpfcnpjprest;
            RzPrest = rzprest;
            CnpjTom = cnpjtom;
            RzTom = rztom;
        }
    }
}
