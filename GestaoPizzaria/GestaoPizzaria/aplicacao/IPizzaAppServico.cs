using GestaoPizzaria.dominio.entidades;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPizzaria.aplicacao
{
    public interface IPizzaAppServico
    {
        void Salvar(string nome, double preco);

        void Atualizar(string nome, double preco, int id);

        void Excluir(int id);

        Pizza? BuscarPorId(int id);

        List<Pizza> BuscarTodos();



    }
}
