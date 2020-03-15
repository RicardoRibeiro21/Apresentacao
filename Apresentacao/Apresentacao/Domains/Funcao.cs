using System;
using System.Collections.Generic;

namespace Apresentacao.Domains
{
    public partial class Funcao
    {
        public Funcao()
        {
            Avaliador = new HashSet<Avaliador>();
        }

        public int IdFuncao { get; set; }
        public string Funcao1 { get; set; }

        public virtual ICollection<Avaliador> Avaliador { get; set; }
    }
}
