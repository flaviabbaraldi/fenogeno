using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fenogeno.Models
{
    public class Noticia
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Subtitulo { get; set; }

        public string Texto { get; set; }

        public DateTime DataHora { get; set; }

        public Usuario Usuario { get; set; }
    }
}
