using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using TestMain;

namespace TestForm
{
    public partial class Form1 : Form
    {
        static void Empleado_SueldoMejorado(object sender, EventArgs e)
        {
            MessageBox.Show(((Empleado)sender).ToString(), "+20000");
        }

        static void Empleado_Sueldo()
        {
            MessageBox.Show("Cobra mucho!", "+9500");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            Empleado e1 = new Empleado("Juan","Perez",2);

            e1.SueldoMejorado += Empleado_SueldoMejorado;
            e1.SueldoEvent += Empleado_Sueldo;
            e1.Sueldo = double.Parse(txtSueldo.Text);
        }
    }
}
