using FormNewUIdesign.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormNewUIdesign.Formularios
{
    public partial class MenuContextual : Form
    {
        static ObjetoUsuario usuario;
        static MenuContextual nuevoMenu;
        public MenuContextual(List<OpcionesMenu> opciones, Point location)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;

            int posicion_Y = 0;
            int x = 0;
            foreach (var item in opciones)
            {
                Panel bordeBoton = new Panel();
                bordeBoton.BackColor = Color.FromArgb(50, 137, 201);
                bordeBoton.Location = new Point(0, posicion_Y);
                bordeBoton.Name = "borde_" + x;
                bordeBoton.Size = new Size(5, 40);
                bordeBoton.Margin = new Padding(0);
                bordeBoton.TabIndex = 0;

                Button botonOpcion = new Button();
                botonOpcion.FlatAppearance.BorderSize = 0;
                botonOpcion.FlatAppearance.BorderColor = Color.FromArgb(167, 204, 232);
                botonOpcion.Cursor = Cursors.Hand;
                botonOpcion.FlatAppearance.MouseDownBackColor = Color.FromArgb(167, 204, 232);
                botonOpcion.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 204, 232);
                botonOpcion.BackColor = Color.FromArgb(245, 245, 245);
                botonOpcion.FlatStyle = FlatStyle.Flat;
                botonOpcion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                botonOpcion.ForeColor = Color.DimGray;
                botonOpcion.Image = Image.FromFile(item.imagen); ;
                botonOpcion.ImageAlign = ContentAlignment.MiddleRight;
                botonOpcion.TextAlign = ContentAlignment.MiddleLeft;
                botonOpcion.Location = new Point(5, posicion_Y);
                botonOpcion.Margin = new Padding(0);
                botonOpcion.Name = item.id;
                botonOpcion.Size = new Size(195, 40);
                botonOpcion.TabIndex = 0;
                botonOpcion.TabStop = false;
                botonOpcion.Text = "     " + item.texto;
                botonOpcion.UseVisualStyleBackColor = true;
                botonOpcion.Click += new EventHandler(MenuItem_Click);

                contenedorOpciones.Controls.Add(bordeBoton);
                contenedorOpciones.Controls.Add(botonOpcion);

                posicion_Y += 40;
                x++;
            }
        }


        public static void ShowMenu(List<OpcionesMenu> opciones, Point location, ObjetoUsuario datosUsuario)
        {
            usuario = datosUsuario;
            nuevoMenu = new MenuContextual(opciones, location);
            nuevoMenu.Show();
        }


        private void MenuItem_Click(Object sender, EventArgs e)
        {
            Button menuItemClicked = (Button)sender;
            switch (menuItemClicked.Name)
            {
                case "optEditarUsuario":
                    nuevoMenu.Dispose();
                    ControlUsuarios.ActivarTabEditarUsuario(usuario);
                    break;

                case "optEliminarUsuario":
                    nuevoMenu.Dispose();
                    string rut = usuario.rut;
                    string nombre = usuario.nombre + " " + usuario.apellidos;
                    DialogResult result = Message.ShowMessage("Eliminar Usuario", "Está a punto de eliminar al usuario " + nombre + ", ¿Desea continuar?", Message.MessageType.information);
                    if (result == DialogResult.Yes)
                    {
                        if (UsersModel.EliminarUsuario(rut) > 0)
                        {
                            ControlUsuarios.listaUsuarios.listUsersData.DataSource = UsersModel.ObtenerUsuarios();
                            ControlUsuarios.listaUsuarios.listUsersData.ClearSelection();
                            ControlUsuarios.listaUsuarios.listUsersData.BringToFront();
                            Message.ShowMessage("Eliminación correcta", "El usuario " + nombre + ", se ha eliminado correctamente.", Message.MessageType.done);
                        }
                    }
                    break;

                case "optActualizarDatos":
                    nuevoMenu.Dispose();
                    Message.ShowMessage("DATOS DE USUARIO", "Actualizar datos de usuario.", Message.MessageType.warning);
                    break;

                case "optCambiarPass":
                    nuevoMenu.Dispose();
                    Message.ShowMessage("CONTRASEÑA", "Cambiar contraseña de la cuenta.", Message.MessageType.information);
                    break;

                case "optCambiarIdioma":
                    nuevoMenu.Dispose();
                    Message.ShowMessage("IDIOMA", "Cambiar idioma del sistema.", Message.MessageType.done);
                    break;

                case "optAyuda":
                    nuevoMenu.Dispose();
                    Message.ShowMessage("AYUDA", "Ingrsar al centro de ayuda del sistema.", Message.MessageType.error);
                    break;

                case "optCerrarSesion":
                    nuevoMenu.Dispose();

                    FormCollection formulariosAbiertos = Application.OpenForms;
                    Form formCerrar = null;
                    Form formMostrar = null;
                    foreach (Form formulario in formulariosAbiertos)
                    {
                        switch (formulario.Name)
                        {
                            case "FormPrincipal":
                                formCerrar = formulario;
                                break;
                            case "FormLogin":
                                formMostrar = formulario;
                                break;
                        }
                    }
                    formCerrar.Dispose();
                    formMostrar.Show();               
                    break;
            }
        }

        private void MenuContextual_Deactivate(object sender, EventArgs e)
        {
            nuevoMenu.Close();
            nuevoMenu.Dispose();
        }
    }
}
