using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using FormNewUIdesign.Modelo;
using FormNewUIdesign.Componentes;
using FormNewUIdesign.Funciones;

namespace FormNewUIdesign
{
    public partial class FormPrincipal : Form
    {
        public ObjetoUsuario objetoUsuario = new ObjetoUsuario();
        string elementoMenuActual = "Dashboard";
        string elementoMenuAnterior = "Dashboard";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public FormPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            lblCalendario.Text = DateTime.Today.ToString("D").Split(',')[0].ToUpper() + ", " + DateTime.Today.ToString("d");
            this.Move += new EventHandler(formulario_Move);
        }

        #region "Eventos Cerrar, Minimizar, Maximizar, Restaurar y Mover"

        private void formulario_Move(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnResturar.Visible = false;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnResturar.Visible = true;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnResturar_Click(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnResturar.Visible = false;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int WParam, int lParam);
        private void tituloPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void logoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Transparent;
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(237, 148, 9);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.Transparent;
        }

        private void btnResturar_MouseEnter(object sender, EventArgs e)
        {
            btnResturar.BackColor = Color.FromArgb(237, 148, 9);
        }

        private void btnResturar_MouseLeave(object sender, EventArgs e)
        {
            btnResturar.BackColor = Color.Transparent;
        }

        private void btnMaximizar_MouseEnter(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(237, 148, 9);
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.Transparent;
        }

        #endregion

        #region "Funciones Menú"

        private void imgSlideMenu_Click(object sender, EventArgs e)
        {
            if (menuPanel.Width == 200)
            {
                logo.Visible = false;
                menuPanel.Width = 55;
                imgSlideMenu.Image = Image.FromFile("../../iconos/slide_right/white.png");
                lblUsername.Visible = false;
                imgUsername.Location = new Point(6, 4);
            }
            else
            {
                menuPanel.Width = 200;
                imgSlideMenu.Image = Image.FromFile("../../iconos/slide_left/white.png");
                logo.Visible = true;
                lblUsername.Visible = true;
                imgUsername.Location = new Point(6, 4);
                lblUsername.Location = new Point(64, 10);
            }
        }

