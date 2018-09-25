
using FormNewUIdesign.Componentes;
using FormNewUIdesign.Funciones;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormNewUIdesign
{
    public partial class ControlUsuarios : UserControl
    {
        public static ListaUsuarios listaUsuarios;
        public static AgregarUsuario agregarUsuario;
        public ControlUsuarios()
        {
            InitializeComponent();
            listaUsuarios = new ListaUsuarios();
            agregarUsuario = new AgregarUsuario();
            contenidoUsuarios.Controls.Add(listaUsuarios);
            listaUsuarios.Dock = DockStyle.Fill;
            contenidoUsuarios.Controls.Add(agregarUsuario);
            agregarUsuario.Dock = DockStyle.Fill;
            listaUsuarios.BringToFront();
        }

        private void tabListUsers_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.activeTabEditUser)
            {
                DialogResult result = Message.ShowMessage("¿Descartar cambios?", "Existen datos sin guardar, si sale de esta pestaña perderá los datos, ¿Desea continuar?", Message.MessageType.information);
                if (result == DialogResult.Yes)
                {
                    ActivarTabListaUsuarios();
                }
            }
            else
            {
                ActivarTabListaUsuarios();
            }
        }

        private void tabAddUser_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.activeTabEditUser)
            {
                DialogResult result = Message.ShowMessage("¿Descartar cambios?", "Existen datos sin guardar, si sale de esta pestaña perderá los datos, ¿Desea continuar?", Message.MessageType.information);
                if (result == DialogResult.Yes)
                {
                    ActivarTabAgregarUsuario();
                }
            }
            else
            {
                ActivarTabAgregarUsuario();
            }            
        }
        

        public static void ActivarTabListaUsuarios()
        {
            if (!VariablesGlobales.activeTabListUsers)
            {
                VariablesGlobales.activeTabListUsers = true;

                tabListUsers.BackColor = Color.FromArgb(50, 137, 201);
                tabListUsers.ForeColor = Color.White;
                tabListUsers.Image = Image.FromFile("../../iconos/list_users/white.png");
                tabEditUser.Visible = false;

                if (VariablesGlobales.activeTabAddUser)
                {
                    VariablesGlobales.activeTabAddUser = false;
                    tabAddUser.BackColor = Color.FromArgb(235, 235, 235);
                    tabAddUser.ForeColor = Color.DimGray;
                    tabAddUser.Image = Image.FromFile("../../iconos/add_user/grey.png");
                }
                else if (VariablesGlobales.activeTabEditUser)
                {
                    VariablesGlobales.activeTabEditUser = false;
                    tabEditUser.BackColor = Color.FromArgb(235, 235, 235);
                    tabEditUser.ForeColor = Color.DimGray;
                    tabEditUser.Image = Image.FromFile("../../iconos/edit_user/grey.png");
                }
                listaUsuarios.BringToFront();
            }            
        }

        public static void ActivarTabAgregarUsuario()
        {
            if (!VariablesGlobales.activeTabAddUser)
            {
                VariablesGlobales.activeTabAddUser = true;
                tabAddUser.BackColor = Color.FromArgb(50, 137, 201);
                tabAddUser.ForeColor = Color.White;
                tabAddUser.Image = Image.FromFile("../../iconos/add_user/white.png");
                tabEditUser.Visible = false;

                if (VariablesGlobales.activeTabListUsers)
                {
                    VariablesGlobales.activeTabListUsers = false;
                    tabListUsers.BackColor = Color.FromArgb(235, 235, 235);
                    tabListUsers.ForeColor = Color.DimGray;
                    tabListUsers.Image = Image.FromFile("../../iconos/list_users/grey.png");
                }
                else if (VariablesGlobales.activeTabEditUser)
                {
                    VariablesGlobales.activeTabEditUser = false;
                    tabEditUser.BackColor = Color.FromArgb(235, 235, 235);
                    tabEditUser.ForeColor = Color.DimGray;
                    tabEditUser.Image = Image.FromFile("../../iconos/edit_user/grey.png");
                }
                agregarUsuario.BringToFront();
            }

        }

        public static void ActivarTabEditarUsuario(ObjetoUsuario datosUsuario)
        {
            EditarUsuario editarUsuario = new EditarUsuario();
            if (!VariablesGlobales.activeTabEditUser)
            {
                VariablesGlobales.activeTabEditUser = true;
                tabEditUser.BackColor = Color.FromArgb(50, 137, 201);
                tabEditUser.ForeColor = Color.White;
                tabEditUser.Image = Image.FromFile("../../iconos/edit_user/white.png");

                editarUsuario.Dock = DockStyle.Fill;
                contenidoUsuarios.Controls.Add(editarUsuario);
                editarUsuario.setDatosFormulario(datosUsuario);
                tabEditUser.Visible = true;

                if (VariablesGlobales.activeTabAddUser)
                {
                    VariablesGlobales.activeTabAddUser = false;
                    tabAddUser.BackColor = Color.FromArgb(235, 235, 235);
                    tabAddUser.ForeColor = Color.DimGray;
                    tabAddUser.Image = Image.FromFile("../../iconos/add_user/grey.png");
                }
                else if (VariablesGlobales.activeTabListUsers)
                {
                    VariablesGlobales.activeTabListUsers = false;
                    tabListUsers.BackColor = Color.FromArgb(235, 235, 235);
                    tabListUsers.ForeColor = Color.DimGray;
                    tabListUsers.Image = Image.FromFile("../../iconos/list_users/grey.png");
                }
            }
            editarUsuario.BringToFront();
        }
    }
}
