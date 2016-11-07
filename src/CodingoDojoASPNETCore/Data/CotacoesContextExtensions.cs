using System;

namespace CodingoDojoASPNETCore.Data
{
    public static class CotacoesContextExtensions
    {
        public static void InitializeData(this CotacoesContext context)
        {
            context.Cotacoes.Add(
                new Cotacao()
                {
                    Sigla = "USD",
                    NomeMoeda = "Dólar norte-americano",
                    UltimaCotacao = Convert.ToDateTime("2016-11-04 17:00"),
                    Valor = 3.2311
                });

            context.Cotacoes.Add(
                new Cotacao()
                {
                    Sigla = "EUR",
                    NomeMoeda = "Euro",
                    UltimaCotacao = Convert.ToDateTime("2016-11-04 17:00"),
                    Valor = 3.6066
                });

            context.Cotacoes.Add(
                new Cotacao()
                {
                    Sigla = "LIB",
                    NomeMoeda = "Libra esterlina",
                    UltimaCotacao = Convert.ToDateTime("2016-11-04 17:00"),
                    Valor = 4.0493
                });

            context.SaveChanges();
        }
    }
}