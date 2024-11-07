namespace ProjetWindowsForms
{
    partial class FichierForm
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
            this.txtEcriture = new System.Windows.Forms.TextBox();
            this.txtLecture = new System.Windows.Forms.TextBox();
            this.btnEcriture = new System.Windows.Forms.Button();
            this.btnLecture = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtEcriture
            // 
            this.txtEcriture.Location = new System.Drawing.Point(68, 24);
            this.txtEcriture.Multiline = true;
            this.txtEcriture.Name = "txtEcriture";
            this.txtEcriture.Size = new System.Drawing.Size(386, 264);
            this.txtEcriture.TabIndex = 0;
            // 
            // txtLecture
            // 
            this.txtLecture.Location = new System.Drawing.Point(68, 304);
            this.txtLecture.Multiline = true;
            this.txtLecture.Name = "txtLecture";
            this.txtLecture.ReadOnly = true;
            this.txtLecture.Size = new System.Drawing.Size(386, 264);
            this.txtLecture.TabIndex = 1;
            // 
            // btnEcriture
            // 
            this.btnEcriture.Location = new System.Drawing.Point(589, 129);
            this.btnEcriture.Name = "btnEcriture";
            this.btnEcriture.Size = new System.Drawing.Size(191, 23);
            this.btnEcriture.TabIndex = 2;
            this.btnEcriture.Text = "Ecriture Fichier";
            this.btnEcriture.UseVisualStyleBackColor = true;
            this.btnEcriture.Click += new System.EventHandler(this.btnEcriture_Click);
            // 
            // btnLecture
            // 
            this.btnLecture.Location = new System.Drawing.Point(589, 441);
            this.btnLecture.Name = "btnLecture";
            this.btnLecture.Size = new System.Drawing.Size(191, 23);
            this.btnLecture.TabIndex = 3;
            this.btnLecture.Text = "Lecture Fichier";
            this.btnLecture.UseVisualStyleBackColor = true;
            this.btnLecture.Click += new System.EventHandler(this.btnLecture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FichierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 606);
            this.Controls.Add(this.btnLecture);
            this.Controls.Add(this.btnEcriture);
            this.Controls.Add(this.txtLecture);
            this.Controls.Add(this.txtEcriture);
            this.Name = "FichierForm";
            this.Text = "FichierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEcriture;
        private System.Windows.Forms.TextBox txtLecture;
        private System.Windows.Forms.Button btnEcriture;
        private System.Windows.Forms.Button btnLecture;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}