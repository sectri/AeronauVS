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
        public void Perills(ref Aeronau[] aeronaus)
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
                                    MessageBox.Show("Perill de colisió: " + aeronaus[c1].getMatricula() + " i " + aeronaus[c2].getMatricula() + ": Mateixa X i Y. Alçada de " + alcada + " metres entre elles", "Perill",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (X < 50 && X > -50)
                                {
                                    Console.Write("Perill de colisió: " + aeronaus[c1].getMatricula() + " i " + aeronaus[c2].getMatricula() + ": Mateixa X. Alçada de " + alcada + " metres entre elles", "Perill",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (Y < 50 && Y > -50)
                                {
                                    Console.Write("Perill de colisió: " + aeronaus[c1].getMatricula() + " i " + aeronaus[c2].getMatricula() + ": Mateixa Y. Alçada de " + alcada + " metres entre elles", "Perill",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
        }

        public void MantenimentAeri(ref Aeronau[] aeronaus)
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

        public Boolean NausDisponibles(ref Aeronau[] aeronaus)
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

        public int PosicioLliure(ref Aeronau[] aeronaus)
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

        public void CrearAeronau(int posicioLliure, String model, String fabricant, int capacitat, int x, int y, String matricula, ref Boolean aeronauCreada, ref Aeronau[] aeronaus)
        {
            Boolean matriculaOk = ComprovarOk(posicioLliure, matricula, ref aeronaus);
            if (matriculaOk)
            {
                aeronauCreada = true;
                aeronaus[posicioLliure] = new Aeronau(model, fabricant, capacitat, x, y, matricula);
                MessageBox.Show("Aeronau creada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Boolean NauDisponible(int nau, ref Aeronau[] aeronaus)
        {
            if (aeronaus[nau] != null) return true;
            return false;
        }

        public void setMotorOnOff(int aeronau, ref Aeronau[] aeronaus)
        {
            if (!aeronaus[aeronau].getMotorEnces())
            {
                aeronaus[aeronau].setMotorEnces(true);
                MessageBox.Show("Motor ences");
            }
            else if (aeronaus[aeronau].getVelocitat() == 0 && aeronaus[aeronau].getAlcada() == 0 && aeronaus[aeronau].getTrenAterratgeDesplegat())
            {
                aeronaus[aeronau].setMotorEnces(false);
                MessageBox.Show("Motor apagat");
            }
            else
            {
                if (aeronaus[aeronau].getVelocitat() > 0)
                {
                    MessageBox.Show("Baixa la velocitat a 0");
                }
                if (aeronaus[aeronau].getAlcada() > 0)
                {
                    MessageBox.Show("Baixa l'alçada a 0");
                }
                if (!aeronaus[aeronau].getTrenAterratgeDesplegat())
                {
                    MessageBox.Show("Desplega el tren d'aterratge");
                }
            }
        }

        public void SetVelocitat(int aeronau, ref Aeronau[] aeronaus)
        {
            if (aeronaus[aeronau].getMotorEnces())
            {
                
                setX setVelocitat = new setX("Introdueix velocitat:");
                setVelocitat.ShowDialog();
                int velocitat = setVelocitat.getValor;
                setVelocitat.Close();

                if (velocitat >= 300)
                {
                    if (!aeronaus[aeronau].getTrenAterratgeDesplegat())
                    {
                        aeronaus[aeronau].setVelocitat(velocitat);
                        MessageBox.Show("Velocitat actualitzada");
                    }
                    else
                    {
                        MessageBox.Show("Primer plega el tren d'aterratge");
                    }
                }
                else if (velocitat < 300 && velocitat >= 180)
                {
                    aeronaus[aeronau].setVelocitat(velocitat);
                    MessageBox.Show("Velocitat actualitzada");
                }
                else if (aeronaus[aeronau].getAlcada() < 100)
                {
                    if (aeronaus[aeronau].getTrenAterratgeDesplegat())
                    {
                        aeronaus[aeronau].setVelocitat(velocitat);
                        MessageBox.Show("Velocitat actualitzada");
                    }
                    else
                    {
                        MessageBox.Show("Primer desplega el tren d'aterratge");
                    }
                }
            }
            else
            {
                MessageBox.Show("El motor esta apagat");
            }
        }

        public void SetAlcada(int aeronau, ref Aeronau[] aeronaus)
        {
            if (aeronaus[aeronau].getMotorEnces())
            {
                setX setAlcada = new setX("Introdueix alcada:");
                setAlcada.ShowDialog();
                int alcada = setAlcada.getValor;
                setAlcada.Close();

                if (aeronaus[aeronau].getVelocitat() >= 180)
                {
                    if (alcada >= 500)
                    {
                        if (aeronaus[aeronau].getTrenAterratgeDesplegat() == false)
                        {
                            aeronaus[aeronau].setAlcada(alcada);
                            MessageBox.Show("Alçada actualitzada");
                        }
                        else
                        {
                            MessageBox.Show("Primer plega el tren d'aterratge");
                        }
                    }
                    else if (alcada < 500)
                    {
                        if (alcada < 100)
                        {
                            if (aeronaus[aeronau].getTrenAterratgeDesplegat() == true)
                            {
                                aeronaus[aeronau].setAlcada(alcada);
                                MessageBox.Show("Alçada actualitzada");
                            }
                            else
                            {
                                MessageBox.Show("Primer desplega el tren d'aterratge");
                            }
                        }
                        else
                        {
                            aeronaus[aeronau].setAlcada(alcada);
                            MessageBox.Show("Alçada actualitzada");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Augmenta velocitat minim a 180 per augmentar l'alçada");
                }
            }
            else
            {
                MessageBox.Show("El motor esta apagat");
            }
        }

        public void SetTrenAterratge(int aeronau, ref Aeronau[] aeronaus)
        {
            if (aeronaus[aeronau].getMotorEnces())
            {
                if (aeronaus[aeronau].getTrenAterratgeDesplegat() == false)
                {
                    SetTrenAccio(aeronau, false, ref aeronaus);
                }
                else if (aeronaus[aeronau].getTrenAterratgeDesplegat() == true)
                {
                    if (aeronaus[aeronau].getAlcada() > 0)
                    {
                        SetTrenAccio(aeronau, true, ref aeronaus);
                    }
                    else
                    {
                       MessageBox.Show("Primer enlaira");
                    }
                }
            }
            else
            {
                MessageBox.Show("El motor esta apagat");
            }
        }

        public void SetTrenAccio(int aeronau, Boolean desplegat, ref Aeronau[] aeronaus)
        {
            if (aeronaus[aeronau].getAlcada() < 500 && aeronaus[aeronau].getVelocitat() < 300)
            {
                if (!desplegat)
                {
                    aeronaus[aeronau].setTrenAterratgeDesplegat(true);
                    MessageBox.Show("Tren d'aterratge desplegat");
                }
                else
                {
                    aeronaus[aeronau].setTrenAterratgeDesplegat(false);
                    MessageBox.Show("Tren d'aterratge plegat");
                }
            }
            else
            {
                if (aeronaus[aeronau].getAlcada() >= 500)
                {
                    MessageBox.Show("Baixa l'altura a menys de 500 per desplegar el tren d'aterratge");
                }
                if (aeronaus[aeronau].getVelocitat() >= 300)
                {
                    MessageBox.Show("Baixa la velocitat a menys de 300 per desplegar el tren d'aterratge");
                }
            }
        }

        public void SetAparcat(int aeronau, ref Aeronau[] aeronaus)
        {
            if (!aeronaus[aeronau].getMotorEnces() && aeronaus[aeronau].getVelocitat() == 0 && aeronaus[aeronau].getAlcada() == 0)
            {
                aeronaus[aeronau].setAparcat(true);
                MessageBox.Show("Aeronau aparcada");
            }
            else
            {
                if (aeronaus[aeronau].getVelocitat() > 0)
                {
                    MessageBox.Show("Baixar velocitat a 0");
                }
                if (aeronaus[aeronau].getAlcada() > 0)
                {
                    MessageBox.Show("Baixat alçada a 0");
                }
                if (aeronaus[aeronau].getMotorEnces())
                {
                    MessageBox.Show("Apaga el motor");
                }
            }
        }

        public void SetRumb(int aeronau, ref Aeronau[] aeronaus)
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

        public void SetXY(int aeronau, ref Aeronau[] aeronaus)
        {
            if (aeronaus[aeronau].getMotorEnces())
            {
                if (aeronaus[aeronau].getAlcada() > 0)
                {
                    setX x = new setX("Introdueix X:");
                    x.ShowDialog();
                    int X = x.getValor;
                    x.Close();

                    setX y = new setX("Introdueix Y:");
                    y.ShowDialog();
                    int Y = y.getValor;
                    y.Close();

                    Boolean error = false;
                    for (int c = 0; c < aeronaus.Length; c++)
                    {
                        if (aeronaus[aeronau] != null)
                        {
                            if ((aeronaus[aeronau].getX() - X) <= 1 && (aeronaus[aeronau].getY() - Y) <= 1
                                    && (aeronaus[aeronau].getX() - X) >= -1 && (aeronaus[aeronau].getY() - Y) >= -1)
                            {
                                MessageBox.Show("Les naus no es poden creuar");
                                error = true;
                                break;
                            }
                        }
                    }
                    if (error == false)
                    {
                        aeronaus[aeronau].setXY(X, Y);
                        MessageBox.Show("X i Y actualitzats");
                    }
                }
                else
                {
                    MessageBox.Show("Primer enlaira");
                }
            }
            else
            {
                MessageBox.Show("El motor esta apagat");
            }
        }

        public Boolean ComprovarOk(int posicioLliure, String matricula, ref Aeronau[] aeronaus)
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