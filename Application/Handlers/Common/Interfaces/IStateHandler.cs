using Model.Commands.General;
using Model.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Handlers.Common.Interfaces
{
    public interface IStateHandler
    {
        Task<List<StateViewModel>> Handler(StateListCommand command);
    }
}
