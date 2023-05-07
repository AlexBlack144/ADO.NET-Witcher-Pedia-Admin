using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsWitcherAdmin.Controller;

namespace WindowsFormsWitcherAdmin.View
{
    public partial class Form2 : Form
    {
        Controller1 controller1 = new Controller1();
        public Form2()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            bool flag = true;
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(textBox_Image.Text, "image.png");
                }
            }
            catch { MessageBox.Show("Не правильно введён url адресс!"); flag = false; }
            if (flag != false)
            {
                controller1.AddChar(textBox_name.Text, textBox_chapter_id.Text, textBox_Description.Text, textBox_Gender.Text, textBox_Race.Text, textBox_Occupation.Text, textBox_Affiliation.Text, textBox_Death.Text, textBox_Image.Text);
                this.Close();
            }
        }
    }
}
