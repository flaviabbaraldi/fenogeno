using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenogeno.Models
{
   public class Comentario
    {
        public int Id { get; set; }
        public Noticia Noticia{ get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataHora { get; set; }
        public string Texto { get; set; }
    }
}
