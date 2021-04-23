using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionDeNotas
{
    public partial class AdministradorDeNotas : Form
    {
        public AdministradorDeNotas()
        {
            InitializeComponent();
        } 

        private void btnEvaluarPromedio_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string area = txtArea.Text;
                double seccion = double.Parse(cbSeccion.Text);
                if(nombre != "" && apellido != "" && area != "" && seccion >= 0)
                {
                    gbAlumno.Enabled = false;
                    gbCalculoPromedios.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error en la validación de los datos. Intentalo nuevamente");
                }
            }
            catch
            {
                MessageBox.Show("Existio un error en la introduccion de datos. Intentalo nuevamente.");
            }
        }

        private void AdministradorDeNotas_Load(object sender, EventArgs e)
        {
            gbCalculoPromedios.Enabled = false;
            lblResultado.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double nota1 = double.Parse(txtNota1.Text);
                double nota2 = double.Parse(txtNota2.Text);
                double nota3 = double.Parse(txtNota3.Text);
                double nota4 = double.Parse(txtNota4.Text);
                if((nota1<= 10 && nota2 <= 10 && nota3 <= 10 && nota4 <= 10) &&(nota1 >=0 && nota2 >= 0 && nota3 >= 0 && nota4 >=0))
                {
                    double promedio = (nota1 + nota2 + nota3 + nota4) / 4;
                    double promedioP = promedio * 10;
                    txtPromedio.Text = Convert.ToString(promedio);
                    txtPromedioP.Text = Convert.ToString(promedioP);
                    lblResultado.Visible = true;
                    if(promedioP >= 51)
                    {
                        lblResultado.Text = $"Felicidades has aprobado la asignatura";

                    }
                    else
                    {
                        lblResultado.Text = $"Nos has aprobado la asignatura.";
                    }
                }
                else
                {
                    MessageBox.Show("Las notas no se encuentran dentro del rango corrrecto");
                    txtNota1.Clear();
                    txtNota2.Clear();
                    txtNota3.Clear();
                    txtNota4.Clear();
                }
            }catch
            {
                MessageBox.Show("Ha ocurrido un error en el calculo del promedio. Intentelo nuevamente");
                txtNota1.Clear();
                txtNota2.Clear();
                txtNota3.Clear();
                txtNota4.Clear();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
