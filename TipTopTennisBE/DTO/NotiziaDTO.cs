using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.DTO
{
    public class NotiziaDTO
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Contenuto { get; set; }
        public DateTime Data { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsVisible { get; set; }
        public bool Espandi { get; set; }
    }
}
