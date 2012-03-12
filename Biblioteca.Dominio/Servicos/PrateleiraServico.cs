using System;
using System.Collections.Generic;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;

namespace Biblioteca.Dominio.Servicos
{
    public class PrateleiraServico : IPrateleiraRepositorio
    {
        private readonly IPrateleiraRepositorio _prateleiraDAO;

        public PrateleiraServico(IPrateleiraRepositorio prateleiraDAO)
        {
            _prateleiraDAO = prateleiraDAO;
        }

        public IList<Prateleira> PesquisarTodos()
        {
            return _prateleiraDAO.GetAll();
        }

        public Prateleira Pesquisar(int id)
        {
            return _prateleiraDAO.Get(id);
        }

        public void Save(Prateleira entity)
        {
            throw new NotImplementedException();
        }

        public Prateleira Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Prateleira> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Prateleira entity)
        {
            throw new NotImplementedException();
        }
    }
}