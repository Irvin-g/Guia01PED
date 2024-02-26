namespace Guia1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtespaciado = new System.Windows.Forms.TextBox();
            this.cmbcolor = new System.Windows.Forms.ComboBox();
            this.areadibujo = new System.Windows.Forms.PictureBox();
            this.btndibujar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.areadibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espaciado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(112, 22);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(121, 20);
            this.txtcantidad.TabIndex = 3;
            // 
            // txtespaciado
            // 
            this.txtespaciado.Location = new System.Drawing.Point(112, 66);
            this.txtespaciado.Name = "txtespaciado";
            this.txtespaciado.Size = new System.Drawing.Size(121, 20);
            this.txtespaciado.TabIndex = 4;
            // 
            // cmbcolor
            // 
            this.cmbcolor.FormattingEnabled = true;
            this.cmbcolor.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Azul",
            "Negro"});
            this.cmbcolor.Location = new System.Drawing.Point(112, 115);
            this.cmbcolor.Name = "cmbcolor";
            this.cmbcolor.Size = new System.Drawing.Size(121, 21);
            this.cmbcolor.TabIndex = 5;
            // 
            // areadibujo
            // 
            this.areadibujo.Location = new System.Drawing.Point(366, 22);
            this.areadibujo.Name = "areadibujo";
            this.areadibujo.Size = new System.Drawing.Size(318, 186);
            this.areadibujo.TabIndex = 7;
            this.areadibujo.TabStop = false;
            // 
            // btndibujar
            // 
            this.btndibujar.Location = new System.Drawing.Point(239, 66);
            this.btndibujar.Name = "btndibujar";
            this.btndibujar.Size = new System.Drawing.Size(121, 23);
            this.btndibujar.TabIndex = 6;
            this.btndibujar.Text = "Dibujar Lineas";
            this.btndibujar.UseVisualStyleBackColor = true;
            this.btndibujar.Click += new System.EventHandler(this.btndibujar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Formulario 3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 21);
            this.button2.TabIndex = 9;
            this.button2.Text = "Complementario 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Complementario 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(691, 228);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.areadibujo);
            this.Controls.Add(this.btndibujar);
            this.Controls.Add(this.cmbcolor);
            this.Controls.Add(this.txtespaciado);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Ejercicio 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.areadibujo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtespaciado;
        private System.Windows.Forms.ComboBox cmbcolor;
        private System.Windows.Forms.PictureBox areadibujo;
        private System.Windows.Forms.Button btndibujar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}