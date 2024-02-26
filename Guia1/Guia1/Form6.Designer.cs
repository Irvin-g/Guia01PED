namespace Guia1
{
    partial class Form6
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
            this.button1 = new System.Windows.Forms.Button();
            this.areadibujo = new System.Windows.Forms.PictureBox();
            this.btndibujar = new System.Windows.Forms.Button();
            this.cmbcolor = new System.Windows.Forms.ComboBox();
            this.txtespaciado = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpuntoinicioX = new System.Windows.Forms.TextBox();
            this.txtpuntofinX = new System.Windows.Forms.TextBox();
            this.txtpuntoinicioY = new System.Windows.Forms.TextBox();
            this.txtpuntofinY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.areadibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // areadibujo
            // 
            this.areadibujo.Location = new System.Drawing.Point(314, 12);
            this.areadibujo.Name = "areadibujo";
            this.areadibujo.Size = new System.Drawing.Size(239, 204);
            this.areadibujo.TabIndex = 18;
            this.areadibujo.TabStop = false;
            // 
            // btndibujar
            // 
            this.btndibujar.Location = new System.Drawing.Point(316, 252);
            this.btndibujar.Name = "btndibujar";
            this.btndibujar.Size = new System.Drawing.Size(121, 23);
            this.btndibujar.TabIndex = 17;
            this.btndibujar.Text = "Dibujar Lineas";
            this.btndibujar.UseVisualStyleBackColor = true;
            this.btndibujar.Click += new System.EventHandler(this.btndibujar_Click);
            // 
            // cmbcolor
            // 
            this.cmbcolor.FormattingEnabled = true;
            this.cmbcolor.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Azul",
            "Negro"});
            this.cmbcolor.Location = new System.Drawing.Point(105, 121);
            this.cmbcolor.Name = "cmbcolor";
            this.cmbcolor.Size = new System.Drawing.Size(121, 21);
            this.cmbcolor.TabIndex = 16;
            // 
            // txtespaciado
            // 
            this.txtespaciado.Location = new System.Drawing.Point(105, 72);
            this.txtespaciado.Name = "txtespaciado";
            this.txtespaciado.Size = new System.Drawing.Size(121, 20);
            this.txtespaciado.TabIndex = 15;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(105, 28);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(121, 20);
            this.txtcantidad.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Espaciado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Punto inicio X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Punto fin X";
            // 
            // txtpuntoinicioX
            // 
            this.txtpuntoinicioX.Location = new System.Drawing.Point(105, 183);
            this.txtpuntoinicioX.Name = "txtpuntoinicioX";
            this.txtpuntoinicioX.Size = new System.Drawing.Size(120, 20);
            this.txtpuntoinicioX.TabIndex = 22;
            // 
            // txtpuntofinX
            // 
            this.txtpuntofinX.Location = new System.Drawing.Point(105, 215);
            this.txtpuntofinX.Name = "txtpuntofinX";
            this.txtpuntofinX.Size = new System.Drawing.Size(120, 20);
            this.txtpuntofinX.TabIndex = 23;
            // 
            // txtpuntoinicioY
            // 
            this.txtpuntoinicioY.Location = new System.Drawing.Point(105, 257);
            this.txtpuntoinicioY.Name = "txtpuntoinicioY";
            this.txtpuntoinicioY.Size = new System.Drawing.Size(121, 20);
            this.txtpuntoinicioY.TabIndex = 24;
            // 
            // txtpuntofinY
            // 
            this.txtpuntofinY.Location = new System.Drawing.Point(105, 297);
            this.txtpuntofinY.Name = "txtpuntofinY";
            this.txtpuntofinY.Size = new System.Drawing.Size(120, 20);
            this.txtpuntofinY.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Punto inicio Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Punto fin Y";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(603, 335);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpuntofinY);
            this.Controls.Add(this.txtpuntoinicioY);
            this.Controls.Add(this.txtpuntofinX);
            this.Controls.Add(this.txtpuntoinicioX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.areadibujo);
            this.Controls.Add(this.btndibujar);
            this.Controls.Add(this.cmbcolor);
            this.Controls.Add(this.txtespaciado);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Complementario 2";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.areadibujo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox areadibujo;
        private System.Windows.Forms.Button btndibujar;
        private System.Windows.Forms.ComboBox cmbcolor;
        private System.Windows.Forms.TextBox txtespaciado;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpuntoinicioX;
        private System.Windows.Forms.TextBox txtpuntofinX;
        private System.Windows.Forms.TextBox txtpuntoinicioY;
        private System.Windows.Forms.TextBox txtpuntofinY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}