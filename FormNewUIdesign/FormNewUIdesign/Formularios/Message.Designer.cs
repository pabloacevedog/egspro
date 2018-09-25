namespace FormNewUIdesign
{
    partial class Message
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.barraMessageBox = new System.Windows.Forms.Panel();
            this.btnCerrarMessage = new System.Windows.Forms.PictureBox();
            this.footerMessageBox = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.MessageIcon = new System.Windows.Forms.PictureBox();
            this.MessageIconList = new System.Windows.Forms.ImageList(this.components);
            this.barraMessageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarMessage)).BeginInit();
            this.footerMessageBox.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // barraMessageBox
            // 
            this.barraMessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(201)))));
            this.barraMessageBox.Controls.Add(this.btnCerrarMessage);
            this.barraMessageBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraMessageBox.Location = new System.Drawing.Point(0, 0);
            this.barraMessageBox.Name = "barraMessageBox";
            this.barraMessageBox.Size = new System.Drawing.Size(480, 40);
            this.barraMessageBox.TabIndex = 0;
            this.barraMessageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Message_MouseDown);
            // 
            // btnCerrarMessage
            // 
            this.btnCerrarMessage.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarMessage.Image")));
            this.btnCerrarMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCerrarMessage.Location = new System.Drawing.Point(440, 0);
            this.btnCerrarMessage.Name = "btnCerrarMessage";
            this.btnCerrarMessage.Padding = new System.Windows.Forms.Padding(9);
            this.btnCerrarMessage.Size = new System.Drawing.Size(40, 40);
            this.btnCerrarMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarMessage.TabIndex = 1;
            this.btnCerrarMessage.TabStop = false;
            this.btnCerrarMessage.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrarMessage.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrarMessage.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // footerMessageBox
            // 
            this.footerMessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(201)))));
            this.footerMessageBox.Controls.Add(this.btnCancelar);
            this.footerMessageBox.Controls.Add(this.btnAceptar);
            this.footerMessageBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerMessageBox.Location = new System.Drawing.Point(0, 180);
            this.footerMessageBox.Name = "footerMessageBox";
            this.footerMessageBox.Size = new System.Drawing.Size(480, 40);
            this.footerMessageBox.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(201)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(97)))), ((int)(((byte)(161)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(97)))), ((int)(((byte)(161)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(242, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnCancelar.Size = new System.Drawing.Size(119, 40);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(201)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(97)))), ((int)(((byte)(161)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(97)))), ((int)(((byte)(161)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(361, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnAceptar.Size = new System.Drawing.Size(119, 40);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.lblMensaje);
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Controls.Add(this.MessageIcon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 140);
            this.panel3.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMensaje.Enabled = false;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMensaje.Location = new System.Drawing.Point(99, 54);
            this.lblMensaje.Multiline = true;
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.ReadOnly = true;
            this.lblMensaje.Size = new System.Drawing.Size(357, 41);
            this.lblMensaje.TabIndex = 7;
            this.lblMensaje.TabStop = false;
            this.lblMensaje.Text = "Mensaje";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(96, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(41, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Título";
            // 
            // MessageIcon
            // 
            this.MessageIcon.Image = ((System.Drawing.Image)(resources.GetObject("MessageIcon.Image")));
            this.MessageIcon.Location = new System.Drawing.Point(30, 45);
            this.MessageIcon.Name = "MessageIcon";
            this.MessageIcon.Size = new System.Drawing.Size(50, 50);
            this.MessageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MessageIcon.TabIndex = 4;
            this.MessageIcon.TabStop = false;
            // 
            // MessageIconList
            // 
            this.MessageIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MessageIconList.ImageStream")));
            this.MessageIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.MessageIconList.Images.SetKeyName(0, "done.png");
            this.MessageIconList.Images.SetKeyName(1, "error.png");
            this.MessageIconList.Images.SetKeyName(2, "info.png");
            this.MessageIconList.Images.SetKeyName(3, "warning.png");
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 220);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.footerMessageBox);
            this.Controls.Add(this.barraMessageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.barraMessageBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarMessage)).EndInit();
            this.footerMessageBox.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraMessageBox;
        private System.Windows.Forms.PictureBox btnCerrarMessage;
        private System.Windows.Forms.Panel footerMessageBox;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox MessageIcon;
        private System.Windows.Forms.ImageList MessageIconList;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox lblMensaje;
    }
}