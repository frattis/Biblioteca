using Biblioteca.Dominio.Servicos;

namespace Biblioteca.WebApplication.Controllers
{
    public class Administrador
    {
        private AutorServico _autorServico;
        private EstanteServico _estanteServico;
        private LivroServico _livroServico;
        private PrateleiraServico _prateleira;

        public Administrador(AutorServico autorServico, EstanteServico estanteServico, LivroServico livroServico, PrateleiraServico prateleira)
        {
            _autorServico = autorServico;
            _estanteServico = estanteServico;
            _livroServico = livroServico;
            _prateleira = prateleira;
        }
    }
}