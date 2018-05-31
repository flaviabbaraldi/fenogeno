using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenogeno.Models
{
    public class Duvida
    {
        public int Id { get; set; }
        public Especialista Especialista { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataHora { get; set; }
        public string Texto { get; set; }
    }
}
