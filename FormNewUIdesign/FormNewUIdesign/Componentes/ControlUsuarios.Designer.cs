namespace FormNewUIdesign
{
    partial class ControlUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuarios));
            tabEditUser = new System.Windows.Forms.Button();
            tabAddUser = new System.Windows.Forms.Button();
            tabListUsers = new System.Windows.Forms.Button();
            contenidoUsuarios = new System.Windows.Forms.Panel();
            btnFiltros = new System.Windows.Forms.PictureBox();
            panelFiltros = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.arrowSexo = new System.Windows.Forms.PictureBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbxPerfil = new System.Windows.Forms.ComboBox();
            this.arrowPerfil = new System.Windows.Forms.PictureBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.arrowUsername = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.arrowCorreo = new System.Windows.Forms.PictureBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.arrowApellido = new System.Windows.Forms.PictureBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.arrowNombre = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnFiltrarUser = new System.Windows.Forms.Button();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.arrowRut = new System.Windows.Forms.PictureBox();
            this.lblRut = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineSexo = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.linePerfil = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineUsername = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineCorreo = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineApellido = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineNombre = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineRut = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(btnFiltros)).BeginInit();
            panelFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRut)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEditUser
            // 
            tabEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            tabEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            tabEditUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            tabEditUser.FlatAppearance.BorderSize = 0;
            tabEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            tabEditUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabEditUser.ForeColor = System.Drawing.Color.DimGray;
            tabEditUser.Image = ((System.Drawing.Image)(resources.GetObject("tabEditUser.Image")));
            tabEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tabEditUser.Location = new System.Drawing.Point(316, 11);
            tabEditUser.Name = "tabEditUser";
            tabEditUser.Size = new System.Drawing.Size(180, 35);
            tabEditUser.TabIndex = 0;
            tabEditUser.TabStop = false;
            tabEditUser.Text = "      Editar Usuario";
            tabEditUser.UseVisualStyleBackColor = false;
            tabEditUser.Visible = false;
            // 
            // tabAddUser
            // 
            tabAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            tabAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            tabAddUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            tabAddUser.FlatAppearance.BorderSize = 0;
            tabAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            tabAddUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabAddUser.ForeColor = System.Drawing.Color.DimGray;
            tabAddUser.Image = ((System.Drawing.Image)(resources.GetObject("tabAddUser.Image")));
            tabAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tabAddUser.Location = new System.Drawing.Point(136, 11);
            tabAddUser.Name = "tabAddUser";
            tabAddUser.Size = new System.Drawing.Size(180, 35);
            tabAddUser.TabIndex = 0;
            tabAddUser.TabStop = false;
            tabAddUser.Text = "      Agregar Usuario";
            tabAddUser.UseVisualStyleBackColor = false;
            tabAddUser.Click += new System.EventHandler(this.tabAddUser_Click);
            // 
            // tabListUsers
            // 
            tabListUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(39)))));
            tabListUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            tabListUsers.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            tabListUsers.FlatAppearance.BorderSize = 0;
            tabListUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            tabListUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabListUsers.ForeColor = System.Drawing.Color.White;
            tabListUsers.Image = ((System.Drawing.Image)(resources.GetObject("tabListUsers.Image")));
            tabListUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tabListUsers.Location = new System.Drawing.Point(11, 11);
            tabListUsers.Name = "tabListUsers";
            tabListUsers.Size = new System.Drawing.Size(125, 35);
            tabListUsers.TabIndex = 0;
            tabListUsers.TabStop = false;
            tabListUsers.Text = "      Usuarios";
            tabListUsers.UseVisualStyleBackColor = false;
            tabListUsers.Click += new System.EventHandler(this.tabListUsers_Click);
            // 
            // contenidoUsuarios
            // 
            contenidoUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            contenidoUsuarios.AutoScroll = true;
            contenidoUsuarios.AutoSize = true;
            contenidoUsuarios.BackColor = System.Drawing.Color.White;
            contenidoUsuarios.Location = new System.Drawing.Point(0, 55);
            contenidoUsuarios.Name = "contenidoUsuarios";
            contenidoUsuarios.Size = new System.Drawing.Size(1114, 605);
            contenidoUsuarios.TabIndex = 11;
            // 
            // btnFiltros
            // 
            btnFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltros.Image")));
            btnFiltros.Location = new System.Drawing.Point(1072, 18);
            btnFiltros.Name = "btnFiltros";
            btnFiltros.Size = new System.Drawing.Size(28, 28);
            btnFiltros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btnFiltros.TabIndex = 12;
            btnFiltros.TabStop = false;
            btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            btnFiltros.MouseEnter += new System.EventHandler(this.btnFiltros_MouseEnter);
            btnFiltros.MouseLeave += new System.EventHandler(this.btnFiltros_MouseLeave);
            // 
            // panelFiltros
            // 
            panelFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            panelFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            panelFiltros.Controls.Add(this.groupBox1);
            panelFiltros.Location = new System.Drawing.Point(536, 46);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new System.Drawing.Size(564, 264);
            panelFiltros.TabIndex = 13;
            panelFiltros.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.cbxSexo);
            this.groupBox1.Controls.Add(this.arrowSexo);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.cbxPerfil);
            this.groupBox1.Controls.Add(this.arrowPerfil);
            this.groupBox1.Controls.Add(this.lblPerfil);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.arrowUsername);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.arrowCorreo);
            this.groupBox1.Controls.Add(this.lblCorreo);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.arrowApellido);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.arrowNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.btnFiltrarUser);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.arrowRut);
            this.groupBox1.Controls.Add(this.lblRut);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(558, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "         Filtros de Búsqueda          ";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.btnLimpiarFiltros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.DimGray;
            this.btnLimpiarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.Image")));
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(310, 208);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(104, 35);
            this.btnLimpiarFiltros.TabIndex = 37;
            this.btnLimpiarFiltros.TabStop = false;
            this.btnLimpiarFiltros.Text = "        Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            this.btnLimpiarFiltros.MouseEnter += new System.EventHandler(this.btnLimpiarFiltros_MouseEnter);
            this.btnLimpiarFiltros.MouseLeave += new System.EventHandler(this.btnLimpiarFiltros_MouseLeave);
            // 
            // cbxSexo
            // 
            this.cbxSexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxSexo.DropDownHeight = 300;
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.DropDownWidth = 150;
            this.cbxSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSexo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexo.ForeColor = System.Drawing.Color.DarkGray;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.IntegralHeight = false;
            this.cbxSexo.ItemHeight = 17;
            this.cbxSexo.Location = new System.Drawing.Point(393, 132);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxSexo.Size = new System.Drawing.Size(144, 25);
            this.cbxSexo.TabIndex = 36;
            this.cbxSexo.Tag = "";
            this.cbxSexo.Enter += new System.EventHandler(this.cbxSexo_Enter);
            this.cbxSexo.Leave += new System.EventHandler(this.cbxSexo_Leave);
            // 
            // arrowSexo
            // 
            this.arrowSexo.Image = ((System.Drawing.Image)(resources.GetObject("arrowSexo.Image")));
            this.arrowSexo.Location = new System.Drawing.Point(290, 140);
            this.arrowSexo.Name = "arrowSexo";
            this.arrowSexo.Size = new System.Drawing.Size(17, 17);
            this.arrowSexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowSexo.TabIndex = 35;
            this.arrowSexo.TabStop = false;
            this.arrowSexo.Visible = false;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSexo.Location = new System.Drawing.Point(310, 140);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(37, 17);
            this.lblSexo.TabIndex = 34;
            this.lblSexo.Text = "Sexo";
            // 
            // cbxPerfil
            // 
            this.cbxPerfil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxPerfil.DropDownHeight = 300;
            this.cbxPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPerfil.DropDownWidth = 150;
            this.cbxPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPerfil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPerfil.ForeColor = System.Drawing.Color.DarkGray;
            this.cbxPerfil.FormattingEnabled = true;
            this.cbxPerfil.IntegralHeight = false;
            this.cbxPerfil.ItemHeight = 17;
            this.cbxPerfil.Location = new System.Drawing.Point(393, 82);
            this.cbxPerfil.Name = "cbxPerfil";
            this.cbxPerfil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxPerfil.Size = new System.Drawing.Size(144, 25);
            this.cbxPerfil.TabIndex = 33;
            this.cbxPerfil.Tag = "";
            this.cbxPerfil.Enter += new System.EventHandler(this.cbxPerfil_Enter);
            this.cbxPerfil.Leave += new System.EventHandler(this.cbxPerfil_Leave);
            // 
            // arrowPerfil
            // 
            this.arrowPerfil.Image = ((System.Drawing.Image)(resources.GetObject("arrowPerfil.Image")));
            this.arrowPerfil.Location = new System.Drawing.Point(290, 90);
            this.arrowPerfil.Name = "arrowPerfil";
            this.arrowPerfil.Size = new System.Drawing.Size(17, 17);
            this.arrowPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowPerfil.TabIndex = 32;
            this.arrowPerfil.TabStop = false;
            this.arrowPerfil.Visible = false;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.DimGray;
            this.lblPerfil.Location = new System.Drawing.Point(310, 90);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(38, 17);
            this.lblPerfil.TabIndex = 31;
            this.lblPerfil.Text = "Perfil";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.Location = new System.Drawing.Point(395, 38);
            this.txtUsername.MaxLength = 500;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.Size = new System.Drawing.Size(140, 18);
            this.txtUsername.TabIndex = 30;
            this.txtUsername.Text = "Ingrese username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // arrowUsername
            // 
            this.arrowUsername.Image = ((System.Drawing.Image)(resources.GetObject("arrowUsername.Image")));
            this.arrowUsername.Location = new System.Drawing.Point(290, 40);
            this.arrowUsername.Name = "arrowUsername";
            this.arrowUsername.Size = new System.Drawing.Size(17, 17);
            this.arrowUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowUsername.TabIndex = 29;
            this.arrowUsername.TabStop = false;
            this.arrowUsername.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsername.Location = new System.Drawing.Point(310, 40);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(69, 17);
            this.lblUsername.TabIndex = 28;
            this.lblUsername.Text = "Username";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCorreo.Location = new System.Drawing.Point(115, 188);
            this.txtCorreo.MaxLength = 500;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCorreo.Size = new System.Drawing.Size(140, 18);
            this.txtCorreo.TabIndex = 27;
            this.txtCorreo.Text = "Ingrese correo";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // arrowCorreo
            // 
            this.arrowCorreo.Image = ((System.Drawing.Image)(resources.GetObject("arrowCorreo.Image")));
            this.arrowCorreo.Location = new System.Drawing.Point(20, 190);
            this.arrowCorreo.Name = "arrowCorreo";
            this.arrowCorreo.Size = new System.Drawing.Size(17, 17);
            this.arrowCorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowCorreo.TabIndex = 26;
            this.arrowCorreo.TabStop = false;
            this.arrowCorreo.Visible = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.lblCorreo.Location = new System.Drawing.Point(40, 190);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(49, 17);
            this.lblCorreo.TabIndex = 25;
            this.lblCorreo.Text = "Correo";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.DarkGray;
            this.txtApellido.Location = new System.Drawing.Point(115, 138);
            this.txtApellido.MaxLength = 500;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtApellido.Size = new System.Drawing.Size(140, 18);
            this.txtApellido.TabIndex = 24;
            this.txtApellido.Text = "Ingrese apellido(s)";
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // arrowApellido
            // 
            this.arrowApellido.Image = ((System.Drawing.Image)(resources.GetObject("arrowApellido.Image")));
            this.arrowApellido.Location = new System.Drawing.Point(20, 140);
            this.arrowApellido.Name = "arrowApellido";
            this.arrowApellido.Size = new System.Drawing.Size(17, 17);
            this.arrowApellido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowApellido.TabIndex = 23;
            this.arrowApellido.TabStop = false;
            this.arrowApellido.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.DimGray;
            this.lblApellido.Location = new System.Drawing.Point(40, 140);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(71, 17);
            this.lblApellido.TabIndex = 22;
            this.lblApellido.Text = "Apellido(s)";
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsTab = true;
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNombre.Location = new System.Drawing.Point(115, 88);
            this.txtNombre.MaxLength = 500;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.Size = new System.Drawing.Size(140, 18);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.Text = "Ingrese nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // arrowNombre
            // 
            this.arrowNombre.Image = ((System.Drawing.Image)(resources.GetObject("arrowNombre.Image")));
            this.arrowNombre.Location = new System.Drawing.Point(20, 90);
            this.arrowNombre.Name = "arrowNombre";
            this.arrowNombre.Size = new System.Drawing.Size(17, 17);
            this.arrowNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowNombre.TabIndex = 20;
            this.arrowNombre.TabStop = false;
            this.arrowNombre.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(40, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // btnFiltrarUser
            // 
            this.btnFiltrarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(86)))));
            this.btnFiltrarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltrarUser.FlatAppearance.BorderSize = 0;
            this.btnFiltrarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarUser.ForeColor = System.Drawing.Color.White;
            this.btnFiltrarUser.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarUser.Image")));
            this.btnFiltrarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrarUser.Location = new System.Drawing.Point(431, 208);
            this.btnFiltrarUser.Name = "btnFiltrarUser";
            this.btnFiltrarUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFiltrarUser.Size = new System.Drawing.Size(104, 35);
            this.btnFiltrarUser.TabIndex = 14;
            this.btnFiltrarUser.TabStop = false;
            this.btnFiltrarUser.Text = "      Buscar";
            this.btnFiltrarUser.UseVisualStyleBackColor = false;
            this.btnFiltrarUser.Click += new System.EventHandler(this.btnFiltrarUser_Click);
            // 
            // txtRut
            // 
            this.txtRut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.ForeColor = System.Drawing.Color.DarkGray;
            this.txtRut.Location = new System.Drawing.Point(115, 38);
            this.txtRut.MaxLength = 9;
            this.txtRut.Name = "txtRut";
            this.txtRut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRut.Size = new System.Drawing.Size(140, 18);
            this.txtRut.TabIndex = 14;
            this.txtRut.Text = "Ingrese rut";
            this.txtRut.Enter += new System.EventHandler(this.txtRut_Enter);
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            this.txtRut.Leave += new System.EventHandler(this.txtRut_Leave);
            // 
            // arrowRut
            // 
            this.arrowRut.Image = ((System.Drawing.Image)(resources.GetObject("arrowRut.Image")));
            this.arrowRut.Location = new System.Drawing.Point(20, 40);
            this.arrowRut.Name = "arrowRut";
            this.arrowRut.Size = new System.Drawing.Size(17, 17);
            this.arrowRut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowRut.TabIndex = 17;
            this.arrowRut.TabStop = false;
            this.arrowRut.Visible = false;
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRut.ForeColor = System.Drawing.Color.DimGray;
            this.lblRut.Location = new System.Drawing.Point(40, 41);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(29, 17);
            this.lblRut.TabIndex = 16;
            this.lblRut.Text = "Rut";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 21);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineSexo,
            this.linePerfil,
            this.lineUsername,
            this.lineCorreo,
            this.lineApellido,
            this.lineNombre,
            this.lineRut});
            this.shapeContainer1.Size = new System.Drawing.Size(552, 234);
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Silver;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 419;
            this.lineShape1.X2 = 419;
            this.lineShape1.Y1 = 190;
            this.lineShape1.Y2 = 218;
            // 
            // lineSexo
            // 
            this.lineSexo.BorderColor = System.Drawing.Color.DimGray;
            this.lineSexo.Enabled = false;
            this.lineSexo.Name = "lineSexo";
            this.lineSexo.X1 = 390;
            this.lineSexo.X2 = 533;
            this.lineSexo.Y1 = 137;
            this.lineSexo.Y2 = 137;
            // 
            // linePerfil
            // 
            this.linePerfil.BorderColor = System.Drawing.Color.DimGray;
            this.linePerfil.Enabled = false;
            this.linePerfil.Name = "linePerfil";
            this.linePerfil.X1 = 390;
            this.linePerfil.X2 = 533;
            this.linePerfil.Y1 = 87;
            this.linePerfil.Y2 = 87;
            // 
            // lineUsername
            // 
            this.lineUsername.BorderColor = System.Drawing.Color.DimGray;
            this.lineUsername.Enabled = false;
            this.lineUsername.Name = "lineUsername";
            this.lineUsername.X1 = 390;
            this.lineUsername.X2 = 533;
            this.lineUsername.Y1 = 37;
            this.lineUsername.Y2 = 37;
            // 
            // lineCorreo
            // 
            this.lineCorreo.BorderColor = System.Drawing.Color.DimGray;
            this.lineCorreo.Enabled = false;
            this.lineCorreo.Name = "lineCorreo";
            this.lineCorreo.X1 = 110;
            this.lineCorreo.X2 = 253;
            this.lineCorreo.Y1 = 187;
            this.lineCorreo.Y2 = 187;
            // 
            // lineApellido
            // 
            this.lineApellido.BorderColor = System.Drawing.Color.DimGray;
            this.lineApellido.Enabled = false;
            this.lineApellido.Name = "lineApellido";
            this.lineApellido.X1 = 110;
            this.lineApellido.X2 = 253;
            this.lineApellido.Y1 = 137;
            this.lineApellido.Y2 = 137;
            // 
            // lineNombre
            // 
            this.lineNombre.BorderColor = System.Drawing.Color.DimGray;
            this.lineNombre.Enabled = false;
            this.lineNombre.Name = "lineNombre";
            this.lineNombre.X1 = 110;
            this.lineNombre.X2 = 253;
            this.lineNombre.Y1 = 87;
            this.lineNombre.Y2 = 87;
            // 
            // lineRut
            // 
            this.lineRut.BorderColor = System.Drawing.Color.DimGray;
            this.lineRut.Enabled = false;
            this.lineRut.Name = "lineRut";
            this.lineRut.X1 = 110;
            this.lineRut.X2 = 253;
            this.lineRut.Y1 = 37;
            this.lineRut.Y2 = 37;
            // 
            // ControlUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(panelFiltros);
            this.Controls.Add(btnFiltros);
            this.Controls.Add(contenidoUsuarios);
            this.Controls.Add(tabEditUser);
            this.Controls.Add(tabAddUser);
            this.Controls.Add(tabListUsers);
            this.Name = "ControlUsuarios";
            this.Size = new System.Drawing.Size(1117, 663);
            ((System.ComponentModel.ISupportInitialize)(btnFiltros)).EndInit();
            panelFiltros.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox arrowRut;
        private System.Windows.Forms.Label lblRut;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineRut;
        private System.Windows.Forms.Button btnFiltrarUser;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.PictureBox arrowNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.PictureBox arrowApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineNombre;
        private System.Windows.Forms.PictureBox arrowUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.PictureBox arrowCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineCorreo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineApellido;
        private System.Windows.Forms.PictureBox arrowPerfil;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtUsername;
        private Microsoft.VisualBasic.PowerPacks.LineShape linePerfil;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineUsername;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.PictureBox arrowSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cbxPerfil;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineSexo;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private static System.Windows.Forms.PictureBox btnFiltros;
        private static System.Windows.Forms.Panel panelFiltros;
        private static System.Windows.Forms.Panel contenidoUsuarios;
        private static System.Windows.Forms.Button tabEditUser;
        private static System.Windows.Forms.Button tabAddUser;
        private static System.Windows.Forms.Button tabListUsers;
    }
}
