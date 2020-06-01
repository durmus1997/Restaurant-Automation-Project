namespace DataBaseManangementProject
{
    partial class Sil
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
            this.label2 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Drink_Rbutton = new System.Windows.Forms.RadioButton();
            this.Food_Rbutton = new System.Windows.Forms.RadioButton();
            this.Menu_List_Dbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ürünün Adı :";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Delete.Location = new System.Drawing.Point(204, 127);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(102, 35);
            this.Delete.TabIndex = 34;
            this.Delete.Text = "Sil";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Back.Location = new System.Drawing.Point(12, 184);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(102, 35);
            this.Back.TabIndex = 35;
            this.Back.Text = "Geri";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Drink_Rbutton
            // 
            this.Drink_Rbutton.AutoSize = true;
            this.Drink_Rbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Drink_Rbutton.Location = new System.Drawing.Point(146, 12);
            this.Drink_Rbutton.Name = "Drink_Rbutton";
            this.Drink_Rbutton.Size = new System.Drawing.Size(117, 28);
            this.Drink_Rbutton.TabIndex = 44;
            this.Drink_Rbutton.TabStop = true;
            this.Drink_Rbutton.Text = "İçecek Ara";
            this.Drink_Rbutton.UseVisualStyleBackColor = true;
            this.Drink_Rbutton.CheckedChanged += new System.EventHandler(this.Drink_Rbutton_CheckedChanged);
            // 
            // Food_Rbutton
            // 
            this.Food_Rbutton.AutoSize = true;
            this.Food_Rbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Food_Rbutton.Location = new System.Drawing.Point(12, 12);
            this.Food_Rbutton.Name = "Food_Rbutton";
            this.Food_Rbutton.Size = new System.Drawing.Size(128, 28);
            this.Food_Rbutton.TabIndex = 43;
            this.Food_Rbutton.TabStop = true;
            this.Food_Rbutton.Text = "Yiyecek Ara";
            this.Food_Rbutton.UseVisualStyleBackColor = true;
            this.Food_Rbutton.CheckedChanged += new System.EventHandler(this.Food_Rbutton_CheckedChanged);
            // 
            // Menu_List_Dbox
            // 
            this.Menu_List_Dbox.FormattingEnabled = true;
            this.Menu_List_Dbox.Location = new System.Drawing.Point(146, 74);
            this.Menu_List_Dbox.Name = "Menu_List_Dbox";
            this.Menu_List_Dbox.Size = new System.Drawing.Size(121, 21);
            this.Menu_List_Dbox.TabIndex = 45;
            // 
            // Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 248);
            this.Controls.Add(this.Menu_List_Dbox);
            this.Controls.Add(this.Drink_Rbutton);
            this.Controls.Add(this.Food_Rbutton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label2);
            this.Name = "Sil";
            this.Text = "Sil";
            this.Load += new System.EventHandler(this.Sil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.RadioButton Drink_Rbutton;
        private System.Windows.Forms.RadioButton Food_Rbutton;
        private System.Windows.Forms.ComboBox Menu_List_Dbox;
    }
}