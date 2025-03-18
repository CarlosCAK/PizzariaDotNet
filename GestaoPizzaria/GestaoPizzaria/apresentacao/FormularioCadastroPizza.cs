using GestaoPizzaria.aplicacao;
using GestaoPizzaria.dominio.entidades;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoPizzaria
{
    public partial class FormularioCadastroPizza : Form
    {

        private readonly IPizzaAppServico pizzaAppServico;
        public FormularioCadastroPizza(IServiceProvider serviceProvider)
        {

            InitializeComponent();

            pizzaAppServico = serviceProvider.GetRequiredService<IPizzaAppServico>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarPizza();
        }
        private void SalvarPizza()
        {


            string Nome = txtNome.Text;

            if (!double.TryParse(txtPreco.Text, out double Preco) || Preco <= 0)
            {
                MessageBox.Show("Preço inválido");
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome do produto é obrigatório.");
                return;
            }



            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    this.pizzaAppServico.Atualizar(Nome, Preco, id);
                    MessageBox.Show("Pizza Atualizada com sucesso ");

                }
                else
                {
                    this.pizzaAppServico.Salvar(Nome, Preco);
                    MessageBox.Show("Pizza cadastrada com sucesso ");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro no cadastro da pizza");
            }
            carregarPizzas();
            limparFormulario();
        }
        private void carregarPizzas()
        {
            List<Pizza> pizzas = this.pizzaAppServico.BuscarTodos();

            dtgPizzas.DataSource = pizzas;

            dtgPizzas.Columns["Id"].HeaderText = "ID";
            dtgPizzas.Columns["Nome"].HeaderText = "Nome do produto";
            dtgPizzas.Columns["Preco"].HeaderText = "Preço";

        }
        private void limparFormulario()
        {
            txtId.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtNome.Text = string.Empty;
        }

        private void FormularioCadastroPizza_Load(object sender, EventArgs e)
        {
            carregarPizzas();
        }

        private void dtgPizzas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            var produtoSelecionado = dtgPizzas.Rows[e.RowIndex].DataBoundItem as Pizza;

            if (produtoSelecionado != null)
            {
                txtId.Text = produtoSelecionado.Id.ToString();
                txtNome.Text = produtoSelecionado.Nome.ToString();
                txtPreco.Text = produtoSelecionado.preco.ToString();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text) || !int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome da pizza é obrigatório.");
                return;
            }
            if (!double.TryParse(txtPreco.Text, out double preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido.");
                return;
            }
            try
            {
                this.pizzaAppServico.Excluir(id);
                carregarPizzas();
                limparFormulario();
                MessageBox.Show("Pizza excluída");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }
    }
}
