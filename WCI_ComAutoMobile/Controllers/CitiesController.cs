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
    public class CitiesController : Controller
    {
        private readonly ICityHandler _cityHandler;
        public CitiesController(ICityHandler cityHandler)
        {
            _cityHandler = cityHandler;
        }

        [HttpGet]
        public async Task<BaseRetornoApi<CityViewModel>> Get()
        {
            try
            {
                BaseRetornoApi<CityViewModel> retorno = new BaseRetornoApi<CityViewModel>();
                retorno.Data = await _cityHandler.Handler(new CityListCommand());

                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
