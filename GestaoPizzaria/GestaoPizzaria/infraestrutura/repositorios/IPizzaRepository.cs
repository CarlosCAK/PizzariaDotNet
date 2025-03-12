using GestaoPizzaria.dominio.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPizzaria.infraestrutura.repositorios
{
    public interface IPizzaRepository
    {
        void Salvar(Pizza pizza);

        void Atualizar(Pizza pizza);

        void Excluir(Pizza pizza);

        Pizza? BuscarPorId(int id);

        List<Pizza> BuscarTodos();
    }
}
