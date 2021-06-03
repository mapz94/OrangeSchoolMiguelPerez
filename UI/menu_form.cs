using OrangeSchool.Classes;
using OrangeSchool.UI;
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
    public partial class MenuForm : Form
    {

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (new System.Diagnostics.StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
            {
                MessageBox.Show("Se cerrará la sesión.");
            }  
            else
            {
                Application.Exit();
            }
                
        }

        private Session session = Session.GetInstance();

        public MenuForm()
        {
            InitializeComponent();
            userLabel.Text = $"Usuario: {session.user.nombre} {session.user.apellido}";
            session.mainMenu = this;

        }

        public void EmbedChildForm(Form childForm)
        {
            if (ContainerPanel.Controls.Count > 0)
                ContainerPanel.Controls.RemoveAt(0);
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Add(childForm);
            ContainerPanel.Tag = childForm;
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            EmbedChildForm(session.getForm("Admin"));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            session.clearSession();
            this.Close();
            Form login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            EmbedChildForm(session.getForm("Prof"));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            EmbedChildForm(session.getForm("Alumn"));
        }
    }
}
