using Model.Commands.Common;
using Model.ViewModels.Common;
using Model.ViewModels.General;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Handlers.Common.Interfaces
{
    public interface ICityHandler
    {
        Task<BaseRetornoApi<CityViewModel>> Handler(CityListCommand command);
    }
}
