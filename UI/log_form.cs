using OrangeSchool;
using OrangeSchool.Classes;
using OrangeSchoolMiguelPerez;
using OrangeScool.UI;
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

namespace OrangeScool
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent(); // inicializa los elementos de la interfaz.
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            admin_form adm = new admin_form();
            adm.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            using (OrangeEntities entity = new OrangeEntities())
            {
                var Admins = from d in entity.administradores
                            where d.nombre == user_txt.Text &&
                            d.contrasena == pass_txt.Text
                            select d;
                if (Admins.Count() > 0)
                {
                    Session s = Session.GetInstance();
                    s.user = Admins.FirstOrDefault();
                    this.Hide();
                    MenuForm menu = new MenuForm();
                    menu.Show();

                }
                else
                {
                    MessageBox.Show("No hay usuarios con esos datos.");
                }
            }
        }
    }
}
