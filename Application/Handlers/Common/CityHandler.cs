using Application.Handlers.Common.Interfaces;
using Model.Commands.Common;
using Model.Models.Common;
using Model.ViewModels.Common;
using Model.ViewModels.General;
using Repository.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Handlers.Common
{
    public class CityHandler : ICityHandler
    {
        private readonly IRCity _rCity;
        public CityHandler(IRCity rCity)
        {
            _rCity = rCity;
        }

        public async Task<BaseRetornoApi<CityViewModel>> Handler(CityListCommand command)
        {
            try
            {
                return await _rCity.GetListCityAsync(command.EstadoId, command.Cidade, command.PageNumber, command.RowspPage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
