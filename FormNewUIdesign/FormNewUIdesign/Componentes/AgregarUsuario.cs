﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FormNewUIdesign.Modelo;
using FormNewUIdesign.Funciones;
using System.IO;
using System.Drawing.Imaging;

namespace FormNewUIdesign
{
    public partial class AgregarUsuario : UserControl
    {
        bool ERROR_rut = true;
        bool ERROR_nombre = true;
        bool ERROR_apellidos = true;
        bool ERROR_mail = true;
        bool ERROR_sexo = true;
        bool ERROR_perfil = true;
        bool ERROR_username = true;
        bool ERROR_password = true;
        bool ERROR_confirmar_password = true;

        string directorioDefault = "C:\\";
        string imgDefault = "user_default.png";
        string imagenPerfil = "user_default.png";
        string rutaImagenPerfil = "";
        string imagenSubida = "";
        public AgregarUsuario()
        {
            InitializeComponent();

            Dictionary<string, string> objeto = new Dictionary<string, string>();
            objeto.Add("0", "Seleccione");

            cbxSexo.DataSource = new BindingSource(objeto, null);
            cbxSexo.DisplayMember = "Value";
            cbxSexo.ValueMember = "Key";

            cbxPerfil.DataSource = new BindingSource(objeto, null);
            cbxPerfil.DisplayMember = "Value";
            cbxPerfil.ValueMember = "Key";
        }

