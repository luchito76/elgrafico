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

        public IEnumerable<Revista> listaRevistas()
        {
            IEnumerable<Revista> result = dominio.Revistas.OrderBy(c => c.NumeroDeEdicion).ToList();

            return result;
        }
    }
}
