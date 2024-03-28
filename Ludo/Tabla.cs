using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;


namespace Ludo
{
    public partial class Ludo : Form
    {
        /*private SimpleTcpServer server;*/

        private Albastru membruAlbastru;
        private Rosu membruRosu;
        private Dice Zar;
        public Ludo()
        { 
            /*server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            server.Start(System.Net.IPAddress.Parse("127.0.0.1"), 3000);//127.0.0.1
            */
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(PictureBox) && control.BackColor.ToArgb() == SystemColors.Control.ToArgb())
                {
                    control.BackColor = Color.NavajoWhite;
                }
            }
            membruAlbastru = new Albastru(albastru1, albastru2, albastru3, albastru4);
            membruRosu = new Rosu(rosu1, rosu2, rosu3, rosu4);
            Zar = new Dice();
            btnRoll1.Enabled = true;
            btnRoll1.BackColor = Color.LawnGreen;
            btnRoll2.Enabled = false;
            btnRoll2.BackColor = Color.Red;
        }

        /*private void Server_DataReceived(object sender, SimpleTcp.Message e)
        {

        }*/

        private void btnRoll1_Click(object sender, EventArgs e)
        {
            rosu1.Enabled = false;
            rosu2.Enabled = false;
            rosu3.Enabled = false;
            rosu4.Enabled = false;
            albastru1.Enabled = true;
            albastru2.Enabled = true;
            albastru3.Enabled = true;
            albastru4.Enabled = true;

            membruAlbastru.Dice = Zar.Roll(ref Dice1);

            if (membruAlbastru.Dice == 6) return;
            btnRoll2.Enabled = true;
            btnRoll2.BackColor = Color.LawnGreen;
            btnRoll1.Enabled = false;
            btnRoll1.BackColor = Color.Red;


        }

        private void btnRoll2_Click(object sender, EventArgs e)
        {
            albastru1.Enabled = false;
            albastru2.Enabled = false;
            albastru3.Enabled = false;
            albastru4.Enabled = false;
            rosu1.Enabled = true;
            rosu2.Enabled = true;
            rosu3.Enabled = true;
            rosu4.Enabled = true;

            membruRosu.Dice = Zar.Roll(ref Dice2);

            if (membruRosu.Dice == 6) return;
            btnRoll2.Enabled = false;
            btnRoll2.BackColor = Color.Red;
            btnRoll1.Enabled = true;
            btnRoll1.BackColor = Color.LawnGreen;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void albastru1_Click(object sender, EventArgs e)
        {
            membruAlbastru.Move(0, this.Controls, p1);
            this.Refresh();
        }

        private void albastru2_Click(object sender, EventArgs e)
        {
            membruAlbastru.Move(1, this.Controls, p1);
            this.Refresh();
        }



        private void albastru3_Click(object sender, EventArgs e)
        {
            membruAlbastru.Move(2, this.Controls, p1);
            this.Refresh();
        }

        private void albastru4_Click(object sender, EventArgs e)
        {
            membruAlbastru.Move(3, this.Controls, p1);
            this.Refresh();
        }

        private void rosu1_Click(object sender, EventArgs e)
        {
            membruRosu.Move(0, this.Controls, p21);
            this.Refresh();
        }

        private void rosu2_Click(object sender, EventArgs e)
        {
            membruRosu.Move(1, this.Controls, p21);
            this.Refresh();
        }

        private void rosu3_Click(object sender, EventArgs e)
        {
            membruRosu.Move(2, this.Controls, p21);
            this.Refresh();
        }

        private void rosu4_Click(object sender, EventArgs e)
        {
            membruRosu.Move(3, this.Controls, p21);
            this.Refresh();
        }


    }
}
