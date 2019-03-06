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
            listGruposIng = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personalidad_juridica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_presidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto_presidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa_crear_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa_reg_postulantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa_add_docs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa_add_formats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGruposIng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(listGruposIng)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGruposIng
            // 
            this.panelGruposIng.Controls.Add(listGruposIng);
            this.panelGruposIng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGruposIng.Location = new System.Drawing.Point(0, 0);
            this.panelGruposIng.Name = "panelGruposIng";
            this.panelGruposIng.Padding = new System.Windows.Forms.Padding(11);
            this.panelGruposIng.Size = new System.Drawing.Size(1100, 660);
            this.panelGruposIng.TabIndex = 0;
            // 
            // listGruposIng
            // 
            listGruposIng.AllowUserToAddRows = false;
            listGruposIng.AllowUserToDeleteRows = false;
            listGruposIng.AllowUserToResizeColumns = false;
            listGruposIng.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            listGruposIng.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            listGruposIng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            listGruposIng.BackgroundColor = System.Drawing.Color.White;
            listGruposIng.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listGruposIng.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            listGruposIng.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.NullValue = "Sin Datos";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            listGruposIng.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            listGruposIng.ColumnHeadersHeight = 40;
            listGruposIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            listGruposIng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Nombre,
            this.Razon_social,
            this.Personalidad_juridica,
            this.Nombre_presidente,
            this.Contacto_presidente,
            this.Proyecto,
            this.Etapa_crear_grupo,
            this.Etapa_reg_postulantes,
            this.Etapa_add_docs,
            this.Etapa_add_formats});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            listGruposIng.DefaultCellStyle = dataGridViewCellStyle3;
            listGruposIng.Dock = System.Windows.Forms.DockStyle.Fill;
            listGruposIng.EnableHeadersVisualStyles = false;
            listGruposIng.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            listGruposIng.Location = new System.Drawing.Point(11, 11);
            listGruposIng.Name = "listGruposIng";
            listGruposIng.ReadOnly = true;
            listGruposIng.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            listGruposIng.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            listGruposIng.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            listGruposIng.RowsDefaultCellStyle = dataGridViewCellStyle5;
            listGruposIng.RowTemplate.DefaultCellStyle.NullValue = "Sin datos";
            listGruposIng.RowTemplate.Height = 35;
            listGruposIng.Size = new System.Drawing.Size(1078, 638);
            listGruposIng.StandardTab = true;
            listGruposIng.TabIndex = 10;
            listGruposIng.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.listGruposIng_CellFormatting);
            listGruposIng.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.listGruposIng_CellMouseEnter);
            listGruposIng.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listGruposIng_MouseClick);
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "Identificador";
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            this.Identificador.Width = 114;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 88;
            // 
            // Razon_social
            // 
            this.Razon_social.DataPropertyName = "Razon_social";
            this.Razon_social.HeaderText = "Razón Social";
            this.Razon_social.Name = "Razon_social";
            this.Razon_social.ReadOnly = true;
            this.Razon_social.Width = 113;
            // 
            // Personalidad_juridica
            // 
            this.Personalidad_juridica.DataPropertyName = "Personalidad_juridica";
            this.Personalidad_juridica.HeaderText = "Pers. Jurídica";
            this.Personalidad_juridica.Name = "Personalidad_juridica";
            this.Personalidad_juridica.ReadOnly = true;
            this.Personalidad_juridica.Width = 116;
            // 
            // Nombre_presidente
            // 
            this.Nombre_presidente.DataPropertyName = "Nombre_presidente";
            this.Nombre_presidente.HeaderText = "Presidente";
            this.Nombre_presidente.Name = "Nombre_presidente";
            this.Nombre_presidente.ReadOnly = true;
            this.Nombre_presidente.Width = 102;
            // 
            // Contacto_presidente
            // 
            this.Contacto_presidente.DataPropertyName = "Contacto_presidente";
            this.Contacto_presidente.HeaderText = "Contacto Presi.";
            this.Contacto_presidente.Name = "Contacto_presidente";
            this.Contacto_presidente.ReadOnly = true;
            this.Contacto_presidente.Width = 129;
            // 
            // Proyecto
            // 
            this.Proyecto.DataPropertyName = "Proyecto";
            this.Proyecto.HeaderText = "Proyecto";
            this.Proyecto.Name = "Proyecto";
            this.Proyecto.ReadOnly = true;
            this.Proyecto.Width = 92;
            // 
            // Etapa_crear_grupo
            // 
            this.Etapa_crear_grupo.DataPropertyName = "Etapa_crear_grupo";
            this.Etapa_crear_grupo.HeaderText = "Crear Grupo";
            this.Etapa_crear_grupo.Name = "Etapa_crear_grupo";
            this.Etapa_crear_grupo.ReadOnly = true;
            this.Etapa_crear_grupo.Width = 112;
            // 
            // Etapa_reg_postulantes
            // 
            this.Etapa_reg_postulantes.DataPropertyName = "Etapa_reg_postulantes";
            this.Etapa_reg_postulantes.HeaderText = "Postulantes";
            this.Etapa_reg_postulantes.Name = "Etapa_reg_postulantes";
            this.Etapa_reg_postulantes.ReadOnly = true;
            this.Etapa_reg_postulantes.Width = 109;
            // 
            // Etapa_add_docs
            // 
            this.Etapa_add_docs.DataPropertyName = "Etapa_add_docs";
            this.Etapa_add_docs.HeaderText = "Documentos";
            this.Etapa_add_docs.Name = "Etapa_add_docs";
            this.Etapa_add_docs.ReadOnly = true;
            this.Etapa_add_docs.Width = 115;
            // 
            // Etapa_add_formats
            // 
            this.Etapa_add_formats.DataPropertyName = "Etapa_add_formats";
            this.Etapa_add_formats.HeaderText = "Formatos";
            this.Etapa_add_formats.Name = "Etapa_add_formats";
            this.Etapa_add_formats.ReadOnly = true;
            this.Etapa_add_formats.Width = 96;
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
            ((System.ComponentModel.ISupportInitialize)(listGruposIng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGruposIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personalidad_juridica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_presidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto_presidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa_crear_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa_reg_postulantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa_add_docs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa_add_formats;
        public static System.Windows.Forms.DataGridView listGruposIng;
    }
}
