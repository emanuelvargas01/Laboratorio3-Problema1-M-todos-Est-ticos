using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3_Problema1
{
    public partial class Form1 : Form
    {
        ArrayList listaPersonas = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Persona miColaborador1 = new Persona();
            miColaborador1.Id = 1;
            miColaborador1.Nombre = "Elena Carolina";
            miColaborador1.Apellido = "Gonzalez Rodríguez";
            miColaborador1.Correo = "elena.gonzalez@ejemplo.com";
            miColaborador1.FechaNacimiento = new DateTime(1990, 5, 15);
            listaPersonas.Add(miColaborador1);
            dtgv1.DataSource = listaPersonas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                errorProvider1.SetError(txtId, "Ingrese un ID");
                txtId.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtId, "");
            }

            if(txtNombre.Text=="")
            {
                errorProvider1.SetError(txtNombre, "Ingrese los nombres del colaborador");
                txtNombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }

            if (txtApellido.Text == "")
            {
                errorProvider1.SetError(txtApellido, "Ingrese los apellidos del colaborador");
                txtApellido.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellido, "");
            }
            if (Utilidades.EsCorreoValido(txtEmail.Text) == false)
            {
                errorProvider1.SetError(txtEmail, "Ingrese un correo válido");
                txtEmail.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
            decimal salario1;
            if(!decimal.TryParse(txtSalario.Text,out salario1))
            {
                errorProvider1.SetError(txtSalario, "Ingrese un salario válido");
                txtSalario.Focus();
                return;
            }
            else
            {
               errorProvider1.SetError(txtSalario, "");
            }
            Persona colaborador1 = new Persona();
            colaborador1.Id = int.Parse(txtId.Text);
            colaborador1.Nombre = txtNombre.Text;
            colaborador1.Apellido = txtApellido.Text;
            colaborador1.Correo = txtEmail.Text;
            colaborador1.Salario = salario1;
            colaborador1.FechaNacimiento = dtpFecha.Value;
            listaPersonas.Add(colaborador1);
            dtgv1.DataSource = null;
            dtgv1.DataSource = listaPersonas;
 
        }
    }
}
