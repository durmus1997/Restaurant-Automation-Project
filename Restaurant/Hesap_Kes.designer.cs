namespace DataBaseManangementProject
{
    partial class Hesap_Kes
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
            this.Result = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Food_List = new System.Windows.Forms.ListBox();
            this.Cost_List = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Cut_Bill = new System.Windows.Forms.Button();
            this.Search_Table_Tbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Back.Location = new System.Drawing.Point(12, 195);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(102, 35);
            this.Back.TabIndex = 39;
            this.Back.Text = "Geri";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Result.Location = new System.Drawing.Point(185, 88);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(102, 35);
            this.Result.TabIndex = 38;
            this.Result.Text = "Sorgula";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "Masa Numarası :";
            // 
            // Food_List
            // 
            this.Food_List.FormattingEnabled = true;
            this.Food_List.Location = new System.Drawing.Point(332, 25);
            this.Food_List.Name = "Food_List";
            this.Food_List.Size = new System.Drawing.Size(142, 160);
            this.Food_List.TabIndex = 41;
            // 
            // Cost_List
            // 
            this.Cost_List.FormattingEnabled = true;
            this.Cost_List.Location = new System.Drawing.Point(496, 25);
            this.Cost_List.Name = "Cost_List";
            this.Cost_List.Size = new System.Drawing.Size(87, 160);
            this.Cost_List.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(356, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Toplam = ";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Total.Location = new System.Drawing.Point(491, 211);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(19, 26);
            this.Total.TabIndex = 44;
            this.Total.Text = " ";
            // 
            // Cut_Bill
            // 
            this.Cut_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cut_Bill.Location = new System.Drawing.Point(627, 31);
            this.Cut_Bill.Name = "Cut_Bill";
            this.Cut_Bill.Size = new System.Drawing.Size(101, 35);
            this.Cut_Bill.TabIndex = 45;
            this.Cut_Bill.Text = "Hesap Kes";
            this.Cut_Bill.UseVisualStyleBackColor = true;
            this.Cut_Bill.Click += new System.EventHandler(this.Cut_Bill_Click);
            // 
            // Search_Table_Tbox
            // 
            this.Search_Table_Tbox.FormattingEnabled = true;
            this.Search_Table_Tbox.Location = new System.Drawing.Point(198, 30);
            this.Search_Table_Tbox.Name = "Search_Table_Tbox";
            this.Search_Table_Tbox.Size = new System.Drawing.Size(78, 21);
            this.Search_Table_Tbox.TabIndex = 46;
            // 
            // Hesap_Kes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 242);
            this.Controls.Add(this.Search_Table_Tbox);
            this.Controls.Add(this.Cut_Bill);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cost_List);
            this.Controls.Add(this.Food_List);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Name = "Hesap_Kes";
            this.Text = "Hesap_Kes";
            this.Load += new System.EventHandler(this.Hesap_Kes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Food_List;
        private System.Windows.Forms.ListBox Cost_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button Cut_Bill;
        private System.Windows.Forms.ComboBox Search_Table_Tbox;
    }
}