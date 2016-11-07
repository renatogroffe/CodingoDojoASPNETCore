using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CodingoDojoASPNETCore.Data;

namespace CodingoDojoASPNETCore.Controllers
{
    [Route("api/[controller]")]
    public class CotacoesController : Controller
    {
        [HttpGet("{id}")]
        public Cotacao Get(
                    [FromServices]CotacoesContext context,
                    string id)
        {
            return context.Cotacoes
                .Where(c => c.Sigla == id)
                .FirstOrDefault();
        }
    }
}