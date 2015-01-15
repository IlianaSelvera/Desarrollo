namespace ProyectoPrueba
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
            this.lblHola = new System.Windows.Forms.Label();
            this.btnHola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.Location = new System.Drawing.Point(98, 68);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(71, 13);
            this.lblHola.TabIndex = 0;
            this.lblHola.Text = "Hola Mundo !";
            this.lblHola.Visible = false;
            // 
            // btnHola
            // 
            this.btnHola.Location = new System.Drawing.Point(94, 135);
            this.btnHola.Name = "btnHola";
            this.btnHola.Size = new System.Drawing.Size(75, 23);
            this.btnHola.TabIndex = 1;
            this.btnHola.Text = "Mensaje";
            this.btnHola.UseVisualStyleBackColor = true;
            this.btnHola.Click += new System.EventHandler(this.btnHola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnHola);
            this.Controls.Add(this.lblHola);
            this.Name = "Form1";
            this.Text = "Hola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHola;
        private System.Windows.Forms.Button btnHola;
    }
}

