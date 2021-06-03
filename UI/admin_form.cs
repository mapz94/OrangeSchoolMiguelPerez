using OrangeSchool;
using OrangeSchoolMiguelPerez;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrangeScool.UI
{
    public partial class admin_form : Form
    {
        administradore admin;

        public admin_form()
        {
            InitializeComponent();
        }
        public admin_form(administradore admin)
        {
            InitializeComponent();
            txt_nom.Text = admin.nombre;
            txt_ape.Text = admin.apellido;

            nombreLabel.Text = "Cambiar Nombre:";
            apellidoLabel.Text = "Cambiar Apellido:";
            passLabel.Text = "Cambiar Contraseña:";

            runButton.Text = "Cambiar datos";
            this.admin = admin;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e) // Registrar
        {
            if (
                txt_nom.Text == "" ||
                txt_ape.Text == "" ||
                txt_pass.Text == ""
                )
            {
                MessageBox.Show("Favor ingrese todos los datos.");
                return;
            }
            using (OrangeEntities entity = new OrangeEntities())
            {
                if (this.admin is null) // Create
                {
                    administradore admin = new administradore()
                    {
                        nombre = txt_nom.Text,
                        apellido = txt_ape.Text,
                        contrasena = txt_pass.Text

                    };
                    entity.administradores.Add(admin);
                    int result = entity.SaveChanges();
                    if (result > 0) MessageBox.Show("Se ha registrado correctamente!");
                    else MessageBox.Show("Hubo un error al registrar");
                }
                else // Update
                {
                    administradore admin = (from a in entity.administradores where a.id == this.admin.id select a).SingleOrDefault();
                    admin.nombre = txt_nom.Text;
                    admin.apellido = txt_ape.Text;
                    admin.contrasena = txt_pass.Text;
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
