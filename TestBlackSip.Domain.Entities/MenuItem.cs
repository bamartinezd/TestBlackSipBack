using System;
using System.Collections.Generic;

namespace TestBlackSipBack.Domain.Entities
{
    public partial class MenuItem
    {
        public MenuItem()
        {
            InverseIdMenuItemPadre = new HashSet<MenuItem>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Uri { get; set; }
        public int? IdmenuItemPadre { get; set; }

        public virtual MenuItem MenuItemPadre { get; set; }
        public virtual ICollection<MenuItem> InverseIdMenuItemPadre { get; set; }
    }
}
