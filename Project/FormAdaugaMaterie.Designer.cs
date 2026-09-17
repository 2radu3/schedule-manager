namespace Project
{
    partial class FormAdaugaMaterie
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
            this.tbAdaugaMaterie = new System.Windows.Forms.TextBox();
            this.btnAdaugaMaterie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAdaugaMaterie
            // 
            this.tbAdaugaMaterie.Location = new System.Drawing.Point(13, 23);
            this.tbAdaugaMaterie.Name = "tbAdaugaMaterie";
            this.tbAdaugaMaterie.Size = new System.Drawing.Size(100, 20);
            this.tbAdaugaMaterie.TabIndex = 0;
            // 
            // btnAdaugaMaterie
            // 
            this.btnAdaugaMaterie.Location = new System.Drawing.Point(13, 49);
            this.btnAdaugaMaterie.Name = "btnAdaugaMaterie";
            this.btnAdaugaMaterie.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaMaterie.TabIndex = 1;
            this.btnAdaugaMaterie.Text = "Adauga";
            this.btnAdaugaMaterie.UseVisualStyleBackColor = true;
            this.btnAdaugaMaterie.Click += new System.EventHandler(this.btnAdaugaMaterie_Click);
            // 
            // FormAdaugaMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 120);
            this.Controls.Add(this.btnAdaugaMaterie);
            this.Controls.Add(this.tbAdaugaMaterie);
            this.Name = "FormAdaugaMaterie";
            this.Text = "FormAdaugaMaterie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAdaugaMaterie;
        private System.Windows.Forms.Button btnAdaugaMaterie;
    }
}