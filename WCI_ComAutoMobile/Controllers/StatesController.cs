using Application.Handlers.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Model.Commands.Common;
using Model.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WCI_ComAutoMobile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly IStateHandler _stateHandler;
        public StatesController(IStateHandler stateHandler)
        {
            _stateHandler = stateHandler;
        }

        [HttpGet]
        public async Task<List<StateViewModel>> Get()
        {
            try
            {
                return await _stateHandler.Handler(new StateListCommand());
            }
            catch (Exception ex)
            {                
                throw ex;
            }
            
        }
    }
}
