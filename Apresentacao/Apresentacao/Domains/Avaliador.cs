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
        public string NomeAvaliador { get; set; }
        public string Funcao { get; set; }

        public virtual ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
