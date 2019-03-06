using FormNewUIdesign.Componentes;
using FormNewUIdesign.Funciones;
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
        static ObjetoGrupo grupo;
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
                bordeBoton.BackColor = Color.FromArgb(255, 154, 0);
                bordeBoton.Location = new Point(0, posicion_Y);
                bordeBoton.Name = "borde_" + x;
                bordeBoton.Size = new Size(5, 40);
                bordeBoton.Margin = new Padding(0);
                bordeBoton.TabIndex = 0;

                Button botonOpcion = new Button();
                botonOpcion.FlatAppearance.BorderSize = 0;
                botonOpcion.FlatAppearance.BorderColor = Color.FromArgb(167, 204, 232);
                botonOpcion.Cursor = Cursors.Hand;
                botonOpcion.FlatAppearance.MouseDownBackColor = Color.FromArgb(251, 168, 39);
                botonOpcion.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 168, 39);
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
                botonOpcion.MouseEnter += new EventHandler(botonOpcion_MouseEnter);
                botonOpcion.MouseLeave += new EventHandler(botonOpcion_MouseLeave);

                contenedorOpciones.Controls.Add(bordeBoton);
                contenedorOpciones.Controls.Add(botonOpcion);

                posicion_Y += 40;
                x++;
            }
        }


        public static void ShowMenu(List<OpcionesMenu> opciones, Point location, object data, string type)
        {
            if (type == "usuario")
            {
                usuario = data as ObjetoUsuario;
            }
            else
            {
                if (type == "grupo")
                {
                    grupo = data as ObjetoGrupo;
                }
            }
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
                    DialogResult resultUser = Message.ShowMessage("Eliminar Usuario", "Está a punto de eliminar al usuario " + nombre + ", ¿Desea continuar?", Message.MessageType.information);
                    if (resultUser == DialogResult.Yes)
                    {
                        if (UsersModel.EliminarUsuario(rut) > 0)
                        {
                            ControlUsuarios.listaUsuarios.listUsersData.DataSource = UsersModel.ObtenerUsuarios();
                            ControlUsuarios.listaUsuarios.listUsersData.Columns["Password"].Visible = false;
                            ControlUsuarios.listaUsuarios.listUsersData.ClearSelection();
                            ControlUsuarios.listaUsuarios.listUsersData.BringToFront();
                            Message.ShowMessage("Eliminación correcta", "El usuario " + nombre + ", se ha eliminado correctamente.", Message.MessageType.done);
                        }
                    }
                    break;

                case "optEliminarGrupo":
                    nuevoMenu.Dispose();
                    string identificador = grupo.Identificador;
                    string proyecto = grupo.Proyecto;
                    DialogResult resultGrupo = Message.ShowMessage("Eliminar Grupo", "Está a punto de eliminar el grupo " + identificador + " asociado a un proyecto de " + proyecto + ", ¿Desea continuar?", Message.MessageType.information);
                    if (resultGrupo == DialogResult.Yes)
                    {
                        if (GruposModel.EliminarGrupo(identificador) > 0)
                        {
                            GruposIngresados.listGruposIng.DataSource = GruposModel.ObtenerGrupos();
                            GruposIngresados.listGruposIng.ClearSelection();
                            GruposIngresados.listGruposIng.BringToFront();
                            Message.ShowMessage("Eliminación correcta", "El grupo " + identificador + ", se ha eliminado correctamente.", Message.MessageType.done);
                        }
                    }
                    break;

                case "optEditarGrupo":
                    nuevoMenu.Dispose();
                    Message.ShowMessage("Eliminación correcta", "EDITAR GRUPO", Message.MessageType.done);
                    break;
            }
        }

        private void MenuContextual_Deactivate(object sender, EventArgs e)
        {
            nuevoMenu.Close();
            nuevoMenu.Dispose();
        }

        public void botonOpcion_MouseEnter(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.ForeColor = Color.White;

            switch (boton.Name)
            {
                case "optEditarUsuario":
                case "optEditarGrupo":
                    boton.Image = Image.FromFile("../../iconos/edit/white.png");
                    
                    break;

                case "optEliminarUsuario":
                case "optEliminarGrupo":
                    boton.Image = Image.FromFile("../../iconos/delete_user/white.png");
                    break;

                case "optActualizarDatos":
                    boton.Image = Image.FromFile("../../iconos/edit/white.png");
                    break;

                case "optCambiarPass":
                    boton.Image = Image.FromFile("../../iconos/password/white.png");
                    break;

                case "optAyuda":
                    boton.Image = Image.FromFile("../../iconos/help_center/white.png");
                    break;

                case "optCerrarSesion":
                    boton.Image = Image.FromFile("../../iconos/log_out/white.png");
                    break;
            }
        }

        public void botonOpcion_MouseLeave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.ForeColor = Color.DimGray;

            switch (boton.Name)
            {
                case "optEditarUsuario":
                case "optEditarGrupo":
                    boton.Image = Image.FromFile("../../iconos/edit/grey.png");

                    break;

                case "optEliminarUsuario":
                case "optEliminarGrupo":
                    boton.Image = Image.FromFile("../../iconos/delete_user/grey.png");
                    break;

                case "optActualizarDatos":
                    boton.Image = Image.FromFile("../../iconos/edit/grey.png");
                    break;

                case "optCambiarPass":
                    boton.Image = Image.FromFile("../../iconos/password/grey.png");
                    break;

                case "optAyuda":
                    boton.Image = Image.FromFile("../../iconos/help_center/grey.png");
                    break;

                case "optCerrarSesion":
                    boton.Image = Image.FromFile("../../iconos/log_out/grey.png");
                    break;
            }
        }
    }
}
