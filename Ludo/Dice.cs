using Ludo.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    public class Dice
    {
        private Random random;

        public Dice()
        {
            random = new Random();
        }

        public int Roll(ref PictureBox dice)
        {
            int dice1 = random.Next(1, 7);
            var diceImageResourceName = $"dice{dice1}"; 
            Image diceImage = Resources.ResourceManager.GetObject(diceImageResourceName) as Image;
            dice.Image = diceImage;
            dice.SizeMode = PictureBoxSizeMode.StretchImage;
            return dice1;
            /*
            switch (dice1)
            {
                case 1:
                    dice.ImageLocation = @"D:\faculta\OOP\Nu_te_supara_frate\dice1.png";
                    dice.SizeMode = PictureBoxSizeMode.StretchImage;
                        jucator.Dice = 1;
                    break;
                case 2:
                    dice.ImageLocation = @"D:\faculta\OOP\Nu_te_supara_frate\dice2.png";
                    dice.SizeMode = PictureBoxSizeMode.StretchImage;
                    jucator.Dice = 2;
                    break;
                case 3:
                    dice.ImageLocation = @"D:\faculta\OOP\Nu_te_supara_frate\dice3.png";
                    dice.SizeMode = PictureBoxSizeMode.StretchImage;
                    jucator.Dice = 3;
                    break;
                case 4:
                    dice.ImageLocation = @"D:\faculta\OOP\Nu_te_supara_frate\dice4.png";
                    dice.SizeMode = PictureBoxSizeMode.StretchImage;
                    jucator.Dice = 4;
                    break;
                case 5:
                    dice.ImageLocation = @"D:\faculta\OOP\Nu_te_supara_frate\dice5.png";
                    dice.SizeMode = PictureBoxSizeMode.StretchImage;
                    jucator.Dice = 5;
                    break;
                case 6:
                    dice.ImageLocation = @"D:\faculta\OOP\Nu_te_supara_frate\dice6.png";
                    dice.SizeMode = PictureBoxSizeMode.StretchImage;
                    jucator.Dice = 6;
                    break;
                default:
                    dice.ImageLocation = @"D:\faculta\OOP\Nu_te_supara_frate\dice1.png";
                    dice.SizeMode = PictureBoxSizeMode.StretchImage;
                    jucator.Dice = 0;
                    break;

            }
            */
        }
    }
}
