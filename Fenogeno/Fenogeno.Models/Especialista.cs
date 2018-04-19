using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenogeno.Models
{
    public class Especialista
    {
        public string CRM { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Curso_f { get; set; }

        public string Universidade_c { get; set; }

        public string Duracao_c { get; set; }

        public DateTime Ano_inicio_c { get; set; }

        public DateTime Ano_termino_c { get; set; }

        public string Area_e { get; set; }

        public string Universidade_e { get; set; }

        public string Duracao_e { get; set; }

        public DateTime Ano_inicio_e { get; set; }

        public DateTime Ano_termino_e { get; set; }

        public string Foto { get; set; }

    }
}
