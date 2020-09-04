using System;
using System.Collections.Generic;

namespace TestBlackSipBack.Services.Dto
{
    public partial class MenuItemDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Uri { get; set; }
        public int? IdmenuItemPadre { get; set; }

        public virtual MenuItemDTO MenuItemPadre { get; set; }
    }
}
