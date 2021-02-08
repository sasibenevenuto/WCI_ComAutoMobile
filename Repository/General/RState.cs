using Context;
using Microsoft.Extensions.Options;
using Model.Models.General;
using Repository.General.Interfaces;

namespace Repository.General
{
    public class RState : Repository<State>, IRState
    {
        public RState(SolutionContext context) : base(context)
        {

        }
    }
}
