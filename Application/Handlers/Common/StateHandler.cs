using Application.Handlers.Common.Interfaces;
using Model.Commands.General;
using Model.Models.Common;
using Model.ViewModels.Common;
using Repository.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Handlers.Common
{
    public class StateHandler : IStateHandler
    {
        private readonly IRState _rState;
        public StateHandler(IRState rState)
        {
            _rState = rState;
        }

        public async Task<List<StateViewModel>> Handler(StateListCommand command)
        {
            try
            {
                return new List<StateViewModel>((await _rState.GetListStateAsync(new State(), "SELECT * FROM State")).Select(x => (StateViewModel)x));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
