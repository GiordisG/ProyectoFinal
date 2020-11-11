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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_seleccionfecha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txb_cedula = new System.Windows.Forms.TextBox();
            this.txb_apellido = new System.Windows.Forms.TextBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.btn_realizarCita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lbl_tituloFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(123, 25);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(239, 28);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Cuestion de Citas";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(18, 134);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(74, 23);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(229, 134);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(78, 23);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cedula.Location = new System.Drawing.Point(28, 192);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(64, 23);
            this.lbl_cedula.TabIndex = 3;
            this.lbl_cedula.Text = "Cedula";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(242, 188);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(80, 23);
            this.lbl_telefono.TabIndex = 4;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_seleccionfecha
            // 
            this.lbl_seleccionfecha.AutoSize = true;
            this.lbl_seleccionfecha.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccionfecha.Location = new System.Drawing.Point(18, 317);
            this.lbl_seleccionfecha.Name = "lbl_seleccionfecha";
            this.lbl_seleccionfecha.Size = new System.Drawing.Size(56, 23);
            this.lbl_seleccionfecha.TabIndex = 5;
            this.lbl_seleccionfecha.Text = "Fecha";
            this.lbl_seleccionfecha.Click += new System.EventHandler(this.lbl_seleccionfecha_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 7;
            // 
            // txb_cedula
            // 
            this.txb_cedula.Location = new System.Drawing.Point(98, 192);
            this.txb_cedula.Name = "txb_cedula";
            this.txb_cedula.Size = new System.Drawing.Size(129, 20);
            this.txb_cedula.TabIndex = 8;
            this.txb_cedula.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txb_apellido
            // 
            this.txb_apellido.Location = new System.Drawing.Point(313, 138);
            this.txb_apellido.Name = "txb_apellido";
            this.txb_apellido.Size = new System.Drawing.Size(130, 20);
            this.txb_apellido.TabIndex = 9;
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(98, 138);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(125, 20);
            this.txb_nombre.TabIndex = 10;
            // 
            // btn_realizarCita
            // 
            this.btn_realizarCita.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_realizarCita.Location = new System.Drawing.Point(164, 378);
            this.btn_realizarCita.Name = "btn_realizarCita";
            this.btn_realizarCita.Size = new System.Drawing.Size(158, 55);
            this.btn_realizarCita.TabIndex = 11;
            this.btn_realizarCita.Text = "Realizar Cita";
            this.btn_realizarCita.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hora";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 320);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(18, 85);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(223, 28);
            this.lbl_.TabIndex = 20;
            this.lbl_.Text = "DATOS PERSONALES";
            // 
            // lbl_tituloFecha
            // 
            this.lbl_tituloFecha.AutoSize = true;
            this.lbl_tituloFecha.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloFecha.Location = new System.Drawing.Point(18, 258);
            this.lbl_tituloFecha.Name = "lbl_tituloFecha";
            this.lbl_tituloFecha.Size = new System.Drawing.Size(220, 28);
            this.lbl_tituloFecha.TabIndex = 21;
            this.lbl_tituloFecha.Text = "PROGRAMAR FECHA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 466);
            this.Controls.Add(this.lbl_tituloFecha);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_realizarCita);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.txb_apellido);
            this.Controls.Add(this.txb_cedula);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_seleccionfecha);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_cedula);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_seleccionfecha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txb_cedula;
        private System.Windows.Forms.TextBox txb_apellido;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.Button btn_realizarCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lbl_tituloFecha;
    }
}

