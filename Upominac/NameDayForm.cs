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

namespace Upominac
{
    public partial class NameDayForm : Form
    {
        private Point mouseLoc;
        SpravceOsob spravceOsob;
        public NameDayForm(SpravceOsob spravceOsob)
        {
            InitializeComponent();
            this.spravceOsob = spravceOsob;
        }

        //vykreslení rohů formuláře
        private void PaintRoundedForm()
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }
        //metoda na zakulacení rohů formuláře
        //metoda je externí,tzn. z jiného zdroje-jazyka,zde použ.library .dll)
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,          //X-coordinate of upper left corner
            int nTopRect,           //Y-coordinate of upper left corner
            int nRightRect,         //X-coordinate of lower right corner
            int nBottomRect,        //Y-coordinate of lower right corner
            int nWidthEllipse,      //width of ellipse
            int nHeightEllipse);    //height of ellipse

        //metody pro posunutí formuláře myší(za horní panel)
        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = e.Location;
        }
        private void TitleBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - mouseLoc.X;
                int dy = e.Location.Y - mouseLoc.Y;
                Location = new Point(Location.X + dx, Location.Y + dy);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(spravceOsob.NajdiSvatekOsoby(nameTextBox.Text.Trim()));

        }

        private void NameDayForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OkButton_Click(sender, e);
        }

        private void CloseRndButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NameDayForm_Load(object sender, EventArgs e)
        {
            PaintRoundedForm();
        }
    }
}
