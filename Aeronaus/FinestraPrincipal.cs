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
    public partial class finestraPrincipal : Form
    {
        SistemaControl sistemaControl = new SistemaControl();
        Aeronau[] aeronaus = new Aeronau[5];

        private Boolean nausDisponibles;

        public finestraPrincipal()
        {
            InitializeComponent();
        }

        private void gestionarAvio_Click(object sender, EventArgs e)
        {
            nausDisponibles = sistemaControl.nausDisponibles(ref aeronaus);
            if (nausDisponibles)
            {
                this.Hide();
                MenuSeleccionarNau seleccionarNau = new MenuSeleccionarNau(ref sistemaControl, ref aeronaus);
                seleccionarNau.ShowDialog();

                Boolean aeronauPilotada = seleccionarNau.getAeronauPilotat;
                seleccionarNau.Close();

                if (aeronauPilotada)
                {
                    sistemaControl.mantenimentAeri(ref aeronaus);
                    EstatNaus estatNaus = new EstatNaus(ref aeronaus);
                    estatNaus.ShowDialog();
                    this.Show();
                }
                else { this.Show(); }
            }
            else
            {
                MessageBox.Show("No hi han naus disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mantenimentAeri_Click(object sender, EventArgs e)
        {
            nausDisponibles = sistemaControl.nausDisponibles(ref aeronaus);
            if (nausDisponibles)
            {
                sistemaControl.mantenimentAeri(ref aeronaus);
            }
            else
            {
                MessageBox.Show("No hi han naus disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void infoEspaiAeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstatNaus estatNaus = new EstatNaus(ref aeronaus);
            estatNaus.ShowDialog();
            this.Show();
        }

        private void donarAlta_Click(object sender, EventArgs e)
        {
            int posicioLliure = sistemaControl.posicioLliure(ref aeronaus);
            if (posicioLliure != 5)
            {
                this.Hide();
                DonarAlta donarAlta = new DonarAlta(posicioLliure, ref sistemaControl, ref aeronaus);
                donarAlta.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No hi han espais lliures");
            }
        }
    }
}
