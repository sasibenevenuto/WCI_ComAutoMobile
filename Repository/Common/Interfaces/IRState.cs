using Model.Models.Common;
using Model.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Common.Interfaces
{
    public interface IRState : IRepository<State>
    {
        Task<List<StateViewModel>> GetListStateAsync(State state, string v);
    }
}
