using System.Collections.Generic;
using Castle.Components.DictionaryAdapter;

namespace Biblioteca.Dominio.Entidades
{
    public class Livro
    {
        public virtual int Id { get; private set; }
        public virtual string Titulo { get; set; }
        public virtual IList<Autor> Autores { get; set; }
        public virtual Prateleira Prateleira { get; set; }

    }
}
