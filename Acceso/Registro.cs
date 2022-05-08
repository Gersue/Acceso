using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso.BD;

namespace Acceso
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncerrar2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            NewCuenta registre = new NewCuenta();
            registre.Show();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            listarJornadaL();
            listarParentesco();
            listarCompanyTelefonico();

        }
        //Rellenar al combobox
        private void listarJornadaL()
        {
            TablaList objJornada = new TablaList();
            cmbJornadaL.DataSource = objJornada.listarJornadaL();
            cmbJornadaL.DisplayMember = "nombre";
            cmbJornadaL.ValueMember = "codigojornada";
        }
        private void listarParentesco()
        {
            TablaList objParentesco = new TablaList();
            cmbparentesco.DataSource = objParentesco.ListarParentesco();
            cmbparentesco.DisplayMember = "nombre";
            cmbparentesco.ValueMember = "codigoParentesco";
        }
        private void listarCompanyTelefonico()
        {
            TablaList objcompany = new TablaList();
            cmbcompanytelf.DataSource = objcompany.listarCompanyTelefonico();
            cmbcompanytelf.DisplayMember = "nombre";
            cmbcompanytelf.ValueMember = "codigoTel";
        }


        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtnombrefam_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtapellidofam_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtsexofam_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbparentesco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
