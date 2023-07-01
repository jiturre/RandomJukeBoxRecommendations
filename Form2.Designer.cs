namespace Proyecto1
{
    partial class Form2
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.pbMedio = new System.Windows.Forms.PictureBox();
            this.pbDerecha = new System.Windows.Forms.PictureBox();
            this.pbIzquierda = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDerecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIzquierda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(179)))));
            this.btnVolver.Location = new System.Drawing.Point(32, 651);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(160, 67);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            this.btnVolver.MouseLeave += new System.EventHandler(this.btnVolver_MouseLeave);
            this.btnVolver.MouseHover += new System.EventHandler(this.btnVolver_MouseHover);
            // 
            // pbMedio
            // 
            this.pbMedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMedio.Location = new System.Drawing.Point(427, 75);
            this.pbMedio.Name = "pbMedio";
            this.pbMedio.Size = new System.Drawing.Size(300, 485);
            this.pbMedio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMedio.TabIndex = 2;
            this.pbMedio.TabStop = false;
            // 
            // pbDerecha
            // 
            this.pbDerecha.Location = new System.Drawing.Point(790, 75);
            this.pbDerecha.Name = "pbDerecha";
            this.pbDerecha.Size = new System.Drawing.Size(300, 485);
            this.pbDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDerecha.TabIndex = 3;
            this.pbDerecha.TabStop = false;
            // 
            // pbIzquierda
            // 
            this.pbIzquierda.Location = new System.Drawing.Point(59, 75);
            this.pbIzquierda.Name = "pbIzquierda";
            this.pbIzquierda.Size = new System.Drawing.Size(300, 485);
            this.pbIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIzquierda.TabIndex = 4;
            this.pbIzquierda.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(499, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Album Seleccionado";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1130, 751);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbIzquierda);
            this.Controls.Add(this.pbDerecha);
            this.Controls.Add(this.pbMedio);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbMedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDerecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIzquierda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pbMedio;
        private System.Windows.Forms.PictureBox pbDerecha;
        private System.Windows.Forms.PictureBox pbIzquierda;
        private System.Windows.Forms.Label label1;
    }
}