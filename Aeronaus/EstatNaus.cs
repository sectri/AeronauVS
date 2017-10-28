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
    internal partial class EstatNaus : Form
    {
        public EstatNaus(ref Aeronau[] aeronaus)
        {
            InitializeComponent();

            //Aeronau 1
            if (aeronaus[0] != null)
            {
                marcaA1.Text = aeronaus[0].getFabricant();
                modelA1.Text = aeronaus[0].getModel();
                matriculaA1.Text = aeronaus[0].getMatricula();
                xA1.Text = aeronaus[0].getX().ToString();
                yA1.Text = aeronaus[0].getY().ToString();
                alcadaA1.Text = aeronaus[0].getAlcada().ToString();
                velocitatA1.Text = aeronaus[0].getVelocitat().ToString();
                if (aeronaus[0].getTrenAterratgeDesplegat())
                {
                    trenA1.Text = "Desplegat";
                }
                else
                {
                    trenA1.Text = "Plegat";
                }
                if (aeronaus[0].getMotorEnces())
                {
                    motorA1.Text = "On";
                }
                else
                {
                    motorA1.Text = "Off";
                }
            }
            //Aeronau 2
            if (aeronaus[1] != null)
            {
                marcaA2.Text = aeronaus[1].getFabricant();
                modelA2.Text = aeronaus[1].getModel();
                matriculaA2.Text = aeronaus[1].getMatricula();
                xA2.Text = aeronaus[1].getX().ToString();
                yA2.Text = aeronaus[1].getY().ToString();
                alcadaA2.Text = aeronaus[1].getAlcada().ToString();
                velocitatA2.Text = aeronaus[1].getVelocitat().ToString();
                if (aeronaus[1].getTrenAterratgeDesplegat())
                {
                    trenA2.Text = "Desplegat";
                }
                else
                {
                    trenA2.Text = "Plegat";
                }
                if (aeronaus[1].getMotorEnces())
                {
                    motorA2.Text = "On";
                }
                else
                {
                    motorA2.Text = "Off";
                }
            }

            //Aeronau 3
            if (aeronaus[2] != null)
            {
                marcaA3.Text = aeronaus[2].getFabricant();
                modelA3.Text = aeronaus[2].getModel();
                matriculaA3.Text = aeronaus[2].getMatricula();
                xA3.Text = aeronaus[2].getX().ToString();
                yA3.Text = aeronaus[2].getY().ToString();
                alcadaA3.Text = aeronaus[2].getAlcada().ToString();
                velocitatA3.Text = aeronaus[2].getVelocitat().ToString();
                if (aeronaus[2].getTrenAterratgeDesplegat())
                {
                    trenA3.Text = "Desplegat";
                }
                else
                {
                    trenA3.Text = "Plegat";
                }
                if (aeronaus[2].getMotorEnces())
                {
                    motorA3.Text = "On";
                }
                else
                {
                    motorA3.Text = "Off";
                }
            }

            //Aeronau 4
            if (aeronaus[3] != null)
            {
                marcaA4.Text = aeronaus[3].getFabricant();
                modelA4.Text = aeronaus[3].getModel();
                matriculaA4.Text = aeronaus[3].getMatricula();
                xA4.Text = aeronaus[3].getX().ToString();
                yA4.Text = aeronaus[3].getY().ToString();
                alcadaA4.Text = aeronaus[3].getAlcada().ToString();
                velocitatA4.Text = aeronaus[3].getVelocitat().ToString();
                if (aeronaus[3].getTrenAterratgeDesplegat())
                {
                    trenA4.Text = "Desplegat";
                }
                else
                {
                    trenA4.Text = "Plegat";
                }
                if (aeronaus[3].getMotorEnces())
                {
                    motorA4.Text = "On";
                }
                else
                {
                    motorA4.Text = "Off";
                }
            }

            //Aeronau 5
            if (aeronaus[4] != null)
            {
                marcaA5.Text = aeronaus[4].getFabricant();
                modelA5.Text = aeronaus[4].getModel();
                matriculaA5.Text = aeronaus[4].getMatricula();
                xA5.Text = aeronaus[4].getX().ToString();
                yA5.Text = aeronaus[4].getY().ToString();
                alcadaA5.Text = aeronaus[4].getAlcada().ToString();
                velocitatA5.Text = aeronaus[4].getVelocitat().ToString();
                if (aeronaus[4].getTrenAterratgeDesplegat())
                {
                    trenA5.Text = "Desplegat";
                }
                else
                {
                    trenA5.Text = "Plegat";
                }
                if (aeronaus[4].getMotorEnces())
                {
                    motorA5.Text = "On";
                }
                else
                {
                    motorA5.Text = "Off";
                }

            }
        }
        
    }
}
