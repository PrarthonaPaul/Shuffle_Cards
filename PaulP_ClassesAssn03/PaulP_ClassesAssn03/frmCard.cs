using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaulP_ClassesAssn03
{
    public partial class frmCard : Form
    {
        public frmCard()
        {
            InitializeComponent();
        }

        private void FrmCard_Load(object sender, EventArgs e)
        {
            PictureBox[] pic = new PictureBox[] { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pic21, pic22, pic23, pic24, pic25, pic26, pic27, pic28, pic29, pic30, pic31, pic32, pic33, pic34, pic35, pic36, pic37, pic38, pic39, pic40, pic41, pic42, pic43, pic44, pic45, pic46, pic47, pic48, pic49, pic50, pic51 };

            //MessageBox.Show("Yeah, I tried and I think I had the right code, but it didn't work:(", "This is unfrtunate.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 0; i < 52; i++)
            {
                switch (frmShuffleCards.cardName[i])
                {
                    case "Ace of Clubs":
                        pic[i].Image = Properties.Resources.aceC;
                        break;
                    case "Deuce of Clubs":
                        pic[i].Image = Properties.Resources.twoC;
                        break;
                    case "Three of Clubs":
                        pic[i].Image = Properties.Resources.threeC;
                        break;
                    case "Four of Clubs":
                        pic[i].Image = Properties.Resources.fourC;
                        break;
                    case "Five of Clubs":
                        pic[i].Image = Properties.Resources.fiveC;
                        break;
                    case "Six of Clubs":
                        pic[i].Image = Properties.Resources.sixC;
                        break;
                    case "Seven of Clubs":
                        pic[i].Image = Properties.Resources.sevenC;
                        break;
                    case "Eight of Clubs":
                        pic[i].Image = Properties.Resources.eightC;
                        break;
                    case "Nine of Clubs":
                        pic[i].Image = Properties.Resources.nineC;
                        break;
                    case "Ten of Clubs":
                        pic[i].Image = Properties.Resources.TenC;
                        break;
                    case "Jack of Clubs":
                        pic[i].Image = Properties.Resources.jackC;
                        break;
                    case "Queen of Clubs":
                        pic[i].Image = Properties.Resources.queenC;
                        break;
                    case "King of Clubs":
                        pic[i].Image = Properties.Resources.kingC;
                        break;
                    case "Ace of Spades":
                        pic[i].Image = Properties.Resources.aceS;
                        break;
                    case "Deuce of Spades":
                        pic[i].Image = Properties.Resources.twoS;
                        break;
                    case "Three of Spades":
                        pic[i].Image = Properties.Resources.threeS;
                        break;
                    case "Four of Spades":
                        pic[i].Image = Properties.Resources.fourS;
                        break;
                    case "Five of Spades":
                        pic[i].Image = Properties.Resources.fiveS;
                        break;
                    case "Six of Spades":
                        pic[i].Image = Properties.Resources.sixS;
                        break;
                    case "Seven of Spades":
                        pic[i].Image = Properties.Resources.sevenS;
                        break;
                    case "Eight of Spades":
                        pic[i].Image = Properties.Resources.eightS;
                        break;
                    case "Nine of Spades":
                        pic[i].Image = Properties.Resources.nineS;
                        break;
                    case "Ten of Spades":
                        pic[i].Image = Properties.Resources.TenS;
                        break;
                    case "Jack of Spades":
                        pic[i].Image = Properties.Resources.jackS;
                        break;
                    case "Queen of Spades":
                        pic[i].Image = Properties.Resources.QueenS;
                        break;
                    case "King of Spades":
                        pic[i].Image = Properties.Resources.kingS;
                        break;
                    case "Ace of Diamonds":
                        pic[i].Image = Properties.Resources.aceD;
                        break;
                    case "Deuce of Diamonds":
                        pic[i].Image = Properties.Resources.twoD;
                        break;
                    case "Three of Diamonds":
                        pic[i].Image = Properties.Resources.threeD;
                        break;
                    case "Four of Diamonds":
                        pic[i].Image = Properties.Resources.fourD;
                        break;
                    case "Five of Diamonds":
                        pic[i].Image = Properties.Resources.fiveD;
                        break;
                    case "Six of Diamonds":
                        pic[i].Image = Properties.Resources.sixD;
                        break;
                    case "Seven of Diamonds":
                        pic[i].Image = Properties.Resources.sevenD;
                        break;
                    case "Eight of Diamonds":
                        pic[i].Image = Properties.Resources.eightD;
                        break;
                    case "Nine of Diamonds":
                        pic[i].Image = Properties.Resources.nineD;
                        break;
                    case "Ten of Diamonds":
                        pic[i].Image = Properties.Resources.tenD;
                        break;
                    case "Jack of Diamonds":
                        pic[i].Image = Properties.Resources.jackD;
                        break;
                    case "Queen of Diamonds":
                        pic[i].Image = Properties.Resources.queenD;
                        break;
                    case "King of Diamonds":
                        pic[i].Image = Properties.Resources.kingD;
                        break;
                    case "Ace of Hearts":
                        pic[i].Image = Properties.Resources.aceH;
                        break;
                    case "Deuce of Hearts":
                        pic[i].Image = Properties.Resources.twoH;
                        break;
                    case "Three of Hearts":
                        pic[i].Image = Properties.Resources.threeH;
                        break;
                    case "Four of Hearts":
                        pic[i].Image = Properties.Resources.fourH;
                        break;
                    case "Five of Hearts":
                        pic[i].Image = Properties.Resources.fiveH;
                        break;
                    case "Six of Hearts":
                        pic[i].Image = Properties.Resources.sixH;
                        break;
                    case "Seven of Hearts":
                        pic[i].Image = Properties.Resources.sevenH;
                        break;
                    case "Eight of Hearts":
                        pic[i].Image = Properties.Resources.eightH;
                        break;
                    case "Nine of Hearts":
                        pic[i].Image = Properties.Resources.nineH;
                        break;
                    case "Ten of Hearts":
                        pic[i].Image = Properties.Resources.tenH;
                        break;
                    case "Jack of Hearts":
                        pic[i].Image = Properties.Resources.jackH;
                        break;
                    case "Queen of Hearts":
                        pic[i].Image = Properties.Resources.queenH;
                        break;
                    case "King of Hearts":
                        pic[i].Image = Properties.Resources.kingH1;
                        break;
                }
            }
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            frmShuffleCards form1 = new frmShuffleCards();
            this.Hide();
            form1.Show();
        }
    }
}
