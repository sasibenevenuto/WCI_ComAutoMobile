using Model.Models.Common;
using Model.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Common.Interfaces
{
    public interface IRCity : IRepository<City>
    {
        Task<List<CityViewModel>> GetListCityAsync(City city);
    }
}
