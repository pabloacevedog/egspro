using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormNewUIdesign
{
    public partial class Message : Form
    {
        MessageType tipoMensaje;
        public Message(string titulo, string message, MessageType type)
        {
            InitializeComponent();
            tipoMensaje = type;
            switch (type)
            {
                case MessageType.done:
                    barraMessageBox.BackColor = Color.FromArgb(46, 204, 113);
                    footerMessageBox.BackColor = Color.FromArgb(46, 204, 113);
                    btnCancelar.BackColor = Color.FromArgb(46, 204, 113);
                    btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 142, 79);
                    btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 142, 79);
                    btnAceptar.BackColor = Color.FromArgb(46, 204, 113);
                    btnAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 142, 79);
                    btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 142, 79);
                    MessageIcon.Image = MessageIconList.Images[0];
                    break;
                case MessageType.error:
                    barraMessageBox.BackColor = Color.FromArgb(192, 57, 43);
                    footerMessageBox.BackColor = Color.FromArgb(192, 57, 43);
                    btnCancelar.BackColor = Color.FromArgb(192, 57, 43);
                    btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 38, 27);
                    btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 38, 27);
                    btnAceptar.BackColor = Color.FromArgb(192, 57, 43);
                    btnAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 38, 27);
                    btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 38, 27);
                    MessageIcon.Image = MessageIconList.Images[1];
                    break;
                case MessageType.information:
                    barraMessageBox.BackColor = Color.FromArgb(52, 152, 219);
                    footerMessageBox.BackColor = Color.FromArgb(52, 152, 219);
                    btnCancelar.BackColor = Color.FromArgb(52, 152, 219);
                    btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(43, 125, 181);
                    btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 125, 181);
                    btnAceptar.BackColor = Color.FromArgb(52, 152, 219);
                    btnAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(43, 125, 181);
                    btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 125, 181);
                    MessageIcon.Image = MessageIconList.Images[2];
                    btnCancelar.Visible = true;
                    break;
                case MessageType.warning:
                    barraMessageBox.BackColor = Color.FromArgb(243, 156, 18);
                    footerMessageBox.BackColor = Color.FromArgb(243, 156, 18);
                    btnCancelar.BackColor = Color.FromArgb(243, 156, 18);
                    btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 130, 14);
                    btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(204, 130, 14);
                    btnAceptar.BackColor = Color.FromArgb(243, 156, 18);
                    btnAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 130, 14);
                    btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(204, 130, 14);
                    MessageIcon.Image = MessageIconList.Images[3];
                    break;
            }
            lblTitulo.Text = titulo;
            lblMensaje.Text = message;
        }

        public static DialogResult ShowMessage(string _titulo, string _message, MessageType _type)
        {
            DialogResult result =  new Message(_titulo, _message, _type).ShowDialog();
            return result;
        }

        public enum MessageType
        {
            done,warning,error,information
        }

        public void close()
        {
            this.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            close();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            switch (tipoMensaje)
            {
                case MessageType.done:
                    btnCerrarMessage.BackColor = Color.FromArgb(32, 142, 79);
                    break;
                case MessageType.error:
                    btnCerrarMessage.BackColor = Color.FromArgb(150, 38, 27);
                    break;
                case MessageType.information:
                    btnCerrarMessage.BackColor = Color.FromArgb(43, 125, 181);
                    break;
                case MessageType.warning:
                    btnCerrarMessage.BackColor = Color.FromArgb(204, 130, 14);
                    break;
            }
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            switch (tipoMensaje)
            {
                case MessageType.done:
                    btnCerrarMessage.BackColor = Color.Transparent;
                    break;
                case MessageType.error:
                    btnCerrarMessage.BackColor = Color.Transparent;
                    break;
                case MessageType.information:
                    btnCerrarMessage.BackColor = Color.Transparent;
                    break;
                case MessageType.warning:
                    btnCerrarMessage.BackColor = Color.Transparent;
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            close();
        }

        //Con esto se puede mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int WParam, int lParam);

        private void Message_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
