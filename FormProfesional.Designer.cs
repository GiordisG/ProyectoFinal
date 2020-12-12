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
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_cedulaP = new System.Windows.Forms.Label();
            this.lbl_apellidoP = new System.Windows.Forms.Label();
            this.lbl_nombreP = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dataTable_profesional = new System.Windows.Forms.DataGridView();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_realizar = new System.Windows.Forms.Button();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_profesion = new System.Windows.Forms.Label();
            this.txt_profesion = new System.Windows.Forms.TextBox();
            this.listbox_disponibilidad = new System.Windows.Forms.CheckedListBox();
            this.lbl_disponibilidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_profesional)).BeginInit();
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
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(185, 208);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(134, 20);
            this.txt_cedula.TabIndex = 20;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(130, 147);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(148, 20);
            this.txt_nombre.TabIndex = 19;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(360, 149);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(145, 20);
            this.txt_apellido.TabIndex = 18;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(602, 147);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(115, 20);
            this.txt_telefono.TabIndex = 17;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(522, 147);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(74, 23);
            this.lbl_telefono.TabIndex = 16;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_cedulaP
            // 
            this.lbl_cedulaP.AutoSize = true;
            this.lbl_cedulaP.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cedulaP.Location = new System.Drawing.Point(118, 204);
            this.lbl_cedulaP.Name = "lbl_cedulaP";
            this.lbl_cedulaP.Size = new System.Drawing.Size(61, 23);
            this.lbl_cedulaP.TabIndex = 15;
            this.lbl_cedulaP.Text = "Cedula";
            // 
            // lbl_apellidoP
            // 
            this.lbl_apellidoP.AutoSize = true;
            this.lbl_apellidoP.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoP.Location = new System.Drawing.Point(284, 145);
            this.lbl_apellidoP.Name = "lbl_apellidoP";
            this.lbl_apellidoP.Size = new System.Drawing.Size(70, 23);
            this.lbl_apellidoP.TabIndex = 14;
            this.lbl_apellidoP.Text = "Apellido";
            // 
            // lbl_nombreP
            // 
            this.lbl_nombreP.AutoSize = true;
            this.lbl_nombreP.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreP.Location = new System.Drawing.Point(55, 145);
            this.lbl_nombreP.Name = "lbl_nombreP";
            this.lbl_nombreP.Size = new System.Drawing.Size(69, 23);
            this.lbl_nombreP.TabIndex = 13;
            this.lbl_nombreP.Text = "Nombre";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(235, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(291, 35);
            this.lbl_titulo.TabIndex = 21;
            this.lbl_titulo.Text = "Cuestion de Citas";
            // 
            // dataTable_profesional
            // 
            this.dataTable_profesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable_profesional.Location = new System.Drawing.Point(11, 371);
            this.dataTable_profesional.Name = "dataTable_profesional";
            this.dataTable_profesional.Size = new System.Drawing.Size(753, 222);
            this.dataTable_profesional.TabIndex = 22;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.Location = new System.Drawing.Point(139, 323);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(93, 42);
            this.btn_seleccionar.TabIndex = 32;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(351, 330);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 35);
            this.btn_eliminar.TabIndex = 31;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(255, 330);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 35);
            this.btn_modificar.TabIndex = 30;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_realizar
            // 
            this.btn_realizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_realizar.Location = new System.Drawing.Point(11, 312);
            this.btn_realizar.Name = "btn_realizar";
            this.btn_realizar.Size = new System.Drawing.Size(107, 53);
            this.btn_realizar.TabIndex = 29;
            this.btn_realizar.Text = "Realizar";
            this.btn_realizar.UseVisualStyleBackColor = true;
            this.btn_realizar.Click += new System.EventHandler(this.btn_realizar_Click);
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(54, 84);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(290, 30);
            this.lbl_cliente.TabIndex = 33;
            this.lbl_cliente.Text = "informacion del profesional";
            // 
            // lbl_profesion
            // 
            this.lbl_profesion.AutoSize = true;
            this.lbl_profesion.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesion.Location = new System.Drawing.Point(350, 205);
            this.lbl_profesion.Name = "lbl_profesion";
            this.lbl_profesion.Size = new System.Drawing.Size(82, 23);
            this.lbl_profesion.TabIndex = 34;
            this.lbl_profesion.Text = "Profesion";
            // 
            // txt_profesion
            // 
            this.txt_profesion.Location = new System.Drawing.Point(438, 208);
            this.txt_profesion.Name = "txt_profesion";
            this.txt_profesion.Size = new System.Drawing.Size(134, 20);
            this.txt_profesion.TabIndex = 35;
            // 
            // listbox_disponibilidad
            // 
            this.listbox_disponibilidad.FormattingEnabled = true;
            this.listbox_disponibilidad.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.listbox_disponibilidad.Location = new System.Drawing.Point(602, 246);
            this.listbox_disponibilidad.Name = "listbox_disponibilidad";
            this.listbox_disponibilidad.Size = new System.Drawing.Size(120, 94);
            this.listbox_disponibilidad.TabIndex = 36;
            // 
            // lbl_disponibilidad
            // 
            this.lbl_disponibilidad.AutoSize = true;
            this.lbl_disponibilidad.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disponibilidad.Location = new System.Drawing.Point(598, 204);
            this.lbl_disponibilidad.Name = "lbl_disponibilidad";
            this.lbl_disponibilidad.Size = new System.Drawing.Size(132, 23);
            this.lbl_disponibilidad.TabIndex = 37;
            this.lbl_disponibilidad.Text = "Dias disponibles";
            // 
            // FormProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 604);
            this.Controls.Add(this.lbl_disponibilidad);
            this.Controls.Add(this.listbox_disponibilidad);
            this.Controls.Add(this.txt_profesion);
            this.Controls.Add(this.lbl_profesion);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_realizar);
            this.Controls.Add(this.dataTable_profesional);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_cedulaP);
            this.Controls.Add(this.lbl_apellidoP);
            this.Controls.Add(this.lbl_nombreP);
            this.Controls.Add(this.btn_volver);
            this.Name = "FormProfesional";
            this.Text = "FormProfesional";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProfesional_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_profesional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_cedulaP;
        private System.Windows.Forms.Label lbl_apellidoP;
        private System.Windows.Forms.Label lbl_nombreP;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView dataTable_profesional;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_realizar;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_profesion;
        private System.Windows.Forms.TextBox txt_profesion;
        private System.Windows.Forms.CheckedListBox listbox_disponibilidad;
        private System.Windows.Forms.Label lbl_disponibilidad;
    }
}