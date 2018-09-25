using System.Drawing;
using System.Windows.Forms;
using FormNewUIdesign.Modelo;
using FormNewUIdesign.Componentes;
using System.Collections.Generic;
using FormNewUIdesign.Formularios;

namespace FormNewUIdesign
{
    public partial class ListaUsuarios : UserControl
    {
        public ListaUsuarios()
        {
            InitializeComponent();
            listUsersData.DataSource = UsersModel.ObtenerUsuarios();
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

                    MenuContextual.ShowMenu(opciones, new Point(Cursor.Position.X, Cursor.Position.Y), datosUsuario);
                }
            }
        }

        // Deal with hovering over a cell.
        private void listUsersData_CellMouseEnter(object sender, DataGridViewCellEventArgs location)
        {
            mouseLocation = location;
        }

        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "editUser":
                    ObjetoUsuario datosUsuario = new ObjetoUsuario();
                    datosUsuario.rut = listUsersData.Rows[mouseLocation.RowIndex].Cells[0].Value.ToString();
                    datosUsuario.nombre = listUsersData.Rows[mouseLocation.RowIndex].Cells[1].Value.ToString();
                    datosUsuario.apellidos = listUsersData.Rows[mouseLocation.RowIndex].Cells[2].Value.ToString();
                    datosUsuario.username = listUsersData.Rows[mouseLocation.RowIndex].Cells[3].Value.ToString();
                    datosUsuario.password = listUsersData.Rows[mouseLocation.RowIndex].Cells[4].Value.ToString();
                    datosUsuario.telefono = listUsersData.Rows[mouseLocation.RowIndex].Cells[5].Value.ToString();
                    datosUsuario.mail = listUsersData.Rows[mouseLocation.RowIndex].Cells[6].Value.ToString();
                    datosUsuario.sexo = listUsersData.Rows[mouseLocation.RowIndex].Cells[7].Value.ToString();
                    if (datosUsuario.sexo == "F"){ datosUsuario.text_sexo = "Femenino"; }
                    else { datosUsuario.text_sexo = "Masculino"; }
                    datosUsuario.edad = listUsersData.Rows[mouseLocation.RowIndex].Cells[8].Value.ToString();
                    datosUsuario.perfil = listUsersData.Rows[mouseLocation.RowIndex].Cells[9].Value.ToString();
                    datosUsuario.id_perfil = UsersModel.ObtenerIdPerfil(datosUsuario.perfil);
                    ControlUsuarios.ActivarTabEditarUsuario(datosUsuario);
                    break;

                case "deleteUser":
                    string rut = listUsersData.Rows[mouseLocation.RowIndex].Cells[0].Value.ToString();
                    string nombre = listUsersData.Rows[mouseLocation.RowIndex].Cells[1].Value.ToString() + " " + listUsersData.Rows[mouseLocation.RowIndex].Cells[2].Value.ToString();
                    DialogResult result = Message.ShowMessage("Eliminar Usuario", "Está a punto de eliminar al usuario " + nombre + ", ¿Desea continuar?", Message.MessageType.information);
                    if (result == DialogResult.Yes)
                    {
                        if (UsersModel.EliminarUsuario(rut) > 0)
                        {
                            listUsersData.DataSource = UsersModel.ObtenerUsuarios();
                            listUsersData.ClearSelection();
                            listUsersData.BringToFront();
                            Message.ShowMessage("Eliminación correcta", "El usuario " + nombre + ", se ha eliminado de nuestros registros correctamente.", Message.MessageType.done);
                        }
                    }
                    break;
            }
        }
    }
}
