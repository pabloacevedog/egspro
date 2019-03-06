using System.Drawing;
using System.Windows.Forms;
using FormNewUIdesign.Modelo;
using System.Collections.Generic;
using FormNewUIdesign.Formularios;

namespace FormNewUIdesign
{
    public partial class ListaUsuarios : UserControl
    {
        public ListaUsuarios()
        {
            InitializeComponent();
            listUsersData.AutoGenerateColumns = false;
            listUsersData.DataSource = UsersModel.ObtenerUsuarios();
            listUsersData.Columns["Password"].Visible = false;
        }

        private DataGridViewCellEventArgs mouseLocation;
        private void listUsersData_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (mouseLocation != null && mouseLocation.RowIndex >= 0)
                {
                    listUsersData.ClearSelection(); 
                    listUsersData.Rows[mouseLocation.RowIndex].Selected = true;
                    listUsersData.CurrentCell = listUsersData[1, mouseLocation.RowIndex];

                    List<OpcionesMenu> opciones = new List<OpcionesMenu>();
                    OpcionesMenu opcion = new OpcionesMenu();
                    opcion.id = "optEditarUsuario";
                    opcion.texto = "Editar Usuario";
                    opcion.imagen = "../../iconos/edit/grey.png";
                    opciones.Add(opcion);

                    opcion = new OpcionesMenu();
                    opcion.id = "optEliminarUsuario";
                    opcion.texto = "Eliminar Usuario";
                    opcion.imagen = "../../iconos/delete_user/grey.png";
                    opciones.Add(opcion);

                    ObjetoUsuario datosUsuario = new ObjetoUsuario();
                    datosUsuario.rut = listUsersData.Rows[mouseLocation.RowIndex].Cells[0].Value.ToString();
                    datosUsuario.nombre = listUsersData.Rows[mouseLocation.RowIndex].Cells[1].Value.ToString();
                    datosUsuario.apellidos = listUsersData.Rows[mouseLocation.RowIndex].Cells[2].Value.ToString();
                    datosUsuario.username = listUsersData.Rows[mouseLocation.RowIndex].Cells[3].Value.ToString();
                    datosUsuario.password = listUsersData.Rows[mouseLocation.RowIndex].Cells[4].Value.ToString();
                    datosUsuario.telefono = listUsersData.Rows[mouseLocation.RowIndex].Cells[5].Value.ToString();
                    datosUsuario.mail = listUsersData.Rows[mouseLocation.RowIndex].Cells[6].Value.ToString();
                    datosUsuario.sexo = listUsersData.Rows[mouseLocation.RowIndex].Cells[7].Value.ToString();
                    if (datosUsuario.sexo == "F") { datosUsuario.text_sexo = "Femenino"; }
                    else { datosUsuario.text_sexo = "Masculino"; }
                    datosUsuario.edad = listUsersData.Rows[mouseLocation.RowIndex].Cells[8].Value.ToString();
                    datosUsuario.perfil = listUsersData.Rows[mouseLocation.RowIndex].Cells[9].Value.ToString();
                    datosUsuario.id_perfil = UsersModel.ObtenerIdPerfil(datosUsuario.perfil);
                    datosUsuario.img_perfil = UsersModel.ObtenerImagenPerfilUsuario(datosUsuario.rut);

                    MenuContextual.ShowMenu(opciones, new Point(Cursor.Position.X, Cursor.Position.Y), datosUsuario, "usuario");
                }
            }
        }

        // Deal with hovering over a cell.
        private void listUsersData_CellMouseEnter(object sender, DataGridViewCellEventArgs location)
        {
            mouseLocation = location;
        }

    }
}
