using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Upominac
{
    public partial class HomeTabUC : UserControl
    {
        private SpravceOsob spravceOsob;
        /*
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.ExStyle &= ~0x02000000;  // turn off ws_clipchildren
                return parms;
            }
        }*/

        public HomeTabUC(SpravceOsob spravceOsob)
        {
            InitializeComponent();
            //DoubleBuffered = true;
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //Application.VisualStyleState = VisualStyleState.NoneEnabled;
            todayDateLabel.Text = DateTime.Now.ToLongDateString();
            todayBirthdayLabel.Text = "";
            this.spravceOsob = spravceOsob;
            //napojení vlast."DataSource"-listBoxu na kolekci(binding list) osob(ve tř."SpravceOsob")
            PersonsListBox.DataSource = spravceOsob.Osoby;//nastav.zdroje listboxu(zdroj=bindingList)    
            if (PersonsListBox.Items.Count > 0)
                PersonsListBox.SelectedIndex = 0;
        }




        public void EmptyPersonsListBox()
        {
            dateBirthLabel.Text = "";
            ageLabel.Text = "";
            birthMonthCalendar.SelectionStart = DateTime.Today;
        }

        public void ObnovDataOsob(bool start, Osoba? osoba)
        {
            if (PersonsListBox.Items.Count == 0)
                EmptyPersonsListBox();
            if (spravceOsob.Osoby.Count > 0)
            {
                Osoba nejblizsi = spravceOsob.NajdiNejblizsi();
                int vek = nejblizsi.SpoctiVek();
                if (DateTime.Today != nejblizsi.Narozeniny)
                    vek++;
                if (start)
                {
                    Osoba? narozeninyDnes = spravceOsob.NarozeninyDnes();
                    if (narozeninyDnes is not null)
                        ZobrazOslavence(narozeninyDnes);
                }
                if (osoba is not null)
                {
                    if (spravceOsob.NarozeninyDnes(osoba))
                        ZobrazOslavence(osoba);
                }
                nextBirthLabel.Text = nejblizsi.Jmeno + " (" + vek + " let) za " + nejblizsi.ZbyvaDni(true) + " dní";
            }
            else
                nextBirthLabel.Text = "Žádné osoby v seznamu";
            nameDayLabel.Text = spravceOsob.VypisSvatekOsoby(DateTime.Today);
            if (PersonsListBox.SelectedItem != null)
            {
                Osoba osobaZobraz = (Osoba)PersonsListBox.SelectedItem;//zobraz.dat narození vybrané osoby(v ListBoxu)
                //Pozn.:"DalsiUdaje"ulož.v XML s 2xtab se nahradí ukonč.řádku"\r"(CR)a novým ř."\n"(CL)
                personDetailTextBox.Text = osobaZobraz.DalsiUdaje.Replace("\t\t", "\r\n");
                dateBirthLabel.Text = osobaZobraz.Narozeniny.ToLongDateString();
                ageLabel.Text = osobaZobraz.SpoctiVek().ToString();
                nameDayLabel.Text = spravceOsob.NajdiSvatekOsoby(osobaZobraz.Jmeno);
                //nastavení kalendáře na datum narozenin vybrané osoby
                birthMonthCalendar.SelectionStart = osobaZobraz.Narozeniny;
            }
        }

        public void ZobrazOslavence(Osoba osoba)
        {
            CelebrateForm osobaCelebrateForm = new CelebrateForm(osoba);
            //Opacity = 0.70;
            osobaCelebrateForm.ShowDialog();
            //Opacity = 1.00;
            todayBirthdayLabel.Text = $"Dnes má narozeniny {osoba.Jmeno} ({osoba.SpoctiVek()} let)!";
            confettiPictureBox.Visible = true;
            PersonsListBox.SelectedItem = osoba;

        }

        private void PersonsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObnovDataOsob(false, null);
        }

        private void PersonDetailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PersonDetailCheckBox.Checked)
            {
                personDetailTextBox.Location = new Point(354, 270);
                personDetailTextBox.Size = new Size(298, 296);
                personDetailTextBox.Visible = true;
                borderPanel1.Visible = false;
                borderPanel2.Visible = false;
                borderPanel3.Visible = false;
                borderPanel4.Visible = false;
            }
            else
            {
                personDetailTextBox.Visible = false;
                borderPanel1.Visible = true;
                borderPanel2.Visible = true;
                borderPanel3.Visible = true;
                borderPanel4.Visible = true;
            }

        }

        public Osoba? VyberOsobu()
        {
            if (PersonsListBox.SelectedItem != null)
            {
                Osoba osoba = (Osoba)PersonsListBox.SelectedItem;
                return osoba;
            }
            return null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
