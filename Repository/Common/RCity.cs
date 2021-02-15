using Context;
using Model.Models.Common;
using Model.ViewModels.Common;
using Repository.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Common
{
    public class RCity : Repository<City>, IRCity
    {
        public RCity(SolutionContext context) : base(context)
        {

        }

        public async Task<List<CityViewModel>> GetListCityAsync(City city)
        {
            return (await GetListAsync(new City(), "SELECT * FROM GEN_City")).Select(x => (CityViewModel)x).ToList();
        }
    }
}
