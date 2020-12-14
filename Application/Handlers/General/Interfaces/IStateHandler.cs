using Application.Commands.General;
using Model.ViewModels.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers.General.Interfaces
{
    public interface IStateHandler
    {
        Task<List<StateViewModel>> Handler(StateListCommand command);
    }
}
