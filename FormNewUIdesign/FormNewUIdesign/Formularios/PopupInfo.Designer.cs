namespace FormNewUIdesign.Formularios
{
    partial class PopupInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupInfo));
            this.barraMessageBox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarMessage = new System.Windows.Forms.PictureBox();
            this.lblPopupInfo = new System.Windows.Forms.Label();
            this.barraMessageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // barraMessageBox
            // 
            this.barraMessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(201)))));
            this.barraMessageBox.Controls.Add(this.label1);
            this.barraMessageBox.Controls.Add(this.pictureBox1);
            this.barraMessageBox.Controls.Add(this.btnCerrarMessage);
            this.barraMessageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barraMessageBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraMessageBox.Location = new System.Drawing.Point(0, 0);
            this.barraMessageBox.Name = "barraMessageBox";
            this.barraMessageBox.Size = new System.Drawing.Size(241, 40);
            this.barraMessageBox.TabIndex = 1;
            this.barraMessageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraMessageBox_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Información";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarMessage
            // 
            this.btnCerrarMessage.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarMessage.Image")));
            this.btnCerrarMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCerrarMessage.Location = new System.Drawing.Point(201, 0);
            this.btnCerrarMessage.Name = "btnCerrarMessage";
            this.btnCerrarMessage.Padding = new System.Windows.Forms.Padding(9);
            this.btnCerrarMessage.Size = new System.Drawing.Size(40, 40);
            this.btnCerrarMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarMessage.TabIndex = 1;
            this.btnCerrarMessage.TabStop = false;
            this.btnCerrarMessage.Click += new System.EventHandler(this.btnCerrarMessage_Click);
            this.btnCerrarMessage.MouseEnter += new System.EventHandler(this.btnCerrarMessage_MouseEnter);
            this.btnCerrarMessage.MouseLeave += new System.EventHandler(this.btnCerrarMessage_MouseLeave);
            // 
            // lblPopupInfo
            // 
            this.lblPopupInfo.AutoSize = true;
            this.lblPopupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPopupInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopupInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblPopupInfo.Location = new System.Drawing.Point(0, 40);
            this.lblPopupInfo.Name = "lblPopupInfo";
            this.lblPopupInfo.Padding = new System.Windows.Forms.Padding(20);
            this.lblPopupInfo.Size = new System.Drawing.Size(79, 57);
            this.lblPopupInfo.TabIndex = 4;
            this.lblPopupInfo.Text = "Texto";
            // 
            // PopupInfo
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(241, 104);
            this.Controls.Add(this.lblPopupInfo);
            this.Controls.Add(this.barraMessageBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Información";
            this.barraMessageBox.ResumeLayout(false);
            this.barraMessageBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraMessageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrarMessage;
        private System.Windows.Forms.Label lblPopupInfo;
    }
}