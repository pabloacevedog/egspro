using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormNewUIdesign.Funciones;

namespace FormNewUIdesign.Componentes
{
    public partial class ControlPostulacion : UserControl
    {
        bool faseCrearGrupo_OK = false;
        bool faseAddGrupo_OK = false;
        bool faseAddDocs_OK = false;
        bool faseAddFormats_OK = false;

        bool activeCrearGrupo = true;
        bool activeAddGrupo = false;
        bool activeAddDocs = false;
        bool activeAddFormats = false;
        CrearGrupo crearGrupo;
        RegistrarPostulantes regPostulantes;

        public ControlPostulacion()
        {
            InitializeComponent();
            ovalCrearGrupo.BorderColor = Color.FromArgb(251, 168, 39);
            ovalCrearGrupo.BackgroundImage = Image.FromFile("../../iconos/account_group/orange.png");
            lblCrearGrupo.ForeColor = Color.FromArgb(251, 168, 39);
            lblCrearGrupo.Text = "Crear Grupo" + Environment.NewLine + "Postulantes";
            lblAddGrupo.Text = "Registrar" + Environment.NewLine + "Postulantes";
            lblAddDocs.Text = "Agregar" + Environment.NewLine + "Documentación";
            lblAddFormats.Text = "Generar" + Environment.NewLine + "Formatos";
            crearGrupo = new CrearGrupo(this);
            panelProcesos.Controls.Add(crearGrupo);
            crearGrupo.Dock = DockStyle.Fill;
            crearGrupo.BringToFront();

            regPostulantes = new RegistrarPostulantes();
            panelProcesos.Controls.Add(regPostulantes);
            regPostulantes.Dock = DockStyle.Fill;
        }
        

        public void btnGuardar_Click()
        {
            if (activeCrearGrupo)
            {
                faseCrearGrupo_OK = true;
                lineCrearGrupo.BorderColor = Color.FromArgb(15, 157, 88);
                checkCrearGrupo.Visible = true;
            }
            else if (activeAddGrupo)
            {
                faseAddGrupo_OK = true;
                lineAddGrupo.BorderColor = Color.FromArgb(15, 157, 88);
                checkAddGrupo.Visible = true;
            }
            else if (activeAddDocs)
            {
                faseAddDocs_OK = true;
                lineAddDocs.BorderColor = Color.FromArgb(15, 157, 88);
                checkAddDocs.Visible = true;
            }
            else if (activeAddFormats)
            {
                faseAddFormats_OK = true;
            }
        }

        public void ovalCrearGrupo_Click(object sender, EventArgs e)
        {
            activarTabCrearGrupo();
        }

        public void ovalAddGrupo_Click(object sender, EventArgs e)
        {
            activarTabRegistrarPostulantes();
        }

        public void ovalAddDocs_Click(object sender, EventArgs e)
        {
            activarTabAgregarDocs();
        }

        public void ovalAddFormats_Click(object sender, EventArgs e)
        {
            activarTabAgregarFormats();
        }

        public void activarTabCrearGrupo()
        {
            crearGrupo.BringToFront();
            activeCrearGrupo = true;
            activeAddGrupo = false;
            activeAddDocs = false;
            activeAddFormats = false;
            ovalCrearGrupo.BorderColor = Color.FromArgb(251, 168, 39);
            ovalCrearGrupo.BackgroundImage = Image.FromFile("../../iconos/account_group/orange.png");
            lblCrearGrupo.ForeColor = Color.FromArgb(251, 168, 39);

            if (faseAddGrupo_OK)
            {
                ovalAddGrupo.BorderColor = Color.FromArgb(15, 157, 88);
                ovalAddGrupo.BackgroundImage = Image.FromFile("../../iconos/group_add/green.png");
                lblAddGrupo.ForeColor = Color.FromArgb(15, 157, 88);
            }
            else
            {
                ovalAddGrupo.BorderColor = Color.FromArgb(169, 169, 169);
                ovalAddGrupo.BackgroundImage = Image.FromFile("../../iconos/group_add/dark_grey.png");
                lblAddGrupo.ForeColor = Color.FromArgb(169, 169, 169);
            }

            if (faseAddDocs_OK)
            {
                ovalAddDocs.BorderColor = Color.FromArgb(15, 157, 88);
                ovalAddDocs.BackgroundImage = Image.FromFile("../../iconos/add_documents/green.png");
                lblAddDocs.ForeColor = Color.FromArgb(15, 157, 88);
            }
            else
            {
                ovalAddDocs.BorderColor = Color.FromArgb(169, 169, 169);
                ovalAddDocs.BackgroundImage = Image.FromFile("../../iconos/add_documents/dark_grey.png");
                lblAddDocs.ForeColor = Color.FromArgb(169, 169, 169);
            }

            if (faseAddFormats_OK)
            {
                ovalAddFormats.BorderColor = Color.FromArgb(15, 157, 88);
                ovalAddFormats.BackgroundImage = Image.FromFile("../../iconos/formats/green.png");
                lblAddFormats.ForeColor = Color.FromArgb(15, 157, 88);
            }
            else
            {
                ovalAddFormats.BorderColor = Color.FromArgb(169, 169, 169);
                ovalAddFormats.BackgroundImage = Image.FromFile("../../iconos/formats/dark_grey.png");
                lblAddFormats.ForeColor = Color.FromArgb(169, 169, 169);
            }
        }

