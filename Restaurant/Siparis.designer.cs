namespace DataBaseManangementProject
{
    partial class Siparis
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
            this.Save = new System.Windows.Forms.Button();
            this.Type_drink = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Drink_list = new System.Windows.Forms.ListBox();
            this.Food_list = new System.Windows.Forms.ListBox();
            this.Choosen_list = new System.Windows.Forms.ListBox();
            this.Sum = new System.Windows.Forms.Label();
            this.Total_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Type_food = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.table_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Save.Location = new System.Drawing.Point(1020, 125);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(86, 100);
            this.Save.TabIndex = 46;
            this.Save.Text = "Kaydet/Yeni kayıt";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Type_drink
            // 
            this.Type_drink.FormattingEnabled = true;
            this.Type_drink.Location = new System.Drawing.Point(380, 58);
            this.Type_drink.Name = "Type_drink";
            this.Type_drink.Size = new System.Drawing.Size(134, 21);
            this.Type_drink.TabIndex = 45;
            this.Type_drink.SelectedIndexChanged += new System.EventHandler(this.Type_Drink_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(277, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "Tür Seç :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Drink_list
            // 
            this.Drink_list.FormattingEnabled = true;
            this.Drink_list.Location = new System.Drawing.Point(281, 83);
            this.Drink_list.Name = "Drink_list";
            this.Drink_list.Size = new System.Drawing.Size(233, 212);
            this.Drink_list.TabIndex = 43;
            // 
            // Food_list
            // 
            this.Food_list.FormattingEnabled = true;
            this.Food_list.Location = new System.Drawing.Point(16, 83);
            this.Food_list.Name = "Food_list";
            this.Food_list.Size = new System.Drawing.Size(233, 212);
            this.Food_list.TabIndex = 42;
            // 
            // Choosen_list
            // 
            this.Choosen_list.FormattingEnabled = true;
            this.Choosen_list.Location = new System.Drawing.Point(751, 85);
            this.Choosen_list.Name = "Choosen_list";
            this.Choosen_list.Size = new System.Drawing.Size(233, 212);
            this.Choosen_list.TabIndex = 41;
            this.Choosen_list.DoubleClick += new System.EventHandler(this.Choosen_list_DoubleClick);
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sum.Location = new System.Drawing.Point(844, 367);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(24, 26);
            this.Sum.TabIndex = 37;
            this.Sum.Text = "0";
            this.Sum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Total_Label
            // 
            this.Total_Label.AutoSize = true;
            this.Total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Total_Label.Location = new System.Drawing.Point(816, 325);
            this.Total_Label.Name = "Total_Label";
            this.Total_Label.Size = new System.Drawing.Size(102, 26);
            this.Total_Label.TabIndex = 36;
            this.Total_Label.Text = "Toplam : ";
            this.Total_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(746, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "Seçilenler : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Add.Location = new System.Drawing.Point(587, 216);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(120, 45);
            this.Add.TabIndex = 31;
            this.Add.Text = "Ekle";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tür Seç :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Type_food
            // 
            this.Type_food.FormattingEnabled = true;
            this.Type_food.Location = new System.Drawing.Point(115, 56);
            this.Type_food.Name = "Type_food";
            this.Type_food.Size = new System.Drawing.Size(134, 21);
            this.Type_food.TabIndex = 29;
            this.Type_food.SelectedIndexChanged += new System.EventHandler(this.Type_Food_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(276, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "İçeçekler :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Yiyecekler :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Back.Location = new System.Drawing.Point(16, 341);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(110, 45);
            this.Back.TabIndex = 47;
            this.Back.Text = "Geri";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // table_button
            // 
            this.table_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.table_button.Location = new System.Drawing.Point(587, 85);
            this.table_button.Name = "table_button";
            this.table_button.Size = new System.Drawing.Size(120, 45);
            this.table_button.TabIndex = 48;
            this.table_button.Text = "Masa Seç :";
            this.table_button.UseVisualStyleBackColor = true;
            this.table_button.Click += new System.EventHandler(this.table_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(535, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(377, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 50;
            // 
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 412);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.table_button);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Type_drink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Drink_list);
            this.Controls.Add(this.Food_list);
            this.Controls.Add(this.Choosen_list);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Total_Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Type_food);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Siparis";
            this.Text = "Siparis";
            this.Load += new System.EventHandler(this.Siparis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label Total_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button table_button;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button Save;
        public System.Windows.Forms.ComboBox Type_drink;
        public System.Windows.Forms.ListBox Drink_list;
        public System.Windows.Forms.ListBox Food_list;
        public System.Windows.Forms.ListBox Choosen_list;
        public System.Windows.Forms.Button Add;
        public System.Windows.Forms.ComboBox Type_food;
        public System.Windows.Forms.Label label7;
    }
}