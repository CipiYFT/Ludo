using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    public class Rosu : Jucator
    {
        public Rosu(PictureBox pion1, PictureBox pion2, PictureBox pion3, PictureBox pion4) : base(pion1, pion2, pion3, pion4)
        {
        }

        bool Verifica(int pos)
        {
            foreach (var position in Positions)
            {
                if (position == pos)
                    return false;
            }
            return true;

        }

        bool Castig()
        {
            int ct = 0;
            foreach (var position in Positions)
            {
                if (position >= 300 && position < 304)
                {
                    ct++;
                }
            }

            if (ct == 4)
                return true;

            return false;
        }
        public void Move(int pion, Control.ControlCollection Controls, PictureBox p21)
        {
            if (Positions[pion] != 0)
            {
                foreach (Control control in Controls)
                {
                    var newPosition = Positions[pion] + Dice;
                    if (newPosition <= 40)
                    {

                        if (Positions[pion] > 14 && Positions[pion] < 21)
                        {
                            if (control.GetType() == typeof(PictureBox) && control.Name.Equals($"p{Positions[pion] + Dice - 20 + 300 - 1}"))
                            {
                                var pos = newPosition - 20 + 300 - 1;
                                if (Verifica(pos))
                                {
                                    Positions[pion] = pos;
                                    Pioni[pion].Location = control.Location;
                                    if (Castig())
                                    {
                                        MessageBox.Show("Roșu a câștigat!!!");
                                    }
                                }

                                break;
                            }
                        }

                        if (control.GetType() == typeof(PictureBox) && control.Name.Equals($"p{Positions[pion] + Dice}"))
                        {

                            Positions[pion] += Dice;
                            Pioni[pion].Location = control.Location;
                            break;
                        }
                    }

                    else
                    {
                        if (control.GetType() == typeof(PictureBox) && control.Name.Equals($"p{Positions[pion] + Dice - 40}"))
                        {
                            Positions[pion] = newPosition - 40;
                            Pioni[pion].Location = control.Location;
                            break;
                        }
                        else if (Positions[pion] >= 300 && Positions[pion] < 304)
                        {
                            if (control.GetType() == typeof(PictureBox) && control.Name.Equals($"p{newPosition}"))
                            {
                                if (Verifica(newPosition))
                                {
                                    Positions[pion] = newPosition;
                                    Pioni[pion].Location = control.Location;
                                }

                                break;
                            }
                        }

                    }
                }
            }

            else if (Positions[pion] == 0 && Dice == 6)
            {
                Positions[pion] = 21;
                Pioni[pion].Location = p21.Location;
                Pioni[pion].BringToFront();
            }
        }
    }
}
