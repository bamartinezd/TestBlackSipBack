using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestBlackSipBack.Domain.Entities;

namespace TestBlackSip.Domain.Contracts
{
    public interface IGenericCUDRepository<T> where T : class
    {
        public Registro Add(Registro entity);
        Task<T> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
    }
}
