using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class DeportesNego
    {
        DeportesRepo deportesRepo = new DeportesRepo();

        public IEnumerable<Deporte> listaDeportes()
        {
            return deportesRepo.listaDeportes();
        }
    }
}
