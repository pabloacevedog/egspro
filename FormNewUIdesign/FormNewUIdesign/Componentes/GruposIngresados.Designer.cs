namespace FormNewUIdesign.Componentes
{
    partial class GruposIngresados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelGruposIng = new System.Windows.Forms.Panel();
            this.listGruposIng = new System.Windows.Forms.DataGridView();
            this.Etapa_crear_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa_reg_postulantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa_add_docs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa_add_formats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personalidad_juridica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_presidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto_presidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGruposIng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listGruposIng)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGruposIng
            // 
            this.panelGruposIng.Controls.Add(this.listGruposIng);
            this.panelGruposIng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGruposIng.Location = new System.Drawing.Point(0, 0);
            this.panelGruposIng.Name = "panelGruposIng";
            this.panelGruposIng.Padding = new System.Windows.Forms.Padding(11);
            this.panelGruposIng.Size = new System.Drawing.Size(1100, 660);
            this.panelGruposIng.TabIndex = 0;
            // 
            // listGruposIng
            // 
            this.listGruposIng.AllowUserToAddRows = false;
            this.listGruposIng.AllowUserToDeleteRows = false;
            this.listGruposIng.AllowUserToResizeColumns = false;
            this.listGruposIng.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listGruposIng.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listGruposIng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listGruposIng.BackgroundColor = System.Drawing.Color.White;
            this.listGruposIng.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listGruposIng.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listGruposIng.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.NullValue = "Sin Datos";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listGruposIng.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listGruposIng.ColumnHeadersHeight = 40;
            this.listGruposIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listGruposIng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Etapa_crear_grupo,
            this.Etapa_reg_postulantes,
            this.Etapa_add_docs,
            this.Etapa_add_formats,
            this.Identificador,
            this.Nombre,
            this.Razon_social,
            this.Personalidad_juridica,
            this.Nombre_presidente,
            this.Contacto_presidente,
            this.Proyecto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listGruposIng.DefaultCellStyle = dataGridViewCellStyle3;
            this.listGruposIng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listGruposIng.EnableHeadersVisualStyles = false;
            this.listGruposIng.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listGruposIng.Location = new System.Drawing.Point(11, 11);
            this.listGruposIng.Name = "listGruposIng";
            this.listGruposIng.ReadOnly = true;
            this.listGruposIng.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listGruposIng.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listGruposIng.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listGruposIng.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.listGruposIng.RowTemplate.DefaultCellStyle.NullValue = "Sin datos";
            this.listGruposIng.RowTemplate.Height = 35;
            this.listGruposIng.Size = new System.Drawing.Size(1078, 638);
            this.listGruposIng.StandardTab = true;
            this.listGruposIng.TabIndex = 10;
            this.listGruposIng.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.listGruposIng_CellFormatting);
            // 
            // Etapa_crear_grupo
            // 
            this.Etapa_crear_grupo.DataPropertyName = "Etapa_crear_grupo";
            this.Etapa_crear_grupo.HeaderText = "Et. Crear Grupo";
            this.Etapa_crear_grupo.Name = "Etapa_crear_grupo";
            this.Etapa_crear_grupo.ReadOnly = true;
            this.Etapa_crear_grupo.Width = 139;
            // 
            // Etapa_reg_postulantes
            // 
            this.Etapa_reg_postulantes.DataPropertyName = "Etapa_reg_postulantes";
            this.Etapa_reg_postulantes.HeaderText = "Et. Registrar Post.";
            this.Etapa_reg_postulantes.Name = "Etapa_reg_postulantes";
            this.Etapa_reg_postulantes.ReadOnly = true;
            this.Etapa_reg_postulantes.Width = 148;
            // 
            // Etapa_add_docs
            // 
            this.Etapa_add_docs.DataPropertyName = "Etapa_add_docs";
            this.Etapa_add_docs.HeaderText = "Et. Agregar Docs.";
            this.Etapa_add_docs.Name = "Etapa_add_docs";
            this.Etapa_add_docs.ReadOnly = true;
            this.Etapa_add_docs.Width = 151;
            // 
            // Etapa_add_formats
            // 
            this.Etapa_add_formats.DataPropertyName = "Etapa_add_formats";
            this.Etapa_add_formats.HeaderText = "Et. Generar Formatos";
            this.Etapa_add_formats.Name = "Etapa_add_formats";
            this.Etapa_add_formats.ReadOnly = true;
            this.Etapa_add_formats.Width = 173;
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "Identificador";
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            this.Identificador.Width = 122;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 90;
            // 
            // Razon_social
            // 
            this.Razon_social.DataPropertyName = "Razon_social";
            this.Razon_social.HeaderText = "Razón Social";
            this.Razon_social.Name = "Razon_social";
            this.Razon_social.ReadOnly = true;
            this.Razon_social.Width = 121;
            // 
            // Personalidad_juridica
            // 
            this.Personalidad_juridica.DataPropertyName = "Personalidad_juridica";
            this.Personalidad_juridica.HeaderText = "Personalidad Jurídica";
            this.Personalidad_juridica.Name = "Personalidad_juridica";
            this.Personalidad_juridica.ReadOnly = true;
            this.Personalidad_juridica.Width = 180;
            // 
            // Nombre_presidente
            // 
            this.Nombre_presidente.DataPropertyName = "Nombre_presidente";
            this.Nombre_presidente.HeaderText = "Nombre Presidente";
            this.Nombre_presidente.Name = "Nombre_presidente";
            this.Nombre_presidente.ReadOnly = true;
            this.Nombre_presidente.Width = 161;
            // 
            // Contacto_presidente
            // 
            this.Contacto_presidente.DataPropertyName = "Contacto_presidente";
            this.Contacto_presidente.HeaderText = "Contacto Presidente";
            this.Contacto_presidente.Name = "Contacto_presidente";
            this.Contacto_presidente.ReadOnly = true;
            this.Contacto_presidente.Width = 168;
            // 
            // Proyecto
            // 
            this.Proyecto.DataPropertyName = "Proyecto";
            this.Proyecto.HeaderText = "Proyecto";
            this.Proyecto.Name = "Proyecto";
            this.Proyecto.ReadOnly = true;
            this.Proyecto.Width = 94;
            // 
            // GruposIngresados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelGruposIng);
            this.Name = "GruposIngresados";
            this.Size = new System.Drawing.Size(1100, 660);
            this.panelGruposIng.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listGruposIng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGruposIng;
        public System.Windows.Forms.DataGridView listGruposIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa_crear_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa_reg_postulantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa_add_docs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa_add_formats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personalidad_juridica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_presidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto_presidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto;
    }
}
