namespace WindowsFormsWitcherAdmin.View
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Add = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_chapter_id = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Race = new System.Windows.Forms.Label();
            this.label_Occupation = new System.Windows.Forms.Label();
            this.label_Affiliation = new System.Windows.Forms.Label();
            this.label_Death = new System.Windows.Forms.Label();
            this.label_Image = new System.Windows.Forms.Label();
            this.textBox_chapter_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_Gender = new System.Windows.Forms.TextBox();
            this.textBox_Race = new System.Windows.Forms.TextBox();
            this.textBox_Occupation = new System.Windows.Forms.TextBox();
            this.textBox_Death = new System.Windows.Forms.TextBox();
            this.textBox_Affiliation = new System.Windows.Forms.TextBox();
            this.textBox_Image = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(520, 331);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(157, 57);
            this.button_Add.TabIndex = 11;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_back.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(159, 331);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(157, 57);
            this.button_back.TabIndex = 12;
            this.button_back.Text = "Отмена";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(16, 29);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(59, 25);
            this.label_name.TabIndex = 13;
            this.label_name.Text = "Имя:";
            // 
            // label_chapter_id
            // 
            this.label_chapter_id.AutoSize = true;
            this.label_chapter_id.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_chapter_id.Location = new System.Drawing.Point(16, 65);
            this.label_chapter_id.Name = "label_chapter_id";
            this.label_chapter_id.Size = new System.Drawing.Size(103, 25);
            this.label_chapter_id.TabIndex = 14;
            this.label_chapter_id.Text = "Id Главы:";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Description.Location = new System.Drawing.Point(16, 112);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(113, 25);
            this.label_Description.TabIndex = 15;
            this.label_Description.Text = "Описание:";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Gender.Location = new System.Drawing.Point(427, 29);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(57, 25);
            this.label_Gender.TabIndex = 16;
            this.label_Gender.Text = "Пол:";
            // 
            // label_Race
            // 
            this.label_Race.AutoSize = true;
            this.label_Race.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Race.Location = new System.Drawing.Point(427, 65);
            this.label_Race.Name = "label_Race";
            this.label_Race.Size = new System.Drawing.Size(64, 25);
            this.label_Race.TabIndex = 17;
            this.label_Race.Text = "Раса:";
            // 
            // label_Occupation
            // 
            this.label_Occupation.AutoSize = true;
            this.label_Occupation.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Occupation.Location = new System.Drawing.Point(426, 107);
            this.label_Occupation.Name = "label_Occupation";
            this.label_Occupation.Size = new System.Drawing.Size(137, 25);
            this.label_Occupation.TabIndex = 18;
            this.label_Occupation.Text = "Род занятий:";
            // 
            // label_Affiliation
            // 
            this.label_Affiliation.AutoSize = true;
            this.label_Affiliation.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Affiliation.Location = new System.Drawing.Point(4, 235);
            this.label_Affiliation.Name = "label_Affiliation";
            this.label_Affiliation.Size = new System.Drawing.Size(181, 25);
            this.label_Affiliation.TabIndex = 19;
            this.label_Affiliation.Text = "Принадлежность:";
            // 
            // label_Death
            // 
            this.label_Death.AutoSize = true;
            this.label_Death.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Death.Location = new System.Drawing.Point(427, 230);
            this.label_Death.Name = "label_Death";
            this.label_Death.Size = new System.Drawing.Size(86, 25);
            this.label_Death.TabIndex = 20;
            this.label_Death.Text = "Смерть:";
            // 
            // label_Image
            // 
            this.label_Image.AutoSize = true;
            this.label_Image.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Image.Location = new System.Drawing.Point(16, 276);
            this.label_Image.Name = "label_Image";
            this.label_Image.Size = new System.Drawing.Size(131, 25);
            this.label_Image.TabIndex = 21;
            this.label_Image.Text = "Фото(URL):";
            // 
            // textBox_chapter_id
            // 
            this.textBox_chapter_id.Location = new System.Drawing.Point(187, 70);
            this.textBox_chapter_id.Multiline = true;
            this.textBox_chapter_id.Name = "textBox_chapter_id";
            this.textBox_chapter_id.Size = new System.Drawing.Size(217, 30);
            this.textBox_chapter_id.TabIndex = 22;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(187, 29);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(217, 30);
            this.textBox_name.TabIndex = 23;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(187, 112);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(217, 98);
            this.textBox_Description.TabIndex = 24;
            // 
            // textBox_Gender
            // 
            this.textBox_Gender.Location = new System.Drawing.Point(563, 29);
            this.textBox_Gender.Multiline = true;
            this.textBox_Gender.Name = "textBox_Gender";
            this.textBox_Gender.Size = new System.Drawing.Size(217, 30);
            this.textBox_Gender.TabIndex = 25;
            // 
            // textBox_Race
            // 
            this.textBox_Race.Location = new System.Drawing.Point(563, 70);
            this.textBox_Race.Multiline = true;
            this.textBox_Race.Name = "textBox_Race";
            this.textBox_Race.Size = new System.Drawing.Size(217, 30);
            this.textBox_Race.TabIndex = 26;
            // 
            // textBox_Occupation
            // 
            this.textBox_Occupation.Location = new System.Drawing.Point(563, 112);
            this.textBox_Occupation.Multiline = true;
            this.textBox_Occupation.Name = "textBox_Occupation";
            this.textBox_Occupation.Size = new System.Drawing.Size(217, 98);
            this.textBox_Occupation.TabIndex = 27;
            // 
            // textBox_Death
            // 
            this.textBox_Death.Location = new System.Drawing.Point(563, 230);
            this.textBox_Death.Multiline = true;
            this.textBox_Death.Name = "textBox_Death";
            this.textBox_Death.Size = new System.Drawing.Size(217, 30);
            this.textBox_Death.TabIndex = 28;
            // 
            // textBox_Affiliation
            // 
            this.textBox_Affiliation.Location = new System.Drawing.Point(187, 230);
            this.textBox_Affiliation.Multiline = true;
            this.textBox_Affiliation.Name = "textBox_Affiliation";
            this.textBox_Affiliation.Size = new System.Drawing.Size(217, 30);
            this.textBox_Affiliation.TabIndex = 29;
            // 
            // textBox_Image
            // 
            this.textBox_Image.Location = new System.Drawing.Point(187, 276);
            this.textBox_Image.Multiline = true;
            this.textBox_Image.Name = "textBox_Image";
            this.textBox_Image.Size = new System.Drawing.Size(593, 30);
            this.textBox_Image.TabIndex = 30;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.textBox_Image);
            this.Controls.Add(this.textBox_Affiliation);
            this.Controls.Add(this.textBox_Death);
            this.Controls.Add(this.textBox_Occupation);
            this.Controls.Add(this.textBox_Race);
            this.Controls.Add(this.textBox_Gender);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_chapter_id);
            this.Controls.Add(this.label_Image);
            this.Controls.Add(this.label_Death);
            this.Controls.Add(this.label_Affiliation);
            this.Controls.Add(this.label_Occupation);
            this.Controls.Add(this.label_Race);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_chapter_id);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_Add);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_chapter_id;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Race;
        private System.Windows.Forms.Label label_Occupation;
        private System.Windows.Forms.Label label_Affiliation;
        private System.Windows.Forms.Label label_Death;
        private System.Windows.Forms.Label label_Image;
        private System.Windows.Forms.TextBox textBox_chapter_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_Gender;
        private System.Windows.Forms.TextBox textBox_Race;
        private System.Windows.Forms.TextBox textBox_Occupation;
        private System.Windows.Forms.TextBox textBox_Death;
        private System.Windows.Forms.TextBox textBox_Affiliation;
        private System.Windows.Forms.TextBox textBox_Image;
    }
}