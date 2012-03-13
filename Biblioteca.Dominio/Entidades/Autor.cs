using System.Collections.Generic;
using Castle.Components.DictionaryAdapter;


namespace Biblioteca.Dominio.Entidades
{
    public class Autor
    {
        public virtual int Id { get; private set; }
        public virtual string Nome { get; set; }
        public virtual IList<Livro> Livros { get; set; }

        public virtual void AdicionarLivros(Livro livro)
        {
            if (Livros == null)
            {
                Livros = new List<Livro>();
            }

            if (livro.Autores == null)
            {
                livro.Autores = new List<Autor>();
            }
            livro.Autores.Add(this);

            Livros.Add(livro);
        }
    }
}
