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
    public partial class GestionAlumno : Form
    {
        private List<alumno> alumnos = null;
        public GestionAlumno()
        {
            InitializeComponent();
            refreshButton_Click(null, null);
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.table.SelectedRows)
            {
                int id = int.Parse(item.Cells[0].Value.ToString());

                using (OrangeEntities entity = new OrangeEntities())
                {
                    var delete = from d in entity.alumnos
                                 where d.id == id
                                 select d;
                    foreach (var d in delete)
                    {
                        entity.alumnos.Remove(d);
                    }

                    entity.SaveChanges();
                    MessageBox.Show("Ha eliminado correctamente.");
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form menu = new MenuForm();
            menu.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form admin = new alumnosForm();
            admin.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            alumnos = GetAlumnos();
            table.DataSource = alumnos;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            alumno alumno = null;
            foreach (DataGridViewRow item in table.SelectedRows)
            {
                int id = int.Parse(item.Cells[0].Value.ToString());
                alumno = alumnos.Find(a => a.id == id);
            }
            Form form = new alumnosForm(alumno);
            form.Show();
        }
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editButton.Enabled = true;
        }

    }
}
