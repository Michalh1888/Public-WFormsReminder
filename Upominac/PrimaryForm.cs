using CustomRoundButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Upominac
{
   

    public partial class PrimaryForm : Form
    {   //načte opce/nastavení/parametry
        private readonly AppOptions appOptions = new AppOptions();
        private SpravceOsob spravceOsob = new SpravceOsob();
        private HomeTabUC homeTabUC;
        //proměnné pro posunutí a roztažení formuláře
        private Point mouseLoc;
        //private static bool resizeNow=false;
        private const int formRadius = 20;
        private const int gripSize = 16;// Grip size
     

        /*
        protected override CreateParams CreateParams
        {
            get
            {
                if (resizeNow)
                {
                    CreateParams cp = base.CreateParams;
                    cp.ExStyle |= 0x2000000;
                    return cp;
                }
                else
                    return base.CreateParams;


            }
        }*/



        //Constructor
        public PrimaryForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            spravceOsob.Nacti();
            spravceOsob.NactiJmena();
            homeTabUC = new HomeTabUC(spravceOsob);
            if (AppOptions.StartTray)//při spouštění bez formuláře v TrayIkon režimu
            {
                AppTrayIcon myTray = new AppTrayIcon();
                homeTabUC.ObnovDataOsob(true, null);//obnov data- příp. oslavence
            }
            if (ErrorsLog.UserErrorsList.Count > 0)
                MessageBox.Show(ErrorsLog.ProjdiChyby(true), "Chyba čtení osob ze souboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //vykreslení rohů formuláře
        private void PaintRoundedForm()
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, formRadius, formRadius));
        }
        //metoda na zakulacení rohů formuláře
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,          //X-coordinate of upper left corner
            int nTopRect,           //Y-coordinate of upper left corner
            int nRightRect,         //X-coordinate of lower right corner
            int nBottomRect,        //Y-coordinate of lower right corner
            int nWidthEllipse,      //width of ellipse
            int nHeightEllipse);    //height of ellipse

        //metoda na vytvoření roztah.šipek(při najetí napravo,dolů a v rohu vpravo dole)
        /*
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);

                if (pos.X >= ClientSize.Width - (gripSize * 2) && pos.Y >= ClientSize.Height - (gripSize * 2))
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
                else if (pos.X >= ClientSize.Width - 5)
                {
                    m.Result = (IntPtr)11; // HTRIGHT
                    return;
                }
                else if (pos.Y >= ClientSize.Height - 5)
                {
                    m.Result = (IntPtr)15; // HTBOTTOM
                    return;
                }
            }
            base.WndProc(ref m);
        }*/

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
        //* Eventy(metody) na resize a control box 
        private void PrimaryForm_Resize(object sender, EventArgs e)
        {
            PaintRoundedForm();
        }
        private void CloseRndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MaximizeRndButton_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)//(Size != this.MaximumSize)
            {
                WindowState = FormWindowState.Maximized;
                MaximizeRndButton.BackgroundImage = Resources.AppIcon.icons8_resize_28;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                MaximizeRndButton.BackgroundImage = Resources.AppIcon.icons8_maximize_28;
            }
        }
        private void MinimizeRndButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //metoda přidání UC formuláře na hlavní panel(plochu)
        private void AddUserControl(UserControl userControl)
        {
            userControl.Parent = this;
            userControl.Dock = DockStyle.Fill;
            mainAreaPanel.Controls.Clear();
            mainAreaPanel.Controls.Add(userControl);
            userControl.BringToFront(); //userControl.Show();
        }

        public void HomeButton_Click(object sender, EventArgs e)
        {
            //HomeTabUC homeTabUC = new HomeTabUC(spravceOsob);
            AddUserControl(homeTabUC);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            AddTabUC addTabUC = new AddTabUC(spravceOsob, homeTabUC);
            AddUserControl(addTabUC);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var osoba = homeTabUC.VyberOsobu();
            if (osoba != null)
            {
                AddTabUC addTabUC = new AddTabUC(spravceOsob, osoba, homeTabUC);
                AddUserControl(addTabUC);
            }
            else
                MessageBox.Show("Žádná osoba k editování");
        }

        //odebrání osoby(použ. dotazu s MessageBoxem) 
        private void RemoveButton_Click(object sender, EventArgs e)
        {

            var osoba = homeTabUC.VyberOsobu();
            if (osoba != null)
            {   
                DialogResult dr = MessageBox.Show("Opravdu smazat?", "Potvrzení", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    spravceOsob.Odeber(osoba);
                    spravceOsob.Uloz();
                    homeTabUC.ObnovDataOsob(false, null);
                }
            }
            else MessageBox.Show("Žádná osoba k vymazání");
        }

        private void ExportPersonButton_Click(object sender, EventArgs e)
        {

            var osoba = homeTabUC.VyberOsobu();
            if (osoba != null)
            {
                DialogResult vysledek = osobaSaveFileDialog.ShowDialog();
                if (vysledek == DialogResult.OK)
                    spravceOsob.ExportujDataOsoby(osoba, osobaSaveFileDialog.FileName);
            }
            else MessageBox.Show("Žádné osoby v seznamu pro export");
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm(appOptions, spravceOsob);
            optionsForm.ShowDialog();
        }

        //metoda pro akce při načtení hlavního(úvodního) formuláře aplikace
        private void PrimaryForm_Load(object sender, EventArgs e)
        {
            if (!AppOptions.StartTray)//spouš.pouze když neběží již v TrayIcon režimu
                homeTabUC.ObnovDataOsob(true, null);//obnov data- příp. oslavence
            AddUserControl(homeTabUC);
            //PaintRoundedForm();
        }

        private void CheckNameDateButton_Click(object sender, EventArgs e)
        {
            NameDayForm nameDayForm = new NameDayForm(spravceOsob);
            nameDayForm.ShowDialog();
        }


    }
}
