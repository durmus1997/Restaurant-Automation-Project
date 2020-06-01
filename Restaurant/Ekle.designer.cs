namespace DataBaseManangementProject
{
    partial class Ekle
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
            this.Add = new System.Windows.Forms.Button();
            this.pName_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Food_Rbutton = new System.Windows.Forms.RadioButton();
            this.Drink_Rbutton = new System.Windows.Forms.RadioButton();
            this.Add_Type_Button = new System.Windows.Forms.Button();
            this.Price_Num = new System.Windows.Forms.NumericUpDown();
            this.Type_List_Dbox = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.Price_Num)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Add.Location = new System.Drawing.Point(358, 345);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(102, 35);
            this.Add.TabIndex = 33;
            this.Add.Text = "Ekle";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // pName_Box
            // 
            this.pName_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pName_Box.Location = new System.Drawing.Point(170, 69);
            this.pName_Box.Name = "pName_Box";
            this.pName_Box.Size = new System.Drawing.Size(160, 29);
            this.pName_Box.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ürünün Türü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(88, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fiyatı :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ürünün Adı :";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Back.Location = new System.Drawing.Point(25, 345);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(102, 35);
            this.Back.TabIndex = 40;
            this.Back.Text = "Geri";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Food_Rbutton
            // 
            this.Food_Rbutton.AutoSize = true;
            this.Food_Rbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Food_Rbutton.Location = new System.Drawing.Point(36, 12);
            this.Food_Rbutton.Name = "Food_Rbutton";
            this.Food_Rbutton.Size = new System.Drawing.Size(94, 28);
            this.Food_Rbutton.TabIndex = 41;
            this.Food_Rbutton.TabStop = true;
            this.Food_Rbutton.Text = "Yiyecek";
            this.Food_Rbutton.UseVisualStyleBackColor = true;
            this.Food_Rbutton.CheckedChanged += new System.EventHandler(this.Food_Rbutton_CheckedChanged);
            // 
            // Drink_Rbutton
            // 
            this.Drink_Rbutton.AutoSize = true;
            this.Drink_Rbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Drink_Rbutton.Location = new System.Drawing.Point(170, 12);
            this.Drink_Rbutton.Name = "Drink_Rbutton";
            this.Drink_Rbutton.Size = new System.Drawing.Size(83, 28);
            this.Drink_Rbutton.TabIndex = 42;
            this.Drink_Rbutton.TabStop = true;
            this.Drink_Rbutton.Text = "İçecek";
            this.Drink_Rbutton.UseVisualStyleBackColor = true;
            this.Drink_Rbutton.CheckedChanged += new System.EventHandler(this.Drink_Rbutton_CheckedChanged);
            // 
            // Add_Type_Button
            // 
            this.Add_Type_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Add_Type_Button.Location = new System.Drawing.Point(347, 166);
            this.Add_Type_Button.Name = "Add_Type_Button";
            this.Add_Type_Button.Size = new System.Drawing.Size(113, 29);
            this.Add_Type_Button.TabIndex = 45;
            this.Add_Type_Button.Text = "Yeni Tür Ekle";
            this.Add_Type_Button.UseVisualStyleBackColor = true;
            this.Add_Type_Button.Click += new System.EventHandler(this.Add_Type_Button_Click);
            // 
            // Price_Num
            // 
            this.Price_Num.DecimalPlaces = 2;
            this.Price_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Price_Num.Location = new System.Drawing.Point(170, 117);
            this.Price_Num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Price_Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Price_Num.Name = "Price_Num";
            this.Price_Num.Size = new System.Drawing.Size(160, 26);
            this.Price_Num.TabIndex = 46;
            this.Price_Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Type_List_Dbox
            // 
            this.Type_List_Dbox.Location = new System.Drawing.Point(170, 166);
            this.Type_List_Dbox.Name = "Type_List_Dbox";
            this.Type_List_Dbox.Size = new System.Drawing.Size(160, 171);
            this.Type_List_Dbox.TabIndex = 47;
            this.Type_List_Dbox.UseCompatibleStateImageBehavior = false;
            // 
            // Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 410);
            this.Controls.Add(this.Type_List_Dbox);
            this.Controls.Add(this.Price_Num);
            this.Controls.Add(this.Add_Type_Button);
            this.Controls.Add(this.Drink_Rbutton);
            this.Controls.Add(this.Food_Rbutton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.pName_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Ekle";
            this.Text = "Ekle";
            this.Load += new System.EventHandler(this.Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Price_Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox pName_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.RadioButton Food_Rbutton;
        private System.Windows.Forms.RadioButton Drink_Rbutton;
        private System.Windows.Forms.Button Add_Type_Button;
        private System.Windows.Forms.NumericUpDown Price_Num;
        private System.Windows.Forms.ListView Type_List_Dbox;
    }
}