        public void activarTabRegistrarPostulantes()
        {
            regPostulantes.BringToFront();
            activeCrearGrupo = false;
            activeAddGrupo = true;
            activeAddDocs = false;
            activeAddFormats = false;
            ovalAddGrupo.BorderColor = Color.FromArgb(251, 168, 39);
            ovalAddGrupo.BackgroundImage = Image.FromFile("../../iconos/group_add/orange.png");
            lblAddGrupo.ForeColor = Color.FromArgb(251, 168, 39);

            if (faseCrearGrupo_OK)
            {
                ovalCrearGrupo.BorderColor = Color.FromArgb(15, 157, 88);
                ovalCrearGrupo.BackgroundImage = Image.FromFile("../../iconos/account_group/green.png");
                lblCrearGrupo.ForeColor = Color.FromArgb(15, 157, 88);
            }
            else
            {
                ovalCrearGrupo.BorderColor = Color.FromArgb(169, 169, 169);
                ovalCrearGrupo.BackgroundImage = Image.FromFile("../../iconos/account_group/dark_grey.png");
                lblCrearGrupo.ForeColor = Color.FromArgb(169, 169, 169);
            }

            if (faseAddDocs_OK)
            {
                ovalAddDocs.BorderColor = Color.FromArgb(15, 157, 88);
                ovalAddDocs.BackgroundImage = Image.FromFile("../../iconos/add_documents/green.png");
                lblAddDocs.ForeColor = Color.FromArgb(15, 157, 88);
            }
            else
            {
                ovalAddDocs.BorderColor = Color.FromArgb(169, 169, 169);
                ovalAddDocs.BackgroundImage = Image.FromFile("../../iconos/add_documents/dark_grey.png");
                lblAddDocs.ForeColor = Color.FromArgb(169, 169, 169);
            }

            if (faseAddFormats_OK)
            {
                ovalAddFormats.BorderColor = Color.FromArgb(15, 157, 88);
                ovalAddFormats.BackgroundImage = Image.FromFile("../../iconos/formats/green.png");
                lblAddFormats.ForeColor = Color.FromArgb(15, 157, 88);
            }
            else
            {
                ovalAddFormats.BorderColor = Color.FromArgb(169, 169, 169);
                ovalAddFormats.BackgroundImage = Image.FromFile("../../iconos/formats/dark_grey.png");
                lblAddFormats.ForeColor = Color.FromArgb(169, 169, 169);
            }
        }

