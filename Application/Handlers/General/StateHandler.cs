using Application.Commands.General;
using Application.Handlers.General.Interfaces;
using Model.Models.General;
using Model.ViewModels.General;
using Repository.General.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers.General
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
                return new List<StateViewModel>((await _rState.GetListAsync(new State(), "SELECT * FROM State")).Select(x => (StateViewModel)x));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
