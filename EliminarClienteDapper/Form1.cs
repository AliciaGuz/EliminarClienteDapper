using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliminarClienteDapper
{
    public partial class Form1 : Form
    {
        
        RepositorioCustomers CustomersR = new RepositorioCustomers();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerTodo_Click(object sender, EventArgs e)
        {
            // Obtener todos los clientes y asignar al DataGridView
            var clientes = CustomersR.ObtenerTodo();
            dgvCustomers.DataSource = clientes;
        }

        private void btnObtenerID_Click(object sender, EventArgs e)
        {
            var cliente = CustomersR.ObtenerPorID(txbObtenerID.Text);
            dgvCustomers.DataSource = new List<Customers> { cliente };
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var eliminadas = CustomersR.EliminarCliente(txbObtenerID.Text);
            MessageBox.Show($"Se ha eliminado {eliminadas} filas de manera correcta");
        }
    }
}
