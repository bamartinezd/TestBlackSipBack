using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBlackSip.Domain.Contracts;
using TestBlackSipBack.Domain.Entities;

namespace TestBlackSipBack.Data.DataAccess.Repositories
{
    public class MenuItemRepository : IGenericGetRepository<MenuItem>
    {
        #region Attributes
        private readonly TestBlackSip_AlejandroMartinezContext _context;
        private DbSet<MenuItem> _dbSet;
        #endregion

        #region Constructor
        public MenuItemRepository(TestBlackSip_AlejandroMartinezContext context)
        {
            this._context = context;
            this._dbSet = _context.Set<MenuItem>();
        }
        #endregion

        #region Public methods
        public async Task<IEnumerable<MenuItem>> GetAllAsync()
        {
            //var a = await _dbSet.ToListAsync();
            //var a = await _dbSet.Where(x => x.IdmenuItemPadre == 0).ToListAsync();
            var a = _context.Database.ExecuteSqlRawAsync($"spGetMenuItems");

            a = a;
            return null;
        }

        public async Task<MenuItem> GetByIdAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(item => item.Id == id);
        }

        #endregion
    }
}
