using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Dominio.Entidades
{
    public class Livro
    {
        public virtual int Id { get; private set; }
        public virtual string Titulo { get; set; }
        public virtual Autor Autor { get; set; }
        public virtual Prateleira Prateleira { get; set; }
    }
}
