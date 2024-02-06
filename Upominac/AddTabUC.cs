using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upominac
{
    public partial class AddTabUC : UserControl
    {
        
        private SpravceOsob spravceOsob;
        private bool edit = false;
        private Osoba osoba;
        private HomeTabUC homeTabUC;


        public AddTabUC(SpravceOsob spravceOsob, HomeTabUC homeTabUC)
        {
            InitializeComponent();
            this.spravceOsob = spravceOsob;
            osoba = new Osoba();
            this.homeTabUC = homeTabUC;
        }

        public AddTabUC(SpravceOsob spravceOsob, Osoba osoba, HomeTabUC homeTabUC)
        {
            InitializeComponent();
            this.spravceOsob = spravceOsob;
            edit = true;
            Text = "Edituj přítele";
            nameTextBox.Text = osoba.Jmeno;
            birthDateTimePicker.Value = osoba.Narozeniny;
            personDataTextBox.Text = osoba.DalsiUdaje.Replace("\t\t", "\r\n");
            this.osoba = osoba;
            this.homeTabUC = homeTabUC;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //zkusí přidat osobu//pozn.:z DataTextBoxu jsou odřádkování \n(LF) nahrazený za 2xtab(kvůli čitelnosti v XML)
            spravceOsob.Pridej(nameTextBox.Text, birthDateTimePicker.Value, personDataTextBox.Text.Replace("\n", "\t\t"));
            if ((spravceOsob.Osoby.Count > 0) && (edit))
                spravceOsob.Odeber(osoba);
            spravceOsob.Uloz();
            homeTabUC.ObnovDataOsob(false, spravceOsob.PoslPridOsoba);
        }

    }
}
