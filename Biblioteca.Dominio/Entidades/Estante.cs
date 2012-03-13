using System.Collections.Generic;

namespace Biblioteca.Dominio.Entidades
{
    public class Estante
    {
        public virtual int Id { get; private set; }
        public virtual string Categoria { get; set; }
        public virtual IList<Prateleira> Prateleiras { get; set; }

        public virtual void AdicionarPrateleira(Prateleira prateleira)
        {
            if (Prateleiras == null)
            {
                Prateleiras = new List<Prateleira>();
            }
            prateleira.Estante = this;
            Prateleiras.Add(prateleira);
        }
    }
}
