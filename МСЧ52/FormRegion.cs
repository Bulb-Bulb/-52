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
    public partial class FormRegion : Form
    {
        public FormRegion()
        {
            InitializeComponent();
            ShowRegions();
        }

        void ShowRegions()
        {
            listViewRegions.Items.Clear();
            foreach (Uchastok uchastokset in Program.MCHSdb.Uchastok)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    uchastokset.Id.ToString(), "Участок №" +uchastokset.Number.ToString()
                });
                item.Tag = uchastokset;
                listViewRegions.Items.Add(item);
            }
            listViewRegions.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRegions.SelectedItems.Count == 1)
            {
                Uchastok uchastokset = listViewRegions.SelectedItems[0].Tag as Uchastok;
                textBoxRegion.Text = uchastokset.Number.ToString();
            }
            else
            {
                textBoxRegion.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Uchastok uchastokset = new Uchastok();
                if (textBoxRegion.Text!="") { uchastokset.Number = Convert.ToInt32(textBoxRegion.Text); }
                Program.MCHSdb.Uchastok.Add(uchastokset);
                Program.MCHSdb.SaveChanges();
            }
            catch
            {
                { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            ShowRegions();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxRegion.Text != null)
            {
                if (listViewRegions.SelectedItems.Count == 1)
                {
                    Uchastok uchastokset = listViewRegions.SelectedItems[0].Tag as Uchastok;
                    if (textBoxRegion.Text != "")
                        uchastokset.Number = Convert.ToInt32(textBoxRegion.Text);
                    Program.MCHSdb.SaveChanges();
                    ShowRegions();
                }
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewRegions.SelectedItems.Count == 1)
                {
                    Uchastok uchastokset = listViewRegions.SelectedItems[0].Tag as Uchastok;
                    Program.MCHSdb.Uchastok.Remove(uchastokset);
                    Program.MCHSdb.SaveChanges();
                    ShowRegions();
                }
                textBoxRegion.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45)
            {
                e.Handled = true;
            }

        }
    }
}