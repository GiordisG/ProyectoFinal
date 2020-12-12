
namespace ProyectoFinal
{
    partial class Cita
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
            this.lbl_cit = new System.Windows.Forms.Label();
            this.lbl_profesional = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.dp_cita = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.cmb_profesional = new System.Windows.Forms.ComboBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_realizar = new System.Windows.Forms.Button();
            this.dataTable_cita = new System.Windows.Forms.DataGridView();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_estadoCita = new System.Windows.Forms.Label();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_cita)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(240, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(322, 41);
            this.lbl_titulo.TabIndex = 33;
            this.lbl_titulo.Text = "Cuestion de Citas";
            // 
            // lbl_cit
            // 
            this.lbl_cit.AutoSize = true;
            this.lbl_cit.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cit.Location = new System.Drawing.Point(346, 93);
            this.lbl_cit.Name = "lbl_cit";
            this.lbl_cit.Size = new System.Drawing.Size(139, 30);
            this.lbl_cit.TabIndex = 30;
            this.lbl_cit.Text = "Realizar Cita";
            // 
            // lbl_profesional
            // 
            this.lbl_profesional.AutoSize = true;
            this.lbl_profesional.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesional.Location = new System.Drawing.Point(269, 168);
            this.lbl_profesional.Name = "lbl_profesional";
            this.lbl_profesional.Size = new System.Drawing.Size(96, 23);
            this.lbl_profesional.TabIndex = 29;
            this.lbl_profesional.Text = "Profesional";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(76, 168);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(62, 23);
            this.lbl_cliente.TabIndex = 28;
            this.lbl_cliente.Text = "Cliente";
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(44, 34);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 27;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // dp_cita
            // 
            this.dp_cita.Location = new System.Drawing.Point(428, 198);
            this.dp_cita.Name = "dp_cita";
            this.dp_cita.Size = new System.Drawing.Size(200, 20);
            this.dp_cita.TabIndex = 34;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(482, 168);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(115, 23);
            this.lbl_fecha.TabIndex = 35;
            this.lbl_fecha.Text = "Escoger Fecha";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(32, 197);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(160, 21);
            this.cmb_cliente.TabIndex = 36;
            this.cmb_cliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_cliente_MouseClick);
            // 
            // cmb_profesional
            // 
            this.cmb_profesional.FormattingEnabled = true;
            this.cmb_profesional.Location = new System.Drawing.Point(230, 197);
            this.cmb_profesional.Name = "cmb_profesional";
            this.cmb_profesional.Size = new System.Drawing.Size(166, 21);
            this.cmb_profesional.TabIndex = 37;
            this.cmb_profesional.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_profesional_MouseClick);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(765, 202);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 35);
            this.btn_eliminar.TabIndex = 40;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(765, 155);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 35);
            this.btn_modificar.TabIndex = 39;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_realizar
            // 
            this.btn_realizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_realizar.Location = new System.Drawing.Point(652, 168);
            this.btn_realizar.Name = "btn_realizar";
            this.btn_realizar.Size = new System.Drawing.Size(107, 53);
            this.btn_realizar.TabIndex = 38;
            this.btn_realizar.Text = "Realizar";
            this.btn_realizar.UseVisualStyleBackColor = true;
            this.btn_realizar.Click += new System.EventHandler(this.btn_realizar_Click);
            // 
            // dataTable_cita
            // 
            this.dataTable_cita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable_cita.Location = new System.Drawing.Point(12, 243);
            this.dataTable_cita.Name = "dataTable_cita";
            this.dataTable_cita.Size = new System.Drawing.Size(822, 236);
            this.dataTable_cita.TabIndex = 41;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(647, 29);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(156, 28);
            this.lbl_estado.TabIndex = 42;
            this.lbl_estado.Text = "Estado de la cita";
            // 
            // lbl_estadoCita
            // 
            this.lbl_estadoCita.AutoSize = true;
            this.lbl_estadoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoCita.Location = new System.Drawing.Point(695, 66);
            this.lbl_estadoCita.Name = "lbl_estadoCita";
            this.lbl_estadoCita.Size = new System.Drawing.Size(55, 18);
            this.lbl_estadoCita.TabIndex = 43;
            this.lbl_estadoCita.Text = "Estado";
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.Location = new System.Drawing.Point(657, 120);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(93, 42);
            this.btn_seleccionar.TabIndex = 44;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 491);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.lbl_estadoCita);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.dataTable_cita);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_realizar);
            this.Controls.Add(this.cmb_profesional);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.dp_cita);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_cit);
            this.Controls.Add(this.lbl_profesional);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.btn_volver);
            this.Name = "Cita";
            this.Text = "Cita";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_cita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_cit;
        private System.Windows.Forms.Label lbl_profesional;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DateTimePicker dp_cita;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.ComboBox cmb_profesional;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_realizar;
        private System.Windows.Forms.DataGridView dataTable_cita;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_estadoCita;
        private System.Windows.Forms.Button btn_seleccionar;
    }
}