using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class TapaRepo
    {
        ModeloDominio dominio = new ModeloDominio();

        public void guardarTapa(Tapa tapa)
        {
            dominio.Add(tapa);
            dominio.SaveChanges();
        }

        public Tapa ultimoIdTapaInsertado() { 
            IEnumerable<Tapa> result = dominio.Tapas;
            Tapa ultimoIdTapa = result.Last();

            return ultimoIdTapa;
        }

        public void actualizarTapa(Tapa tapa)
        {
            dominio.AttachCopy(tapa);
            dominio.SaveChanges();
        } 
    }
}
