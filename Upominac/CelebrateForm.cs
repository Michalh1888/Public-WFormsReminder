using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using NAudio;
//using NAudio.Wave;
using WMPLib;





namespace Upominac
{
    public partial class CelebrateForm : Form
    {
        
        WindowsMediaPlayer myplayer = new WindowsMediaPlayer();

        public CelebrateForm(Osoba osoba)
        {
            InitializeComponent();
          
            
            if (!AppOptions.StartTray)
                CenterToScreen();
            else
            {
                //v TrayIcon režimu-nastavení okna vpravo dolů
                Rectangle workingArea = Screen.GetWorkingArea(this);
                Location = new Point(workingArea.Right - Size.Width,
                                          workingArea.Bottom - Size.Height);
            }
            VypisLabel.Text = $"Dnes má narozeniny";
            VypisJmenoLabel.Text = osoba.Jmeno + " !";
            PlaySound(true);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            PlaySound(false);
            Close();
        }

        public void PlaySound(bool start)
        {
            if (start)
            {             
               
                string fullPath = $@"{Application.StartupPath}sound\happyBirthday_sound.mp3";
                myplayer.URL = fullPath; //@"M:\MojeProjekty\C#\WinForms\Upominac\happyBirthday_sound.mp3";
                myplayer.controls.play();//spuštění playeru
            }
            else
                myplayer.controls.stop();
        }

    }
}
