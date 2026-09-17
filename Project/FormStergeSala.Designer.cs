namespace Project
{
    partial class FormStergeSala
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
            this.btnStergeSala = new System.Windows.Forms.Button();
            this.cmbSaliDeSters = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnStergeSala
            // 
            this.btnStergeSala.Location = new System.Drawing.Point(13, 43);
            this.btnStergeSala.Name = "btnStergeSala";
            this.btnStergeSala.Size = new System.Drawing.Size(75, 23);
            this.btnStergeSala.TabIndex = 0;
            this.btnStergeSala.Text = "Sterge";
            this.btnStergeSala.UseVisualStyleBackColor = true;
            this.btnStergeSala.Click += new System.EventHandler(this.btnStergeSala_Click);
            // 
            // cmbSaliDeSters
            // 
            this.cmbSaliDeSters.FormattingEnabled = true;
            this.cmbSaliDeSters.Location = new System.Drawing.Point(13, 13);
            this.cmbSaliDeSters.Name = "cmbSaliDeSters";
            this.cmbSaliDeSters.Size = new System.Drawing.Size(121, 21);
            this.cmbSaliDeSters.TabIndex = 1;
            // 
            // FormStergeSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 109);
            this.Controls.Add(this.cmbSaliDeSters);
            this.Controls.Add(this.btnStergeSala);
            this.Name = "FormStergeSala";
            this.Text = "FormStergeSala";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStergeSala;
        private System.Windows.Forms.ComboBox cmbSaliDeSters;
    }
}