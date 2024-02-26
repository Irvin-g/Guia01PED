namespace Guia1
{
    partial class Form7
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
            this.timermov = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 287);
            this.Name = "Form7";
            this.Text = "Gusanito";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form7_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form7_KeyDown_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timermov;
    }
}