using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TestBlackSip.Domain.Contracts;
using TestBlackSipBack.Domain.Entities;
using Microsoft.Data.SqlClient;

namespace TestBlackSipBack.Data.DataAccess.Repositories
{
    public class RegistroRepository : IGenericCUDRepository<Registro>
    {

        #region Attributes
        private readonly TestBlackSip_AlejandroMartinezContext _context;
        #endregion

        #region Constructor
        public RegistroRepository(TestBlackSip_AlejandroMartinezContext context) {
            this._context = context;
        }
        #endregion

        #region Public methods
        public Registro Add(Registro entity)
        {
            try
            {
                return _context.Database.ExecuteSqlInterpolated($"insRegistro {entity.Id}, {entity.Nombre}, {entity.Email}, {entity.Telefono}") > 0 ? entity : new Registro();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Registro entity)
        {
            throw new NotImplementedException();
        }

        public Task<Registro> AddAsync(Registro entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
