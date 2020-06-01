namespace DataBaseManangementProject
{
    partial class Tarif
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.Amount_Numeric = new System.Windows.Forms.NumericUpDown();
            this.Recipe_List = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Material_List = new System.Windows.Forms.ListBox();
            this.Food_List = new System.Windows.Forms.ListBox();
            this.Type_Food = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RemoveButton.Location = new System.Drawing.Point(335, 251);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(131, 51);
            this.RemoveButton.TabIndex = 63;
            this.RemoveButton.Text = "<<";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(508, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 62;
            this.label4.Text = "Recipe :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Amount.Location = new System.Drawing.Point(314, 118);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(81, 22);
            this.Amount.TabIndex = 61;
            this.Amount.Text = "Amount :";
            this.Amount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Amount_Numeric
            // 
            this.Amount_Numeric.DecimalPlaces = 3;
            this.Amount_Numeric.Location = new System.Drawing.Point(426, 122);
            this.Amount_Numeric.Name = "Amount_Numeric";
            this.Amount_Numeric.Size = new System.Drawing.Size(60, 20);
            this.Amount_Numeric.TabIndex = 60;
            // 
            // Recipe_List
            // 
            this.Recipe_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Recipe_List.FormattingEnabled = true;
            this.Recipe_List.ItemHeight = 16;
            this.Recipe_List.Location = new System.Drawing.Point(512, 122);
            this.Recipe_List.Name = "Recipe_List";
            this.Recipe_List.Size = new System.Drawing.Size(182, 180);
            this.Recipe_List.TabIndex = 59;
            this.Recipe_List.DoubleClick += new System.EventHandler(this.Recipe_List_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(172, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Materials :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Foods Type :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(335, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 56;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Material_Button);
            // 
            // Material_List
            // 
            this.Material_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Material_List.FormattingEnabled = true;
            this.Material_List.ItemHeight = 16;
            this.Material_List.Location = new System.Drawing.Point(176, 122);
            this.Material_List.Name = "Material_List";
            this.Material_List.Size = new System.Drawing.Size(137, 180);
            this.Material_List.TabIndex = 55;
            this.Material_List.SelectedIndexChanged += new System.EventHandler(this.Material_List_SelectedIndexChanged);
            this.Material_List.DoubleClick += new System.EventHandler(this.Material_List_DoubleClick);
            // 
            // Food_List
            // 
            this.Food_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Food_List.FormattingEnabled = true;
            this.Food_List.ItemHeight = 16;
            this.Food_List.Location = new System.Drawing.Point(12, 122);
            this.Food_List.Name = "Food_List";
            this.Food_List.Size = new System.Drawing.Size(137, 180);
            this.Food_List.TabIndex = 54;
            this.Food_List.SelectedIndexChanged += new System.EventHandler(this.Food_List_SelectedIndexChanged);
            // 
            // Type_Food
            // 
            this.Type_Food.FormattingEnabled = true;
            this.Type_Food.Location = new System.Drawing.Point(12, 95);
            this.Type_Food.Name = "Type_Food";
            this.Type_Food.Size = new System.Drawing.Size(137, 21);
            this.Type_Food.TabIndex = 53;
            this.Type_Food.SelectedIndexChanged += new System.EventHandler(this.Type_Food_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Back.Location = new System.Drawing.Point(12, 373);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(102, 35);
            this.Back.TabIndex = 52;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Tarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 476);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Amount_Numeric);
            this.Controls.Add(this.Recipe_List);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Material_List);
            this.Controls.Add(this.Food_List);
            this.Controls.Add(this.Type_Food);
            this.Controls.Add(this.Back);
            this.Name = "Tarif";
            this.Text = "Tarif";
            this.Load += new System.EventHandler(this.Tarif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Amount_Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.NumericUpDown Amount_Numeric;
        private System.Windows.Forms.ListBox Recipe_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Material_List;
        private System.Windows.Forms.ListBox Food_List;
        private System.Windows.Forms.ComboBox Type_Food;
        private System.Windows.Forms.Button Back;
    }
}