        private void colorActiveMenu(string elemento, Button boton)
        {
            boton.BackColor = Color.FromArgb(251, 168, 39);
            boton.ForeColor = Color.White;
            if (boton.BackColor == Color.FromArgb(251, 168, 39))
            {
                boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 168, 39);
                boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(251, 168, 39);
            }
            else
            {
                boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 137, 201);
                boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 137, 201);
            }

            switch (elemento)
            {
                case "Dashboard":
                    boton.Image = Image.FromFile("../../iconos/dashboard/white.png");
                    break;

                case "Usuarios":
                    boton.Image = Image.FromFile("../../iconos/account_group/white.png");
                    break;

                case "Postulación":
                    boton.Image = Image.FromFile("../../iconos/projects/white.png");
                    break;

                case "Postulantes":
                    boton.Image = Image.FromFile("../../iconos/system/white.png");
                    break;

                case "Sistema":
                    boton.Image = Image.FromFile("../../iconos/clients/white.png");
                    break;

                case "Grupos Ingresados":
                    boton.Image = Image.FromFile("../../iconos/groups/white.png");
                    break;

                case "Configuración":
                    boton.Image = Image.FromFile("../../iconos/settings/white.png");
                    break;

                case "Reportes":
                    boton.Image = Image.FromFile("../../iconos/reports/white.png");
                    break;
            }
        }

        private void colorInactiveMenu(string elemento)
        {
            Button boton = new Button();

            switch (elemento)
            {
                case "Dashboard":
                    foreach (Control item in Controls.Find("btnDashboard", true))
                    {
                        boton = item as Button;
                        boton.BackColor = Color.FromArgb(235, 235, 235);
                        boton.ForeColor = Color.DimGray;
                        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
                        boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
                        boton.Image = Image.FromFile("../../iconos/dashboard/grey.png");
                    }
                    break;

                case "Usuarios":
                    foreach (Control item in Controls.Find("btnUsers", true))
                    {
                        boton = item as Button;
                        boton.BackColor = Color.FromArgb(235, 235, 235);
                        boton.ForeColor = Color.DimGray;
                        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
                        boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
                        boton.Image = Image.FromFile("../../iconos/account_group/grey.png");
                    }
                    break;

                case "Postulación":
                    foreach (Control item in Controls.Find("btnPostulacion", true))
                    {
                        boton = item as Button;
                        boton.BackColor = Color.FromArgb(235, 235, 235);
                        boton.ForeColor = Color.DimGray;
                        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
                        boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
                        boton.Image = Image.FromFile("../../iconos/projects/grey.png");
                    }
                    break;

                case "Postulantes":
                    foreach (Control item in Controls.Find("btnPostulantes", true))
                    {
                        boton = item as Button;
                        boton.BackColor = Color.FromArgb(235, 235, 235);
                        boton.ForeColor = Color.DimGray;
                        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
                        boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
                        boton.Image = Image.FromFile("../../iconos/clients/grey.png");
                    }
                    break;

                case "Sistema":
                    foreach (Control item in Controls.Find("btnSystem", true))
                    {
                        boton = item as Button;
                        boton.BackColor = Color.FromArgb(235, 235, 235);
                        boton.ForeColor = Color.DimGray;
                        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
                        boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
                        boton.Image = Image.FromFile("../../iconos/system/grey.png");
                    }                    
                    break;

                case "Grupos Ingresados":
                    foreach (Control item in Controls.Find("btnGrupos", true))
                    {
                        boton = item as Button;
                        boton.BackColor = Color.FromArgb(235, 235, 235);
                        boton.ForeColor = Color.DimGray;
                        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
                        boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
                        boton.Image = Image.FromFile("../../iconos/groups/grey.png");
                    }
                    break;

                case "Configuración":
                    foreach (Control item in Controls.Find("btnConfig", true))
                    {
                        boton = item as Button;
                        boton.BackColor = Color.FromArgb(235, 235, 235);
                        boton.ForeColor = Color.DimGray;
                        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
                        boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
                        boton.Image = Image.FromFile("../../iconos/settings/grey.png");
                    }
                    break;

                case "Reportes":
                    foreach (Control item in Controls.Find("btnReportes", true))
                    {
                        boton = item as Button;
                        boton.BackColor = Color.FromArgb(235, 235, 235);
                        boton.ForeColor = Color.DimGray;
                        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
                        boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
                        boton.Image = Image.FromFile("../../iconos/reports/grey.png");
                    }
                    break;
            }
        }

        #endregion

        public void SetTextoUsername(string nombre)
        {
            lblUsername.Text = nombre;
        }

        public static void SetUserImage(string rutaImagenPerfil)
        {
            imgUsername.BackgroundImage = Image.FromFile(rutaImagenPerfil);
        }

        private void btnDataUser_MouseEnter(object sender, EventArgs e)
        {
            btnDataUser.BackColor = Color.FromArgb(13, 130, 73);
        }

        private void btnDataUser_MouseLeave(object sender, EventArgs e)
        {
            btnDataUser.BackColor = Color.FromArgb(15, 157, 88);
        }

        private void btnDataUser_Click(object sender, EventArgs e)
        {
            if (controlPanel.Height == 50)
            {
                controlPanel.Height = 200;
                btnDataUser.Image = Image.FromFile("../../iconos/arrow_down/white.png");
                imgUsername.Location = new Point(6, 4);
                lblUsername.Location = new Point(64, 10);

                List<OpcionesMenu> opciones = new List<OpcionesMenu>();
                OpcionesMenu opcion = new OpcionesMenu();
                opcion.id = "optActualizarDatos";
                opcion.texto = "        Actualizar Datos";
                opcion.imagen = "../../iconos/edit/white.png";
                opciones.Add(opcion);

                opcion = new OpcionesMenu();
                opcion.id = "optCambiarPass";
                opcion.texto = "        Cambiar Contraseña";
                opcion.imagen = "../../iconos/password/white.png";
                opciones.Add(opcion);

                opcion = new OpcionesMenu();
                opcion.id = "optAyuda";
                opcion.texto = "        Centro de Ayuda";
                opcion.imagen = "../../iconos/help_center/white.png";
                opciones.Add(opcion);

                opcion = new OpcionesMenu();
                opcion.id = "optCerrarSesion";
                opcion.texto = "        Cerrar Sesión";
                opcion.imagen = "../../iconos/log_out/white.png";
                opciones.Add(opcion);

                int posicion_Y = 60;
                int x = 0;
                foreach (var item in opciones)
                {
                    Panel bordeBoton = new Panel();
                    bordeBoton.BackColor = Color.FromArgb(13, 130, 73);
                    bordeBoton.Location = new Point(0, posicion_Y);
                    bordeBoton.Name = "borde_" + x;
                    bordeBoton.Size = new Size(5, 32);
                    bordeBoton.Margin = new Padding(0);
                    bordeBoton.TabIndex = 0;

                    Button botonOpcion = new Button();
                    botonOpcion.FlatAppearance.BorderSize = 0;
                    botonOpcion.FlatAppearance.BorderColor = Color.FromArgb(15, 157, 88);
                    botonOpcion.Cursor = Cursors.Hand;
                    botonOpcion.BackColor = Color.FromArgb(15, 157, 88);
                    botonOpcion.ForeColor = Color.White;
                    botonOpcion.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 130, 73);
                    botonOpcion.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 130, 73);
                    botonOpcion.FlatStyle = FlatStyle.Flat;
                    botonOpcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    botonOpcion.Image = Image.FromFile(item.imagen); ;
                    botonOpcion.ImageAlign = ContentAlignment.MiddleLeft;
                    botonOpcion.TextAlign = ContentAlignment.MiddleLeft;
                    botonOpcion.Location = new Point(5, posicion_Y);
                    botonOpcion.Margin = new Padding(0);
                    botonOpcion.Name = item.id;
                    botonOpcion.Size = new Size(196, 32);
                    botonOpcion.TabIndex = 0;
                    botonOpcion.TabStop = false;
                    botonOpcion.Text = "     " + item.texto;
                    botonOpcion.UseVisualStyleBackColor = true;
                    botonOpcion.Click += new EventHandler(MenuItem_Click);

                    controlPanel.Controls.Add(bordeBoton);
                    controlPanel.Controls.Add(botonOpcion);

                    posicion_Y += 32;
                    x++;
                }

            }
            else
            {
                controlPanel.Height = 50;
                btnDataUser.Image = Image.FromFile("../../iconos/arrow_up/white.png");
                imgUsername.Location = new Point(6, 4);
                lblUsername.Location = new Point(64, 10);
            }
        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            Dashboard dashboardControl = new Dashboard();
            contentPanel.Controls.Add(dashboardControl);
            dashboardControl.Dock = DockStyle.Fill;
            dashboardControl.BringToFront();

            if (objetoUsuario.img_perfil != "" && objetoUsuario.img_perfil != null)
            {
                string rutaImagenPerfil = Path.Combine(UsersModel.ObtenerDirectorioFotosPerfil(), objetoUsuario.img_perfil);
                if (File.Exists(rutaImagenPerfil))
                {
                    imgUsername.BackgroundImage = Image.FromFile(rutaImagenPerfil);
                }
                else
                {
                    imgUsername.BackgroundImage = Image.FromFile(Path.Combine(UsersModel.ObtenerDirectorioFotosPerfil(), "user_default.png"));
                }
            }

            //***********************************************************************
            //***********************************************************************
            //***** CARGAR DESDE BD TODOS LOS MENUES ASOCIADOS AL PERFIL ACTUAL *****
            //***********************************************************************
            //***********************************************************************

            List<OpcionesMenu> opciones = new List<OpcionesMenu>();
            OpcionesMenu opcion = new OpcionesMenu();
            opcion.id = "btnDashboard";
            opcion.texto = "        Dashboard";
            opcion.imagen = "../../iconos/dashboard/white.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "btnPostulantes";
            opcion.texto = "        Postulantes";
            opcion.imagen = "../../iconos/clients/grey.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "btnPostulacion";
            opcion.texto = "        Postulación";
            opcion.imagen = "../../iconos/projects/grey.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "btnGrupos";
            opcion.texto = "        Grupos Ingresados";
            opcion.imagen = "../../iconos/groups/grey.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "btnSystem";
            opcion.texto = "        Sistema";
            opcion.imagen = "../../iconos/system/grey.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "btnUsers";
            opcion.texto = "        Usuarios";
            opcion.imagen = "../../iconos/account_group/grey.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "btnPerfiles";
            opcion.texto = "        Perfiles";
            opcion.imagen = "../../iconos/account_group/grey.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "btnConstantes";
            opcion.texto = "        Constantes";
            opcion.imagen = "../../iconos/account_group/grey.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "btnConfig";
            opcion.texto = "        Configuración";
            opcion.imagen = "../../iconos/settings/grey.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "btnReportes";
            opcion.texto = "        Reportes";
            opcion.imagen = "../../iconos/reports/grey.png";
            opciones.Add(opcion);


            int posicion_Y = logo.Height + 50;
            int x = 0;
            foreach (var item in opciones)
            {
                Panel bordeBoton = new Panel();
                bordeBoton.BackColor = Color.FromArgb(255, 154, 0);
                bordeBoton.Location = new Point(0, posicion_Y);
                bordeBoton.Name = "borde_" + x;
                bordeBoton.Size = new Size(5, 32);
                bordeBoton.Margin = new Padding(0);
                bordeBoton.TabIndex = 0;

                Button botonOpcion = new Button();
                botonOpcion.FlatAppearance.BorderSize = 0;
                botonOpcion.FlatAppearance.BorderColor = Color.FromArgb(167, 204, 232);
                botonOpcion.Cursor = Cursors.Hand;

                if (item.id == "btnDashboard")
                {
                    botonOpcion.BackColor = Color.FromArgb(251, 168, 39);
                    botonOpcion.ForeColor = Color.White;
                    botonOpcion.FlatAppearance.MouseDownBackColor = Color.FromArgb(251, 168, 39);
                    botonOpcion.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 168, 39);
                }
                else
                {
                    botonOpcion.BackColor = Color.FromArgb(235, 235, 235);
                    botonOpcion.ForeColor = Color.DimGray;
                    botonOpcion.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
                    botonOpcion.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
                }
                botonOpcion.FlatStyle = FlatStyle.Flat;
                botonOpcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                botonOpcion.Image = Image.FromFile(item.imagen); ;
                botonOpcion.ImageAlign = ContentAlignment.MiddleLeft;
                botonOpcion.TextAlign = ContentAlignment.MiddleLeft;
                botonOpcion.Location = new Point(5, posicion_Y);
                botonOpcion.Margin = new Padding(0);
                botonOpcion.Name = item.id;
                botonOpcion.Size = new Size(196, 32);
                botonOpcion.TabIndex = 0;
                botonOpcion.TabStop = false;
                botonOpcion.Text = "     " + item.texto;
                botonOpcion.UseVisualStyleBackColor = true;
                botonOpcion.Click += new EventHandler(MenuItem_Click);
                botonOpcion.MouseEnter += new EventHandler(botonOpcion_MouseEnter);
                botonOpcion.MouseLeave += new EventHandler(botonOpcion_MouseLeave);

                menuPanel.Controls.Add(bordeBoton);
                menuPanel.Controls.Add(botonOpcion);

                posicion_Y += 32;
                x++;
            }
        }

        private void MenuItem_Click(Object sender, EventArgs e)
        {
            Button menuItemClicked = (Button)sender;
            switch (menuItemClicked.Name)
            {
                case "btnDashboard":
                    lblTitulo.Text = "Dashboard";
                    elementoMenuAnterior = elementoMenuActual;
                    elementoMenuActual = "Dashboard";
                    imgTitle.Image = Image.FromFile("../../iconos/dashboard/white.png");
                    colorActiveMenu(elementoMenuActual, menuItemClicked);
                    if (elementoMenuActual != elementoMenuAnterior)
                    {
                        colorInactiveMenu(elementoMenuAnterior);
                    }
                    Dashboard dashboardControl = new Dashboard();
                    contentPanel.Controls.Add(dashboardControl);
                    dashboardControl.Dock = DockStyle.Fill;
                    dashboardControl.BringToFront();
                    break;

                case "btnUsers":
                    lblTitulo.Text = "Usuarios";
                    elementoMenuAnterior = elementoMenuActual;
                    elementoMenuActual = "Usuarios";
                    imgTitle.Image = Image.FromFile("../../iconos/account_group/white.png");
                    colorActiveMenu(elementoMenuActual, menuItemClicked);
                    if (elementoMenuActual != elementoMenuAnterior)
                    {
                        colorInactiveMenu(elementoMenuAnterior);
                    }
                    ControlUsuarios controlUsuarios = new ControlUsuarios();
                    contentPanel.Controls.Add(controlUsuarios);
                    controlUsuarios.Dock = DockStyle.Fill;
                    controlUsuarios.BringToFront();
                    break;

                case "btnPostulacion":
                    lblTitulo.Text = "Postulación";
                    elementoMenuAnterior = elementoMenuActual;
                    elementoMenuActual = "Postulación";
                    imgTitle.Image = Image.FromFile("../../iconos/projects/white.png");
                    colorActiveMenu(elementoMenuActual, menuItemClicked);
                    if (elementoMenuActual != elementoMenuAnterior)
                    {
                        colorInactiveMenu(elementoMenuAnterior);
                    }
                    ControlPostulacion controlPostulacion = new ControlPostulacion();
                    contentPanel.Controls.Add(controlPostulacion);
                    controlPostulacion.Dock = DockStyle.Fill;
                    controlPostulacion.BringToFront();
                    break;

                case "btnPostulantes":
                    lblTitulo.Text = "Postulantes";
                    elementoMenuAnterior = elementoMenuActual;
                    elementoMenuActual = "Postulantes";
                    imgTitle.Image = Image.FromFile("../../iconos/clients/white.png");
                    colorActiveMenu(elementoMenuActual, menuItemClicked);
                    if (elementoMenuActual != elementoMenuAnterior)
                    {
                        colorInactiveMenu(elementoMenuAnterior);
                    }
                    break;

                case "btnSystem":
                    lblTitulo.Text = "Sistema";
                    elementoMenuAnterior = elementoMenuActual;
                    elementoMenuActual = "Sistema";
                    imgTitle.Image = Image.FromFile("../../iconos/system/white.png");
                    colorActiveMenu(elementoMenuActual, menuItemClicked);
                    if (elementoMenuActual != elementoMenuAnterior)
                    {
                        colorInactiveMenu(elementoMenuAnterior);
                    }
                    break;

                case "btnGrupos":
                    lblTitulo.Text = "Grupos Ingresados";
                    elementoMenuAnterior = elementoMenuActual;
                    elementoMenuActual = "Grupos Ingresados";
                    imgTitle.Image = Image.FromFile("../../iconos/groups/white.png");
                    colorActiveMenu(elementoMenuActual, menuItemClicked);
                    if (elementoMenuActual != elementoMenuAnterior)
                    {
                        colorInactiveMenu(elementoMenuAnterior);
                    }

                    GruposIngresados gruposIngresados = new GruposIngresados();
                    contentPanel.Controls.Add(gruposIngresados);
                    gruposIngresados.Dock = DockStyle.Fill;
                    gruposIngresados.BringToFront();
                    break;

                case "btnConfig":
                    lblTitulo.Text = "Configuración";
                    elementoMenuAnterior = elementoMenuActual;
                    elementoMenuActual = "Configuración";
                    imgTitle.Image = Image.FromFile("../../iconos/settings/white.png");
                    colorActiveMenu(elementoMenuActual, menuItemClicked);
                    if (elementoMenuActual != elementoMenuAnterior)
                    {
                        colorInactiveMenu(elementoMenuAnterior);
                    }
                    break;

                case "btnReportes":
                    lblTitulo.Text = "Reportes";
                    elementoMenuAnterior = elementoMenuActual;
                    elementoMenuActual = "Reportes";
                    imgTitle.Image = Image.FromFile("../../iconos/reports/white.png");
                    colorActiveMenu(elementoMenuActual, menuItemClicked);
                    if (elementoMenuActual != elementoMenuAnterior)
                    {
                        colorInactiveMenu(elementoMenuAnterior);
                    }
                    break;

                case "optActualizarDatos":
                    Message.ShowMessage("DATOS DE USUARIO", "Actualizar datos de usuario.", Message.MessageType.warning);
                    break;

                case "optCambiarPass":
                    Message.ShowMessage("CONTRASEÑA", "Cambiar contraseña de la cuenta.", Message.MessageType.done);
                    break;

                case "optAyuda":
                    Message.ShowMessage("AYUDA", "Ingrsar al centro de ayuda del sistema.", Message.MessageType.error);
                    break;

                case "optCerrarSesion":
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
                    Mixin.VG.activeTabListUsers = true;
                    Mixin.VG.activeTabAddUser = false;
                    Mixin.VG.activeTabEditUser = false;
                    formCerrar.Dispose();
                    formMostrar.Show();
                    break;
            }
        }

        public void botonOpcion_MouseEnter(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (elementoMenuActual != boton.Text.TrimStart())
            {
                boton.ForeColor = Color.FromArgb(251, 168, 39);
                boton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {
                boton.ForeColor = Color.White;
            }
            

            switch (boton.Name)
            {
                case "btnDashboard":
                    if (elementoMenuActual != boton.Text.TrimStart())
                    {
                        boton.Image = Image.FromFile("../../iconos/dashboard/orange.png");
                    }
                    else
                    {
                        boton.Image = Image.FromFile("../../iconos/dashboard/white.png");
                    }
                    break;

                case "btnUsers":
                    if (elementoMenuActual != boton.Text.TrimStart())
                    {
                        boton.Image = Image.FromFile("../../iconos/account_group/orange.png");
                    }
                    else
                    {
                        boton.Image = Image.FromFile("../../iconos/account_group/white.png");
                    }
                    break;

                case "btnPostulacion":
                    if (elementoMenuActual != boton.Text.TrimStart())
                    {
                        boton.Image = Image.FromFile("../../iconos/projects/orange.png");
                    }
                    else
                    {
                        boton.Image = Image.FromFile("../../iconos/projects/white.png");
                    }
                    break;

                case "btnPostulantes":
                    if (elementoMenuActual != boton.Text.TrimStart())
                    {
                        boton.Image = Image.FromFile("../../iconos/clients/orange.png");
                    }
                    else
                    {
                        boton.Image = Image.FromFile("../../iconos/clients/white.png");
                    }
                    break;

                case "btnSystem":
                    if (elementoMenuActual != boton.Text.TrimStart())
                    {
                        boton.Image = Image.FromFile("../../iconos/system/orange.png");
                    }
                    else
                    {
                        boton.Image = Image.FromFile("../../iconos/system/white.png");
                    }
                    break;

                case "btnGrupos":
                    if (elementoMenuActual != boton.Text.TrimStart())
                    {
                        boton.Image = Image.FromFile("../../iconos/groups/orange.png");
                    }
                    else
                    {
                        boton.Image = Image.FromFile("../../iconos/groups/white.png");
                    }
                    break;

                case "btnConfig":
                    if (elementoMenuActual != boton.Text.TrimStart())
                    {
                        boton.Image = Image.FromFile("../../iconos/settings/orange.png");
                    }
                    else
                    {
                        boton.Image = Image.FromFile("../../iconos/settings/white.png");
                    }
                    break;

                case "btnReportes":
                    if (elementoMenuActual != boton.Text.TrimStart())
                    {
                        boton.Image = Image.FromFile("../../iconos/reports/orange.png");
                    }
                    else
                    {
                        boton.Image = Image.FromFile("../../iconos/reports/white.png");
                    }
                    break;
            }
        }

        public void botonOpcion_MouseLeave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            switch (boton.Name)
            {
                case "btnDashboard":
                    if (elementoMenuActual != "Dashboard")
                    {
                        boton.ForeColor = Color.DimGray;
                        boton.Image = Image.FromFile("../../iconos/dashboard/grey.png");
                    }
                    break;

                case "btnUsers":
                    if (elementoMenuActual != "Usuarios")
                    {
                        boton.ForeColor = Color.DimGray;
                        boton.Image = Image.FromFile("../../iconos/account_group/grey.png");
                    }
                    break;

                case "btnPostulacion":
                    if (elementoMenuActual != "Postulación")
                    {
                        boton.ForeColor = Color.DimGray;
                        boton.Image = Image.FromFile("../../iconos/projects/grey.png");
                    }
                    break;

                case "btnPostulantes":
                    if (elementoMenuActual != "Postulantes")
                    {
                        boton.ForeColor = Color.DimGray;
                        boton.Image = Image.FromFile("../../iconos/clients/grey.png");
                    }
                    break;

                case "btnSystem":
                    if (elementoMenuActual != "Sistema")
                    {
                        boton.ForeColor = Color.DimGray;
                        boton.Image = Image.FromFile("../../iconos/system/grey.png");
                    }
                    break;

                case "btnGrupos":
                    if (elementoMenuActual != "Grupos Ingresados")
                    {
                        boton.ForeColor = Color.DimGray;
                        boton.Image = Image.FromFile("../../iconos/groups/grey.png");
                    }
                    break;

                case "btnConfig":
                    if (elementoMenuActual != "Configuración")
                    {
                        boton.ForeColor = Color.DimGray;
                        boton.Image = Image.FromFile("../../iconos/settings/grey.png");
                    }
                    break;

                case "btnReportes":
                    if (elementoMenuActual != "Reportes")
                    {
                        boton.ForeColor = Color.DimGray;
                        boton.Image = Image.FromFile("../../iconos/reports/grey.png");
                    }
                    break;
            }
        }
    }
}
