using ExamenProgramacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;


namespace ExamenProgramacion
{
    public partial class Form1 : Form
    {
        List<Ingenieria> lista = new List<Ingenieria>();

        Ingenieria ing;

        List<Universitario> lista2 = new List<Universitario>();

        Universitario u;

        int Aprovados = 0;


        int contador = 0;
        int valor1 = 0;
        int valor2 = 0;


        public void GuardarIngeniero()
        {
            ing = new Ingenieria(txtNombreyApellido.Text, int.Parse(txtEdad.Text), cbSegs.Text, txtCarnet.Text, cbNivelAcademico.Text,
                cbUniversidad.Text, cbCarrera.Text, cbMateriasInscritas.Text, int.Parse(txtNotas.Text),
                txtNombreProyecto.Text, int.Parse(txtHoraTotales.Text), int.Parse(txtHoraCompletadas.Text));

            lista.Add(ing);

            dgvPersona.DataSource = null;
            dgvPersona.DataSource = lista;

        }

        public void GuardarPersona()
        {
            u = new Universitario(txtNombreyApellido.Text, int.Parse(txtEdad.Text), cbSegs.Text, txtCarnet.Text, cbNivelAcademico.Text,
                cbUniversidad.Text, cbCarrera.Text, cbMateriasInscritas.Text, int.Parse(txtNotas.Text));

            lista2.Add(u);

            dgvPersona.DataSource = null;
            dgvPersona.DataSource = lista2;

        }







        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas Seguro que quieres salir?", "Registro De Estudiantes",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (cbCarrera.Text == "Ingenieria")
            {
                GuardarIngeniero();

            }

            if (cbCarrera.Text == "Medicina")
            {
                GuardarPersona();

            }
            if (cbCarrera.Text == "Arquitectura")
            {
                GuardarPersona();

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("D");




            if(cbCarrera.SelectedIndex == 0)
            {
                txtNombreProyecto.Visible = true;
                txtHoraCompletadas.Visible = true;
                txtHoraTotales.Visible = true;

                lblHoraC.Visible = true;
                lblProyecto.Visible = true;
                lblHorasT.Visible = true;

            }

            if (cbCarrera.SelectedIndex == 1)
            {
                txtNombreProyecto.Visible = false;
                txtHoraCompletadas.Visible = false;
                txtHoraTotales.Visible = false;

                lblHoraC.Visible = false;
                lblProyecto.Visible = false;
                lblHorasT.Visible = false;

            }

            if (cbCarrera.SelectedIndex == 2)
            {
                txtNombreProyecto.Visible = false;
                txtHoraCompletadas.Visible = false;
                txtHoraTotales.Visible = false;

                lblHoraC.Visible = false;
                lblProyecto.Visible = false;
                lblHorasT.Visible = false;

            }

        }

        #region LINQ

        public void getUniversidadMasEstudiantes()
        {
               
            IEnumerable<Ingenieria> UmasIngenieria = from uni in lista where uni.Carrera == "Ingenieria" select uni;

            foreach (var xd in UmasIngenieria)
            {
                txtCONSULTA.Clear();
                txtCONSULTA.Text = "la Universidad Con Mayor Numero de Ingenieros Es: "+xd.Universidad+ "\r\n";
            }

        }


        public void getEstudianteYUniversidad()
        {

            Ingenieria d = new Ingenieria();

            IEnumerable<Ingenieria> EstudiantesIng = from uni in lista select uni;
            IEnumerable<Universitario> EstudiantesUniv = from univer in lista2 select univer;

            foreach (Ingenieria xd in EstudiantesIng)
            {
                txtCONSULTA.AppendText(xd.ImprimirIngenieria());
            }
            foreach (Universitario xd2 in EstudiantesUniv)
            {               
                txtCONSULTA.AppendText(xd2.ImprimirUniversitario());
            }
        }

        public void getPromedio()
        {

            IEnumerable<Ingenieria> promedio = from p in lista select p;
            IEnumerable<Universitario> promedio2 = from f in lista2 select f;

            foreach (Ingenieria d in lista)
            {
                contador++;

                

                valor1 =+  d.Promedio1();

            }

            foreach (Universitario xd in lista)
            {
                contador++;

                

                valor2 =+ xd.Promedio2();

            }


            int Valorcompleto = valor1 + valor2;

            double Promedio = Valorcompleto / contador;


            txtCONSULTA.AppendText("El promedio notas aproximado de los todos los Estudiantes es de: " + Promedio);

        }


        public void getAprobadosNoAprovados()
        {

            IEnumerable<Ingenieria> AproRepro1 = from p in lista select p;
            IEnumerable<Universitario> AproRepro2 = from f in lista2 select f;

            foreach (Ingenieria xd in AproRepro1)
            {

                if(xd.Notas > 59)
                {
                    Aprovados++;

                }

                txtCONSULTA.AppendText("La Universidad " + xd.Universidad + "Tiene un total de estudiantes aprovados de: " + Aprovados);


            }
            foreach (Universitario xd2 in AproRepro2)
            {
                if (xd2.Notas > 59)
                {
                    Aprovados++;

                }

                txtCONSULTA.AppendText("La Universidad " + xd2.Universidad + "Tiene un total de estudiantes aprovados de: " + Aprovados);
            }


           

        }




        #endregion



        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if(cblistas.Text == "lista1")
            {
                dgvPersona.DataSource = lista;

            }


            if (cblistas.Text == "lista2")
            {
                dgvPersona.DataSource = lista2;

            }


           

        }

        private void RbUniversidadMasEstudiantes_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();

            getUniversidadMasEstudiantes();
        }

        private void RbPromediio_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            getPromedio();
        }

        private void RbNameyUniver_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            getEstudianteYUniversidad();
        }
    }
}
