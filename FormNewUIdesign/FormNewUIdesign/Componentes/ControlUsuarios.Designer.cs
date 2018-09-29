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
            this.SuspendLayout();
            // 
            // tabEditUser
            // 
            tabEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            tabEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            tabEditUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            tabEditUser.FlatAppearance.BorderSize = 0;
            tabEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            tabEditUser.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            tabAddUser.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            tabListUsers.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            contenidoUsuarios.Size = new System.Drawing.Size(1100, 605);
            contenidoUsuarios.TabIndex = 11;
            // 
            // ControlUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(contenidoUsuarios);
            this.Controls.Add(tabEditUser);
            this.Controls.Add(tabAddUser);
            this.Controls.Add(tabListUsers);
            this.Name = "ControlUsuarios";
            this.Size = new System.Drawing.Size(1103, 663);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public static System.Windows.Forms.Panel contenidoUsuarios;
        public static System.Windows.Forms.Button tabEditUser;
        public static System.Windows.Forms.Button tabAddUser;
        public static System.Windows.Forms.Button tabListUsers;
    }
}
