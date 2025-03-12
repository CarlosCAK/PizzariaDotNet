using GestaoPizzaria.dominio.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPizzaria.dominio.servico
{
    public class PedidoDominioServicoIMPL : IPedidoDominioServico
    {
        public void Validar(Pedido pedido)
        {
            if(pedido.ValorTotal <= 0)
            {
                throw new Exception("O pedido deve ter um valor maior que 0");
            }
            if(pedido.QuanidadePizzas < 1)
            {
                throw new Exception("Você precisa de ao menos uma pizza");
            }
            if (string.IsNullOrEmpty(pedido.NomePizza))
            {
                throw new Exception("A pizza deve ter um nome");
            }
            ValidarId(pedido.Id);
        }

        public void ValidarId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Id inválido");
            }
        }
    }
}
