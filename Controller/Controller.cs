using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsWitcherAdmin.Model;

namespace WindowsFormsWitcherAdmin.Controller
{
    internal class Controller1
    {
        WitcherContext db = new WitcherContext();

        public void ShowChars(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = db.Characters.ToList();
            }
            catch { MessageBox.Show("Cannot Show Table from DB"); }
        }

        public void AddChar(string name, string chapter_Id_str, string description, string gender, string race, string occupation, string affiliation, string death, string image)
        {
            
            try
            {
                int chapter_Id = Convert.ToInt32(chapter_Id_str);
                db.Characters.Add(new Character() { Name = name, Chapter_Id = chapter_Id, Description = description, Gender = gender, Race = race, Occupation = occupation, Affiliation = affiliation, Death = death, Image = image });
                db.SaveChanges();
                MessageBox.Show("Добавлен!");
            }
            catch { MessageBox.Show("Cannot insert in Table from DB"); }
        }

        public void DeleteChar(string id_str)
        {
          
            try
            {
                int id = Convert.ToInt32(id_str);
                Character character = db.Characters.Where(x => x.Id == id).FirstOrDefault();
                db.Characters.Remove(character);
                db.SaveChanges();   
            }
            catch { MessageBox.Show("Выберете ячейку с ID которую хотите удалить!"); }

        }
    }
}
