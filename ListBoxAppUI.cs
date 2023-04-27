using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxApp
{
    public partial class ListBoxAppUI : Form
    {
        public ListBoxAppUI()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(input_txtbox.Text);
        }

        private void input_txtbox_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(input_txtbox.Text);
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void count_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Items.Count.ToString());
        }

        private void clearList_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void ListBoxAppUI_Load(object sender, EventArgs e)
        {

        }
    }
}
