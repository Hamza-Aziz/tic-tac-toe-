using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceDSRemotingTrue
{
    public class Jeu
    {
        public String[,] t = new String[3, 3];//la grille du jeu
        public string v = "O";//Représente la valeur qui sera affichée dans le texte du bouton lors un click(X ou O) (Voir la partie RemotingClient)
        public int tour = 0 ;//déterminer la tour de quel joueur
        public String j = "joueur1";//la valeur qui va être affichée dans le textBox1 :Joueur1/Joueur2
        public string J1 = "joueur1";
        public string J2 = "joueur2";
        public Jeu() { }
        public  void jouer()
        {
            if (tour % 2 != 0)
            {
                v = "X";
                j = J1;
                tour++;

            }
            else
            {
                v = "O";
                j = J2;
                tour++;

            }

        }
        public Boolean gagner()
        {
            Boolean gagne = false;
            for (int i = 0; i < 3; i++)
            {
                if (testLigne(i) || testColonne(i) || testDiagn())
                {
                    gagne = true;
                    break;
                }
            }
            return gagne;

        }
        public Boolean testColonne(int col)
        {
            int nombreO = 0;
            int nombreX = 0;
            for(int i = 0; i < 3; i++)
            {
                if (t[i, col].Equals("O"))
                    nombreO++;
                else if (t[i, col].Equals("X"))
                    nombreX++;
            }
            if (nombreX == 3 || nombreO == 3)
                return true;
            else
                return false;

        }
        public Boolean testLigne(int lig)
        {
            int nombreO = 0;
            int nombreX = 0;
            for (int j = 0; j < 3; j++)
            {
                if (t[lig, j].Equals("O"))
                    nombreO++;
                else if (t[lig, j].Equals("X"))
                    nombreX++;
            }
            if (nombreX == 3 || nombreO == 3)
                return true;
            else
                return false;
        }
        public Boolean testDiagn()
        {
            int nombreO = 0;
            int nombreX = 0;
            int nombre2O = 0;
            int nombre2X = 0;
            for (int i = 0; i < 3; i++)
            {
                if (t[i, i].Equals("O"))
                    nombreO++;
                else if (t[i, i].Equals("X"))
                    nombreX++;
            }
            for(int i = 0; i < 3; i++)
            {
                if (t[i,3-i-1].Equals("O"))
                {
                    nombre2O++;
                }
                else if (t[i, 3 - i -1].Equals("X"))
                    nombre2X++;

            }
            if (nombreX == 3 || nombreO == 3 ||nombre2O == 3||nombre2X == 3 )
                return true;
            else
                return false;
        }



        public void initialiser(String[,] ta)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    t[i,j] = ta[i,j];
                }
           
            }
        }
    }
}
