namespace ProyectoFinal
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.cbx_seccion = new System.Windows.Forms.ComboBox();
            this.lbl_seccion = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(134, 26);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(239, 28);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Cuestion de Citas";
            // 
            // cbx_seccion
            // 
            this.cbx_seccion.FormattingEnabled = true;
            this.cbx_seccion.Items.AddRange(new object[] {
            "CLIENTE",
            "PROFESIONAL"});
            this.cbx_seccion.Location = new System.Drawing.Point(174, 163);
            this.cbx_seccion.Name = "cbx_seccion";
            this.cbx_seccion.Size = new System.Drawing.Size(147, 21);
            this.cbx_seccion.TabIndex = 1;
            // 
            // lbl_seccion
            // 
            this.lbl_seccion.AutoSize = true;
            this.lbl_seccion.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seccion.Location = new System.Drawing.Point(127, 92);
            this.lbl_seccion.Name = "lbl_seccion";
            this.lbl_seccion.Size = new System.Drawing.Size(246, 40);
            this.lbl_seccion.TabIndex = 2;
            this.lbl_seccion.Text = "Escoger Seccion";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Location = new System.Drawing.Point(202, 211);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(98, 42);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 291);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.lbl_seccion);
            this.Controls.Add(this.cbx_seccion);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ComboBox cbx_seccion;
        private System.Windows.Forms.Label lbl_seccion;
        private System.Windows.Forms.Button btn_ingresar;
    }
}

