using GestaoPizzaria.dominio.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPizzaria.dominio.servico
{
    public interface IPedidoDominioServico
    {
        public void Validar(Pedido pedido);

        public void ValidarId(int id);
    }
}