        private void txtRut_Enter(object sender, EventArgs e)
        {
            if (txtRut.Text.Equals("Ingrese rut"))
            {
                txtRut.Text = "";
                txtRut.ForeColor = Color.DimGray;
            }
            else
            {
                txtRut.SelectAll();
            }
            lineRut.BorderColor = Color.FromArgb(50, 137, 201);
            lblRut.ForeColor = Color.FromArgb(50, 137, 201);
            arrowRut.Visible = true;
            txtRut.Text = txtRut.Text.ToString().Replace(".", "").Replace("-", "");
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRut.Text))
            {
                txtRut.Text = "Ingrese rut";
                txtRut.ForeColor = Color.DarkGray;
                lineRut.BorderColor = Color.FromArgb(209, 52, 66);
                lblRut.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorRut.Text = "Debe ingresar el Rut del usuario.";
                lblErrorRut.Visible = true;
                ERROR_rut = true;
            }
            else
            {
                if (txtRut.Text.IndexOf(".") == -1 && txtRut.Text.IndexOf("-") == -1)
                {
                    if (txtRut.Text.Length >= 8)
                    {
                        string numeroRut = txtRut.Text.Substring(0, txtRut.Text.Length - 1).Replace("k", "0").Replace("K", "0");
                        string dv = txtRut.Text.Substring(txtRut.Text.Length - 1);
                        if (Mixin.ValidarRut(int.Parse(numeroRut), dv))
                        {
                            txtRut.Text = Mixin.FormatearRut(txtRut.Text);
                            lineRut.BorderColor = Color.DimGray;
                            lblRut.ForeColor = Color.DimGray;
                            lblErrorRut.Visible = false;
                            ERROR_rut = false;
                        }
                        else
                        {
                            lblRut.ForeColor = Color.FromArgb(209, 52, 66);
                            lineRut.BorderColor = Color.FromArgb(209, 52, 66);
                            lblErrorRut.Text = "El Rut no es válido.";
                            lblErrorRut.Visible = true;
                            ERROR_rut = true;
                        }

                    }
                    else
                    {
                        lblRut.ForeColor = Color.FromArgb(209, 52, 66);
                        lineRut.BorderColor = Color.FromArgb(209, 52, 66);
                        lblErrorRut.Text = "El Rut debe tener al menos 8 dígitos.";
                        lblErrorRut.Visible = true;
                        ERROR_rut = true;
                    }
                }
                else
                {
                    string rut = txtRut.Text.Replace(".", "").Replace("-", "");
                    if (rut.Length >= 8)
                    {
                        string numeroRut = rut.Substring(0, rut.Length - 1).Replace("k", "0").Replace("K", "0");
                        string dv = rut.Substring(rut.Length - 1);
                        if (Mixin.ValidarRut(int.Parse(numeroRut), dv))
                        {
                            txtRut.Text = Mixin.FormatearRut(txtRut.Text);
                            lineRut.BorderColor = Color.DimGray;
                            lblRut.ForeColor = Color.DimGray;
                            lblErrorRut.Visible = false;
                            ERROR_rut = false;
                        }
                        else
                        {
                            lblRut.ForeColor = Color.FromArgb(209, 52, 66);
                            lineRut.BorderColor = Color.FromArgb(209, 52, 66);
                            lblErrorRut.Text = "El Rut no es válido.";
                            lblErrorRut.Visible = true;
                            ERROR_rut = true;
                        }
                    }
                    else
                    {
                        lblRut.ForeColor = Color.FromArgb(209, 52, 66);
                        lineRut.BorderColor = Color.FromArgb(209, 52, 66);
                        lblErrorRut.Text = "El Rut debe tener al menos 8 dígitos.";
                        lblErrorRut.Visible = true;
                        ERROR_rut = true;
                    }
                }
            }
            arrowRut.Visible = false;
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 'k') && (e.KeyChar != 'K'))
            {
                e.Handled = true;
            }
        }



        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("Ingrese nombre"))
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.DimGray;
            }
            else
            {
                txtNombre.SelectAll();
            }
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
                lineNombre.BorderColor = Color.FromArgb(209, 52, 66);
                lblNombre.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorNombre.Text = "Debe ingresar el Nombre del usuario.";
                lblErrorNombre.Visible = true;
                ERROR_nombre = true;
            }
            else
            {
                txtNombre.ForeColor = Color.DimGray;
                lineNombre.BorderColor = Color.DimGray;
                lblNombre.ForeColor = Color.DimGray;
                lblErrorNombre.Visible = false;
                ERROR_nombre = false;
            }
            arrowNombre.Visible = false;
        }



        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            if (txtApellidos.Text.Equals("Ingrese apellidos"))
            {
                txtApellidos.Text = "";
                txtApellidos.ForeColor = Color.DimGray;
            }
            else
            {
                txtApellidos.SelectAll();
            }
            lineApellidos.BorderColor = Color.FromArgb(50, 137, 201);
            lblApellidos.ForeColor = Color.FromArgb(50, 137, 201);
            arrowApellidos.Visible = true;
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                txtApellidos.Text = "Ingrese apellidos";
                txtApellidos.ForeColor = Color.DarkGray;
                lineApellidos.BorderColor = Color.FromArgb(209, 52, 66);
                lblApellidos.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorApellidos.Text = "Debe ingresar los Apellidos del usuario.";
                lblErrorApellidos.Visible = true;
                ERROR_apellidos = true;
            }
            else
            {
                txtApellidos.ForeColor = Color.DimGray;
                lineApellidos.BorderColor = Color.DimGray;
                lblApellidos.ForeColor = Color.DimGray;
                lblErrorApellidos.Visible = false;
                ERROR_apellidos = false;
            }
            arrowApellidos.Visible = false;
        }



        private void txtEdad_Enter(object sender, EventArgs e)
        {
            if (txtEdad.Text.Equals("Ingrese edad"))
            {
                txtEdad.Text = "";
                txtEdad.ForeColor = Color.DimGray;
            }
            else
            {
                txtEdad.SelectAll();
            }
            lineEdad.BorderColor = Color.FromArgb(50, 137, 201);
            lblEdad.ForeColor = Color.FromArgb(50, 137, 201);
            arrowEdad.Visible = true;
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                txtEdad.Text = "Ingrese edad";
                txtEdad.ForeColor = Color.DarkGray;
            }
            lineEdad.BorderColor = Color.DimGray;
            lblEdad.ForeColor = Color.DimGray;
            arrowEdad.Visible = false;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals("Ingrese teléfono de contacto"))
            {
                txtTelefono.Text = "9";
                txtTelefono.ForeColor = Color.DimGray;
            }
            else
            {
                txtTelefono.SelectAll();
            }
            lineTelefono.BorderColor = Color.FromArgb(50, 137, 201);
            lblTelefono.ForeColor = Color.FromArgb(50, 137, 201);
            arrowTelefono.Visible = true;
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                txtTelefono.Text = "Ingrese teléfono de contacto";
                lblErrorTelefono.Visible = false;
                txtTelefono.ForeColor = Color.DarkGray;
            }
            else
            {
                if (!txtTelefono.Text.StartsWith("9"))
                {
                    if (txtTelefono.Text.Length < 9)
                    {
                        txtTelefono.Text = "9" + txtTelefono.Text;
                        if (txtTelefono.Text.Length < 9)
                        {
                            lblErrorTelefono.Text = "El teléfono debe tener 9 dígitos";
                            lblErrorTelefono.Visible = true;
                        }
                        else
                        {
                            lblErrorTelefono.Visible = false;
                        }
                    }
                    else
                    {
                        txtTelefono.Text = "9" + txtTelefono.Text.Substring(0, txtTelefono.Text.Length - 1);
                        lblErrorTelefono.Visible = false;
                    }
                }
                else
                {
                    if (txtTelefono.Text.Length < 9)
                    {
                        lblErrorTelefono.Text = "El teléfono debe tener 9 dígitos";
                        lblErrorTelefono.Visible = true;
                    }
                    else
                    {
                        lblErrorTelefono.Visible = false;
                    }
                }
            }
            lineTelefono.BorderColor = Color.DimGray;
            lblTelefono.ForeColor = Color.DimGray;
            arrowTelefono.Visible = false;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text.Equals("Ingrese correo electrónico"))
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.DimGray;
            }
            else
            {
                txtMail.SelectAll();
            }
            lineMail.BorderColor = Color.FromArgb(50, 137, 201);
            lblMail.ForeColor = Color.FromArgb(50, 137, 201);
            arrowMail.Visible = true;
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                txtMail.Text = "Ingrese correo electrónico";
                txtMail.ForeColor = Color.DarkGray;
                lineMail.BorderColor = Color.FromArgb(209, 52, 66);
                lblMail.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorMail.Text = "Debe ingresar correo electrónico del usuario.";
                lblErrorMail.Visible = true;
                ERROR_mail = true;
            }
            else
            {
                if (Mixin.ValidarCorreo(txtMail.Text))
                {
                    txtMail.ForeColor = Color.DimGray;
                    lineMail.BorderColor = Color.DimGray;
                    lblMail.ForeColor = Color.DimGray;
                    lblErrorMail.Visible = false;
                    ERROR_mail = false;
                }
                else
                {
                    txtMail.ForeColor = Color.DimGray;
                    lineMail.BorderColor = Color.FromArgb(209, 52, 66);
                    lblMail.ForeColor = Color.FromArgb(209, 52, 66);
                    lblErrorMail.Text = "Correo electrónico no válido.";
                    lblErrorMail.Visible = true;
                    ERROR_mail = true;
                }

            }
            arrowMail.Visible = false;
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
                lineSexo.BorderColor = Color.FromArgb(209, 52, 66);
                lblSexo.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorSexo.Text = "Debe seleccionar una opción.";
                lblErrorSexo.Visible = true;
                ERROR_sexo = true;
            }
            else
            {
                cbxSexo.ForeColor = Color.DimGray;
                lineSexo.BorderColor = Color.DimGray;
                lblSexo.ForeColor = Color.DimGray;
                lblErrorSexo.Visible = false;
                ERROR_sexo = false;
            }
            arrowSexo.Visible = false;
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
                linePerfil.BorderColor = Color.FromArgb(209, 52, 66);
                lblPerfil.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorPerfil.Text = "Debe seleccionar una opción.";
                lblErrorPerfil.Visible = true;
                ERROR_perfil = true;
            }
            else
            {
                cbxPerfil.ForeColor = Color.DimGray;
                linePerfil.BorderColor = Color.DimGray;
                lblPerfil.ForeColor = Color.DimGray;
                lblErrorPerfil.Visible = false;
                ERROR_perfil = false;
            }
            arrowPerfil.Visible = false;
        }



        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Ingrese nombre de usuario"))
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.DimGray;
            }
            else
            {
                txtUsername.SelectAll();
            }
            lineUsername.BorderColor = Color.FromArgb(50, 137, 201);
            lblUsername.ForeColor = Color.FromArgb(50, 137, 201);
            arrowUsername.Visible = true;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Ingrese nombre de usuario";
                txtUsername.ForeColor = Color.DarkGray;
                lineUsername.BorderColor = Color.FromArgb(209, 52, 66);
                lblUsername.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorUsername.Text = "Debe ingresar un nombre de usuario.";
                lblErrorUsername.Visible = true;
                ERROR_username = true;
            }
            else
            {
                txtUsername.ForeColor = Color.DimGray;
                lineUsername.BorderColor = Color.DimGray;
                lblUsername.ForeColor = Color.DimGray;
                lblErrorUsername.Visible = false;
                ERROR_username = false;
            }
            arrowUsername.Visible = false;
        }



        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Ingrese una contraseña"))
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.SelectAll();
            }
            linePassword.BorderColor = Color.FromArgb(50, 137, 201);
            lblPassword.ForeColor = Color.FromArgb(50, 137, 201);
            arrowPassword.Visible = true;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Ingrese una contraseña";
                txtPassword.ForeColor = Color.DarkGray;
                txtPassword.UseSystemPasswordChar = false;
                linePassword.BorderColor = Color.FromArgb(209, 52, 66);
                lblPassword.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorPassword.Text = "Debe ingresar una contraseña.";
                lblErrorPassword.Visible = true;
                ERROR_password = true;
            }
            else
            {
                txtPassword.ForeColor = Color.DimGray;
                linePassword.BorderColor = Color.DimGray;
                lblPassword.ForeColor = Color.DimGray;
                lblErrorPassword.Visible = false;
                txtPassword.UseSystemPasswordChar = true;
                ERROR_password = false;
            }

            if (!txtConfirmarPass.Text.Equals(txtPassword.Text) && txtConfirmarPass.Text != "Confirme la contraseña")
            {
                lineConfirmarPass.BorderColor = Color.FromArgb(209, 52, 66);
                lblConfirmarPass.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorPass.Visible = true;
                arrowConfirmarPass.Visible = false;
                ERROR_password = true;
            }
            else
            {
                lblErrorPass.Visible = false;
                lineConfirmarPass.BorderColor = Color.DimGray;
                lblConfirmarPass.ForeColor = Color.DimGray;
                ERROR_password = false;
            }

            arrowPassword.Visible = false;
        }



        private void txtConfirmarPass_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarPass.Text.Equals("Confirme la contraseña"))
            {
                txtConfirmarPass.Text = "";
                txtConfirmarPass.ForeColor = Color.DimGray;
                txtConfirmarPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtConfirmarPass.SelectAll();
            }
            lineConfirmarPass.BorderColor = Color.FromArgb(50, 137, 201);
            lblConfirmarPass.ForeColor = Color.FromArgb(50, 137, 201);
            arrowConfirmarPass.Visible = true;
        }

        private void txtConfirmarPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmarPass.Text))
            {
                txtConfirmarPass.Text = "Confirme la contraseña";
                txtConfirmarPass.ForeColor = Color.DarkGray;
                txtConfirmarPass.UseSystemPasswordChar = false;
            }

            if (!txtConfirmarPass.Text.ToString().Equals(txtPassword.Text.ToString()))
            {
                lineConfirmarPass.BorderColor = Color.FromArgb(209, 52, 66);
                lblConfirmarPass.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorPass.Visible = true;
                arrowConfirmarPass.Visible = false;
                ERROR_confirmar_password = true;
            }
            else
            {
                lineConfirmarPass.BorderColor = Color.DimGray;
                lblConfirmarPass.ForeColor = Color.DimGray;
                arrowConfirmarPass.Visible = false;
                lblErrorPass.Visible = false;
                ERROR_confirmar_password = false;
                ERROR_password = false;
            }
        }



        private void btnGuardarAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ERROR_rut && !ERROR_nombre && !ERROR_apellidos && !ERROR_mail && !ERROR_sexo && !ERROR_perfil && !ERROR_username && !ERROR_password && !ERROR_confirmar_password)
                {
                    if (!UsersModel.ExisteRut(txtRut.Text.Replace(".", "").Replace("-", "")))
                    {
                        if (!UsersModel.ExisteUsername(txtUsername.Text, ""))
                        {
                            ObjetoUsuario nuevoUsuario = new ObjetoUsuario();
                            nuevoUsuario.rut = txtRut.Text.Replace(".", "").Replace("-", "");
                            nuevoUsuario.nombre = txtNombre.Text;
                            nuevoUsuario.apellidos = txtApellidos.Text;
                            if (txtEdad.Text.Equals("Ingrese edad")) { nuevoUsuario.edad = "0"; }
                            else { nuevoUsuario.edad = txtEdad.Text; }
                            if (txtTelefono.Text.Equals("Ingrese teléfono de contacto")) { nuevoUsuario.telefono = "0"; }
                            else { nuevoUsuario.telefono = txtTelefono.Text; }
                            nuevoUsuario.mail = txtMail.Text;
                            nuevoUsuario.img_perfil = imagenPerfil;
                            nuevoUsuario.username = txtUsername.Text;
                            nuevoUsuario.password = txtPassword.Text;
                            nuevoUsuario.sexo = ((KeyValuePair<string, string>)cbxSexo.SelectedItem).Key;
                            nuevoUsuario.perfil = ((KeyValuePair<string, string>)cbxPerfil.SelectedItem).Key;
                            int idInsertado = UsersModel.GuardarUsuario(nuevoUsuario);
                            if (idInsertado > 0)
                            {
                                try
                                {
                                    if (rutaImagenPerfil == "")
                                    {
                                        rutaImagenPerfil = UsersModel.ObtenerDirectorioFotosPerfil();
                                        rutaImagenPerfil = Path.Combine(rutaImagenPerfil, imagenPerfil);
                                    }

                                    if (!File.Exists(rutaImagenPerfil))
                                    {
                                        File.Copy(imagenSubida, rutaImagenPerfil, true);
                                    }
                                    ControlUsuarios.listaUsuarios.listUsersData.AutoGenerateColumns = false;
                                    ControlUsuarios.listaUsuarios.listUsersData.DataSource = UsersModel.ObtenerUsuarios();
                                    ControlUsuarios.listaUsuarios.listUsersData.Columns["Password"].Visible = false;
                                    int rowIndex = 0;
                                    foreach (DataGridViewRow row in ControlUsuarios.listaUsuarios.listUsersData.Rows)
                                    {
                                        if (row.Cells[0].Value.ToString() == nuevoUsuario.rut)
                                        {
                                            rowIndex = row.Cells[0].RowIndex;
                                            break;
                                        }
                                    }
                                    ControlUsuarios.listaUsuarios.listUsersData.ClearSelection();
                                    ControlUsuarios.listaUsuarios.listUsersData.Rows[rowIndex].Selected = true;

                                    ControlUsuarios.ActivarTabListaUsuarios();
                                    Message.ShowMessage("Agregar Usuario", "El usuario " + nuevoUsuario.nombre + " " + nuevoUsuario.apellidos + ", ha sido creado correctamente.", Message.MessageType.done);
                                }
                                catch (Exception ex)
                                {
                                    Message.ShowMessage("Error", "AgregarUsuario.cs -> btnGuardarAddUser_Click() \n" + ex.Message, Message.MessageType.error);
                                }
                            }
                        }
                        else
                        {
                            Message.ShowMessage("Nombre de usuario en uso", "El nombre de usuario ya se encuentra en uso, favor registrar otro nombre.", Message.MessageType.warning);
                            txtUsername.Focus();
                            txtUsername.SelectAll();
                        }
                    }
                    else
                    {
                        Message.ShowMessage("Usuario ya registrado", "El rut ingresado ya se encuentra registrado, favor registrar otro rut.", Message.MessageType.warning);
                        txtRut.Focus();
                        txtRut.SelectAll();
                    }
                }
                else
                {
                    Message.ShowMessage("Advertencia", "Existen errores en el formulario o campos vacíos por completar, antes de continuar, favor corregir los errores.", Message.MessageType.warning);
                }
            }
            catch (Exception ex)
            {
                Message.ShowMessage("Error", "AgregarUsuario.cs -> btnGuardarAddUser_Click() \n" + ex.Message, Message.MessageType.error);
            }
            
        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = directorioDefault;
            openFileDialog.Filter = "Imágenes (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog.OpenFile() != null)
                    {
                        imagenSubida = Path.GetFullPath(openFileDialog.FileName).ToString();
                        string directorioFotosPerfil = UsersModel.ObtenerDirectorioFotosPerfil();
                        if (!Directory.Exists(directorioFotosPerfil))
                        {
                            Directory.CreateDirectory(directorioFotosPerfil);
                        }

                        string[] valores = imagenSubida.ToString().Split('\\');
                        imagenPerfil = valores[valores.Length - 1];
                        rutaImagenPerfil = Path.Combine(directorioFotosPerfil, imagenPerfil);                        
                        imgFotoPerfil.BackgroundImage = Image.FromFile(imagenSubida); ;

                        //La próxima vez que se abra el cuadro de dialogo para seleccionar una imagen, se abrirá en el último directorio abierto
                        directorioDefault = "";
                        for (int x = 0; x < valores.Length - 1; x++)
                        {
                            directorioDefault += valores[x] + "\\";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Message.ShowMessage("Error", "AgregarUsuario.cs -> btnSubirImagen_Click() \n" + ex.Message, Message.MessageType.error);
                }
            }
        }

        private void btnBorrarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                string directorioFotosPerfil = UsersModel.ObtenerDirectorioFotosPerfil();
                imgFotoPerfil.BackgroundImage = Image.FromFile(Path.Combine(directorioFotosPerfil, imgDefault));
                imagenPerfil = imgDefault;
            }
            catch (Exception ex)
            {
                Message.ShowMessage("Error", "AgregarUsuario.cs -> btnBorrarImagen_Click() \n" + ex.Message, Message.MessageType.error);
            }
        }
        
    }
}
