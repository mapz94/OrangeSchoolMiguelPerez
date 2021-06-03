using OrangeSchool.UI;
using OrangeSchoolMiguelPerez;
using OrangeSchoolMiguelPerez.UI;
using OrangeScool.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrangeSchool.Classes
{
    class Session
    {

        private static Session _instance;

        private static readonly Session _lock = new Session();

        public administradore user { get; set; }

        private Session() { }

        public MenuForm mainMenu { get; set; }


        // Singleton
        public static Session GetInstance()
        {
            if (_instance == null)
            {
                // Proteger la instancia de Multi-Threading
                lock (_lock)
                {
                    _instance = new Session();
                    _instance.setForms();
                }
            }
            return _instance;
        }

        public List<KeyValuePair<string, Form>> forms;

        private void setForms()
        {
            forms = new List<KeyValuePair<string, Form>>();
            forms.Add(new KeyValuePair<string, Form>("Admin", new GestionAdmin()));
            forms.Add(new KeyValuePair<string, Form>("Prof", new GestionProfesores()));
            forms.Add(new KeyValuePair<string, Form>("Alumn", new AlumnosUI()));
            forms.Add(new KeyValuePair<string, Form>("AlumnGestion", new GestionAlumno()));
        }

        public Form getForm(string key)
        {
            if (forms.Exists(pair => pair.Key == key))
            {
                return forms.Find(pair => pair.Key == key).Value;
            }
            return null;
        }

        public void clearSession()
        {
            user = null;
            setForms();
        }

    }
}
