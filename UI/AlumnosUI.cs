using OrangeSchool.Classes;
using OrangeSchool.UI;
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

namespace OrangeSchoolMiguelPerez.UI
{
    public partial class AlumnosUI : Form
    {

        private List<alumno> alumnos = null;
        private Session session = Session.GetInstance();
        public AlumnosUI()
        {
            InitializeComponent();
            refreshButton(null, null);
            alumnosBox.DisplayMember = "nombre";
        }

        private void refreshButton(object sender, EventArgs e)
        {
            alumnos = GetAlumnos();
            alumnosBox.DataSource = alumnos;
        }

        private void setInputs(object sender, EventArgs e)
        {
            alumno a = (alumno)alumnosBox.SelectedItem;
            bonoInput.Text = a.bono.ToString();
            adicionalInput.Text = a.adicional.ToString();
            resultInput.Text = $"{a.nombre} tu bono es de {a.bono + a.adicional}";

        }

        private List<alumno> GetAlumnos()
        {
            using (OrangeEntities entity = new OrangeEntities())
            {
                IQueryable<alumno> alumnos = from d in entity.alumnos
                                             select d;
                List<alumno> alumnosList = alumnos.ToList();

                return alumnosList;

            }
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            session.mainMenu.EmbedChildForm(session.getForm("AlumnGestion"));
        }
    }
}
