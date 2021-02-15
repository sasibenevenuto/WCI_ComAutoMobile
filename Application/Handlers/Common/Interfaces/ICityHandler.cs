using Model.Commands.Common;
using Model.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Handlers.Common.Interfaces
{
    public interface ICityHandler
    {
        Task<List<CityViewModel>> Handler(CityListCommand command);
    }
}
