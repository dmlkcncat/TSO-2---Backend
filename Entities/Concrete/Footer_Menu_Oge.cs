using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Footer_Menu_Oge : IEntity
    {
        public int Id { get; set; }
        public int Footer_Menu_Baslik_id { get; set; }
        public string Ad { get; set; }
        public int Sayfa_id { get; set; }
    }
}
