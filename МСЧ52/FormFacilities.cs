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
    public partial class FormFacilities : Form
    {
        public FormFacilities()
        {
            InitializeComponent();
            ShowFacilitie();
            ShowPatient();
        }
        void ShowPatient()
        {
            comboBoxPatient.Items.Clear();
            foreach (Pastients pastientsSet in Program.MCHSdb.Pastients)
            {
                string[] item = { pastientsSet.Id.ToString() + ".", pastientsSet.MiddleName
                +" " + pastientsSet.FirstName +" " + pastientsSet.LastName};
                comboBoxPatient.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewFacilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFacilities.SelectedItems.Count == 1)
            {
                Facilities facilitiesSet = listViewFacilities.SelectedItems[0].Tag as Facilities;
                textBoxFacilitie.Text = facilitiesSet.Name;
                comboBoxPatient.SelectedIndex = comboBoxPatient.FindString(facilitiesSet.IdPastients.ToString());
            }
            else
            {
                textBoxFacilitie.Text = "";
                comboBoxPatient.SelectedItem = null;
            }
        }
        void ShowFacilitie()
        {
            listViewFacilities.Items.Clear();
            foreach (Facilities facilitiesSet in Program.MCHSdb.Facilities)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    facilitiesSet.Id.ToString(), facilitiesSet.Pastients.MiddleName+" "
                    +facilitiesSet.Pastients.FirstName +" "+facilitiesSet.Pastients.LastName,
                    facilitiesSet.Name
                });
                item.Tag = facilitiesSet;
                listViewFacilities.Items.Add(item);
            }
            listViewFacilities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Facilities facilitiesSet = new Facilities();
                if (textBoxFacilitie.Text != "") { facilitiesSet.Name = textBoxFacilitie.Text; }            
                if (comboBoxPatient.SelectedItem != null) { facilitiesSet.IdPastients = Convert.ToInt32(comboBoxPatient.SelectedItem.ToString().Split('.')[0]); }
                Program.MCHSdb.Facilities.Add(facilitiesSet);
                Program.MCHSdb.SaveChanges();
                ShowFacilitie();
            }
            catch
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if ((textBoxFacilitie.Text != "")&&(comboBoxPatient.SelectedItem != null))
            {
                if (listViewFacilities.SelectedItems.Count == 1)
                {
                    Facilities facilitiesSet = listViewFacilities.SelectedItems[0].Tag as Facilities;
                    if (textBoxFacilitie.Text != "") { facilitiesSet.Name = textBoxFacilitie.Text; }
                    if (comboBoxPatient.SelectedItem != null) { facilitiesSet.IdPastients = Convert.ToInt32(comboBoxPatient.SelectedItem.ToString().Split('.')[0]); }
                    Program.MCHSdb.SaveChanges();
                    ShowFacilitie();
                }
            }
            else
            { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFacilities.SelectedItems.Count == 1)
                {
                    Facilities facilitiesSet = listViewFacilities.SelectedItems[0].Tag as Facilities;
                    Program.MCHSdb.Facilities.Remove(facilitiesSet);
                    Program.MCHSdb.SaveChanges();
                    ShowFacilitie();
                }
                textBoxFacilitie.Text="";
                comboBoxPatient.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
