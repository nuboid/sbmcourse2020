using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using MyBackendService001.Contracts;

namespace MyBackendService001.Controllers
{
    [Authorize]
    public class Controller001 : IMyBackendService001Controller001
    {
        public async Task<SomeOutputParameter> GetSomeData(SomeInputParameter inputParameter)
        {
            return new SomeOutputParameter();
        }
    }
}
