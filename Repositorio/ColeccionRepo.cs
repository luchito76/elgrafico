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

        //Devuelve el último capítulo ingresado de la colección seleccionada para sugerir al usuario el capítulo siguiente que tiene que ingresar.
        public int ultimoCapituloXColeccion(int idColeccion)
        {

            int ultimoCapitulo = 0;

            IList<DetalleColeccion> lista = dominio.DetalleColeccions.Where(c => c.IdColeccion == idColeccion).ToList();

            if (lista.Count > 0)
            {
                IEnumerable<DetalleColeccion> result = dominio.DetalleColeccions;
                ultimoCapitulo = int.Parse(result.Where(c => c.IdColeccion == idColeccion).Last().Capitulo.ToString());
            }

            return ultimoCapitulo;
        }

    }
}
