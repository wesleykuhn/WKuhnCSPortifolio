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

namespace DemonstracaoWinForms
{
    public partial class FRM_Main : Form
    {
        // ----------------------------------------------------------------------------------------->
        //
        // Neste exemplar de WinForms eu não quero destacar minhas classes, ou como eu as ultilizo. Quero 
        // destacar meu estilo em projetos Windows Forms, principalmente o Layour responsível. Eu sempre gostei mais de me aprofundar em WinForms pela sua
        // simplicidade e velocidade no ambiente Windows! Tenho sim vontade de aprender e usar o WPF.
        //
        // O conteúdo deste Formulário foi retirado de uma classe Form, que eu uso de base para herdar e criar outros formulários a partir da mesma. Eu retirei´
        // vários métodos que a original usa, que são métodos de escolha de cor, botões, som e controle de formulário (fechar, minimizar, redimencionar).
        //
        // NOTAS: Os botões de controle (Fechar, maximiliar, minimizar) não costumam ficar deste jeito, eu geralmente coloco um icone e cada um deles.
        //
        // <-----------------------------------------------------------------------------------------

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private const int cGrip = 16;
        private const int cCaption = 32;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Resize var
        private bool maximized = false;

        public FRM_Main()
        {
            InitializeComponent();

            this.lbl_Title.Text = this.Text;
        }

        //---------------------------------------------------------------------------------------------------
        // RESIZE AND MOVIMENT METHODS --------------------------------------------------------------------------------->
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(0, 22, 22, 22));

            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(brush, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void Lbl_Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //Don't maximize and get the taskbar also!
        private void FRM_Main_Full_Load(object sender, EventArgs e)
        {            
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FRM_Main_Full_Resize(object sender, EventArgs e)
        {
            if (this.Bounds.Width < Screen.FromHandle(this.Handle).WorkingArea.Width || this.Bounds.Height < Screen.FromHandle(this.Handle).WorkingArea.Height)
            {
                this.maximized = false;

                this.btn_Resize.Text = "Maximilizar";
            }
            else
            {
                this.maximized = true;

                this.btn_Resize.Text = "Redimencionar";
            }
        }

        //---------------------------------------------------------------------------------------------------
        // BUTTONS METHODS --------------------------------------------------------------------------------->
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Rezise_Click(object sender, EventArgs e)
        {
            this.maximized = !this.maximized;

            if (!this.maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_JsonSerialize_Click(object sender, EventArgs e)
        {
            rtb_Serealized.Text = String.Empty;

            User user = new User()
            {
                Name = txt_Name.Text,
                Email = txt_Email.Text,
                PhoneNumber = txt_PhoneNumber.Text,
                Password = txt_Password.Text
            };

            try
            {
                rtb_Serealized.Text = ClassesOnly.Translators.JsonSerialization.ObjectToString<User>(user);
            }
            catch (Exception ex)
            {
                rtb_Serealized.Text = String.Empty;

                rtb_Serealized.Text = "Houve um erro ao tentar descriptografar o texto. Detalhes do erro: " + ex.Message;
            }
        }
    }
}
