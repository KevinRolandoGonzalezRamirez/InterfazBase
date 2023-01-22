namespace Launcher
{
    partial class claseDePrueba
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
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearArchivo.Location = new System.Drawing.Point(47, 66);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrearArchivo.Size = new System.Drawing.Size(296, 45);
            this.btnCrearArchivo.TabIndex = 0;
            this.btnCrearArchivo.Text = "Crear Archivo";
            this.btnCrearArchivo.UseVisualStyleBackColor = true;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // claseDePrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearArchivo);
            this.Name = "claseDePrueba";
            this.Text = "claseDePrueba";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearArchivo;
    }
}