using System.Windows.Forms;
using FormNewUIdesign.Modelo;
using System.Drawing;

namespace FormNewUIdesign.Componentes
{
    public partial class GruposIngresados : UserControl
    {
        public GruposIngresados()
        {
            InitializeComponent();
            listGruposIng.AutoGenerateColumns = false;
            listGruposIng.DataSource = GruposModel.ObtenerGrupos();
        }

        private void listGruposIng_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (listGruposIng.Columns[e.ColumnIndex].Name == "Etapa_crear_grupo")
            {
                if (e.Value.ToString() == "Completa")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(0, 127, 0);
                    e.CellStyle.BackColor = Color.FromArgb(213, 255, 201);
                }

                if (e.Value.ToString() == "Incompleta")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(188, 0, 0);
                    e.CellStyle.BackColor = Color.FromArgb(255, 206, 206);
                }
            }

            if (listGruposIng.Columns[e.ColumnIndex].Name == "Etapa_reg_postulantes")
            {
                if (e.Value.ToString() == "Completa")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(0, 127, 0);
                    e.CellStyle.BackColor = Color.FromArgb(213, 255, 201);
                }

                if (e.Value.ToString() == "Incompleta")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(188, 0, 0);
                    e.CellStyle.BackColor = Color.FromArgb(255, 206, 206);
                }
            }

            if (listGruposIng.Columns[e.ColumnIndex].Name == "Etapa_add_docs")
            {
                if (e.Value.ToString() == "Completa")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(0, 127, 0);
                    e.CellStyle.BackColor = Color.FromArgb(213, 255, 201);
                }

                if (e.Value.ToString() == "Incompleta")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(188, 0, 0);
                    e.CellStyle.BackColor = Color.FromArgb(255, 206, 206);
                }
            }

            if (listGruposIng.Columns[e.ColumnIndex].Name == "Etapa_add_formats")
            {
                if (e.Value.ToString() == "Completa")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(0, 127, 0);
                    e.CellStyle.BackColor = Color.FromArgb(213, 255, 201);
                }

                if (e.Value.ToString() == "Incompleta")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(188, 0, 0);
                    e.CellStyle.BackColor = Color.FromArgb(255, 206, 206);
                }
            }
        }

    }
}
