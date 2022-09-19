using Microsoft.AspNetCore.Mvc;

namespace CpmPedidos.Api.Controllers
{
    public class AppBaseController : ControllerBase
    {
        protected readonly IServiceProvider serviceprovider;

        public AppBaseController(IServiceProvider serviceProvider)
        {
            serviceprovider = serviceProvider;
        }
    }
}
