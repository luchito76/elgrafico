using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
namespace Negocio
{
    public class RevistasNego
    {
        RevistasRepo revistaRepo = new RevistasRepo();

        public void guardarRevista(Revista revista)
        {
            revistaRepo.guardarRevista(revista);
        }

        public IEnumerable<Revista> listaRevistas()
        {
            return revistaRepo.listaRevistas();
        }
    }
}
