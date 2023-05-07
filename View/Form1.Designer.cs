namespace WindowsFormsWitcherAdmin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_chars = new System.Windows.Forms.DataGridView();
            this.label_DB_Witcher = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_refrash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_chars
            // 
            this.dataGridView_chars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_chars.Location = new System.Drawing.Point(12, 57);
            this.dataGridView_chars.Name = "dataGridView_chars";
            this.dataGridView_chars.Size = new System.Drawing.Size(776, 318);
            this.dataGridView_chars.TabIndex = 0;
            // 
            // label_DB_Witcher
            // 
            this.label_DB_Witcher.AutoSize = true;
            this.label_DB_Witcher.Font = new System.Drawing.Font("Mason Chronicles", 24F, System.Drawing.FontStyle.Bold);
            this.label_DB_Witcher.Location = new System.Drawing.Point(282, 9);
            this.label_DB_Witcher.Name = "label_DB_Witcher";
            this.label_DB_Witcher.Size = new System.Drawing.Size(213, 39);
            this.label_DB_Witcher.TabIndex = 3;
            this.label_DB_Witcher.Text = "DB Witcher";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(590, 381);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(157, 57);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_delete.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(50, 381);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(157, 57);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_refrash
            // 
            this.button_refrash.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_refrash.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_refrash.Location = new System.Drawing.Point(325, 381);
            this.button_refrash.Name = "button_refrash";
            this.button_refrash.Size = new System.Drawing.Size(157, 57);
            this.button_refrash.TabIndex = 12;
            this.button_refrash.Text = "Обновить";
            this.button_refrash.UseVisualStyleBackColor = false;
            this.button_refrash.Click += new System.EventHandler(this.button_refrash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_refrash);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_DB_Witcher);
            this.Controls.Add(this.dataGridView_chars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_chars;
        private System.Windows.Forms.Label label_DB_Witcher;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_refrash;
    }
}

