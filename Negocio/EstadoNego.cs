using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class EstadoNego
    {
        EstadoRepo estadoRepo = new EstadoRepo();

        public IEnumerable<Estado> listaEstados()
        {
            return estadoRepo.listaEstados();
        }
    }
}
