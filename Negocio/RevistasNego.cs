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

        public IEnumerable<ListadoDeRevistasResultSet0> listaRevistas()
        {
            return revistaRepo.listaRevistas();
        }

        public IEnumerable<Revista> listaRevistaXIdRevista(int idRevista)
        {
            return revistaRepo.listaRevistaXIdRevista(idRevista);
        }
        public void actualizarRevista(Revista revista)
        {
            revistaRepo.actualizarRevista(revista);
        }

        public IEnumerable<CantidadRevistasXDeporteResultSet0> cantidadDeRevistasXDeporte()
        {
            return revistaRepo.cantidadDeRevistasXDeporte();
        }

    }
}
