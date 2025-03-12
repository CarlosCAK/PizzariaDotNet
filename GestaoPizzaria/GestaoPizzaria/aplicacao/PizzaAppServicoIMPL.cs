using GestaoPizzaria.dominio.entidades;
using GestaoPizzaria.dominio.servico;
using GestaoPizzaria.infraestrutura.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPizzaria.aplicacao
{
    public class PizzaAppServicoIMPL : IPizzaAppServico
    {
        private readonly IPizzaDominioServico _dominioServico;
        private readonly IPizzaRepository _repository;

        public PizzaAppServicoIMPL(IPizzaDominioServico dominioServico, IPizzaRepository repository)
        {
            _dominioServico = dominioServico;
            _repository = repository;
        }   

        public void Atualizar(string nome, double preco, int id)
        {
            Pizza pizza = new Pizza(nome,preco);
            _dominioServico.Validar(pizza);
            _repository.Salvar(pizza);
        }

        public Pizza? BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }

        public List<Pizza> BuscarTodos()
        {
            return _repository.BuscarTodos();
        }

        public void Excluir(int id)
        {
            Pizza pizza = BuscarPorId(id);

           _repository.Excluir(pizza);
        }

        public void Salvar(string nome, double preco)
        {
            throw new NotImplementedException();
        }
    }
}
