namespace DataBaseManangementProject
{
    partial class Materyal_Ekle
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
            this.Back = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Add_Material_Tbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Piece_Rbutton = new System.Windows.Forms.RadioButton();
            this.Kg_Rbutton = new System.Windows.Forms.RadioButton();
            this.Kg__Numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Piece_Numeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Kg__Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piece_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Back.Location = new System.Drawing.Point(18, 220);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(102, 35);
            this.Back.TabIndex = 39;
            this.Back.Text = "Geri";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Add.Location = new System.Drawing.Point(210, 180);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(102, 35);
            this.Add.TabIndex = 38;
            this.Add.Text = "Ekle";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Add_Material_Tbox
            // 
            this.Add_Material_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Add_Material_Tbox.Location = new System.Drawing.Point(152, 30);
            this.Add_Material_Tbox.Name = "Add_Material_Tbox";
            this.Add_Material_Tbox.Size = new System.Drawing.Size(160, 29);
            this.Add_Material_Tbox.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ürünün Adı :";
            // 
            // Piece_Rbutton
            // 
            this.Piece_Rbutton.AutoSize = true;
            this.Piece_Rbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Piece_Rbutton.Location = new System.Drawing.Point(14, 132);
            this.Piece_Rbutton.Name = "Piece_Rbutton";
            this.Piece_Rbutton.Size = new System.Drawing.Size(82, 28);
            this.Piece_Rbutton.TabIndex = 43;
            this.Piece_Rbutton.TabStop = true;
            this.Piece_Rbutton.Text = "Tane :";
            this.Piece_Rbutton.UseVisualStyleBackColor = true;
            this.Piece_Rbutton.CheckedChanged += new System.EventHandler(this.Piece_Rbutton_CheckedChanged);
            // 
            // Kg_Rbutton
            // 
            this.Kg_Rbutton.AutoSize = true;
            this.Kg_Rbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kg_Rbutton.Location = new System.Drawing.Point(18, 85);
            this.Kg_Rbutton.Name = "Kg_Rbutton";
            this.Kg_Rbutton.Size = new System.Drawing.Size(79, 28);
            this.Kg_Rbutton.TabIndex = 44;
            this.Kg_Rbutton.TabStop = true;
            this.Kg_Rbutton.Text = "KG    :";
            this.Kg_Rbutton.UseVisualStyleBackColor = true;
            this.Kg_Rbutton.CheckedChanged += new System.EventHandler(this.Kg_Rbutton_CheckedChanged);
            // 
            // Kg__Numeric
            // 
            this.Kg__Numeric.DecimalPlaces = 3;
            this.Kg__Numeric.Location = new System.Drawing.Point(103, 93);
            this.Kg__Numeric.Name = "Kg__Numeric";
            this.Kg__Numeric.Size = new System.Drawing.Size(62, 20);
            this.Kg__Numeric.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(171, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "( lütfen virgül kullanın! )";
            // 
            // Piece_Numeric
            // 
            this.Piece_Numeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Piece_Numeric.Location = new System.Drawing.Point(103, 140);
            this.Piece_Numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Piece_Numeric.Name = "Piece_Numeric";
            this.Piece_Numeric.Size = new System.Drawing.Size(62, 20);
            this.Piece_Numeric.TabIndex = 47;
            // 
            // Materyal_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 282);
            this.Controls.Add(this.Piece_Numeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kg__Numeric);
            this.Controls.Add(this.Kg_Rbutton);
            this.Controls.Add(this.Piece_Rbutton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Add_Material_Tbox);
            this.Controls.Add(this.label2);
            this.Name = "Materyal_Ekle";
            this.Text = "Materyal_Ekle";
            this.Load += new System.EventHandler(this.Materyal_Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kg__Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piece_Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Add_Material_Tbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Piece_Rbutton;
        private System.Windows.Forms.RadioButton Kg_Rbutton;
        private System.Windows.Forms.NumericUpDown Kg__Numeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Piece_Numeric;
    }
}