using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class EstadoRepo
    {
        ModeloDominio dominio = new ModeloDominio();

        public IEnumerable<Estado> listaEstados()
        {
            IEnumerable<Estado> result = dominio.Estados.ToList();

            return result;
        }
    }
}
