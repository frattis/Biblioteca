using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Dominio.Entidades
{
    public class Estante
    {
        public virtual int Id { get; private set; }
        public virtual IList<Prateleira> Prateleira { get; set; }

        public virtual void AdicionarPrateleira(Prateleira prateleira)
        {
            if (Prateleira == null)
            {
                Prateleira = new List<Prateleira>();
            }
            prateleira.Estante = this;
            Prateleira.Add(prateleira);
        }
    }
}
