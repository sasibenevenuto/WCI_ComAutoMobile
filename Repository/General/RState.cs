using Context;
using Microsoft.Extensions.Options;
using Model.Models.General;
using Model.ViewModels.General;
using Repository.General.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.General
{
    public class RState : Repository<State>, IRState
    {
        public RState(SolutionContext context) : base(context)
        {

        }

        public async Task<List<StateViewModel>> GetListStateAsync(State state, string v)
        {
            return (await GetListAsync(new State(), "SELECT * FROM State")).Select(x => (StateViewModel)x).ToList();
        }
    }
}
