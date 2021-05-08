using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulP_ClassesAssn03
{
    class Cards
    {
        public string face;
        public string suit, output;

        public Cards()
        {
            face = "";
            suit = "";
        }

        public string Face
        {
            get { return face; }
            set { face = value; }
        }

        public string Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        //Method to output face and suit

        public override string ToString()
        {
            Random rand1 = new Random(), rand2 = new Random();
            int faceInt, suitInt;

            faceInt = rand1.Next(1, 13);
            suitInt = rand2.Next(1, 5);

            switch (suitInt)
            {
                case 1:
                    suit = "Hearts";
                    break;
                case 2:
                    suit = "Clubs";
                    break;
                case 3:
                    suit = "Spade";
                    break;
                case 4:
                    suit = "Diamonds";
                    break;
            }

            switch (faceInt)
            {
                case 1:
                    face = "Ace";
                    break;
                case 2:
                    face = "Two";
                    break;
                case 3:
                    face = "Three";
                    break;
                case 4:
                    face = "Four";
                    break;
                case 5:
                    face = "Five";
                    break;
                case 6:
                    face = "Six";
                    break;
                case 7:
                    face = "Seven";
                    break;
                case 8:
                    face = "Eight";
                    break;
                case 9:
                    face = "Nine";
                    break;
                case 10:
                    face = "Ten";
                    break;
                case 11:
                    face = "Jack";
                    break;
                case 12:
                    face = "Queen";
                    break;
                case 13:
                    face = "King";
                    break;
            }
            output = face + " of " + suit;
            return output;
        }
    }
}
