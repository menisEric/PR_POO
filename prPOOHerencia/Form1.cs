using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace prPOOHerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor1 = new Vendedor();
            vendedor1.Apellidos = txtApellido.Text;
            vendedor1.Nombres = txtNombre.Text;
            vendedor1.Documento = txtDocumento.Text;
            vendedor1.Tipo = cboTipo.Text;
            vendedor1.TipoContrato = cboContrato.Text;

            vendedor1.calcularSueldo(750);

            dgvVendedores.Rows.Insert(0,vendedor1.Tipo,vendedor1.Apellidos,vendedor1.Nombres,vendedor1.Documento,vendedor1.Sueldo);
            
        }
    }
}
