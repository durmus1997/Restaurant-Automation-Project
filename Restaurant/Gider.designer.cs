namespace DataBaseManangementProject
{
    partial class Gider
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
            this.Material = new System.Windows.Forms.RadioButton();
            this.Drink = new System.Windows.Forms.RadioButton();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Cost = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Geri = new System.Windows.Forms.Button();
            this.Ekle_Gider = new System.Windows.Forms.Button();
            this.UrunAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cost)).BeginInit();
            this.SuspendLayout();
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Checked = true;
            this.Material.Location = new System.Drawing.Point(152, 6);
            this.Material.Margin = new System.Windows.Forms.Padding(2);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(62, 17);
            this.Material.TabIndex = 61;
            this.Material.TabStop = true;
            this.Material.Text = "Material";
            this.Material.UseVisualStyleBackColor = true;
            this.Material.CheckedChanged += new System.EventHandler(this.Material_CheckedChanged);
            // 
            // Drink
            // 
            this.Drink.AutoSize = true;
            this.Drink.Location = new System.Drawing.Point(265, 6);
            this.Drink.Margin = new System.Windows.Forms.Padding(2);
            this.Drink.Name = "Drink";
            this.Drink.Size = new System.Drawing.Size(50, 17);
            this.Drink.TabIndex = 60;
            this.Drink.Text = "Drink";
            this.Drink.UseVisualStyleBackColor = true;
            this.Drink.CheckedChanged += new System.EventHandler(this.Drink_CheckedChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(152, 97);
            this.numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(160, 20);
            this.numericUpDown.TabIndex = 59;
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(152, 45);
            this.MaterialComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(161, 21);
            this.MaterialComboBox.TabIndex = 58;
            this.MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.Material_Combo_Box);
            // 
            // numericUpDown_Cost
            // 
            this.numericUpDown_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_Cost.Location = new System.Drawing.Point(152, 140);
            this.numericUpDown_Cost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Cost.Name = "numericUpDown_Cost";
            this.numericUpDown_Cost.Size = new System.Drawing.Size(160, 30);
            this.numericUpDown_Cost.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 56;
            this.label3.Text = "Fiyat           :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "Miktar         :";
            // 
            // Geri
            // 
            this.Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Geri.Location = new System.Drawing.Point(17, 228);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(102, 35);
            this.Geri.TabIndex = 54;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // Ekle_Gider
            // 
            this.Ekle_Gider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle_Gider.Location = new System.Drawing.Point(219, 182);
            this.Ekle_Gider.Name = "Ekle_Gider";
            this.Ekle_Gider.Size = new System.Drawing.Size(102, 35);
            this.Ekle_Gider.TabIndex = 53;
            this.Ekle_Gider.Text = "Ekle Gider";
            this.Ekle_Gider.UseVisualStyleBackColor = true;
            this.Ekle_Gider.Click += new System.EventHandler(this.Ekle_Gider_Click);
            // 
            // UrunAdi
            // 
            this.UrunAdi.AutoSize = true;
            this.UrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunAdi.Location = new System.Drawing.Point(12, 40);
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Size = new System.Drawing.Size(145, 26);
            this.UrunAdi.TabIndex = 52;
            this.UrunAdi.Text = "Material Seç :";
            // 
            // Gider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 316);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.Drink);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.numericUpDown_Cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.Ekle_Gider);
            this.Controls.Add(this.UrunAdi);
            this.Name = "Gider";
            this.Text = "Gider";
            this.Load += new System.EventHandler(this.Gider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Material;
        private System.Windows.Forms.RadioButton Drink;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.NumericUpDown numericUpDown_Cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Button Ekle_Gider;
        private System.Windows.Forms.Label UrunAdi;
    }
}