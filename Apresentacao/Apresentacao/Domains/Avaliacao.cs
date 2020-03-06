using System;
using System.Collections.Generic;

namespace Apresentacao.Domains
{
    public partial class Avaliacao
    {
        public int? IdAvaliacao { get; set; }
        public int? IdUsuario { get; set; }
        public decimal Nota { get; set; }
        public int? IdAvaliador { get; set; }

        public virtual TipoAvaliacao IdAvaliacaoNavigation { get; set; }
        public virtual Avaliador IdAvaliadorNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
