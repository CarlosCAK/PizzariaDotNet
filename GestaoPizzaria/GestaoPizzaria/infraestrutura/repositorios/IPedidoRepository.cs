using GestaoPizzaria.dominio.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPizzaria.infraestrutura.repositorios
{
    internal interface IPedidoRepository
    {

        void Salvar(Pedido pedido);

        void Atualizar(Pedido pedido);

        void Excluir(Pedido pedido);


        Pedido? BuscarPorId(int id);

        List<Pedido> BuscarTodos();

    }
}
