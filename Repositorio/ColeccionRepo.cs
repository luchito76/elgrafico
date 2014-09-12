using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class ColeccionRepo
    {
        ModeloDominio dominio = new ModeloDominio();

        public void guardarNombreColeccion(Coleccion coleccion)
        {
            dominio.Add(coleccion);
            dominio.SaveChanges();
        }

        public Coleccion ultimoIdColeccionInsertado()
        {
            IEnumerable<Coleccion> result = dominio.Coleccions;
            Coleccion ultimoIdColeccion = result.Last();

            return ultimoIdColeccion;
        }

        public void guardarDetalleColeccion(DetalleColeccion detalleColeccion)
        {
            dominio.Add(detalleColeccion);
            dominio.SaveChanges();
        }

        public IEnumerable<Coleccion> listaColecciones()
        {
            IEnumerable<Coleccion> result = dominio.Coleccions.ToList();

            return result;
        }
    }
}
