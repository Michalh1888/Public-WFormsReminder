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
    public partial class OptionsForm : Form
    {
        private Point mouseLoc;
        private AppOptions appOptions;
        private SpravceOsob spravceOsob;

        public OptionsForm(AppOptions appOptions, SpravceOsob spravceOsob)
        {
            InitializeComponent();
            this.appOptions = appOptions;
            this.spravceOsob = spravceOsob;
            RunOnStartupCheckBox.Checked = RegistryManager.IsOnStartup();
            RunOnTrayCheckBox.Checked = AppOptions.StartTray;
            SaveDataSystemFolderCheckBox.Checked = AppOptions.SaveSysAppData;
            this.spravceOsob = spravceOsob;
        }

        //vykreslení rohů formuláře
        private void PaintRoundedForm()
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
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


        private void RunOnStartupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RegistryManager.SetOnStartup(RunOnStartupCheckBox.Checked);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            appOptions.UlozParam();
            appOptions.NastavParam();
            spravceOsob.Uloz();//uloží osoby do souboru XML(i pro případ změny cesty souboru do "AppData")
            Close();
        }

        private void RunOnTrayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            appOptions.PridejParam("StartTray", RunOnTrayCheckBox.Checked);
        }

        private void SaveDataSystemFolderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            appOptions.PridejParam("SaveSysAppData", SaveDataSystemFolderCheckBox.Checked);
        }

        private void CloseRndButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            PaintRoundedForm();
        }
    }
}
