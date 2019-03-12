using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FormNewUIdesign.Formularios
{
    public partial class PopupInfo : Form
    {
        public PopupInfo(string texto)
        {
            InitializeComponent();
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
            lblPopupInfo.Text = texto;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int WParam, int lParam);

        private void barraMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-26);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        public static DialogResult ShowMessage(string _message)
        {
            DialogResult result = new PopupInfo(_message).ShowDialog();
            return result;
        }

        public void close()
        {
            this.Dispose();
        }
        
        private void btnCerrarMessage_Click(object sender, EventArgs e)
        {
            close();
        }

        private void btnCerrarMessage_MouseEnter(object sender, EventArgs e)
        {
            btnCerrarMessage.BackColor = Color.FromArgb(43, 125, 181);
        }

        private void btnCerrarMessage_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarMessage.BackColor = Color.Transparent;
        }

        
    }
}
