﻿using Application.Handlers.Common.Interfaces;
using Model.Commands.Common;
using Model.Models.Common;
using Model.ViewModels.Common;
using Repository.Common.Interfaces;
using System;
using System.Collections.Generic;
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
                return await _rState.GetListStateAsync(new State());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
