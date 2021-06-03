using OrangeSchoolMiguelPerez;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrangeSchool
{
    public partial class alumnosForm : Form
    {
        alumno alumno = null;
        public alumnosForm()
        {
            InitializeComponent();
        }

        public alumnosForm(alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
            txt_nom.Text = alumno.nombre;
            txt_ape.Text = alumno.apellido;
            txt_matricula.Text = alumno.matricula.ToString();
            txt_bono.Text = alumno.bono.ToString();
            txt_adicional.Text = alumno.adicional.ToString();

            nombreLabel.Text = "Cambiar Nombre: ";
            apellidoLabel.Text = "Cambiar Apellido: ";
            matriculaLabel.Text = "Cambiar Matricula: ";
            bonoLabel.Text = "Cambiar Bono";
            adicionalLabel.Text = "Cambiar Adicional";

            runButton.Text = "Cambiar Datos";

            Text = "Editar Alumno";

            this.alumno = alumno;
        }

        private void runButton_Click(object sender, EventArgs e) // Registrar
        {
            if (
                txt_nom.Text == "" ||
                txt_ape.Text == "" ||
                txt_matricula.Text == "" ||
                txt_bono.Text == ""||
                txt_adicional.Text == ""
                )
            {
                MessageBox.Show("Favor ingrese todos los datos.");
                return;
            }
            using (OrangeEntities entity = new OrangeEntities())
            {
                if(this.alumno is null)
                {
                    alumno alumno = new alumno()
                    {
                        nombre = txt_nom.Text,
                        apellido = txt_ape.Text,
                        matricula = int.Parse(txt_matricula.Text),
                        bono = int.Parse(txt_bono.Text),
                        adicional = int.Parse(txt_adicional.Text),
                        fecha_ing = DateTime.Now

                    };
                    entity.alumnos.Add(alumno);
                    int result = entity.SaveChanges();
                    if (result > 0) MessageBox.Show("Se ha registrado correctamente!");
                    else MessageBox.Show("Hubo un error al registrar");
                }
                else
                {
                    alumno alumno = (from a in entity.alumnos where a.id == this.alumno.id select a).SingleOrDefault();
                    alumno.nombre = txt_nom.Text;
                    alumno.apellido = txt_ape.Text;
                    alumno.bono = int.Parse(txt_bono.Text);
                    alumno.adicional = int.Parse(txt_adicional.Text);
                    alumno.matricula = int.Parse( txt_matricula.Text);
                    entity.SaveChanges();
                    MessageBox.Show("Cambios realizados de forma exitosa.");
                }
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
