using System;

namespace CodingoDojoASPNETCore
{
    public class Cotacao
    {
        public string Sigla { get; set; }
        public string NomeMoeda { get; set; }
        public DateTime UltimaCotacao { get; set; }
        public double Valor { get; set; }
    }
}