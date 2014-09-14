using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class ColeccionNego
    {
        ColeccionRepo coleccionRepo = new ColeccionRepo();

        public void guardarNombreColeccion(Coleccion coleccion)
        {
            coleccionRepo.guardarNombreColeccion(coleccion);
        }

        public Coleccion ultimoIdColeccionInsertado()
        {
            return coleccionRepo.ultimoIdColeccionInsertado();
        }

        public void guardarDetalleColeccion(DetalleColeccion detalleColeccion)
        {
            coleccionRepo.guardarDetalleColeccion(detalleColeccion);
        }

        public IEnumerable<Coleccion> listaColecciones()
        {
            return coleccionRepo.listaColecciones();
        }

        public IEnumerable<ListadoColeccionResultSet0> listaColeccionXDetalleColeccion()
        {
            return coleccionRepo.listaColeccionXDetalleColeccion();
        }

        public int ultimoCapituloXColeccion(int idColeccion)
        {
            return coleccionRepo.ultimoCapituloXColeccion(idColeccion);
        }
    }
}
