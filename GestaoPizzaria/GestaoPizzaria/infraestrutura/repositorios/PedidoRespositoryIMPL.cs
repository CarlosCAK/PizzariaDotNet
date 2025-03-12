using GestaoPizzaria.dominio.entidades;
using GestaoPizzaria.infraestrutura.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPizzaria.infraestrutura.repositorios
{
    internal class PedidoRespositoryIMPL : IPedidoRepository
    {
        private readonly AppDbContext _context;

        public PedidoRespositoryIMPL(AppDbContext context)
        {
            _context = context;
        }
        public void Atualizar(Pedido pedido)
        {
            var PedidoExistente= BuscarPorId(pedido.Id);
            if(PedidoExistente == null )
            {
                throw new Exception("Produto não existente");
            }
            PedidoExistente.NomePizza = pedido.NomePizza;   
            PedidoExistente.QuanidadePizzas = pedido.QuanidadePizzas;
            PedidoExistente.DataHora = pedido.DataHora;
            PedidoExistente.ValorTotal = pedido.ValorTotal;

            _context.SaveChanges();
        }

        public Pedido? BuscarPorId(int id)
        {
            return _context.Pedidos.Find(id);
        }

        public List<Pedido> BuscarTodos()
        {
            return _context.Pedidos.ToList();
        }

        public void Excluir(Pedido pedido)
        {

            _context.Pedidos.Remove(pedido);
            _context.SaveChanges();

        }

        public void Salvar(Pedido pedido)
        {
            pedido.DataHora = DateTime.Now;
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }
    }
}
