using System;
using System.Collections.Generic;

namespace Apresentacao.Domains
{
    public partial class TipoAvaliacao
    {
        public TipoAvaliacao()
        {
            Avaliacao = new HashSet<Avaliacao>();
        }

        public int IdTipoAvaliacao { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
