using GestaoPizzaria.aplicacao;
using GestaoPizzaria.dominio.servico;
using GestaoPizzaria.infraestrutura.database;
using GestaoPizzaria.infraestrutura.repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoPizzaria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            try
            {
                services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite("Data Source=pizzaria.db"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        

            services.AddScoped<IPizzaRepository, PizzaRepositoryIMPL>();
            services.AddScoped<IPedidoRepository, PedidoRespositoryIMPL>();
            services.AddScoped<IPizzaDominioServico, PizzaDominioServiceIMPL>();
            services.AddScoped<IPedidoDominioServico, PedidoDominioServicoIMPL>();
            services.AddScoped<IPizzaAppServico, PizzaAppServicoIMPL>();

            var serviceProvider = services.BuildServiceProvider();


            ApplicationConfiguration.Initialize();
            Application.Run(new FormularioCadastroPizza());
        }
    }
}