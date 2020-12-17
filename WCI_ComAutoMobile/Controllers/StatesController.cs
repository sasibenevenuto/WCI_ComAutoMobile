using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.General;
using Application.Handlers.General;
using Application.Handlers.General.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Models.General;
using Model.ViewModels.General;

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
