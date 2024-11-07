namespace ProjetWindowsForms
{
    partial class DemoForm
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
            this.txtNb1 = new System.Windows.Forms.TextBox();
            this.txtNb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNb1
            // 
            this.txtNb1.Location = new System.Drawing.Point(205, 89);
            this.txtNb1.Name = "txtNb1";
            this.txtNb1.Size = new System.Drawing.Size(100, 20);
            this.txtNb1.TabIndex = 0;
            // 
            // txtNb2
            // 
            this.txtNb2.Location = new System.Drawing.Point(205, 129);
            this.txtNb2.Name = "txtNb2";
            this.txtNb2.Size = new System.Drawing.Size(100, 20);
            this.txtNb2.TabIndex = 1;
            this.txtNb2.TextChanged += new System.EventHandler(this.txtNb2_TextChanged);
            this.txtNb2.Leave += new System.EventHandler(this.txtNb2_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre2:";
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(215, 180);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 4;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(226, 240);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(54, 13);
            this.lblResultat.TabIndex = 5;
            this.lblResultat.Text = "Somme = ";
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 488);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNb2);
            this.Controls.Add(this.txtNb1);
            this.Name = "DemoForm";
            this.Text = "DemoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNb1;
        private System.Windows.Forms.TextBox txtNb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Label lblResultat;
    }
}