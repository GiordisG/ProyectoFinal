namespace ProyectoFinal
{
    partial class FormProfesional
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_profesion = new System.Windows.Forms.Label();
            this.lbl_cedulaP = new System.Windows.Forms.Label();
            this.lbl_apellidoP = new System.Windows.Forms.Label();
            this.lbl_nombreP = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(27, 27);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(114, 185);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(352, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(352, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 17;
            // 
            // lbl_profesion
            // 
            this.lbl_profesion.AutoSize = true;
            this.lbl_profesion.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesion.Location = new System.Drawing.Point(264, 181);
            this.lbl_profesion.Name = "lbl_profesion";
            this.lbl_profesion.Size = new System.Drawing.Size(82, 23);
            this.lbl_profesion.TabIndex = 16;
            this.lbl_profesion.Text = "Profesion";
            // 
            // lbl_cedulaP
            // 
            this.lbl_cedulaP.AutoSize = true;
            this.lbl_cedulaP.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cedulaP.Location = new System.Drawing.Point(47, 181);
            this.lbl_cedulaP.Name = "lbl_cedulaP";
            this.lbl_cedulaP.Size = new System.Drawing.Size(61, 23);
            this.lbl_cedulaP.TabIndex = 15;
            this.lbl_cedulaP.Text = "Cedula";
            // 
            // lbl_apellidoP
            // 
            this.lbl_apellidoP.AutoSize = true;
            this.lbl_apellidoP.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoP.Location = new System.Drawing.Point(276, 124);
            this.lbl_apellidoP.Name = "lbl_apellidoP";
            this.lbl_apellidoP.Size = new System.Drawing.Size(70, 23);
            this.lbl_apellidoP.TabIndex = 14;
            this.lbl_apellidoP.Text = "Apellido";
            // 
            // lbl_nombreP
            // 
            this.lbl_nombreP.AutoSize = true;
            this.lbl_nombreP.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreP.Location = new System.Drawing.Point(47, 124);
            this.lbl_nombreP.Name = "lbl_nombreP";
            this.lbl_nombreP.Size = new System.Drawing.Size(69, 23);
            this.lbl_nombreP.TabIndex = 13;
            this.lbl_nombreP.Text = "Nombre";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(151, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(291, 35);
            this.lbl_titulo.TabIndex = 21;
            this.lbl_titulo.Text = "Cuestion de Citas";
            // 
            // FormProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 517);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_profesion);
            this.Controls.Add(this.lbl_cedulaP);
            this.Controls.Add(this.lbl_apellidoP);
            this.Controls.Add(this.lbl_nombreP);
            this.Controls.Add(this.btn_volver);
            this.Name = "FormProfesional";
            this.Text = "FormProfesional";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProfesional_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_profesion;
        private System.Windows.Forms.Label lbl_cedulaP;
        private System.Windows.Forms.Label lbl_apellidoP;
        private System.Windows.Forms.Label lbl_nombreP;
        private System.Windows.Forms.Label lbl_titulo;
    }
}