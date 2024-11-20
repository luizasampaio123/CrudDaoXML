using System.Reflection.Emit;
using System.Windows.Forms;

namespace CrudDAOXML
{
    public partial class Crud : Form
    {

        private ClienteDAO clienteDAO;

        public Crud()
        {
            InitializeComponent();
            labelAlterar.Visible = false;
            textBox3.Visible = false;
            btn_concluido.Visible = false;
            textBox4.Visible = false;
            label_remover.Visible = false;
            btn_concluido_excluir.Visible = false;
        }

        private void Crud_Load(object sender, EventArgs e)
        {
            clienteDAO = new ClienteDAO();
            clienteDAO.Carregar();
            dataGridView2.DataSource = clienteDAO.getClientes();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Nome = textBox1.Text;
            cli.Email = textBox2.Text;

            clienteDAO.adicionarCliente(cli);
            clienteDAO.Salvar();

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = clienteDAO.getClientes();
        }



        private void btn_alterar_Click(object sender, EventArgs e)
        {
            btn_concluido.Visible = true;
            labelAlterar.Visible = true;
            textBox3.Visible = true;
            btn_alterar.Visible = false;
            btn_cadastrar.Visible = false;
            btn_excluir.Visible = false;

        }

        private void btn_concluido_Click(object sender, EventArgs e)
        {
            string aux = textBox3.Text;
            var clientes = clienteDAO.getClientes();
            bool encontrado = false;

            for (int i = 0; i < clientes.Count; i++)
            {
                if (aux == clientes[i].Nome)
                {

                    clientes[i].Nome = textBox1.Text;
                    clientes[i].Email = textBox2.Text;
                    MessageBox.Show("O cliente foi alterado com sucesso!");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("O cliente não foi encontrado.");
            }

            clienteDAO.Salvar();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = clienteDAO.getClientes();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
           
            label_nome.Visible = false;
            label_email.Visible = false;
            labelAlterar.Visible = false;
            textBox4.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            btn_alterar.Visible = false;
            label_remover.Visible = true;
            btn_concluido_excluir.Visible = true;
            btn_cadastrar.Visible = false;
            btn_excluir.Visible = false;
        }

        private void btn_concluido_excluir_Click(object sender, EventArgs e)
        {
            string aux = textBox4.Text;
            var clientes = clienteDAO.getClientes();
            bool encontrado = false;

            for (int i = 0; i < clientes.Count; i++)
            {
                if (aux == clientes[i].Nome)
                {
                    clienteDAO.removerCliente(clientes[i]);
                    MessageBox.Show("O cliente foi alterado com sucesso!");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("O cliente não foi encontrado.");
            }

            clienteDAO.Salvar();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = clienteDAO.getClientes();
        }
    }
}
