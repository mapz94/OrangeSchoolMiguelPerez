
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
    public partial class GestionProfesores : Form
    {
        private List<profesore> profes = null;
        public GestionProfesores()
        {
            InitializeComponent();
            refreshButton_Click(null, null);
        }

        private List<profesore> GetProfes()
        {
            using (OrangeEntities entity = new OrangeEntities())
            {
                IQueryable<profesore> profes = from d in entity.profesores
                                               select d;
                List<profesore> profesList = profes.ToList();

                return profesList;
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            using (OrangeEntities entity = new OrangeEntities())
            {
                IQueryable<profesore> profes = from d in entity.profesores
                                                    select d;
                List<profesore> profesList = profes.ToList();

                table.DataSource = profesList;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form profes = new profes_form();
            profes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new MenuForm();
            menu.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.table.SelectedRows)
            {
                int id = int.Parse(item.Cells[0].Value.ToString());

                using (OrangeEntities entity = new OrangeEntities())
                {
                    var delete = from d in entity.profesores
                                 where d.id == id
                                 select d;
                    foreach (var d in delete)
                    {
                        entity.profesores.Remove(d);
                    }

                    entity.SaveChanges();
                    MessageBox.Show("Ha eliminado correctamente.");
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            profesore profe = null;
            foreach (DataGridViewRow item in this.table.SelectedRows)
            {
                int id = int.Parse(item.Cells[0].Value.ToString());
                profe = profes.Find(p => p.id == id);
            }
            Form form = new profes_form(profe);
            form.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            profes = GetProfes();
            table.DataSource = profes;
        }
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editButton.Enabled = true;
        }
    }
}
