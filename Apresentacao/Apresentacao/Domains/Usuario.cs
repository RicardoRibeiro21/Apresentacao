using System;
using System.Collections.Generic;

namespace Apresentacao.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Avaliacao = new HashSet<Avaliacao>();
        }

        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public int IdadeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }

        public virtual ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
