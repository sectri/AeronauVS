using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeronaus
{
    internal partial class MenuSeleccionarNau : Form
    {
        SistemaControl sistemaControl;
        Aeronau[] aeronaus;
        Boolean aeronauPilotada;

        public MenuSeleccionarNau(ref SistemaControl sistemaControl, ref Aeronau[] aeronaus) : this()
        {
            InitializeComponent();
            this.sistemaControl = sistemaControl;
            this.aeronaus = aeronaus;

            for (int c = 0; c < 5; c++)
            {
                if (aeronaus[c] != null)
                {
                    if (c == 0) menuSeleccionarNau1.Text = aeronaus[c].getMatricula();
                    if (c == 1) menuSeleccionarNau2.Text = aeronaus[c].getMatricula();
                    if (c == 2) menuSeleccionarNau3.Text = aeronaus[c].getMatricula();
                    if (c == 3) menuSeleccionarNau4.Text = aeronaus[c].getMatricula();
                    if (c == 4) menuSeleccionarNau5.Text = aeronaus[c].getMatricula();
                }
                else
                {
                    if (c == 0) menuSeleccionarNau1.Enabled = false;
                    if (c == 1) menuSeleccionarNau2.Enabled = false;
                    if (c == 2) menuSeleccionarNau3.Enabled = false;
                    if (c == 3) menuSeleccionarNau4.Enabled = false;
                    if (c == 4) menuSeleccionarNau5.Enabled = false;
                }
            }
        }

        public MenuSeleccionarNau()
        {

        }

        private void menuSeleccionarNau1_Click(object sender, EventArgs e)
        {
            this.Hide();
            aeronauPilotada = true;
            GestionarNau gestionarNau = new GestionarNau(ref sistemaControl, 0, ref aeronaus);
            gestionarNau.ShowDialog();

        }

        public Boolean getAeronauPilotat
        {
            get { return aeronauPilotada; }
        }

        private void menuSeleccionarNau2_Click(object sender, EventArgs e)
        {
            this.Hide();
            aeronauPilotada = true;
            GestionarNau gestionarNau = new GestionarNau(ref sistemaControl, 1, ref aeronaus);
            gestionarNau.ShowDialog();
        }

        private void menuSeleccionarNau3_Click(object sender, EventArgs e)
        {
            this.Hide();
            aeronauPilotada = true;
            GestionarNau gestionarNau = new GestionarNau(ref sistemaControl, 2, ref aeronaus);
            gestionarNau.ShowDialog();
        }

        private void menuSeleccionarNau4_Click(object sender, EventArgs e)
        {
            this.Hide();
            aeronauPilotada = true;
            GestionarNau gestionarNau = new GestionarNau(ref sistemaControl, 3, ref aeronaus);
            gestionarNau.ShowDialog();
        }

        private void menuSeleccionarNau5_Click(object sender, EventArgs e)
        {
            this.Hide();
            aeronauPilotada = true;
            GestionarNau gestionarNau = new GestionarNau(ref sistemaControl, 4, ref aeronaus);
            gestionarNau.ShowDialog();
        }

        private void menuSeleccionarNau_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void menuSeleccionarNau_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
