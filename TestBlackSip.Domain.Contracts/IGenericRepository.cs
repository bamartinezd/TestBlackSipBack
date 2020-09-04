using System;
using System.Collections.Generic;
using System.Text;

namespace TestBlackSip.Domain.Contracts
{
    public interface IGenericRepository<T> : IGenericCUDRepository<T>, IGenericGetRepository<T> where T : class { }
}
