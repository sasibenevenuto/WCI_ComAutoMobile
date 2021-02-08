using Model.Models.General;
using Model.ViewModels.General;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.General.Interfaces
{
    public interface IRState : IRepository<State>
    {
        Task<List<StateViewModel>> GetListStateAsync(State state, string v);
    }
}
