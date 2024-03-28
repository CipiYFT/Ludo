using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    public class Albastru : Jucator
    {
        public Albastru(PictureBox pion1, PictureBox pion2, PictureBox pion3, PictureBox pion4) : base(pion1, pion2, pion3, pion4)
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
                if (position >= 100 && position < 104)
                {
                    ct++;
                }
            }

            if (ct == 4)
                return true;
            
            return false;
        }

        public void Move(int pion, Control.ControlCollection Controls, PictureBox p1)
        {
            if (Positions[pion] != 0)
            {
               
                foreach (Control control in Controls)
                {
                    var newPosition = Positions[pion] + Dice;
                    if (newPosition <= 46)
                    {
                        if (control.GetType() == typeof(PictureBox) && control.Name.Equals($"p{Positions[pion] + Dice}"))
                        {

                            Positions[pion] += Dice;
                            Pioni[pion].Location = control.Location;
                            break;
                        }

                        if (control.GetType() == typeof(PictureBox) && control.Name.Equals($"p{newPosition - 40 + 100 - 1}"))
                        {
                            var pos = newPosition - 40 + 100 - 1;
                            if (Verifica(pos))
                            {
                                Positions[pion] = pos;
                                Pioni[pion].Location = control.Location;
                                if (Castig())
                                {
                                    MessageBox.Show("Albastru a câștigat!!!");
                                }
                            }
                            break;
                        }
                    }

                    else if (newPosition >= 100 && newPosition < 104)
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
            else if (Positions[pion] == 0 && Dice == 6)
            {
                Positions[pion] = 1;
                Pioni[pion].Location = p1.Location;
                Pioni[pion].BringToFront();
            }
        }

    }
}
