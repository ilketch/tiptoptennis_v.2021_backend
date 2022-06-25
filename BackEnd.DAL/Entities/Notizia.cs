using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAL.Entities
{
    public class Notizia
    {
        public int NotiziaId { get; set; }
        public string Titolo { get; set; }
        public string Contenuto { get; set; }
        public DateTime Data { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsVisible { get; set; }
    }
}
