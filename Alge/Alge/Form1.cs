using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alge
{
    public partial class Alge : Form
    {
        public Alge()
        {
            InitializeComponent();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();
            Settings.Show();
        }

        private void credits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://paxonic.eu");
        }

        private void button_alge_Click(object sender, EventArgs e)
        {
            if (modus_farbe.Checked)
            {
                var Farbe = new Random();
                var Farben = new List<string> { "Grün", "Rot" };
                int index1 = Farbe.Next(Farben.Count);
                ergebnis.Text = (Farben[index1]);
                ergebnis.Visible = true;

            }

            else if (modus_alge.Checked)
            {
                var Alge = new Random();
                var Algen = new List<string> { "Alge 1", "Alge 2", "Alge 3", "Alge 4" };
                int index2 = Alge.Next(Algen.Count);
                ergebnis.Text = (Algen[index2]);
                ergebnis.Visible = true;

            }

            Stream str = Properties.Resources.AlgeSound;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

        }
    }
}
