namespace ProyectoFinal
{
    partial class FormCliente
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.lbl_tipoDoc = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_encuestro = new System.Windows.Forms.Label();
            this.lbl_profesional = new System.Windows.Forms.Label();
            this.lbl_estadoCita = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_cita = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(17, 17);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 0;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(13, 124);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(69, 23);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(256, 127);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(70, 23);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cedula.Location = new System.Drawing.Point(21, 185);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(61, 23);
            this.lbl_cedula.TabIndex = 3;
            this.lbl_cedula.Text = "Cedula";
            // 
            // lbl_tipoDoc
            // 
            this.lbl_tipoDoc.AutoSize = true;
            this.lbl_tipoDoc.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoDoc.Location = new System.Drawing.Point(256, 185);
            this.lbl_tipoDoc.Name = "lbl_tipoDoc";
            this.lbl_tipoDoc.Size = new System.Drawing.Size(150, 23);
            this.lbl_tipoDoc.TabIndex = 4;
            this.lbl_tipoDoc.Text = "Tipo de documento";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(12, 73);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(244, 30);
            this.lbl_cliente.TabIndex = 6;
            this.lbl_cliente.Text = "informacion del cliente";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(386, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Realizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(412, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(332, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(88, 189);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 20);
            this.textBox5.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 349);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // lbl_encuestro
            // 
            this.lbl_encuestro.AutoSize = true;
            this.lbl_encuestro.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_encuestro.Location = new System.Drawing.Point(21, 346);
            this.lbl_encuestro.Name = "lbl_encuestro";
            this.lbl_encuestro.Size = new System.Drawing.Size(153, 23);
            this.lbl_encuestro.TabIndex = 14;
            this.lbl_encuestro.Text = "Fecha de encuentro";
            // 
            // lbl_profesional
            // 
            this.lbl_profesional.AutoSize = true;
            this.lbl_profesional.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesional.Location = new System.Drawing.Point(123, 240);
            this.lbl_profesional.Name = "lbl_profesional";
            this.lbl_profesional.Size = new System.Drawing.Size(96, 23);
            this.lbl_profesional.TabIndex = 15;
            this.lbl_profesional.Text = "Profesional";
            this.lbl_profesional.Click += new System.EventHandler(this.lbl_profesional_Click);
            // 
            // lbl_estadoCita
            // 
            this.lbl_estadoCita.AutoSize = true;
            this.lbl_estadoCita.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoCita.Location = new System.Drawing.Point(408, 246);
            this.lbl_estadoCita.Name = "lbl_estadoCita";
            this.lbl_estadoCita.Size = new System.Drawing.Size(107, 19);
            this.lbl_estadoCita.TabIndex = 16;
            this.lbl_estadoCita.Text = "Estado de la cita";
            this.lbl_estadoCita.Click += new System.EventHandler(this.lbl_estadoCita_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(175, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(239, 28);
            this.lbl_titulo.TabIndex = 18;
            this.lbl_titulo.Text = "Cuestion de Citas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 200);
            this.dataGridView1.TabIndex = 19;
            // 
            // lbl_cita
            // 
            this.lbl_cita.AutoSize = true;
            this.lbl_cita.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cita.Location = new System.Drawing.Point(20, 296);
            this.lbl_cita.Name = "lbl_cita";
            this.lbl_cita.Size = new System.Drawing.Size(52, 30);
            this.lbl_cita.TabIndex = 20;
            this.lbl_cita.Text = "Cita";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 244);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(499, 320);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 35);
            this.btn_modificar.TabIndex = 22;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(499, 361);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 35);
            this.btn_eliminar.TabIndex = 23;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Estado";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_cita);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_estadoCita);
            this.Controls.Add(this.lbl_profesional);
            this.Controls.Add(this.lbl_encuestro);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_tipoDoc);
            this.Controls.Add(this.lbl_cedula);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_volver);
            this.Name = "FormCliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCliente_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.Label lbl_tipoDoc;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_encuestro;
        private System.Windows.Forms.Label lbl_profesional;
        private System.Windows.Forms.Label lbl_estadoCita;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_cita;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label1;
    }
}