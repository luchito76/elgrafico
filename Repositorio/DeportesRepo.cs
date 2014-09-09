using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class DeportesRepo
    {
        ModeloDominio dominio = new ModeloDominio();

        public IEnumerable<Deporte> listaDeportes()
        {
            IEnumerable<Deporte> result = dominio.Deportes.OrderBy(c => c.Nombre).ToList();

            return result;
        }
    }
}
