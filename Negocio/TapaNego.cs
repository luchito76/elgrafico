using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class TapaNego
    {
        TapaRepo tapaRepo = new TapaRepo();

        public void guardarTapa(Tapa tapa)
        {
            tapaRepo.guardarTapa(tapa);
        }

        public Tapa ultimoIdTapaInsertado()
        {
            return tapaRepo.ultimoIdTapaInsertado();
        }

        public void actualizarTapa(Tapa tapa)
        {
            tapaRepo.actualizarTapa(tapa);
        }
    }
}
