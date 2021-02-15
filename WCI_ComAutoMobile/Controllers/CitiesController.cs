using Application.Handlers.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Model.Commands.Common;
using Model.ViewModels.Common;
using Model.ViewModels.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WCI_ComAutoMobile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : Controller
    {
        private readonly ICityHandler _cityHandler;
        public CitiesController(ICityHandler cityHandler)
        {
            _cityHandler = cityHandler;
        }

        [HttpGet]
        public async Task<BaseRetornoApi<CityViewModel>> Get([FromQuery] CityListCommand command)
        {
            try
            {
                return await _cityHandler.Handler(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
