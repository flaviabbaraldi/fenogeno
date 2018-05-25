using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Web.Script.Serialization;

namespace Fenogeno.Models
{
    public class Usuario : ICustomPrincipal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Foto { get; set; }
        public bool Administrador { get; set; }

        [ScriptIgnore]
        public IIdentity Identity
        {
            get
            {
                return new GenericIdentity(this.Email, "Usuario");
            }
            set { }
        }

        public bool IsInRole(string role)
        {
            return (role == "Admin");
        }

        public Usuario()
        {

        }

        public Usuario(string myEmail)
        {
            Identity = new GenericIdentity(myEmail, "Usuario");
        }
    }
}
