using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenogeno.Models
{
    public class Especialista
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int CPF { get; set;}

        public int CRM { get; set; }

        public string Email {get; set;}

        public int Telefone { get; set;}

        public string Curso { get; set; }

        public string UniversidadeC { get; set; }

        public int DuracaoC { get; set; }

        public DateTime AnoInicioC { get; set;}

        public DateTime AnoTerminoC { get; set; }

        public string Area { get; set; }

        public string UniversidadeE { get; set; }

        public int DuracaoE { get; set}

        public DateTime AnoInicioE { get; set; }

        public DateTime AnoTerminoE { get; set; }
    }
}
