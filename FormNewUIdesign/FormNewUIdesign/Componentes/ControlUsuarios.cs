
using FormNewUIdesign.Componentes;
using FormNewUIdesign.Funciones;
using FormNewUIdesign.Modelo;
using System;
using System.Collections.Generic;
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
            Mixin.VG.activeTabListUsers = true;
            Mixin.VG.activeTabAddUser = false;
            Mixin.VG.activeTabEditUser = false;

            Dictionary<string, string> objeto = new Dictionary<string, string>();
            objeto.Add("0", "Seleccione");

            cbxSexo.DataSource = new BindingSource(objeto, null);
            cbxSexo.DisplayMember = "Value";
            cbxSexo.ValueMember = "Key";

            cbxPerfil.DataSource = new BindingSource(objeto, null);
            cbxPerfil.DisplayMember = "Value";
            cbxPerfil.ValueMember = "Key";
        }

        private void tabListUsers_Click(object sender, EventArgs e)
        {
            if (Mixin.VG.activeTabEditUser)
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
            if (Mixin.VG.activeTabEditUser)
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
            if (!Mixin.VG.activeTabListUsers)
            {
                Mixin.VG.activeTabListUsers = true;

                tabListUsers.BackColor = Color.FromArgb(251, 168, 39);
                tabListUsers.ForeColor = Color.White;
                tabListUsers.Image = Image.FromFile("../../iconos/list_users/white.png");
                tabEditUser.Visible = false;
                btnFiltros.Visible = true;

                if (Mixin.VG.activeTabAddUser)
                {
                    Mixin.VG.activeTabAddUser = false;
                    tabAddUser.BackColor = Color.FromArgb(235, 235, 235);
                    tabAddUser.ForeColor = Color.DimGray;
                    tabAddUser.Image = Image.FromFile("../../iconos/add_user/grey.png");
                }
                else if (Mixin.VG.activeTabEditUser)
                {
                    Mixin.VG.activeTabEditUser = false;
                    tabEditUser.BackColor = Color.FromArgb(235, 235, 235);
                    tabEditUser.ForeColor = Color.DimGray;
                    tabEditUser.Image = Image.FromFile("../../iconos/edit_user/grey.png");
                }
                listaUsuarios.BringToFront();
            }            
        }

        public static void ActivarTabAgregarUsuario()
        {
            if (!Mixin.VG.activeTabAddUser)
            {
                Mixin.VG.activeTabAddUser = true;
                tabAddUser.BackColor = Color.FromArgb(251, 168, 39);
                tabAddUser.ForeColor = Color.White;
                tabAddUser.Image = Image.FromFile("../../iconos/add_user/white.png");
                tabEditUser.Visible = false;
                btnFiltros.Visible = false;
                if (panelFiltros.Visible)
                {
                    panelFiltros.Visible = false;
                    btnFiltros.Image = Image.FromFile("../../iconos/filter/grey.png");
                }

                if (Mixin.VG.activeTabListUsers)
                {
                    Mixin.VG.activeTabListUsers = false;
                    tabListUsers.BackColor = Color.FromArgb(235, 235, 235);
                    tabListUsers.ForeColor = Color.DimGray;
                    tabListUsers.Image = Image.FromFile("../../iconos/list_users/grey.png");
                }
                else if (Mixin.VG.activeTabEditUser)
                {
                    Mixin.VG.activeTabEditUser = false;
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
            if (!Mixin.VG.activeTabEditUser)
            {
                Mixin.VG.activeTabEditUser = true;
                tabEditUser.BackColor = Color.FromArgb(251, 168, 39);
                tabEditUser.ForeColor = Color.White;
                tabEditUser.Image = Image.FromFile("../../iconos/edit_user/white.png");

                editarUsuario.Dock = DockStyle.Fill;
                contenidoUsuarios.Controls.Add(editarUsuario);
                editarUsuario.setDatosFormulario(datosUsuario);
                tabEditUser.Visible = true;
                btnFiltros.Visible = false;
                if (panelFiltros.Visible)
                {
                    panelFiltros.Visible = false;
                    btnFiltros.Image = Image.FromFile("../../iconos/filter/grey.png");
                }

                if (Mixin.VG.activeTabAddUser)
                {
                    Mixin.VG.activeTabAddUser = false;
                    tabAddUser.BackColor = Color.FromArgb(235, 235, 235);
                    tabAddUser.ForeColor = Color.DimGray;
                    tabAddUser.Image = Image.FromFile("../../iconos/add_user/grey.png");
                }
                else if (Mixin.VG.activeTabListUsers)
                {
                    Mixin.VG.activeTabListUsers = false;
                    tabListUsers.BackColor = Color.FromArgb(235, 235, 235);
                    tabListUsers.ForeColor = Color.DimGray;
                    tabListUsers.Image = Image.FromFile("../../iconos/list_users/grey.png");
                }
            }
            editarUsuario.BringToFront();
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            if (panelFiltros.Visible)
            {
                panelFiltros.Visible = false;
                btnFiltros.Image = Image.FromFile("../../iconos/filter/grey.png");
            }
            else
            {
                panelFiltros.Visible = true;
                btnFiltros.Image = Image.FromFile("../../iconos/filter_remove/orange.png");
            }
        }

        private void btnFiltros_MouseEnter(object sender, EventArgs e)
        {
            if (!panelFiltros.Visible)
            {
                btnFiltros.Image = Image.FromFile("../../iconos/filter/orange.png");
            }
        }

        private void btnFiltros_MouseLeave(object sender, EventArgs e)
        {
            if (!panelFiltros.Visible)
            {
                btnFiltros.Image = Image.FromFile("../../iconos/filter/grey.png");
            }
        }

        private void txtRut_Enter(object sender, EventArgs e)
        {
            if (txtRut.Text.Equals("Ingrese rut"))
            {
                txtRut.Text = "";
            }
            else
            {
                txtRut.SelectAll();
            }
            txtRut.ForeColor = Color.DimGray;
            lineRut.BorderColor = Color.FromArgb(50, 137, 201);
            lblRut.ForeColor = Color.FromArgb(50, 137, 201);
            arrowRut.Visible = true;
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRut.Text))
            {
                txtRut.Text = "Ingrese rut";
                txtRut.ForeColor = Color.DarkGray;
            }
            else
            {
                txtRut.ForeColor = Color.DimGray;
            }
            lineRut.BorderColor = Color.DimGray;
            lblRut.ForeColor = Color.DimGray;
            arrowRut.Visible = false;
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 'k') && (e.KeyChar != 'K') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("Ingrese nombre"))
            {
                txtNombre.Text = "";
            }
            else
            {
                txtNombre.SelectAll();
            }
            txtNombre.ForeColor = Color.DimGray;
            lineNombre.BorderColor = Color.FromArgb(50, 137, 201);
            lblNombre.ForeColor = Color.FromArgb(50, 137, 201);
            arrowNombre.Visible = true;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Ingrese nombre";
                txtNombre.ForeColor = Color.DarkGray;
            }
            else
            {
                txtNombre.ForeColor = Color.DimGray;
            }
            lineNombre.BorderColor = Color.DimGray;
            lblNombre.ForeColor = Color.DimGray;
            arrowNombre.Visible = false;
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text.Equals("Ingrese apellido(s)"))
            {
                txtApellido.Text = "";
            }
            else
            {
                txtApellido.SelectAll();
            }
            txtApellido.ForeColor = Color.DimGray;
            lineApellido.BorderColor = Color.FromArgb(50, 137, 201);
            lblApellido.ForeColor = Color.FromArgb(50, 137, 201);
            arrowApellido.Visible = true;
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.Text = "Ingrese apellido(s)";
                txtApellido.ForeColor = Color.DarkGray;
            }
            else
            {
                txtApellido.ForeColor = Color.DimGray;
            }
            lineApellido.BorderColor = Color.DimGray;
            lblApellido.ForeColor = Color.DimGray;
            arrowApellido.Visible = false;
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals("Ingrese correo"))
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.DimGray;
            }
            else
            {
                txtCorreo.SelectAll();
            }
            lineCorreo.BorderColor = Color.FromArgb(50, 137, 201);
            lblCorreo.ForeColor = Color.FromArgb(50, 137, 201);
            arrowCorreo.Visible = true;
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                txtCorreo.Text = "Ingrese correo";
                txtCorreo.ForeColor = Color.DarkGray;
            }
            else
            {
                txtCorreo.ForeColor = Color.DimGray;
            }
            lineCorreo.BorderColor = Color.DimGray;
            lblCorreo.ForeColor = Color.DimGray;
            arrowCorreo.Visible = false;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Ingrese username"))
            {
                txtUsername.Text = "";
            }
            else
            {
                txtUsername.SelectAll();
            }
            txtUsername.ForeColor = Color.DimGray;
            lineUsername.BorderColor = Color.FromArgb(50, 137, 201);
            lblUsername.ForeColor = Color.FromArgb(50, 137, 201);
            arrowUsername.Visible = true;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Ingrese username";
                txtUsername.ForeColor = Color.DarkGray;
            }
            else
            {
                txtUsername.ForeColor = Color.DimGray;
            }
            lineUsername.BorderColor = Color.DimGray;
            lblUsername.ForeColor = Color.DimGray;
            arrowUsername.Visible = false;
        }

        private void cbxPerfil_Enter(object sender, EventArgs e)
        {
            cbxPerfil.DataSource = null;
            //Cargar el selector de Perfiles
            cbxPerfil.DataSource = new BindingSource(UsersModel.ObtenerPerfiles(), null);
            cbxPerfil.DisplayMember = "Value";
            cbxPerfil.ValueMember = "Key";

            cbxPerfil.ForeColor = Color.DimGray;
            linePerfil.BorderColor = Color.FromArgb(50, 137, 201);
            lblPerfil.ForeColor = Color.FromArgb(50, 137, 201);
            arrowPerfil.Visible = true;
        }

        private void cbxPerfil_Leave(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)cbxPerfil.SelectedItem).Value;
            if (value == "Seleccione")
            {
                cbxPerfil.ForeColor = Color.DarkGray;
            }
            else
            {
                cbxPerfil.ForeColor = Color.DimGray;
            }
            linePerfil.BorderColor = Color.DimGray;
            lblPerfil.ForeColor = Color.DimGray;
            arrowPerfil.Visible = false;
        }

        private void cbxSexo_Enter(object sender, EventArgs e)
        {
            cbxSexo.DataSource = null;
            //Cargar el selector de Sexo
            Dictionary<string, string> objeto = new Dictionary<string, string>();
            objeto.Add("0", "Seleccione");
            objeto.Add("M", "Masculino");
            objeto.Add("F", "Femenino");
            cbxSexo.DataSource = new BindingSource(objeto, null);
            cbxSexo.DisplayMember = "Value";
            cbxSexo.ValueMember = "Key";

            cbxSexo.ForeColor = Color.DimGray;
            lineSexo.BorderColor = Color.FromArgb(50, 137, 201);
            lblSexo.ForeColor = Color.FromArgb(50, 137, 201);
            arrowSexo.Visible = true;
        }

        private void cbxSexo_Leave(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)cbxSexo.SelectedItem).Value;
            if (value == "Seleccione")
            {
                cbxSexo.ForeColor = Color.DarkGray;
            }
            else
            {
                cbxSexo.ForeColor = Color.DimGray;
            }
            lineSexo.BorderColor = Color.DimGray;
            lblSexo.ForeColor = Color.DimGray;
            arrowSexo.Visible = false;
        }

        private void btnFiltrarUser_Click(object sender, EventArgs e)
        {
            ObjetoUsuario buscarUsuario = new ObjetoUsuario();
            buscarUsuario.rut = txtRut.Text.Replace(".", "").Replace("-", "");
            buscarUsuario.nombre = txtNombre.Text;
            buscarUsuario.apellidos = txtApellido.Text;
            buscarUsuario.mail = txtCorreo.Text;
            buscarUsuario.username = txtUsername.Text;
            buscarUsuario.sexo = ((KeyValuePair<string, string>)cbxSexo.SelectedItem).Key;
            buscarUsuario.id_perfil = ((KeyValuePair<string, string>)cbxPerfil.SelectedItem).Key;
            listaUsuarios.listUsersData.DataSource = UsersModel.BuscarUsuarios(buscarUsuario);
            listaUsuarios.BringToFront();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtRut.Text = "Ingrese rut";
            txtRut.ForeColor = Color.DarkGray;
            lineRut.BorderColor = Color.DimGray;
            lblRut.ForeColor = Color.DimGray;
            arrowRut.Visible = false;

            txtNombre.Text = "Ingrese nombre";
            txtNombre.ForeColor = Color.DarkGray;
            lineNombre.BorderColor = Color.DimGray;
            lblNombre.ForeColor = Color.DimGray;
            arrowNombre.Visible = false;

            txtApellido.Text = "Ingrese apellido(s)";
            txtApellido.ForeColor = Color.DarkGray;
            lineApellido.BorderColor = Color.DimGray;
            lblApellido.ForeColor = Color.DimGray;
            arrowApellido.Visible = false;

            txtCorreo.Text = "Ingrese correo";
            txtCorreo.ForeColor = Color.DarkGray;
            lineCorreo.BorderColor = Color.DimGray;
            lblCorreo.ForeColor = Color.DimGray;
            arrowCorreo.Visible = false;

            txtUsername.Text = "Ingrese username";
            txtUsername.ForeColor = Color.DarkGray;
            lineUsername.BorderColor = Color.DimGray;
            lblUsername.ForeColor = Color.DimGray;
            arrowUsername.Visible = false;

            cbxPerfil.SelectedIndex = 0;
            cbxPerfil.ForeColor = Color.DarkGray;
            linePerfil.BorderColor = Color.DimGray;
            lblPerfil.ForeColor = Color.DimGray;
            arrowPerfil.Visible = false;

            cbxSexo.SelectedIndex = 0;
            cbxSexo.ForeColor = Color.DarkGray;
            lineSexo.BorderColor = Color.DimGray;
            lblSexo.ForeColor = Color.DimGray;
            arrowSexo.Visible = false;


            ObjetoUsuario buscarUsuario = new ObjetoUsuario();
            buscarUsuario.rut = txtRut.Text.Replace(".", "").Replace("-", "");
            buscarUsuario.nombre = txtNombre.Text;
            buscarUsuario.apellidos = txtApellido.Text;
            buscarUsuario.mail = txtCorreo.Text;
            buscarUsuario.username = txtUsername.Text;
            buscarUsuario.sexo = ((KeyValuePair<string, string>)cbxSexo.SelectedItem).Key;
            buscarUsuario.perfil = ((KeyValuePair<string, string>)cbxPerfil.SelectedItem).Key;
            listaUsuarios.listUsersData.DataSource = UsersModel.BuscarUsuarios(buscarUsuario);
            listaUsuarios.BringToFront();
        }

        private void btnLimpiarFiltros_MouseEnter(object sender, EventArgs e)
        {
            btnLimpiarFiltros.ForeColor = Color.White;
            btnLimpiarFiltros.Image = Image.FromFile("../../iconos/trash_delete/white.png");
        }

        private void btnLimpiarFiltros_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiarFiltros.ForeColor = Color.DimGray;
            btnLimpiarFiltros.Image = Image.FromFile("../../iconos/trash_delete/light_grey.png");
        }
    }
}
