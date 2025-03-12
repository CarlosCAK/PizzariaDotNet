using GestaoPizzaria.dominio.entidades;
using GestaoPizzaria.infraestrutura.database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPizzaria.infraestrutura.repositorios
{
    internal class PizzaRepositoryIMPL : IPizzaRepository
    {

        private readonly AppDbContext _context;

        public PizzaRepositoryIMPL(AppDbContext context) {
            this._context = context;
        }    

        public void Atualizar(Pizza pizza)
        {
            var pizzaExistente = BuscarPorId(pizza.Id);
            if (pizzaExistente == null)
            {
                throw new Exception("Produto não existente");
            }
            pizzaExistente.preco = pizza.preco;
            pizzaExistente.Nome = pizza.Nome;

            _context.SaveChanges();
        }

        public Pizza? BuscarPorId(int id)
        {
            return _context.Pizzas.Find(id);
        }

        public List<Pizza> BuscarTodos()
        {
            return _context.Pizzas.ToList();

        }

        public void Excluir(Pizza pizza)
        {
            _context.Pizzas.Remove(pizza);
            _context.SaveChanges();
        }

        public void Salvar(Pizza pizza)
        {
           _context.Pizzas.Add(pizza);
           _context.SaveChanges();
        }
    }
}
