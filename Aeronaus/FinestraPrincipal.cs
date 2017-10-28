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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void gestionarAvio_Click(object sender, EventArgs e)
        {
            nausDisponibles = sistemaControl.NausDisponibles(ref aeronaus);
            if (nausDisponibles)
            {
                this.Hide();
                MenuSeleccionarNau seleccionarNau = new MenuSeleccionarNau(ref sistemaControl, ref aeronaus);
                seleccionarNau.ShowDialog();

                Boolean aeronauPilotada = seleccionarNau.getAeronauPilotat;
                seleccionarNau.Close();

                if (aeronauPilotada)
                {
                    sistemaControl.MantenimentAeri(ref aeronaus);
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
            nausDisponibles = sistemaControl.NausDisponibles(ref aeronaus);
            if (nausDisponibles)
            {
                sistemaControl.MantenimentAeri(ref aeronaus);
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
            int posicioLliure = sistemaControl.PosicioLliure(ref aeronaus);
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

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void panelConsola_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sortir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