        public void activarTabAgregarDocs()
        {
            activeCrearGrupo = false;
            activeAddGrupo = false;
            activeAddDocs = true;
            activeAddFormats = false;
            ovalAddDocs.BorderColor = Color.FromArgb(251, 168, 39);
            ovalAddDocs.BackgroundImage = Image.FromFile("../../iconos/add_documents/orange.png");
            lblAddDocs.ForeColor = Color.FromArgb(251, 168, 39);

            if (faseCrearGrupo_OK)
            {
                ovalCrearGrupo.BorderColor = Color.FromArgb(15, 157, 88);
                ovalCrearGrupo.BackgroundImage = Image.FromFile("../../iconos/account_group/green.png");
                lblCrearGrupo.ForeColor = Color.FromArgb(15, 157, 88);
            }
            else
            {
                ovalCrearGrupo.BorderColor = Color.FromArgb(169, 169, 169);
                ovalCrearGrupo.BackgroundImage = Image.FromFile("../../iconos/account_group/dark_grey.png");
                lblCrearGrupo.ForeColor = Color.FromArgb(169, 169, 169);
            }

            if (faseAddGrupo_OK)
            {
                ovalAddGrupo.BorderColor = Color.FromArgb(15, 157, 88);
                ovalAddGrupo.BackgroundImage = Image.FromFile("../../iconos/group_add/green.png");
                lblAddGrupo.ForeColor = Color.FromArgb(15, 157, 88);
            }
            else
            {
                ovalAddGrupo.BorderColor = Color.FromArgb(169, 169, 169);
                ovalAddGrupo.BackgroundImage = Image.FromFile("../../iconos/group_add/dark_grey.png");
                lblAddGrupo.ForeColor = Color.FromArgb(169, 169, 169);
            }

            if (faseAddFormats_OK)
            {
                ovalAddFormats.BorderColor = Color.FromArgb(15, 157, 88);
                ovalAddFormats.BackgroundImage = Image.FromFile("../../iconos/formats/green.png");
                lblAddFormats.ForeColor = Color.FromArgb(15, 157, 88);
            }
            else
            {
                ovalAddFormats.BorderColor = Color.FromArgb(169, 169, 169);
                ovalAddFormats.BackgroundImage = Image.FromFile("../../iconos/formats/dark_grey.png");
                lblAddFormats.ForeColor = Color.FromArgb(169, 169, 169);
            }
        }

        public void activarTabAgregarFormats()
        {
            activeCrearGrupo = false;
            activeAddGrupo = false;
            activeAddDocs = false;
            activeAddFormats = true;
            ovalAddFormats.BorderColor = Color.FromArgb(251, 168, 39);
            ovalAddFormats.BackgroundImage = Image.FromFile("../../iconos/formats/orange.png");
            lblAddFormats.ForeColor = Color.FromArgb(251, 168, 39);

            if (faseCrearGrupo_OK)
            {
                ovalCrearGrupo.BorderColor = Color.FromArgb(15, 157, 88);
                ovalCrearGrupo.BackgroundImage = Image.FromFile("../../iconos/account_group/green.png");
                lblCrearGrupo.ForeColor = Color.FromArgb(15, 157, 88);
            }
            else
            {
                ovalCrearGrupo.BorderColor = Color.FromArgb(169, 169, 169);
                ovalCrearGrupo.BackgroundImage = Image.FromFile("../../iconos/account_group/dark_grey.png");
                lblCrearGrupo.ForeColor = Color.FromArgb(169, 169, 169);
            }

            if (faseAddGrupo_OK)
            {
                ovalAddGrupo.BorderColor = Color.FromArgb(15, 157, 88);
                ovalAddGrupo.BackgroundImage = Image.FromFile("../../iconos/group_add/green.png");
                lblAddGrupo.ForeColor = Color.FromArgb(15, 157, 88);
            }
            else
            {
                ovalAddGrupo.BorderColor = Color.FromArgb(169, 169, 169);
                ovalAddGrupo.BackgroundImage = Image.FromFile("../../iconos/group_add/dark_grey.png");
                lblAddGrupo.ForeColor = Color.FromArgb(169, 169, 169);
            }

            if (faseAddDocs_OK)
            {
                ovalAddDocs.BorderColor = Color.FromArgb(15, 157, 88);
                ovalAddDocs.BackgroundImage = Image.FromFile("../../iconos/add_documents/green.png");
                lblAddDocs.ForeColor = Color.FromArgb(15, 157, 88);
            }
            else
            {
                ovalAddDocs.BorderColor = Color.FromArgb(169, 169, 169);
                ovalAddDocs.BackgroundImage = Image.FromFile("../../iconos/add_documents/dark_grey.png");
                lblAddDocs.ForeColor = Color.FromArgb(169, 169, 169);
            }
        }
    }
}
