using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Dominio.Entidades
{
    public class Prateleira
    {
        public virtual int Id { get; private set; }
        public virtual Estante Estante { get; set; }
        public virtual IList<Livro> Livros { get; set; }

        public virtual void AdicionarLivros(Livro livro)
        {
            if (Livros == null)
            {
                Livros = new List<Livro>();
            }
            livro.Prateleira = this;
            Livros.Add(livro);
        }
    }
}
