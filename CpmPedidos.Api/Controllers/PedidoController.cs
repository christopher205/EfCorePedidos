using Microsoft.AspNetCore.Mvc;

namespace CpmPedidos.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : AppBaseController
    {

        public PedidoController(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }


    }
}