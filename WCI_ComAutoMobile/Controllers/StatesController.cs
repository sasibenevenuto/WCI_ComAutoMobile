using Application.Handlers.General.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Model.Commands.General;
using Model.ViewModels.General;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WCI_ComAutoMobile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly IStateHandler _stateHanlder;
        public StatesController(IStateHandler stateHanlder)
        {
            _stateHanlder = stateHanlder;
        }

        [HttpGet]
        public async Task<List<StateViewModel>> Get()
        {
            return await _stateHanlder.Handler(new StateListCommand());
        }
    }
}
