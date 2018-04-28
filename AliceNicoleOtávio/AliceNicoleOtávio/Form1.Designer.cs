namespace AliceNicoleOtávio
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
            this.btnVetor = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVetor
            // 
            this.btnVetor.Location = new System.Drawing.Point(24, 81);
            this.btnVetor.Name = "btnVetor";
            this.btnVetor.Size = new System.Drawing.Size(229, 23);
            this.btnVetor.TabIndex = 0;
            this.btnVetor.Text = "Exercicio 1";
            this.btnVetor.UseVisualStyleBackColor = true;
            this.btnVetor.Click += new System.EventHandler(this.btnVetor_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(24, 154);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(229, 23);
            this.btnMatriz.TabIndex = 1;
            this.btnMatriz.Text = "Exercicio 2";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.btnVetor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVetor;
        private System.Windows.Forms.Button btnMatriz;
    }
}

