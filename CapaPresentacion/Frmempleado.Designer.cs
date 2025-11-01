namespace CapaPresentacion
{
    partial class Frmempleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmempleado));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpiar = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrar = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.cboxcodigousuario = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dtpfecha = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cboxcargo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtsalario = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtemail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny10 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cboxEstado = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txttelefono = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny9 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txtnombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny8 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txtccodigoempleado = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dvgempleados = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxcodigousuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxcargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.toolStripSeparator5,
            this.btnEditar,
            this.toolStripSeparator4,
            this.btnEliminar,
            this.toolStripSeparator2,
            this.btnLimpiar,
            this.toolStripSeparator3,
            this.btnCerrar,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 90;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 22);
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator5.Click += new System.EventHandler(this.toolStripSeparator5_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 90;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 22);
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator4.Click += new System.EventHandler(this.toolStripSeparator4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 90;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 22);
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Click += new System.EventHandler(this.toolStripSeparator2_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 90;
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(72, 22);
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator3.Click += new System.EventHandler(this.toolStripSeparator3_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.XmarksLines;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 90;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(70, 22);
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonHeaderGroup2);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonHeaderGroup1);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(800, 568);
            this.kryptonSplitContainer1.SplitterDistance = 266;
            this.kryptonSplitContainer1.TabIndex = 7;
            this.kryptonSplitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.kryptonSplitContainer1_SplitterMoved);
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup2.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.cboxcodigousuario);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.dtpfecha);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.cboxcargo);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel9);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtsalario);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel7);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtemail);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.cboxEstado);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel8);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txttelefono);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtnombre);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtccodigoempleado);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(266, 568);
            this.kryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup2.TabIndex = 2;
            this.kryptonHeaderGroup2.ValuesPrimary.Description = "Captura de Datos:";
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = null;
            this.kryptonHeaderGroup2.ValuesSecondary.Description = "Registros: 0";
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "";
            this.kryptonHeaderGroup2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonHeaderGroup2_Paint);
            // 
            // cboxcodigousuario
            // 
            this.cboxcodigousuario.DropDownWidth = 231;
            this.cboxcodigousuario.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboxcodigousuario.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Suspendido",
            "Despedido"});
            this.cboxcodigousuario.Location = new System.Drawing.Point(3, 97);
            this.cboxcodigousuario.Name = "cboxcodigousuario";
            this.cboxcodigousuario.Size = new System.Drawing.Size(235, 25);
            this.cboxcodigousuario.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.LightSlateGray;
            this.cboxcodigousuario.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboxcodigousuario.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboxcodigousuario.StateActive.ComboBox.Border.Rounding = 5;
            this.cboxcodigousuario.TabIndex = 50;
            this.cboxcodigousuario.SelectedIndexChanged += new System.EventHandler(this.cboxcodigousuario_SelectedIndexChanged);
            // 
            // dtpfecha
            // 
            this.dtpfecha.CalendarTodayDate = new System.DateTime(2025, 10, 30, 0, 0, 0, 0);
            this.dtpfecha.Location = new System.Drawing.Point(3, 461);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(234, 21);
            this.dtpfecha.TabIndex = 49;
            this.dtpfecha.ValueChanged += new System.EventHandler(this.dtpfecha_ValueChanged);
            // 
            // cboxcargo
            // 
            this.cboxcargo.DropDownWidth = 231;
            this.cboxcargo.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboxcargo.Items.AddRange(new object[] {
            "Analista Financiero",
            "Asesor Comercial Senior",
            "Asistente RH",
            "Auditor Interno",
            "Auxiliar Contable",
            "Cajero Principal",
            "Director General",
            "Ejecutivo de Ventas",
            "Encargado de Almacén",
            "Especialista de Marketing",
            "Gerente",
            "Jefe de Flota",
            "Jefe de Inventario",
            "Jefe de Ventas",
            "Mensajero",
            "Pasante Administrativa",
            "Recepcionista",
            "Supervisor de Compras",
            "Técnico de Soporte",
            "Vendedor"});
            this.cboxcargo.Location = new System.Drawing.Point(3, 334);
            this.cboxcargo.Name = "cboxcargo";
            this.cboxcargo.Size = new System.Drawing.Size(235, 25);
            this.cboxcargo.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.LightSlateGray;
            this.cboxcargo.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboxcargo.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboxcargo.StateActive.ComboBox.Border.Rounding = 5;
            this.cboxcargo.TabIndex = 48;
            this.cboxcargo.SelectedIndexChanged += new System.EventHandler(this.cboxcargo_SelectedIndexChanged);
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel9.Location = new System.Drawing.Point(3, 428);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel9.TabIndex = 46;
            this.kryptonLabel9.Values.Text = "Fecha ingreso";
            this.kryptonLabel9.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel9_Paint);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(3, 368);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(80, 20);
            this.kryptonLabel6.TabIndex = 44;
            this.kryptonLabel6.Values.Text = "Salario Base";
            this.kryptonLabel6.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel6_Paint);
            // 
            // txtsalario
            // 
            this.txtsalario.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtsalario.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtsalario.Location = new System.Drawing.Point(3, 394);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.txtsalario.Size = new System.Drawing.Size(235, 28);
            this.txtsalario.StateActive.Border.Color1 = System.Drawing.Color.LightSlateGray;
            this.txtsalario.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtsalario.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtsalario.StateActive.Border.Rounding = 5;
            this.txtsalario.StateActive.Border.Width = 1;
            this.txtsalario.TabIndex = 45;
            this.txtsalario.TextChanged += new System.EventHandler(this.txtsalario_TextChanged);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAny1.Image")));
            this.buttonSpecAny1.UniqueName = "2C4D73A64A93480A5EA6D6D0436819F6";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel7.Location = new System.Drawing.Point(3, 308);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel7.TabIndex = 37;
            this.kryptonLabel7.Values.Text = "Cargo";
            this.kryptonLabel7.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel7_Paint);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 63);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(100, 20);
            this.kryptonLabel2.TabIndex = 35;
            this.kryptonLabel2.Values.Text = "Codigo Usuario";
            this.kryptonLabel2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel2_Paint);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 128);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel3.TabIndex = 36;
            this.kryptonLabel3.Values.Text = "Nombre";
            this.kryptonLabel3.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel3_Paint);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(3, 248);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel5.TabIndex = 43;
            this.kryptonLabel5.Values.Text = "Email";
            this.kryptonLabel5.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel5_Paint);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 188);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel4.TabIndex = 42;
            this.kryptonLabel4.Values.Text = "Telefono";
            this.kryptonLabel4.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel4_Paint);
            // 
            // txtemail
            // 
            this.txtemail.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny10});
            this.txtemail.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtemail.Location = new System.Drawing.Point(3, 274);
            this.txtemail.Name = "txtemail";
            this.txtemail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.txtemail.Size = new System.Drawing.Size(235, 28);
            this.txtemail.StateActive.Border.Color1 = System.Drawing.Color.LightSlateGray;
            this.txtemail.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtemail.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtemail.StateActive.Border.Rounding = 5;
            this.txtemail.StateActive.Border.Width = 1;
            this.txtemail.TabIndex = 40;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // buttonSpecAny10
            // 
            this.buttonSpecAny10.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAny10.Image")));
            this.buttonSpecAny10.UniqueName = "95FEAD3015C84EE921BDB247661606F8";
            this.buttonSpecAny10.Click += new System.EventHandler(this.buttonSpecAny10_Click);
            // 
            // cboxEstado
            // 
            this.cboxEstado.DropDownWidth = 231;
            this.cboxEstado.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Suspendido",
            "Despedido"});
            this.cboxEstado.Location = new System.Drawing.Point(3, 514);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(235, 25);
            this.cboxEstado.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.LightSlateGray;
            this.cboxEstado.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboxEstado.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboxEstado.StateActive.ComboBox.Border.Rounding = 5;
            this.cboxEstado.TabIndex = 39;
            this.cboxEstado.SelectedIndexChanged += new System.EventHandler(this.cboxEstado_SelectedIndexChanged);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel8.Location = new System.Drawing.Point(10, 488);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel8.TabIndex = 38;
            this.kryptonLabel8.Values.Text = "Estado:";
            this.kryptonLabel8.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel8_Paint);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(113, 20);
            this.kryptonLabel1.TabIndex = 34;
            this.kryptonLabel1.Values.Text = "Codigo Empleado";
            this.kryptonLabel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // txttelefono
            // 
            this.txttelefono.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny9});
            this.txttelefono.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txttelefono.Location = new System.Drawing.Point(3, 214);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.txttelefono.Size = new System.Drawing.Size(235, 28);
            this.txttelefono.StateActive.Border.Color1 = System.Drawing.Color.LightSlateGray;
            this.txttelefono.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttelefono.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txttelefono.StateActive.Border.Rounding = 5;
            this.txttelefono.StateActive.Border.Width = 1;
            this.txttelefono.TabIndex = 33;
            this.txttelefono.TextChanged += new System.EventHandler(this.txttelefono_TextChanged);
            // 
            // buttonSpecAny9
            // 
            this.buttonSpecAny9.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAny9.Image")));
            this.buttonSpecAny9.UniqueName = "B1DFDFE42D844E701F8AC05531241CB9";
            this.buttonSpecAny9.Click += new System.EventHandler(this.buttonSpecAny9_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny8});
            this.txtnombre.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtnombre.Location = new System.Drawing.Point(3, 154);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.txtnombre.Size = new System.Drawing.Size(235, 28);
            this.txtnombre.StateActive.Border.Color1 = System.Drawing.Color.LightSlateGray;
            this.txtnombre.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtnombre.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtnombre.StateActive.Border.Rounding = 5;
            this.txtnombre.StateActive.Border.Width = 1;
            this.txtnombre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtnombre.StateCommon.Border.Rounding = 5;
            this.txtnombre.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtnombre.TabIndex = 32;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // buttonSpecAny8
            // 
            this.buttonSpecAny8.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAny8.Image")));
            this.buttonSpecAny8.UniqueName = "9A1CECAA35634953CC87C1F9315833B5";
            this.buttonSpecAny8.Click += new System.EventHandler(this.buttonSpecAny8_Click);
            // 
            // txtccodigoempleado
            // 
            this.txtccodigoempleado.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txtccodigoempleado.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtccodigoempleado.Location = new System.Drawing.Point(2, 25);
            this.txtccodigoempleado.Name = "txtccodigoempleado";
            this.txtccodigoempleado.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.txtccodigoempleado.ReadOnly = true;
            this.txtccodigoempleado.Size = new System.Drawing.Size(235, 32);
            this.txtccodigoempleado.StateActive.Border.Color1 = System.Drawing.Color.LightSlateGray;
            this.txtccodigoempleado.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtccodigoempleado.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtccodigoempleado.StateActive.Border.Rounding = 5;
            this.txtccodigoempleado.StateActive.Border.Width = 1;
            this.txtccodigoempleado.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtccodigoempleado.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtccodigoempleado.StateCommon.Border.Rounding = 5;
            this.txtccodigoempleado.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtccodigoempleado.TabIndex = 30;
            this.txtccodigoempleado.TextChanged += new System.EventHandler(this.txtccodigoempleado_TextChanged);
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAny5.Image")));
            this.buttonSpecAny5.UniqueName = "31AC3C8C3ED346F116889E03781CC09E";
            this.buttonSpecAny5.Click += new System.EventHandler(this.buttonSpecAny5_Click);
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(3, 28);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.dvgempleados);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(523, 536);
            this.kryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "Lista Empleados";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "\r\n";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = null;
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "Registros: 0";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "";
            this.kryptonHeaderGroup1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonHeaderGroup1_Paint);
            // 
            // dvgempleados
            // 
            this.dvgempleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgempleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgempleados.Location = new System.Drawing.Point(0, 0);
            this.dvgempleados.Name = "dvgempleados";
            this.dvgempleados.ReadOnly = true;
            this.dvgempleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgempleados.Size = new System.Drawing.Size(521, 483);
            this.dvgempleados.TabIndex = 0;
            this.dvgempleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgempleados_CellClick);
            this.dvgempleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgempleados_CellContentClick);
            // 
            // Frmempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Name = "Frmempleado";
            this.Text = "Frmempleado";
            this.Load += new System.EventHandler(this.Frmempleado_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboxcodigousuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxcargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgempleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton btnAgregar;
        private FontAwesome.Sharp.IconToolStripButton btnEditar;
        private FontAwesome.Sharp.IconToolStripButton btnEliminar;
        private FontAwesome.Sharp.IconToolStripButton btnLimpiar;
        private FontAwesome.Sharp.IconToolStripButton btnCerrar;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtsalario;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtemail;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny10;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboxEstado;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txttelefono;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtnombre;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtccodigoempleado;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dvgempleados;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboxcargo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpfecha;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboxcodigousuario;
    }
}