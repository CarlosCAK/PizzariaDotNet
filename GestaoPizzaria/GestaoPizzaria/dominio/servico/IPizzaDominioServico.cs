using GestaoPizzaria.dominio.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPizzaria.dominio.servico
{
    public interface IPizzaDominioServico
    {
        public void Validar(Pizza pizza);

        public void ValidarId(int id);
    }
}
