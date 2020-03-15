using System;
using System.Collections.Generic;

namespace Apresentacao.Domains
{
    public partial class Avaliador
    {
        public Avaliador()
        {
            Avaliacao = new HashSet<Avaliacao>();
        }

        public int IdAvaliador { get; set; }
        public int? IdUsuario { get; set; }
        public string NomeAvaliador { get; set; }
        public int? IdFuncao { get; set; }

        public virtual Funcao IdFuncaoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
