using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МСЧ52
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "staff")
            {
                buttonStaff.Enabled = false;
            }
            labelHello.Text = "Привет, " + FormAuthorization.users.login;
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            Form formregion = new FormRegion();
            formregion.Show();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            Form formstaff = new FormStaff();
            formstaff.Show();
        }

        private void buttonDepartment_Click(object sender, EventArgs e)
        {
            Form formpatient = new FormPatient();
            formpatient.Show();
        }
        private void buttonAveragings_Click(object sender, EventArgs e)
        {
            Form formaveragings = new FormAveragings();
            formaveragings.Show();
        }
        private void buttonService_Click(object sender, EventArgs e)
        {
            Form formdiagnosis = new FormDiagnosis();
            formdiagnosis.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form formfacilities = new FormFacilities();
            formfacilities.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Hide();
            Form formauthorization = new FormAuthorization();
            formauthorization.Show();
        }

    }
}
