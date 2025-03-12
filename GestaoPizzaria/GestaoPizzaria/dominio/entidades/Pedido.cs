using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPizzaria.dominio.entidades
{
    public class Pedido
    {
        [Required]
        public int Id { get; set; }


        [Required]
        public string NomePizza {  get; set; }

        [Required]
        public int QuanidadePizzas { get; set; }

        [Required]
        public double ValorTotal { get; set; }

        public DateTime? DataHora { get; set; }

    }
}
