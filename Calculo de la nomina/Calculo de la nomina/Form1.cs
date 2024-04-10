using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_la_nomina
{
    public partial class Form1 : Form
    {
        Empleado myEmpleado = new Empleado();
        Nomina myNomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
          

           

            myEmpleado.Nombre = txtNombre.Text;
            myEmpleado.Identificacion = txtIdentificacion.Text;
            myEmpleado.AsignacionDia = Convert.ToDecimal(txtAsignacionDia.Text);
            myNomina.DiasLaborados = Convert.ToInt32(txtDiasLaborados.Text);
            MessageBox.Show("Seguardo el registro correctamente");


        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            txtTotalDevengado.Text = myNomina.CalcularNomina(Convert.ToInt32(myNomina.DiasLaborados), Convert.ToDecimal(myEmpleado.AsignacionDia)).ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtAsignacionDia.Clear();
            txtTotalDevengado.Clear();
            txtDiasLaborados.Clear();
        }
    }
}
