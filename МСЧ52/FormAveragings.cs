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
    public partial class FormAveragings : Form
    {
        public FormAveragings()
        {
            InitializeComponent();
            ShowAveragings();
            ShowPatient();
        }
        void ShowPatient()
        {
            comboBoxPatient.Items.Clear();
            foreach (Pastients pastientsSet in Program.MCHSdb.Pastients)
            {
                string[] item = { pastientsSet.Id.ToString() + ".", pastientsSet.MiddleName
                +" " + pastientsSet.FirstName + " " + pastientsSet.LastName};
                comboBoxPatient.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewAveragings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAveragings.SelectedItems.Count == 1)
            {
                Mesto_rab_uch Mesto_rab_uchSet = listViewAveragings.SelectedItems[0].Tag as Mesto_rab_uch;
                textBoxCity.Text = Mesto_rab_uchSet.City;
                textBoxNazvOrg.Text = Mesto_rab_uchSet.NazvOrg;
                textBoxPodrazdelenie.Text = Mesto_rab_uchSet.Podrazdeleniya;
                comboBoxPatient.SelectedIndex = comboBoxPatient.FindString(Mesto_rab_uchSet.IdPastients.ToString());
            }
            else
            {
                textBoxCity.Text = "";
                textBoxNazvOrg.Text = "";
                textBoxPodrazdelenie.Text = "";
                comboBoxPatient.SelectedItem = null;
            }
        }
        void ShowAveragings()
        {
            listViewAveragings.Items.Clear();
            foreach (Mesto_rab_uch Mesto_rab_uchSet in Program.MCHSdb.Mesto_rab_uch)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    Mesto_rab_uchSet.Id.ToString(), Mesto_rab_uchSet.City,
                    Mesto_rab_uchSet.NazvOrg, Mesto_rab_uchSet.Podrazdeleniya,
                    Mesto_rab_uchSet.Pastients.MiddleName+ " " + Mesto_rab_uchSet.Pastients.FirstName+ " " +
                    Mesto_rab_uchSet.Pastients.LastName
                });
                item.Tag = Mesto_rab_uchSet;
                listViewAveragings.Items.Add(item);
            }
            listViewAveragings.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Mesto_rab_uch Mesto_rab_uchSet = new Mesto_rab_uch();
                if (textBoxCity.Text != "") { Mesto_rab_uchSet.City = textBoxCity.Text; }
                if (textBoxNazvOrg.Text != "") { Mesto_rab_uchSet.NazvOrg = textBoxNazvOrg.Text; }
                if (textBoxPodrazdelenie.Text != "") { Mesto_rab_uchSet.Podrazdeleniya = textBoxPodrazdelenie.Text; }
                if (comboBoxPatient.SelectedItem != null) { Mesto_rab_uchSet.IdPastients = Convert.ToInt32(comboBoxPatient.SelectedItem.ToString().Split('.')[0]); }
                Program.MCHSdb.Mesto_rab_uch.Add(Mesto_rab_uchSet);
                Program.MCHSdb.SaveChanges();
                ShowAveragings();
            }
            catch
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if ((textBoxCity.Text != "") && (textBoxNazvOrg.Text != "") && (textBoxPodrazdelenie.Text != "") &&
                (comboBoxPatient.SelectedItem != null))
            {
                if (listViewAveragings.SelectedItems.Count == 1)
                {
                    Mesto_rab_uch Mesto_rab_uchSet = listViewAveragings.SelectedItems[0].Tag as Mesto_rab_uch;
                    if (textBoxCity.Text != "") { Mesto_rab_uchSet.City = textBoxCity.Text; }
                    if (textBoxNazvOrg.Text != "") { Mesto_rab_uchSet.NazvOrg = textBoxNazvOrg.Text; }
                    if (textBoxPodrazdelenie.Text != "") { Mesto_rab_uchSet.Podrazdeleniya = textBoxPodrazdelenie.Text; }
                    if (comboBoxPatient.SelectedItem != null) { Mesto_rab_uchSet.IdPastients = Convert.ToInt32(comboBoxPatient.SelectedItem.ToString().Split('.')[0]); }
                    Program.MCHSdb.SaveChanges();
                    ShowAveragings();
                }
            }
            else
            { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAveragings.SelectedItems.Count == 1)
                {
                    Mesto_rab_uch Mesto_rab_uchSet = listViewAveragings.SelectedItems[0].Tag as Mesto_rab_uch;
                    Program.MCHSdb.Mesto_rab_uch.Remove(Mesto_rab_uchSet);
                    Program.MCHSdb.SaveChanges();
                    ShowAveragings();
                }
                textBoxCity.Text = "";
                textBoxPodrazdelenie.Text = "";
                textBoxNazvOrg.Text = "";
                comboBoxPatient.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


