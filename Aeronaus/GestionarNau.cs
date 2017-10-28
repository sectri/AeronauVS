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
    internal partial class GestionarNau : Form
    {
        SistemaControl sistemaControl;
        Aeronau[] aeronaus;
        int nauSeleccionada;

        public GestionarNau(ref SistemaControl sistemaControl, int nauSeleccionada, ref Aeronau[] aeronaus) : this()
        {
            InitializeComponent();
            this.sistemaControl = sistemaControl;
            this.nauSeleccionada = nauSeleccionada;
            this.aeronaus = aeronaus;
            aeronaus[nauSeleccionada].setAparcat(false);
        }

        public GestionarNau()
        {

        }

        private void menuFinalitzar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void GestionarNau_Load(object sender, EventArgs e)
        {

        }

        private void menuTrenAterratge_Click(object sender, EventArgs e)
        {
            sistemaControl.SetTrenAterratge(nauSeleccionada, ref aeronaus);
        }

        private void menuVelocitat_Click(object sender, EventArgs e)
        {
            sistemaControl.SetVelocitat(nauSeleccionada, ref aeronaus);
        }

        private void menuMotorOnOff_Click(object sender, EventArgs e)
        {
            sistemaControl.setMotorOnOff(nauSeleccionada, ref aeronaus);
        }

        private void menuPosicionarXY_Click(object sender, EventArgs e)
        {
            sistemaControl.SetXY(nauSeleccionada, ref aeronaus);
        }

        private void menuAlcada_Click(object sender, EventArgs e)
        {
            sistemaControl.SetAlcada(nauSeleccionada, ref aeronaus);
        }

        private void menuAparcar_Click(object sender, EventArgs e)
        {
            sistemaControl.SetAparcat(nauSeleccionada, ref aeronaus);
        }

        private void menuRumb_Click(object sender, EventArgs e)
        {
            sistemaControl.SetRumb(nauSeleccionada, ref aeronaus);
        }
    }
}
