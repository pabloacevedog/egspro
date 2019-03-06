using System.Windows.Forms;
using FormNewUIdesign.Modelo;
using System.Drawing;
using System.Collections.Generic;
using FormNewUIdesign.Formularios;

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

        private DataGridViewCellEventArgs mouseLocation;
        private void listGruposIng_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (mouseLocation != null && mouseLocation.RowIndex >= 0)
                {
                    listGruposIng.ClearSelection();
                    listGruposIng.Rows[mouseLocation.RowIndex].Selected = true;
                    listGruposIng.CurrentCell = listGruposIng[1, mouseLocation.RowIndex];

                    List<OpcionesMenu> opciones = new List<OpcionesMenu>();
                    OpcionesMenu opcion = new OpcionesMenu();
                    opcion.id = "optEditarGrupo";
                    opcion.texto = "Editar Grupo";
                    opcion.imagen = "../../iconos/edit/grey.png";
                    opciones.Add(opcion);

                    opcion = new OpcionesMenu();
                    opcion.id = "optEliminarGrupo";
                    opcion.texto = "Eliminar Grupo";
                    opcion.imagen = "../../iconos/delete_user/grey.png";
                    opciones.Add(opcion);

                    ObjetoGrupo datosGrupo = new ObjetoGrupo();
                    datosGrupo.Identificador = listGruposIng.Rows[mouseLocation.RowIndex].Cells[0].Value.ToString();
                    datosGrupo.Nombre = listGruposIng.Rows[mouseLocation.RowIndex].Cells[1].Value.ToString();
                    datosGrupo.Razon_social = listGruposIng.Rows[mouseLocation.RowIndex].Cells[2].Value.ToString();
                    datosGrupo.Personalidad_juridica = listGruposIng.Rows[mouseLocation.RowIndex].Cells[3].Value.ToString();
                    datosGrupo.Nombre_presidente = listGruposIng.Rows[mouseLocation.RowIndex].Cells[4].Value.ToString();
                    datosGrupo.Contacto_presidente = listGruposIng.Rows[mouseLocation.RowIndex].Cells[5].Value.ToString();
                    datosGrupo.Proyecto = listGruposIng.Rows[mouseLocation.RowIndex].Cells[6].Value.ToString();
                    datosGrupo.Etapa_crear_grupo = listGruposIng.Rows[mouseLocation.RowIndex].Cells[7].Value.ToString();
                    datosGrupo.Etapa_reg_postulantes = listGruposIng.Rows[mouseLocation.RowIndex].Cells[8].Value.ToString();
                    datosGrupo.Etapa_add_docs = listGruposIng.Rows[mouseLocation.RowIndex].Cells[9].Value.ToString();
                    datosGrupo.Etapa_add_formats = listGruposIng.Rows[mouseLocation.RowIndex].Cells[10].Value.ToString();

                    MenuContextual.ShowMenu(opciones, new Point(Cursor.Position.X, Cursor.Position.Y), datosGrupo, "grupo");
                }
            }
        }

        private void listGruposIng_CellMouseEnter(object sender, DataGridViewCellEventArgs location)
        {
            mouseLocation = location;
        }

        //private void btnSimbologia_Click(object sender, System.EventArgs e)
        //{
        //    PopupInfo.ShowMessage("Para finalizar el proceso de postulación de un grupo, debe completar todas las etapas \nmarcadas como ''completa (verde) / incompleta (rojo)'' de cada grupo.\n\nEtapa 1: Creación del grupo de postulantes. \nEtapa 2: Registro de los postulantes en un grupo. \nEtapa 3: Ingreso de la documentación perteneciente a cada postulante. \nEtapa 4: Generación de los formatos necesarios para cada postulante del grupo.");
        //}
    }
}
