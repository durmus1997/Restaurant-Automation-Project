﻿namespace DataBaseManangementProject
{
    partial class Tur_Ekle2
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
            this.Type_Tbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Drink_Type_Rbutton = new System.Windows.Forms.RadioButton();
            this.Food_Type_Rbutton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Add.Location = new System.Drawing.Point(227, 133);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(102, 35);
            this.Add.TabIndex = 55;
            this.Add.Text = "Ekle";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Type_Tbox
            // 
            this.Type_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Type_Tbox.Location = new System.Drawing.Point(169, 69);
            this.Type_Tbox.Name = "Type_Tbox";
            this.Type_Tbox.Size = new System.Drawing.Size(160, 29);
            this.Type_Tbox.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 53;
            this.label4.Text = "Ürünün Türü :";
            // 
            // Drink_Type_Rbutton
            // 
            this.Drink_Type_Rbutton.AutoSize = true;
            this.Drink_Type_Rbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Drink_Type_Rbutton.Location = new System.Drawing.Point(227, 12);
            this.Drink_Type_Rbutton.Name = "Drink_Type_Rbutton";
            this.Drink_Type_Rbutton.Size = new System.Drawing.Size(170, 28);
            this.Drink_Type_Rbutton.TabIndex = 52;
            this.Drink_Type_Rbutton.TabStop = true;
            this.Drink_Type_Rbutton.Text = "İçecek Türü Ekle";
            this.Drink_Type_Rbutton.UseVisualStyleBackColor = true;
            this.Drink_Type_Rbutton.CheckedChanged += new System.EventHandler(this.Drink_Type_Rbutton_CheckedChanged);
            // 
            // Food_Type_Rbutton
            // 
            this.Food_Type_Rbutton.AutoSize = true;
            this.Food_Type_Rbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Food_Type_Rbutton.Location = new System.Drawing.Point(12, 12);
            this.Food_Type_Rbutton.Name = "Food_Type_Rbutton";
            this.Food_Type_Rbutton.Size = new System.Drawing.Size(181, 28);
            this.Food_Type_Rbutton.TabIndex = 51;
            this.Food_Type_Rbutton.TabStop = true;
            this.Food_Type_Rbutton.Text = "Yiyecek Türü Ekle";
            this.Food_Type_Rbutton.UseVisualStyleBackColor = true;
            this.Food_Type_Rbutton.CheckedChanged += new System.EventHandler(this.Food_Type_Rbutton_CheckedChanged);
            // 
            // Turk_Ekle2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 190);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Type_Tbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Drink_Type_Rbutton);
            this.Controls.Add(this.Food_Type_Rbutton);
            this.Name = "Turk_Ekle2";
            this.Text = "Turk_Ekle2";
            this.Load += new System.EventHandler(this.Turk_Ekle2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Type_Tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Drink_Type_Rbutton;
        private System.Windows.Forms.RadioButton Food_Type_Rbutton;
    }
}