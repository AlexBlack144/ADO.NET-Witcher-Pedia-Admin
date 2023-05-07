using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsWitcherAdmin.Controller;
using WindowsFormsWitcherAdmin.View;

namespace WindowsFormsWitcherAdmin
{
    public partial class Form1 : Form
    {
        Controller1 controller = new Controller1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller.ShowChars(dataGridView_chars);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string id = dataGridView_chars.SelectedCells[0].Value.ToString();
            controller.DeleteChar(id);
            controller.ShowChars(dataGridView_chars);
        }

        private void button_refrash_Click(object sender, EventArgs e)
        {
            controller.ShowChars(dataGridView_chars);
        }
    }
}
