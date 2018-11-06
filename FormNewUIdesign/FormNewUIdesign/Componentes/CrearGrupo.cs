using System;
using System.Drawing;
using System.Windows.Forms;
using FormNewUIdesign.Modelo;
using System.Collections.Generic;
using FormNewUIdesign.Funciones;

namespace FormNewUIdesign.Componentes
{
    public partial class CrearGrupo : UserControl
    {
        static ControlPostulacion controlPostulacion;
        bool ERROR_nombre_grupo = true;
        bool ERROR_razon_social = true;
        bool ERROR_pers_jurid = true;
        bool ERROR_nombre_presi = true;
        bool ERROR_contacto_presi = true;
        bool ERROR_proyecto = true;

        public CrearGrupo(ControlPostulacion obj)
        {
            InitializeComponent();
            controlPostulacion = obj;

            Dictionary<string, string> objeto = new Dictionary<string, string>();
            objeto.Add("0", "Seleccione");

            cbxProyecto.DataSource = new BindingSource(objeto, null);
            cbxProyecto.DisplayMember = "Value";
            cbxProyecto.ValueMember = "Key";
        }

        private void CrearGrupo_Load(object sender, EventArgs e)
        {
            string Identificador = GruposModel.GenerarIdentificadorGrupo();
            txtCodigoGrupo.Text = Identificador;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("Ingrese nombre del grupo"))
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
                txtNombre.Text = "Ingrese nombre del grupo";
                txtNombre.ForeColor = Color.DarkGray;
                lineNombre.BorderColor = Color.FromArgb(209, 52, 66);
                lblNombre.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorNombre.Text = "Debe ingresar el nombre del grupo.";
                lblErrorNombre.Visible = true;
                ERROR_nombre_grupo = true;
            }
            else
            {
                txtNombre.ForeColor = Color.DimGray;
                lineNombre.BorderColor = Color.DimGray;
                lblNombre.ForeColor = Color.DimGray;
                lblErrorNombre.Visible = false;
                ERROR_nombre_grupo = false;
            }
            arrowNombre.Visible = false;
        }

        private void txtRazonSocial_Enter(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text.Equals("Ingrese razón social"))
            {
                txtRazonSocial.Text = "";
                txtRazonSocial.ForeColor = Color.DimGray;
            }
            else
            {
                txtRazonSocial.SelectAll();
            }
            lineRazonSocial.BorderColor = Color.FromArgb(50, 137, 201);
            lblRazonSocial.ForeColor = Color.FromArgb(50, 137, 201);
            arrowRazonSocial.Visible = true;
        }

        private void txtRazonSocial_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                txtRazonSocial.Text = "Ingrese razón social";
                txtRazonSocial.ForeColor = Color.DarkGray;
                lineRazonSocial.BorderColor = Color.FromArgb(209, 52, 66);
                lblRazonSocial.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorRazonSocial.Text = "Debe ingresar la razón social del grupo.";
                lblErrorRazonSocial.Visible = true;
                ERROR_razon_social = true;
            }
            else
            {
                txtRazonSocial.ForeColor = Color.DimGray;
                lineRazonSocial.BorderColor = Color.DimGray;
                lblRazonSocial.ForeColor = Color.DimGray;
                lblErrorRazonSocial.Visible = false;
                ERROR_razon_social = false;
            }
            arrowRazonSocial.Visible = false;
        }

        private void txtPersJuri_Enter(object sender, EventArgs e)
        {
            if (txtPersJuri.Text.Equals("Ingrese personalidad jurídica"))
            {
                txtPersJuri.Text = "";
                txtPersJuri.ForeColor = Color.DimGray;
            }
            else
            {
                txtPersJuri.SelectAll();
            }
            linePersJuri.BorderColor = Color.FromArgb(50, 137, 201);
            lblPersJuri.ForeColor = Color.FromArgb(50, 137, 201);
            arrowPersJuri.Visible = true;
        }

        private void txtPersJuri_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPersJuri.Text))
            {
                txtPersJuri.Text = "Ingrese personalidad jurídica";
                txtPersJuri.ForeColor = Color.DarkGray;
                linePersJuri.BorderColor = Color.FromArgb(209, 52, 66);
                lblPersJuri.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorPersJuri.Text = "Debe ingresar la personalidad jurídica del grupo.";
                lblErrorPersJuri.Visible = true;
                ERROR_pers_jurid = true;
            }
            else
            {
                txtPersJuri.ForeColor = Color.DimGray;
                linePersJuri.BorderColor = Color.DimGray;
                lblPersJuri.ForeColor = Color.DimGray;
                lblErrorPersJuri.Visible = false;
                ERROR_pers_jurid = false;
            }
            arrowPersJuri.Visible = false;
        }

        private void txtNombrePresi_Enter(object sender, EventArgs e)
        {
            if (txtNombrePresi.Text.Equals("Ingrese nombre del presidente del grupo"))
            {
                txtNombrePresi.Text = "";
                txtNombrePresi.ForeColor = Color.DimGray;
            }
            else
            {
                txtNombrePresi.SelectAll();
            }
            lineNombrePresi.BorderColor = Color.FromArgb(50, 137, 201);
            lblNombrePresi.ForeColor = Color.FromArgb(50, 137, 201);
            arrowNombrePresi.Visible = true;
        }

        private void txtNombrePresi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePresi.Text))
            {
                txtNombrePresi.Text = "Ingrese nombre del presidente del grupo";
                txtNombrePresi.ForeColor = Color.DarkGray;
                lineNombrePresi.BorderColor = Color.FromArgb(209, 52, 66);
                lblNombrePresi.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorNombrePresi.Text = "Debe ingresar el nombre del presidente del grupo.";
                lblErrorNombrePresi.Visible = true;
                ERROR_nombre_presi = true;
            }
            else
            {
                txtNombrePresi.ForeColor = Color.DimGray;
                lineNombrePresi.BorderColor = Color.DimGray;
                lblNombrePresi.ForeColor = Color.DimGray;
                lblErrorNombrePresi.Visible = false;
                ERROR_nombre_presi = false;
            }
            arrowNombrePresi.Visible = false;
        }

        private void txtContactoPresi_Enter(object sender, EventArgs e)
        {
            if (txtContactoPresi.Text.Equals("Ingrese contacto del presidente"))
            {
                txtContactoPresi.Text = "";
                txtContactoPresi.ForeColor = Color.DimGray;
            }
            else
            {
                txtContactoPresi.SelectAll();
            }
            lineContactoPresi.BorderColor = Color.FromArgb(50, 137, 201);
            lblContactoPresi.ForeColor = Color.FromArgb(50, 137, 201);
            arrowContactoPresi.Visible = true;
        }

        private void txtContactoPresi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContactoPresi.Text))
            {
                txtContactoPresi.Text = "Ingrese contacto del presidente";
                txtContactoPresi.ForeColor = Color.DarkGray;
                lineContactoPresi.BorderColor = Color.FromArgb(209, 52, 66);
                lblContactoPresi.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorContactoPresi.Text = "Debe ingresar contacto del presidente (teléfono o email).";
                lblErrorContactoPresi.Visible = true;
                ERROR_contacto_presi = true;
            }
            else
            {
                txtContactoPresi.ForeColor = Color.DimGray;
                lineContactoPresi.BorderColor = Color.DimGray;
                lblContactoPresi.ForeColor = Color.DimGray;
                lblErrorContactoPresi.Visible = false;
                ERROR_contacto_presi = false;
            }
            arrowContactoPresi.Visible = false;
        }

        private void cbxProyecto_Enter(object sender, EventArgs e)
        {
            cbxProyecto.DataSource = null;
            //Cargar el selector de Perfiles
            cbxProyecto.DataSource = new BindingSource(GruposModel.ObtenerProyectos(), null);
            cbxProyecto.DisplayMember = "Value";
            cbxProyecto.ValueMember = "Key";

            cbxProyecto.ForeColor = Color.DimGray;
            lineProyecto.BorderColor = Color.FromArgb(50, 137, 201);
            lblProyecto.ForeColor = Color.FromArgb(50, 137, 201);
            arrowProyecto.Visible = true;
        }

        private void cbxProyecto_Leave(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)cbxProyecto.SelectedItem).Value;
            if (value == "Seleccione")
            {
                cbxProyecto.ForeColor = Color.DarkGray;
                lineProyecto.BorderColor = Color.FromArgb(209, 52, 66);
                lblProyecto.ForeColor = Color.FromArgb(209, 52, 66);
                lblErrorProyecto.Text = "Debe seleccionar una opción.";
                lblErrorProyecto.Visible = true;
                ERROR_proyecto = true;
            }
            else
            {
                cbxProyecto.ForeColor = Color.DimGray;
                lineProyecto.BorderColor = Color.DimGray;
                lblProyecto.ForeColor = Color.DimGray;
                lblErrorProyecto.Visible = false;
                ERROR_proyecto = false;
            }
            arrowProyecto.Visible = false;
        }

        private void btnGuardarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ERROR_nombre_grupo && !ERROR_razon_social && !ERROR_pers_jurid && !ERROR_nombre_presi && !ERROR_contacto_presi && !ERROR_proyecto)
                {
                    ObjetoGrupo nuevoGrupo = new ObjetoGrupo();
                    nuevoGrupo.Identificador = txtCodigoGrupo.Text;
                    nuevoGrupo.Nombre = txtNombre.Text;
                    nuevoGrupo.Razon_social = txtRazonSocial.Text;
                    nuevoGrupo.Personalidad_juridica = txtPersJuri.Text;
                    nuevoGrupo.Nombre_presidente = txtNombrePresi.Text;
                    nuevoGrupo.Contacto_presidente = txtContactoPresi.Text;
                    nuevoGrupo.Id_proyecto = ((KeyValuePair<string, string>)cbxProyecto.SelectedItem).Key;
                    if (!GruposModel.ExisteIdentificadorGrupo(nuevoGrupo.Identificador))
                    {
                        int idInsertado = GruposModel.GuardarGrupo(nuevoGrupo);
                        if (idInsertado > 0)
                        {
                            string id_grupo = idInsertado.ToString();
                            string id_etapa = GruposModel.ObtenerIdEtapa(Mixin.VG.etapaCrearGrupo);
                            string estado = "1"; //Después de que el grupo se guardó correctamente el estado es 1 (Ok)
                            //Si el grupo se insertó correctamente, insertar en la tabla grupos_etapas, el id del grupo con todas sus etapas y el estado grupo creado en 1
                            GruposModel.GuardarEstadoEtapa(id_grupo, id_etapa, estado);
                            controlPostulacion.btnGuardar_Click();
                            controlPostulacion.activarTabRegistrarPostulantes();
                            Message.ShowMessage("Crear Grupo", "El grupo con identificador " + nuevoGrupo.Identificador + " ha sido creado correctamente.", Message.MessageType.done);
                            btnGuardarGrupo.Visible = false;
                        }
                    }
                    else
                    {
                        Message.ShowMessage("Advertencia", "Ya existe un grupo con este Identificador.", Message.MessageType.warning);
                    }
                }
                else
                {
                    Message.ShowMessage("Advertencia", "Existen errores en el formulario o campos vacíos por completar, antes de continuar, favor corregir los errores.", Message.MessageType.warning);
                }
            }
            catch (Exception ex)
            {
                Message.ShowMessage("Error", "CrearGrupo.cs -> btnGuardarAddUser_Click() \n" + ex.Message, Message.MessageType.error);
            }
        }
    }
}
