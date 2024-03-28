using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    public class Jucator
    {
        public PictureBox[] Pioni { get; set; } = new PictureBox[4];
        public int Dice { get; set; }
        public int[] Positions { get; set; }


        public Jucator(PictureBox pion1, PictureBox pion2, PictureBox pion3, PictureBox pion4)
        {
            Pioni[0] = pion1;
            Pioni[1] = pion2;
            Pioni[2] = pion3;
            Pioni[3] = pion4;
            Positions = new[] { 0, 0, 0, 0 };
        }


    }
}
