using Context;
using Model.Models.Common;
using Model.ViewModels.Common;
using Repository.Common.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Common
{
    public class RState : Repository<State>, IRState
    {
        public RState(SolutionContext context) : base(context)
        {

        }

        public async Task<List<StateViewModel>> GetListStateAsync(State state)
        {
            return (await GetListAsync(new State(), "SELECT * FROM GEN_State")).Select(x => (StateViewModel)x).ToList();
        }
    }
}
