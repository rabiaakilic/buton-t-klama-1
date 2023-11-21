namespace buton_tıklama_1__1359
{
    partial class Form1
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
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lbAdlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(12, 63);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(116, 20);
            this.txtAranan.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(148, 52);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(109, 41);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lbAdlar
            // 
            this.lbAdlar.FormattingEnabled = true;
            this.lbAdlar.Items.AddRange(new object[] {
            "kübra ",
            "rabia",
            "deniz",
            "sükeyna",
            "esma",
            "hira",
            "elif",
            "ilayda ",
            "zeynep",
            "hayri",
            "pelin",
            "melek"});
            this.lbAdlar.Location = new System.Drawing.Point(47, 123);
            this.lbAdlar.Name = "lbAdlar";
            this.lbAdlar.Size = new System.Drawing.Size(159, 290);
            this.lbAdlar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.lbAdlar);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAranan);
            this.Name = "Form1";
            this.Text = "ara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ListBox lbAdlar;
    }
}

