﻿namespace ControlPersonal.Vistas
{
    partial class Personal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataListadoPersonal = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelPaginado = new System.Windows.Forms.Panel();
            this.lblTotalPaginas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPagina = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrimera = new System.Windows.Forms.Button();
            this.btnUltima = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBuscador = new System.Windows.Forms.TextBox();
            this.PanelRegistros = new System.Windows.Forms.Panel();
            this.dataListadoCargos = new System.Windows.Forms.DataGridView();
            this.EditarC = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnVolverPersonal = new System.Windows.Forms.Button();
            this.PanelCargos = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnVolverCargos = new System.Windows.Forms.Button();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.btnGuardarCambiosC = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtSueldoG = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtCargoG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PanelBtnGuardarPer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarPersonal = new System.Windows.Forms.Button();
            this.btnGuardarCambiosPersonal = new System.Windows.Forms.Button();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSueldoHora = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoPersonal)).BeginInit();
            this.PanelPaginado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCargos)).BeginInit();
            this.PanelCargos.SuspendLayout();
            this.panel12.SuspendLayout();
            this.PanelBtnGuardarPer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataListadoPersonal
            // 
            this.dataListadoPersonal.AllowUserToAddRows = false;
            this.dataListadoPersonal.AllowUserToDeleteRows = false;
            this.dataListadoPersonal.AllowUserToResizeRows = false;
            this.dataListadoPersonal.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataListadoPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListadoPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListadoPersonal.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataListadoPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListadoPersonal.Location = new System.Drawing.Point(0, 82);
            this.dataListadoPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataListadoPersonal.Name = "dataListadoPersonal";
            this.dataListadoPersonal.ReadOnly = true;
            this.dataListadoPersonal.RowHeadersWidth = 62;
            this.dataListadoPersonal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose;
            this.dataListadoPersonal.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zilla Slab", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListadoPersonal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataListadoPersonal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Salmon;
            this.dataListadoPersonal.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataListadoPersonal.RowTemplate.Height = 40;
            this.dataListadoPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoPersonal.Size = new System.Drawing.Size(1389, 553);
            this.dataListadoPersonal.TabIndex = 1;
            this.dataListadoPersonal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadoPersonal_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::ControlPersonal.Properties.Resources.basura;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = global::ControlPersonal.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 125;
            // 
            // PanelPaginado
            // 
            this.PanelPaginado.BackColor = System.Drawing.Color.Pink;
            this.PanelPaginado.Controls.Add(this.lblTotalPaginas);
            this.PanelPaginado.Controls.Add(this.label8);
            this.PanelPaginado.Controls.Add(this.lblPagina);
            this.PanelPaginado.Controls.Add(this.label6);
            this.PanelPaginado.Controls.Add(this.btnPrimera);
            this.PanelPaginado.Controls.Add(this.btnUltima);
            this.PanelPaginado.Controls.Add(this.btnSiguiente);
            this.PanelPaginado.Controls.Add(this.btnAnterior);
            this.PanelPaginado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelPaginado.Location = new System.Drawing.Point(0, 635);
            this.PanelPaginado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPaginado.Name = "PanelPaginado";
            this.PanelPaginado.Size = new System.Drawing.Size(1389, 79);
            this.PanelPaginado.TabIndex = 2;
            // 
            // lblTotalPaginas
            // 
            this.lblTotalPaginas.AutoSize = true;
            this.lblTotalPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaginas.Location = new System.Drawing.Point(763, 29);
            this.lblTotalPaginas.Name = "lblTotalPaginas";
            this.lblTotalPaginas.Size = new System.Drawing.Size(19, 20);
            this.lblTotalPaginas.TabIndex = 9;
            this.lblTotalPaginas.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(726, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "de";
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.Location = new System.Drawing.Point(695, 29);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(19, 20);
            this.lblPagina.TabIndex = 7;
            this.lblPagina.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pagina";
            // 
            // btnPrimera
            // 
            this.btnPrimera.BackColor = System.Drawing.Color.Linen;
            this.btnPrimera.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrimera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimera.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimera.Location = new System.Drawing.Point(1085, 19);
            this.btnPrimera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrimera.Name = "btnPrimera";
            this.btnPrimera.Size = new System.Drawing.Size(220, 40);
            this.btnPrimera.TabIndex = 5;
            this.btnPrimera.Text = "Primera Pagina";
            this.btnPrimera.UseVisualStyleBackColor = false;
            this.btnPrimera.Click += new System.EventHandler(this.btnPrimera_Click);
            // 
            // btnUltima
            // 
            this.btnUltima.BackColor = System.Drawing.Color.Linen;
            this.btnUltima.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUltima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltima.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltima.Location = new System.Drawing.Point(836, 19);
            this.btnUltima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUltima.Name = "btnUltima";
            this.btnUltima.Size = new System.Drawing.Size(220, 40);
            this.btnUltima.TabIndex = 4;
            this.btnUltima.Text = "Ultima Pagina";
            this.btnUltima.UseVisualStyleBackColor = false;
            this.btnUltima.Click += new System.EventHandler(this.btnUltima_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.HotPink;
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Black;
            this.btnSiguiente.Location = new System.Drawing.Point(354, 19);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(220, 40);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Pagina siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.HotPink;
            this.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(84, 19);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(220, 40);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "Pagina anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMostrarTodos);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBuscador);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1389, 82);
            this.panel2.TabIndex = 3;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnMostrarTodos.Location = new System.Drawing.Point(496, 25);
            this.btnMostrarTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(156, 31);
            this.btnMostrarTodos.TabIndex = 17;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MistyRose;
            this.btnAgregar.BackgroundImage = global::ControlPersonal.Properties.Resources.agregar__1_;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(1288, 0);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 82);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepPink;
            this.panel3.Location = new System.Drawing.Point(14, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 2);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlPersonal.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(435, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBuscador
            // 
            this.textBuscador.BackColor = System.Drawing.Color.MistyRose;
            this.textBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBuscador.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscador.Location = new System.Drawing.Point(14, 27);
            this.textBuscador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBuscador.Name = "textBuscador";
            this.textBuscador.Size = new System.Drawing.Size(415, 24);
            this.textBuscador.TabIndex = 0;
            this.textBuscador.TextChanged += new System.EventHandler(this.textBuscador_TextChanged);
            // 
            // PanelRegistros
            // 
            this.PanelRegistros.Controls.Add(this.dataListadoCargos);
            this.PanelRegistros.Controls.Add(this.btnVolverPersonal);
            this.PanelRegistros.Controls.Add(this.PanelCargos);
            this.PanelRegistros.Controls.Add(this.PanelBtnGuardarPer);
            this.PanelRegistros.Controls.Add(this.btnAgregarCargo);
            this.PanelRegistros.Controls.Add(this.cbxPais);
            this.PanelRegistros.Controls.Add(this.panel9);
            this.PanelRegistros.Controls.Add(this.txtSueldoHora);
            this.PanelRegistros.Controls.Add(this.panel8);
            this.PanelRegistros.Controls.Add(this.txtCargo);
            this.PanelRegistros.Controls.Add(this.panel6);
            this.PanelRegistros.Controls.Add(this.txtIdentificacion);
            this.PanelRegistros.Controls.Add(this.panel5);
            this.PanelRegistros.Controls.Add(this.txtNombres);
            this.PanelRegistros.Controls.Add(this.label5);
            this.PanelRegistros.Controls.Add(this.label4);
            this.PanelRegistros.Controls.Add(this.lblSueldo);
            this.PanelRegistros.Controls.Add(this.label2);
            this.PanelRegistros.Controls.Add(this.label1);
            this.PanelRegistros.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelRegistros.Location = new System.Drawing.Point(14, 113);
            this.PanelRegistros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelRegistros.Name = "PanelRegistros";
            this.PanelRegistros.Size = new System.Drawing.Size(1353, 481);
            this.PanelRegistros.TabIndex = 4;
            this.PanelRegistros.Visible = false;
            // 
            // dataListadoCargos
            // 
            this.dataListadoCargos.AllowUserToAddRows = false;
            this.dataListadoCargos.AllowUserToDeleteRows = false;
            this.dataListadoCargos.AllowUserToOrderColumns = true;
            this.dataListadoCargos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListadoCargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataListadoCargos.ColumnHeadersHeight = 29;
            this.dataListadoCargos.ColumnHeadersVisible = false;
            this.dataListadoCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListadoCargos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataListadoCargos.Location = new System.Drawing.Point(652, 320);
            this.dataListadoCargos.Name = "dataListadoCargos";
            this.dataListadoCargos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListadoCargos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataListadoCargos.RowHeadersWidth = 51;
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose;
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataListadoCargos.RowTemplate.Height = 40;
            this.dataListadoCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoCargos.Size = new System.Drawing.Size(499, 127);
            this.dataListadoCargos.TabIndex = 19;
            this.dataListadoCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadoCargos_CellClick);
            // 
            // EditarC
            // 
            this.EditarC.HeaderText = "";
            this.EditarC.Image = global::ControlPersonal.Properties.Resources.editar;
            this.EditarC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarC.MinimumWidth = 6;
            this.EditarC.Name = "EditarC";
            this.EditarC.ReadOnly = true;
            this.EditarC.Width = 125;
            // 
            // btnVolverPersonal
            // 
            this.btnVolverPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverPersonal.BackgroundImage = global::ControlPersonal.Properties.Resources.girar_a_la_izquierda;
            this.btnVolverPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolverPersonal.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnVolverPersonal.FlatAppearance.BorderSize = 0;
            this.btnVolverPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverPersonal.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPersonal.Location = new System.Drawing.Point(691, 28);
            this.btnVolverPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolverPersonal.Name = "btnVolverPersonal";
            this.btnVolverPersonal.Size = new System.Drawing.Size(52, 34);
            this.btnVolverPersonal.TabIndex = 18;
            this.btnVolverPersonal.UseVisualStyleBackColor = false;
            this.btnVolverPersonal.Click += new System.EventHandler(this.btnVolverPersonal_Click);
            // 
            // PanelCargos
            // 
            this.PanelCargos.Controls.Add(this.panel12);
            this.PanelCargos.Controls.Add(this.panel10);
            this.PanelCargos.Controls.Add(this.txtSueldoG);
            this.PanelCargos.Controls.Add(this.panel11);
            this.PanelCargos.Controls.Add(this.txtCargoG);
            this.PanelCargos.Controls.Add(this.label10);
            this.PanelCargos.Controls.Add(this.label11);
            this.PanelCargos.Location = new System.Drawing.Point(870, 75);
            this.PanelCargos.Name = "PanelCargos";
            this.PanelCargos.Size = new System.Drawing.Size(447, 221);
            this.PanelCargos.TabIndex = 18;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnVolverCargos);
            this.panel12.Controls.Add(this.btnGuardarC);
            this.panel12.Controls.Add(this.btnGuardarCambiosC);
            this.panel12.Location = new System.Drawing.Point(24, 128);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(402, 82);
            this.panel12.TabIndex = 21;
            // 
            // btnVolverCargos
            // 
            this.btnVolverCargos.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverCargos.BackgroundImage = global::ControlPersonal.Properties.Resources.girar_a_la_izquierda;
            this.btnVolverCargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolverCargos.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnVolverCargos.FlatAppearance.BorderSize = 0;
            this.btnVolverCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverCargos.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCargos.Location = new System.Drawing.Point(329, 26);
            this.btnVolverCargos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolverCargos.Name = "btnVolverCargos";
            this.btnVolverCargos.Size = new System.Drawing.Size(52, 34);
            this.btnVolverCargos.TabIndex = 19;
            this.btnVolverCargos.UseVisualStyleBackColor = false;
            this.btnVolverCargos.Click += new System.EventHandler(this.btnVolverCargos_Click);
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarC.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnGuardarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarC.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarC.Location = new System.Drawing.Point(21, 21);
            this.btnGuardarC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(139, 40);
            this.btnGuardarC.TabIndex = 2;
            this.btnGuardarC.Text = "Guardar";
            this.btnGuardarC.UseVisualStyleBackColor = false;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // btnGuardarCambiosC
            // 
            this.btnGuardarCambiosC.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarCambiosC.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnGuardarCambiosC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambiosC.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambiosC.Location = new System.Drawing.Point(166, 21);
            this.btnGuardarCambiosC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarCambiosC.Name = "btnGuardarCambiosC";
            this.btnGuardarCambiosC.Size = new System.Drawing.Size(139, 40);
            this.btnGuardarCambiosC.TabIndex = 3;
            this.btnGuardarCambiosC.Text = "Guardar*";
            this.btnGuardarCambiosC.UseVisualStyleBackColor = false;
            this.btnGuardarCambiosC.Click += new System.EventHandler(this.btnGuardarCambiosC_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DeepPink;
            this.panel10.Location = new System.Drawing.Point(201, 95);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(225, 1);
            this.panel10.TabIndex = 20;
            // 
            // txtSueldoG
            // 
            this.txtSueldoG.BackColor = System.Drawing.Color.MistyRose;
            this.txtSueldoG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoG.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoG.Location = new System.Drawing.Point(201, 74);
            this.txtSueldoG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSueldoG.Name = "txtSueldoG";
            this.txtSueldoG.Size = new System.Drawing.Size(225, 24);
            this.txtSueldoG.TabIndex = 19;
            this.txtSueldoG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoG_KeyPress);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DeepPink;
            this.panel11.Location = new System.Drawing.Point(201, 43);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(225, 1);
            this.panel11.TabIndex = 18;
            // 
            // txtCargoG
            // 
            this.txtCargoG.BackColor = System.Drawing.Color.MistyRose;
            this.txtCargoG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargoG.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoG.Location = new System.Drawing.Point(201, 22);
            this.txtCargoG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCargoG.Name = "txtCargoG";
            this.txtCargoG.Size = new System.Drawing.Size(225, 24);
            this.txtCargoG.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cargo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Sueldo por hora:";
            // 
            // PanelBtnGuardarPer
            // 
            this.PanelBtnGuardarPer.Controls.Add(this.btnGuardarPersonal);
            this.PanelBtnGuardarPer.Controls.Add(this.btnGuardarCambiosPersonal);
            this.PanelBtnGuardarPer.Location = new System.Drawing.Point(285, 380);
            this.PanelBtnGuardarPer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelBtnGuardarPer.Name = "PanelBtnGuardarPer";
            this.PanelBtnGuardarPer.Size = new System.Drawing.Size(301, 56);
            this.PanelBtnGuardarPer.TabIndex = 17;
            // 
            // btnGuardarPersonal
            // 
            this.btnGuardarPersonal.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarPersonal.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnGuardarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPersonal.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPersonal.Location = new System.Drawing.Point(3, 2);
            this.btnGuardarPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarPersonal.Name = "btnGuardarPersonal";
            this.btnGuardarPersonal.Size = new System.Drawing.Size(139, 40);
            this.btnGuardarPersonal.TabIndex = 0;
            this.btnGuardarPersonal.Text = "Guardar";
            this.btnGuardarPersonal.UseVisualStyleBackColor = false;
            this.btnGuardarPersonal.Click += new System.EventHandler(this.btnGuardarPersonal_Click);
            // 
            // btnGuardarCambiosPersonal
            // 
            this.btnGuardarCambiosPersonal.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarCambiosPersonal.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnGuardarCambiosPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambiosPersonal.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambiosPersonal.Location = new System.Drawing.Point(148, 2);
            this.btnGuardarCambiosPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarCambiosPersonal.Name = "btnGuardarCambiosPersonal";
            this.btnGuardarCambiosPersonal.Size = new System.Drawing.Size(139, 40);
            this.btnGuardarCambiosPersonal.TabIndex = 1;
            this.btnGuardarCambiosPersonal.Text = "Guardar*";
            this.btnGuardarCambiosPersonal.UseVisualStyleBackColor = false;
            this.btnGuardarCambiosPersonal.Click += new System.EventHandler(this.btnGuardarCambiosPersonal_Click);
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.FlatAppearance.BorderSize = 0;
            this.btnAgregarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCargo.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCargo.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarCargo.Location = new System.Drawing.Point(513, 222);
            this.btnAgregarCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(230, 44);
            this.btnAgregarCargo.TabIndex = 16;
            this.btnAgregarCargo.Text = "+ Agregar cargo";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // cbxPais
            // 
            this.cbxPais.BackColor = System.Drawing.Color.White;
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Items.AddRange(new object[] {
            "Peru",
            "Venezuela",
            "México",
            "Costa Rica",
            "Guatemala",
            "Honduras",
            "Nicaragua",
            "Panamá",
            "Cuba",
            "Puerto Rico",
            "República Dominicana",
            "Argentina",
            "Bolivia",
            "Chile",
            "Colombia",
            "Ecuador",
            "Uruguay",
            "España"});
            this.cbxPais.Location = new System.Drawing.Point(283, 166);
            this.cbxPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(387, 32);
            this.cbxPais.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DeepPink;
            this.panel9.Location = new System.Drawing.Point(283, 330);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(146, 1);
            this.panel9.TabIndex = 14;
            // 
            // txtSueldoHora
            // 
            this.txtSueldoHora.BackColor = System.Drawing.Color.MistyRose;
            this.txtSueldoHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoHora.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoHora.Location = new System.Drawing.Point(283, 309);
            this.txtSueldoHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSueldoHora.Name = "txtSueldoHora";
            this.txtSueldoHora.Size = new System.Drawing.Size(146, 24);
            this.txtSueldoHora.TabIndex = 13;
            this.txtSueldoHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoHora_KeyPress);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DeepPink;
            this.panel8.Location = new System.Drawing.Point(283, 260);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(225, 1);
            this.panel8.TabIndex = 12;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.MistyRose;
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargo.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(283, 239);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(225, 24);
            this.txtCargo.TabIndex = 11;
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DeepPink;
            this.panel6.Location = new System.Drawing.Point(285, 126);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(387, 1);
            this.panel6.TabIndex = 8;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.Color.MistyRose;
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(285, 105);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(387, 24);
            this.txtIdentificacion.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DeepPink;
            this.panel5.Location = new System.Drawing.Point(278, 58);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(387, 1);
            this.panel5.TabIndex = 6;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.MistyRose;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(278, 38);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(387, 24);
            this.txtNombres.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pais:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(111, 310);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(149, 24);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo por hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres y apellidos:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ControlPersonal.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ControlPersonal.Properties.Resources.editar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::ControlPersonal.Properties.Resources.editar;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.PanelRegistros);
            this.Controls.Add(this.dataListadoPersonal);
            this.Controls.Add(this.PanelPaginado);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(1389, 714);
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoPersonal)).EndInit();
            this.PanelPaginado.ResumeLayout(false);
            this.PanelPaginado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelRegistros.ResumeLayout(false);
            this.PanelRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCargos)).EndInit();
            this.PanelCargos.ResumeLayout(false);
            this.PanelCargos.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.PanelBtnGuardarPer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataListadoPersonal;
        private System.Windows.Forms.Panel PanelPaginado;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBuscador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtSueldoHora;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.FlowLayoutPanel PanelBtnGuardarPer;
        private System.Windows.Forms.Button btnGuardarPersonal;
        private System.Windows.Forms.Button btnVolverPersonal;
        private System.Windows.Forms.Button btnGuardarCambiosPersonal;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnPrimera;
        private System.Windows.Forms.Button btnUltima;
        private System.Windows.Forms.Label lblTotalPaginas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PanelCargos;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.Button btnGuardarCambiosC;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtSueldoG;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtCargoG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataListadoCargos;
        private System.Windows.Forms.DataGridViewImageColumn EditarC;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnVolverCargos;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
