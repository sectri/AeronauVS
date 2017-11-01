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

        public GestionarNau(ref SistemaControl sistemaControl, int nauSeleccionada, ref Aeronau[] aeronaus)
        {
            InitializeComponent();
            this.sistemaControl = sistemaControl;
            this.nauSeleccionada = nauSeleccionada;
            this.aeronaus = aeronaus;
            aeronaus[nauSeleccionada].setAparcat(false);
            checkAll();
        }

        private void menuFinalitzar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void menuTrenAterratge_Click(object sender, EventArgs e)
        {
            sistemaControl.trenAterratgeOnOff(nauSeleccionada, ref aeronaus);
            checkAll();
        }
        
        private void menuMotorOnOff_Click(object sender, EventArgs e)
        {
            sistemaControl.motorOnOff(nauSeleccionada, ref aeronaus);
            checkAll();
        }

        private void menuPosicionarXY_Click(object sender, EventArgs e)
        {
            sistemaControl.posicio(nauSeleccionada, ref aeronaus);
            checkAll();
        }
        
        private void menuAparcar_Click(object sender, EventArgs e)
        {
            sistemaControl.aparcar(nauSeleccionada, ref aeronaus);
            checkAll();
        }

        private void menuRumb_Click(object sender, EventArgs e)
        {
            sistemaControl.rumb(nauSeleccionada, ref aeronaus);
            checkAll();
        }

        private void menuPujarAlcada_Click(object sender, EventArgs e)
        {
            sistemaControl.pujar(nauSeleccionada, ref aeronaus);
            checkAll();
        }

        private void menuBaixarAlcada_Click(object sender, EventArgs e)
        {
            sistemaControl.baixar(nauSeleccionada, ref aeronaus);
            checkAll();
        }

        private void menuAccelerar_Click(object sender, EventArgs e)
        {
            sistemaControl.accelerar(nauSeleccionada, ref aeronaus);
            checkAll();
        }

        private void menuFrenar_Click(object sender, EventArgs e)
        {
            sistemaControl.frenar(nauSeleccionada, ref aeronaus);
            checkAll();
        }

        //Comprova si activar o desactivar l'opcio a click

        private void checkAll()
        {
            checkMotor();
            checkTren();
            checkXY();
            checkAparcar();
            checkRumb();
            checkPujar();
            checkBaixar();
            checkAccelerar();
            checkFrenar();
            checkText();
        }

        private void checkMotor()
        {
            menuMotorOnOff.Enabled = true;

            if(aeronaus[nauSeleccionada].getAlcada() > 0 ||
                    aeronaus[nauSeleccionada].getVelocitat() > 0 ||
                    !aeronaus[nauSeleccionada].getTrenAterratgeDesplegat() ||
                    aeronaus[nauSeleccionada].getAparcat())
            {
                menuMotorOnOff.Enabled = false;
            }
        }
        
        private void checkTren()
        {
            menuTrenAterratge.Enabled = true;

            if(aeronaus[nauSeleccionada].getAlcada() >= 500 ||
                aeronaus[nauSeleccionada].getAlcada() < 100 ||
                aeronaus[nauSeleccionada].getVelocitat() >= 300)
            {
                menuTrenAterratge.Enabled = false;
            }
        }

        private void checkXY()
        {
            menuPosicionarXY.Enabled = true;

            if(aeronaus[nauSeleccionada].getAlcada() == 0)
            {
                menuPosicionarXY.Enabled = false;
            }
        }

        private void checkAparcar()
        {
            menuAparcar.Enabled = true;

            if (aeronaus[nauSeleccionada].getMotorEnces())
            {
                menuAparcar.Enabled = false;
            }
        }

        private void checkRumb()
        {
            menuRumb.Enabled = true;

            if(aeronaus[nauSeleccionada].getAlcada() == 0)
            {
                menuRumb.Enabled = false;
            }
        }

        private void checkPujar()
        {
            menuPujarAlcada.Enabled = true;

            if(aeronaus[nauSeleccionada].getVelocitat() < 180)
            {
                menuPujarAlcada.Enabled = false;
            }
        }

        private void checkBaixar()
        {
            menuBaixarAlcada.Enabled = true;

            if(aeronaus[nauSeleccionada].getAlcada() == 0)
            {
                menuBaixarAlcada.Enabled = false;
            }
        }

        private void checkAccelerar()
        {
            menuAccelerar.Enabled = true;

            if (!aeronaus[nauSeleccionada].getMotorEnces())
            {
                menuAccelerar.Enabled = false;
            }
        }

        private void checkFrenar()
        {
            menuFrenar.Enabled = true;

            if(aeronaus[nauSeleccionada].getVelocitat() == 0)
            {
                menuFrenar.Enabled = false;
            }
        }

        private void checkText()
        {
            if (aeronaus[nauSeleccionada].getMotorEnces())
            {
                menuMotorOnOff.Text = "Encendre / Apagar motor \n Estat: On";
            }
            else
            {
                menuMotorOnOff.Text = "Encendre / Apagar motor \n Estat: Off";
            }
            if (aeronaus[nauSeleccionada].getTrenAterratgeDesplegat())
            {
                menuTrenAterratge.Text = "Pujar / Baixar tren aterratge \n Estat: Desplegat";
            }
            else
            {
                menuTrenAterratge.Text = "Pujar / Baixar tren aterratge \n Estat: Plegat";
            }
            menuPujarAlcada.Text = "Pujar \n Alçada actual: " + aeronaus[nauSeleccionada].getAlcada();
            menuBaixarAlcada.Text = "Baixar \n Alçada actual: " + aeronaus[nauSeleccionada].getAlcada();
            menuAccelerar.Text = "Accelerar \n Velocitat actual: " + aeronaus[nauSeleccionada].getVelocitat();
            menuFrenar.Text = "Frenar \n Velocitat actual: " + aeronaus[nauSeleccionada].getVelocitat();
            menuPosicionarXY.Text = "Posicionar X, Y \n Posició actual: " + aeronaus[nauSeleccionada].getX() + ", " + aeronaus[nauSeleccionada].getY();
            menuRumb.Text = "Establir rumb \n Rumb actual: " + aeronaus[nauSeleccionada].getRumb();
            if (aeronaus[nauSeleccionada].getAparcat())
            {
                menuAparcar.Text = "Aparcar \n Estat: Aparcada";
            }
            else
            {
                menuAparcar.Text = "Aparcar \n Estat: Operativa";
            }
        }
    }
}
