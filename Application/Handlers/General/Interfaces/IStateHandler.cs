using Model.Commands.General;
using Model.ViewModels.General;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Handlers.General.Interfaces
{
    public interface IStateHandler
    {
        Task<List<StateViewModel>> Handler(StateListCommand command);
    }
}
