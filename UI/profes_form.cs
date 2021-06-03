using OrangeSchoolMiguelPerez;
using OrangeScool.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrangeSchool.UI
{
    public partial class profes_form : Form
    {
        private profesore profe = null;
        public profes_form()
        {
            InitializeComponent();
        }

        public profes_form(profesore profe)
        {
            InitializeComponent();

            txt_nom.Text = profe.nombre;
            txt_ape.Text = profe.apellido;
            txt_sal.Text = profe.salario.ToString();

            nombreLabel.Text = "Cambiar Nombre: ";
            apellidoLabel.Text = "Cambiar Apellido: ";
            salaryLabel.Text = "Cambiar Salario: ";

            runButton.Text = "Cambiar Datos";
            this.profe = profe;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            if (
                txt_nom.Text == "" ||
                txt_ape.Text == "" ||
                txt_sal.Text == ""
                )
            {
                MessageBox.Show("Favor ingrese todos los datos.");
                return;
            }
            using (OrangeEntities entity = new OrangeEntities())
            {
                if(this.profe is null)
                {
                    profesore profes = new profesore()
                    {
                        nombre = txt_nom.Text,
                        apellido = txt_ape.Text,
                        salario = int.Parse(txt_sal.Text)

                    };
                    entity.profesores.Add(profes);
                    int result = entity.SaveChanges();
                    if (result > 0) MessageBox.Show("Se ha registrado correctamente!");
                    else MessageBox.Show("Hubo un error al registrar");
                }
                else
                {
                    profesore profe = (from a in entity.profesores where a.id == this.profe.id select a).SingleOrDefault();
                    profe.nombre = txt_nom.Text;
                    profe.apellido = txt_ape.Text;
                    profe.salario = int.Parse( txt_sal.Text);
                    entity.SaveChanges();
                    MessageBox.Show("Cambios realizados de forma exitosa.");
                }
                
            }
        }
    }
}
