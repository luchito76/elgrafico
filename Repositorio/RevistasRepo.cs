using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class RevistasRepo
    {
        ModeloDominio dominio = new ModeloDominio();

        public void guardarRevista(Revista revista)
        {
            dominio.Add(revista);
            dominio.SaveChanges();
        }

        public IEnumerable<ListadoDeRevistasResultSet0> listaRevistas()
        {
            IEnumerable<ListadoDeRevistasResultSet0> result = dominio.SP_ListadoDeRevistas().ToList();

            return result;
        }

        public IEnumerable<Revista> listaRevistaXIdRevista(int idRevista)
        {
            IEnumerable<Revista> result = dominio.Revistas.Where(c => c.IdRevista == idRevista).ToList();

            return result;
        }

        public void actualizarRevista(Revista revista)
        {
            dominio.AttachCopy(revista);
            dominio.SaveChanges();
        }

        public IEnumerable<CantidadRevistasXDeporteResultSet0> cantidadDeRevistasXDeporte()
        {
            IEnumerable<CantidadRevistasXDeporteResultSet0> result = dominio.SP_CantidadRevistasXDeporte().ToList();

            return result;
        }
    }
}
