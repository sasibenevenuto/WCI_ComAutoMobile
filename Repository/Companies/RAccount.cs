using Microsoft.Extensions.Options;
using Model.Models.Companies;
using Model.Models.General;
using Repository.Companies.Interfaces;
using Repository.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Companies
{
    public class RAccount : Repository<Account>, IRAccount
    {
        public RAccount(IOptions<Settings> options)
        {
            _settings = options.Value;
        }
    }
}
