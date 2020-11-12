using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace MyBackendService001.Contracts
{
    public interface IMyBackendService001Controller001
    {
        [Post("/GetSomeData")]
        Task<SomeOutputParameter> GetSomeData([FromBody] SomeInputParameter inputParameter);
    }
}
