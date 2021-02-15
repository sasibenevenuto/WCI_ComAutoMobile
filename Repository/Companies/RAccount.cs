using Context;
using Model.Models.Companies;
using Repository.Common;
using Repository.Companies.Interfaces;

namespace Repository.Companies
{
    public class RAccount : Repository<Account>, IRAccount
    {
        public RAccount(SolutionContext context) : base(context)
        {
            
        }
    }
}
