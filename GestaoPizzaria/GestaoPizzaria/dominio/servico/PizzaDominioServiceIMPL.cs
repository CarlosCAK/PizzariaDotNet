using GestaoPizzaria.dominio.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPizzaria.dominio.servico
{
    public class PizzaDominioServiceIMPL : IPizzaDominioServico
    {
        public void Validar(Pizza pizza)
        {
           if(string.IsNullOrEmpty(pizza.Nome))
            {
                throw new Exception("O nome da pizza é obrigatório");
            }
           if(pizza.preco > 0)
            {
                throw new Exception("O Valor da pizza deve ser maior do que 0");
            }
            ValidarId(pizza.Id);
        }

        public void ValidarId(int id )
        {
            if(id <= 0)
            {
                throw new Exception("Id inválido");
            }
        }
    }
}
