namespace Proyecto1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAlbum = new System.Windows.Forms.Button();
            this.btnEncendido = new System.Windows.Forms.Button();
            this.btnGeneros = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbMoneda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoneda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlbum
            // 
            this.btnAlbum.BackColor = System.Drawing.Color.IndianRed;
            this.btnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlbum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbum.Location = new System.Drawing.Point(497, 373);
            this.btnAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(95, 31);
            this.btnAlbum.TabIndex = 0;
            this.btnAlbum.Text = "Albumes";
            this.btnAlbum.UseVisualStyleBackColor = false;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnEncendido
            // 
            this.btnEncendido.BackColor = System.Drawing.Color.IndianRed;
            this.btnEncendido.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnEncendido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncendido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncendido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEncendido.Location = new System.Drawing.Point(387, 282);
            this.btnEncendido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncendido.Name = "btnEncendido";
            this.btnEncendido.Size = new System.Drawing.Size(83, 27);
            this.btnEncendido.TabIndex = 2;
            this.btnEncendido.Text = "ON/OFF";
            this.btnEncendido.UseVisualStyleBackColor = false;
            this.btnEncendido.Click += new System.EventHandler(this.btnEncendido_Click);
            // 
            // btnGeneros
            // 
            this.btnGeneros.BackColor = System.Drawing.Color.IndianRed;
            this.btnGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeneros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneros.Location = new System.Drawing.Point(264, 373);
            this.btnGeneros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeneros.Name = "btnGeneros";
            this.btnGeneros.Size = new System.Drawing.Size(93, 31);
            this.btnGeneros.TabIndex = 3;
            this.btnGeneros.Text = "Generos";
            this.btnGeneros.UseVisualStyleBackColor = false;
            this.btnGeneros.Click += new System.EventHandler(this.btnGeneros_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.Fuchsia;
            this.cmbGenero.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbGenero.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(387, 398);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(81, 24);
            this.cmbGenero.TabIndex = 4;
            this.cmbGenero.Visible = false;
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGenero_SelectedIndexChanged);
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(295, 176);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(246, 31);
            this.lblAlbum.TabIndex = 5;
            this.lblAlbum.Text = "Album seleccionado";
            this.lblAlbum.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbMoneda
            // 
            this.pbMoneda.BackColor = System.Drawing.Color.Transparent;
            this.pbMoneda.BackgroundImage = global::Proyecto1.Properties.Resources.coin;
            this.pbMoneda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMoneda.Location = new System.Drawing.Point(730, 591);
            this.pbMoneda.Name = "pbMoneda";
            this.pbMoneda.Size = new System.Drawing.Size(98, 83);
            this.pbMoneda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMoneda.TabIndex = 6;
            this.pbMoneda.TabStop = false;
            this.pbMoneda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMoneda_MouseDown);
            this.pbMoneda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMoneda_MouseMove);
            this.pbMoneda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMoneda_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.WhatsApp_Image_2023_06_21_at_20_22_37;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 750);
            this.Controls.Add(this.pbMoneda);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnGeneros);
            this.Controls.Add(this.btnEncendido);
            this.Controls.Add(this.btnAlbum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(871, 798);
            this.MinimumSize = new System.Drawing.Size(871, 717);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Juke Box Recommendations";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMoneda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Button btnEncendido;
        private System.Windows.Forms.Button btnGeneros;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbMoneda;
    }
}

