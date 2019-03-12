namespace FormNewUIdesign
{
    partial class FormPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.tituloPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnResturar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.imgUsername = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panelUserData = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCalendario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.btnDataUser = new System.Windows.Forms.PictureBox();
            this.imgSlideMenu = new System.Windows.Forms.PictureBox();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.tituloPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDataUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlideMenu)).BeginInit();
            this.logoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloPanel
            // 
            this.tituloPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.tituloPanel.Controls.Add(this.panel1);
            this.tituloPanel.Controls.Add(this.btnCerrar);
            this.tituloPanel.Controls.Add(this.btnResturar);
            this.tituloPanel.Controls.Add(this.btnMinimizar);
            this.tituloPanel.Controls.Add(this.btnMaximizar);
            this.tituloPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.tituloPanel, "tituloPanel");
            this.tituloPanel.Name = "tituloPanel";
            this.tituloPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tituloPanel_MouseDown);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.imgTitle);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Name = "panel1";
            // 
            // imgTitle
            // 
            this.imgTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.imgTitle, "imgTitle");
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.TabStop = false;
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Name = "lblTitulo";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // btnResturar
            // 
            resources.ApplyResources(this.btnResturar, "btnResturar");
            this.btnResturar.BackColor = System.Drawing.Color.Transparent;
            this.btnResturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResturar.Name = "btnResturar";
            this.btnResturar.TabStop = false;
            this.btnResturar.Click += new System.EventHandler(this.btnResturar_Click);
            this.btnResturar.MouseEnter += new System.EventHandler(this.btnResturar_MouseEnter);
            this.btnResturar.MouseLeave += new System.EventHandler(this.btnResturar_MouseLeave);
            // 
            // btnMinimizar
            // 
            resources.ApplyResources(this.btnMinimizar, "btnMinimizar");
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseEnter += new System.EventHandler(this.btnMinimizar_MouseEnter);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            // 
            // btnMaximizar
            // 
            resources.ApplyResources(this.btnMaximizar, "btnMaximizar");
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            this.btnMaximizar.MouseEnter += new System.EventHandler(this.btnMaximizar_MouseEnter);
            this.btnMaximizar.MouseLeave += new System.EventHandler(this.btnMaximizar_MouseLeave);
            // 
            // contentPanel
            // 
            resources.ApplyResources(this.contentPanel, "contentPanel");
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Name = "contentPanel";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.logo);
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.menuPanel.Controls.Add(this.panelLogo);
            this.menuPanel.Controls.Add(this.btnDataUser);
            this.menuPanel.Controls.Add(this.controlPanel);
            this.menuPanel.Controls.Add(this.logoPanel);
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Name = "menuPanel";
            // 
            // imgUsername
            // 
            resources.ApplyResources(this.imgUsername, "imgUsername");
            this.imgUsername.BackColor = System.Drawing.Color.Transparent;
            this.imgUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgUsername.Name = "imgUsername";
            // 
            // shapeContainer1
            // 
            resources.ApplyResources(this.shapeContainer1, "shapeContainer1");
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.imgUsername});
            this.shapeContainer1.TabStop = false;
            // 
            // panelUserData
            // 
            resources.ApplyResources(this.panelUserData, "panelUserData");
            this.panelUserData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelUserData.Name = "panelUserData";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoEllipsis = true;
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Name = "lblUsername";
            // 
            // lblCalendario
            // 
            resources.ApplyResources(this.lblCalendario, "lblCalendario");
            this.lblCalendario.ForeColor = System.Drawing.Color.White;
            this.lblCalendario.Name = "lblCalendario";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.controlPanel.Controls.Add(this.pictureBox2);
            this.controlPanel.Controls.Add(this.lblCalendario);
            this.controlPanel.Controls.Add(this.lblUsername);
            this.controlPanel.Controls.Add(this.panelUserData);
            this.controlPanel.Controls.Add(this.shapeContainer1);
            this.controlPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.controlPanel, "controlPanel");
            this.controlPanel.Name = "controlPanel";
            // 
            // btnDataUser
            // 
            this.btnDataUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnDataUser.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDataUser, "btnDataUser");
            this.btnDataUser.Name = "btnDataUser";
            this.btnDataUser.TabStop = false;
            this.btnDataUser.Click += new System.EventHandler(this.btnDataUser_Click);
            this.btnDataUser.MouseEnter += new System.EventHandler(this.btnDataUser_MouseEnter);
            this.btnDataUser.MouseLeave += new System.EventHandler(this.btnDataUser_MouseLeave);
            // 
            // imgSlideMenu
            // 
            this.imgSlideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.imgSlideMenu, "imgSlideMenu");
            this.imgSlideMenu.Name = "imgSlideMenu";
            this.imgSlideMenu.TabStop = false;
            this.imgSlideMenu.Click += new System.EventHandler(this.imgSlideMenu_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.logoPanel.Controls.Add(this.imgSlideMenu);
            this.logoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.logoPanel, "logoPanel");
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logoPanel_MouseDown);
            // 
            // FormPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.tituloPanel);
            this.Controls.Add(this.menuPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Tag = "";
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.tituloPanel.ResumeLayout(false);
            this.tituloPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDataUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlideMenu)).EndInit();
            this.logoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel tituloPanel;
        private System.Windows.Forms.PictureBox btnResturar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox btnDataUser;
        public System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCalendario;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panelUserData;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public Microsoft.VisualBasic.PowerPacks.OvalShape imgUsername;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox imgSlideMenu;
    }
}

