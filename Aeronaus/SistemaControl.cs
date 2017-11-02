using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeronaus
{
    class SistemaControl
    {
        public void perills(ref Aeronau[] aeronaus)
        {
            int c2;
            for (int c1 = 0; c1 < aeronaus.Length; c1++)
            {
                if (aeronaus[c1] != null)
                {
                    for (c2 = c1 + 1; c2 < aeronaus.Length; c2++)
                    {
                        if (aeronaus[c2] != null && aeronaus[c2].getMatricula() != aeronaus[c1].getMatricula())
                        {
                            int alcada = aeronaus[c1].getAlcada() - aeronaus[c2].getAlcada();
                            int X = aeronaus[c1].getX() - aeronaus[c2].getX();
                            int Y = aeronaus[c1].getY() - aeronaus[c2].getY();

                            if (alcada < 500 && alcada > -500)
                            {
                                if ((X < 50 && X > -50) && (Y < 50 && Y > -50))
                                {
                                    MessageBox.Show("Perill de colisió: " + aeronaus[c1].getMatricula() + " i " + aeronaus[c2].getMatricula() + ": X i Y massa a prop. Alçada de " + alcada + " metres entre elles", "Perill",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (X < 50 && X > -50)
                                {
                                    Console.Write("Perill de colisió: " + aeronaus[c1].getMatricula() + " i " + aeronaus[c2].getMatricula() + ": X massa a prop. Alçada de " + alcada + " metres entre elles", "Perill",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (Y < 50 && Y > -50)
                                {
                                    Console.Write("Perill de colisió: " + aeronaus[c1].getMatricula() + " i " + aeronaus[c2].getMatricula() + ": Y massa a prop. Alçada de " + alcada + " metres entre elles", "Perill",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
        }

        public void mantenimentAeri(ref Aeronau[] aeronaus)
        {
            Boolean borrada = false;
            for (int c = 0; c < aeronaus.Length; c++)
            {
                if (aeronaus[c] != null)
                {
                    if (aeronaus[c].getAparcat() || aeronaus[c].getX() < 0 || aeronaus[c].getY() < 0 || aeronaus[c].getX() > 1000 || aeronaus[c].getY() > 1000)
                    {
                        borrada = true;
                        MessageBox.Show("Aeronau amb la matricula " + aeronaus[c].getMatricula() + " eliminada", "Actualitzacio",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        aeronaus[c] = null;
                    }
                }
            }
            if (!borrada)
            {
                MessageBox.Show("No s'ha borrat ninguna nau", "Informacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Boolean nausDisponibles(ref Aeronau[] aeronaus)
        {
            for (int c = 0; c < aeronaus.Length; c++)
            {
                if (aeronaus[c] != null)
                {
                    return true;
                }
            }
            return false;
        }

        public int posicioLliure(ref Aeronau[] aeronaus)
        {
            int posicioLliure = 5;

            for (int c = 0; c < 5; c++)
            {
                if (aeronaus[c] == null)
                {
                    posicioLliure = c;
                    break;
                }
            }
            return posicioLliure;
        }

        public void crearAeronau(int posicioLliure, String model, String fabricant, int capacitat, int x, int y, String matricula, ref Boolean aeronauCreada, ref Aeronau[] aeronaus)
        {
            Boolean matriculaOk = comprovarOk(posicioLliure, matricula, ref aeronaus);
            if (matriculaOk)
            {
                aeronauCreada = true;
                aeronaus[posicioLliure] = new Aeronau(model, fabricant, capacitat, x, y, matricula);
                MessageBox.Show("Aeronau creada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Boolean nauDisponible(int nau, ref Aeronau[] aeronaus)
        {
            if (aeronaus[nau] != null) return true;
            return false;
        }
        
        public void motorOnOff(int aeronau, ref Aeronau[] aeronaus)
        {
            if (!aeronaus[aeronau].getMotorEnces())
            {
                aeronaus[aeronau].setMotorEnces(true);
                MessageBox.Show("Motor ences");
            }
            else
            {
                aeronaus[aeronau].setMotorEnces(false);
                MessageBox.Show("Motor apagat");
            }
        }
        
        public void accelerar(int aeronau, ref Aeronau[] aeronaus)
        {
            setX setAccelerar = new setX("Quant vols accelerar:");
            setAccelerar.ShowDialog();
            int velocitat = aeronaus[aeronau].getVelocitat() + setAccelerar.getValor;

            if (velocitat >= 300 && aeronaus[aeronau].getTrenAterratgeDesplegat())
            {
                MessageBox.Show("Per superar els 300 primer plega el tren d'aterratge");
                return;
            }
            aeronaus[aeronau].setVelocitat(velocitat);
        }
        
        public void frenar(int aeronau, ref Aeronau[] aeronaus)
        {
            setX setFrenar = new setX("Quant vols frenar:");
            setFrenar.ShowDialog();
            int velocitat = aeronaus[aeronau].getVelocitat() - setFrenar.getValor;

            if(velocitat < 0)
            {
                MessageBox.Show("No es pot anar en negatiu");
                return;
            }
            if (velocitat < 180 && aeronaus[aeronau].getAlcada() > 0)
            {
                MessageBox.Show("Primer baixa l'alçada");
                return;
            }
            aeronaus[aeronau].setVelocitat(velocitat);
        }

        public void pujar(int aeronau, ref Aeronau[] aeronaus)
        {
            setX setPujar = new setX("Quant vols pujar:");
            setPujar.ShowDialog();
            int alcada = aeronaus[aeronau].getAlcada() + setPujar.getValor;

            if (alcada >= 500 && aeronaus[aeronau].getTrenAterratgeDesplegat())
            {
                MessageBox.Show("Per superar els 500 metres primer plega el tren d'aterratge");
                return;
            }
            aeronaus[aeronau].setAlcada(alcada);
        }

        public void baixar(int aeronau, ref Aeronau[] aeronaus)
        {
            setX setBaixar = new setX("Quant vols baixar:");
            setBaixar.ShowDialog();
            int alcada = aeronaus[aeronau].getAlcada() - setBaixar.getValor;

            if (alcada < 0)
            {
                MessageBox.Show("No es pot anar en negatiu");
                return;
            }
            if (alcada < 100 && !aeronaus[aeronau].getTrenAterratgeDesplegat())
            {
                MessageBox.Show("Primer desplega el tren d'aterratge");
                return;
            }
            aeronaus[aeronau].setAlcada(alcada);
        }
        
        public void trenAterratgeOnOff(int aeronau, ref Aeronau[] aeronaus)
        {
            if (!aeronaus[aeronau].getTrenAterratgeDesplegat())
            {
                MessageBox.Show("Tren desplegat");
                aeronaus[aeronau].setTrenAterratgeDesplegat(true);
            }
            else
            {
                MessageBox.Show("Tren plegat");
                aeronaus[aeronau].setTrenAterratgeDesplegat(false);
            }
        }
        
        public void aparcar(int aeronau, ref Aeronau[] aeronaus)
        {
            if(aeronaus[aeronau].getAparcat() == false)
            {
                aeronaus[aeronau].setAparcat(true);
                MessageBox.Show("Aeronau aparcada");
            }
            else
            {
                aeronaus[aeronau].setAparcat(false);
                MessageBox.Show("Aeronau operativa");
            }
        }
        
        public void rumb(int aeronau, ref Aeronau[] aeronaus)
        {
            setX setRumb = new setX("Introdueix rumb:");
            setRumb.ShowDialog();
            int rumb = setRumb.getValor;

            if (rumb >= 0 && rumb <= 360)
            {
                aeronaus[aeronau].setRumb(rumb);
            }
            else
            {
                MessageBox.Show("Rumb incorrecte");
            }
        }
        
        public void posicio(int aeronau, ref Aeronau[] aeronaus)
        {            
            setX x = new setX("Introdueix X:");
            x.ShowDialog();
            int X = x.getValor;
            x.Close();

            setX y = new setX("Introdueix Y:");
            y.ShowDialog();
            int Y = y.getValor;
            y.Close();
            
            for (int c = 0; c < aeronaus.Length; c++)
            {
                if (aeronaus[c] != null && c != aeronau)
                {
                    if (aeronaus[c].getX() == X && aeronaus[c].getY() == Y &&
                        aeronaus[c].getAlcada() == aeronaus[aeronau].getAlcada())
                    {
                        MessageBox.Show("Les naus no es poden creuar");
                        return;
                    }
                }
            }
            aeronaus[aeronau].setXY(X, Y);
            MessageBox.Show("X i Y actualitzats");           
        }
        
        public Boolean comprovarOk(int posicioLliure, String matricula, ref Aeronau[] aeronaus)
        {
            Boolean ok = true;
            for (int c = 0; c < 5; c++)
            {
                if (c == posicioLliure)
                {
                    continue;
                }
                if (aeronaus[c] != null)
                {
                    if (aeronaus[c].getMatricula().Equals(matricula))
                    {
                        ok = false;
                        MessageBox.Show("Hi ha una aeronau amb la meteixa matricula");
                        break;
                    }
                }
            }
            return ok;
        }
    }
}