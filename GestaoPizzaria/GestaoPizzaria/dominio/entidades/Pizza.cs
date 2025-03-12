using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPizzaria.dominio.entidades
{
    public class Pizza
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public double preco { get; set; }

        public Pizza(string nome, double preco)
        {
            this.Nome = nome;
            this.preco = preco;
        }
        public Pizza(int id, string nome, double preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.preco = preco;
        }

        public Pizza() { 
        }



    }
}
