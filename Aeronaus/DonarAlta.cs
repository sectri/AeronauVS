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
    internal partial class DonarAlta : Form
    {
        private readonly int posicioLliure;
        SistemaControl sistemaControl;
        Aeronau[] aeronaus;

        public DonarAlta(int posicioLliure, ref SistemaControl sistemaControl, ref Aeronau[] aeronaus) : this()
        {
            InitializeComponent();
            this.posicioLliure = posicioLliure;
            this.sistemaControl = sistemaControl;
            this.aeronaus = aeronaus;
        }

        public DonarAlta()
        {

        }
        
        private void crearNau_Click(object sender, EventArgs e)
        {
            Boolean aeronauCreada = false;
            int x = (posicioLliure + 1) * 100;
            int y = (posicioLliure + 1) * 100;
            String model = introduirModel.Text;
            String fabricant = introduirFabricant.Text;
            String capacitatString = introduirCapacitat.Text;
            String matricula = introduirMatricula.Text;

            if (string.IsNullOrEmpty(model) || string.IsNullOrEmpty(fabricant) || string.IsNullOrEmpty(capacitatString) || string.IsNullOrEmpty(matricula))
            {
                MessageBox.Show("Falta informacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int capacitat = int.Parse(capacitatString);
            this.sistemaControl.crearAeronau(posicioLliure, model, fabricant, capacitat, x, y, matricula, ref aeronauCreada, ref aeronaus);
            if (aeronauCreada)
            {
                this.Hide();
                this.Close();
            }
        }

        private void onlyNumeric(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
