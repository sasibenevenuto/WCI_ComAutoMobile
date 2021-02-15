using Model.Models.Common;
using Model.ViewModels.Common;
using Model.ViewModels.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Common.Interfaces
{
    public interface IRCity : IRepository<City>
    {
        Task<BaseRetornoApi<CityViewModel>> GetListCityAsync(int? estadoId, string cidade, int? pageNumber, int? rowspPage);
    }
}
