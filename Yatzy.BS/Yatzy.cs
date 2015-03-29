using System.Collections.Generic;
using System.Linq;

namespace Yatzy.BS
{
    public class Yatzy
    {
        public List<Dice> Dices { get; set; }
        /// <summary>
        /// Retourne la somme des dès
        /// </summary>
        /// <param name="dices">Liste de Dice</param>
        /// <returns>int</returns>
        public int Chance()
        {
            return Dices.Sum(x => x.Valeur);
        }

        /// <summary>
        /// Retourne 50 si 5 dès ont la même valeur, sinon 0.
        /// </summary>
        /// <param name="dices">Liste de dès</param>
        /// <returns>int</returns>
        public int yatzy()
        {
            for (int i = 1; i <= 6; i++)
            {
                int nb = Dices.Where(x => x.Valeur == i).Count();
                if (nb == 5) { return 50; }
            }
            return 0;
        }

        /// <summary>
        /// Retourne le nombre total de dès avec la même valeur
        /// </summary>
        /// <param name="value">Valeur du dès</param>
        /// <returns>int</returns>
        public int GetTotalOfDicesWithSameValue(int value)
        {
            return Dices.Where(x => x.Valeur == value).Count();
        }


        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <param name="d3"></param>
        /// <param name="d4"></param>
        /// <param name="d5"></param>
        public Yatzy(int d1, int d2, int d3, int d4, int d5)
        {
            Dices = new List<Dice>();
            Dices.Add(new Dice { Valeur = d1 });
            Dices.Add(new Dice { Valeur = d2 });
            Dices.Add(new Dice { Valeur = d3 });
            Dices.Add(new Dice { Valeur = d4 });
            Dices.Add(new Dice { Valeur = d5 });
        }


        public static int ScorePair(int d1, int d2, int d3, int d4, int d5)
        {
            
            int[] counts = new int[6];
            counts[d1 - 1]++;
            counts[d2 - 1]++;
            counts[d3 - 1]++;
            counts[d4 - 1]++;
            counts[d5 - 1]++;
            int at;
            for (at = 0; at != 6; at++)
                if (counts[6 - at - 1] >= 2)
                    return (6 - at) * 2;
            return 0;
        }

        public static int TwoPair(int d1, int d2, int d3, int d4, int d5)
        {
            int[] counts = new int[6];
            counts[d1 - 1]++;
            counts[d2 - 1]++;
            counts[d3 - 1]++;
            counts[d4 - 1]++;
            counts[d5 - 1]++;
            int n = 0;
            int score = 0;
            for (int i = 0; i < 6; i += 1)
                if (counts[6 - i - 1] >= 2)
                {
                    n++;
                    score += (6 - i);
                }
            if (n == 2)
                return score * 2;
            else
                return 0;
        }

        public static int FourOfAKind(int _1, int _2, int d3, int d4, int d5)
        {
            int[] tallies;
            tallies = new int[6];
            tallies[_1 - 1]++;
            tallies[_2 - 1]++;
            tallies[d3 - 1]++;
            tallies[d4 - 1]++;
            tallies[d5 - 1]++;
            for (int i = 0; i < 6; i++)
                if (tallies[i] >= 4)
                    return (i + 1) * 4;
            return 0;
        }

        public static int ThreeOfAKind(int d1, int d2, int d3, int d4, int d5)
        {
            int[] t;
            t = new int[6];
            t[d1 - 1]++;
            t[d2 - 1]++;
            t[d3 - 1]++;
            t[d4 - 1]++;
            t[d5 - 1]++;
            for (int i = 0; i < 6; i++)
                if (t[i] >= 3)
                    return (i + 1) * 3;
            return 0;
        }

        public static int SmallStraight(int d1, int d2, int d3, int d4, int d5)
        {
            int[] tallies;
            tallies = new int[6];
            tallies[d1 - 1] += 1;
            tallies[d2 - 1] += 1;
            tallies[d3 - 1] += 1;
            tallies[d4 - 1] += 1;
            tallies[d5 - 1] += 1;
            if (tallies[0] == 1 &&
                tallies[1] == 1 &&
                tallies[2] == 1 &&
                tallies[3] == 1 &&
                tallies[4] == 1)
                return 15;
            return 0;
        }

        public static int LargeStraight(int d1, int d2, int d3, int d4, int d5)
        {
            int[] tallies;
            tallies = new int[6];
            tallies[d1 - 1] += 1;
            tallies[d2 - 1] += 1;
            tallies[d3 - 1] += 1;
            tallies[d4 - 1] += 1;
            tallies[d5 - 1] += 1;
            if (tallies[1] == 1 &&
                tallies[2] == 1 &&
                tallies[3] == 1 &&
                tallies[4] == 1
                && tallies[5] == 1)
                return 20;
            return 0;
        }

        public static int FullHouse(int d1, int d2, int d3, int d4, int d5)
        {
            int[] tallies;
            bool _2 = false;
            int i;
            int _2_at = 0;
            bool _3 = false;
            int _3_at = 0;




            tallies = new int[6];
            tallies[d1 - 1] += 1;
            tallies[d2 - 1] += 1;
            tallies[d3 - 1] += 1;
            tallies[d4 - 1] += 1;
            tallies[d5 - 1] += 1;

            for (i = 0; i != 6; i += 1)
                if (tallies[i] == 2)
                {
                    _2 = true;
                    _2_at = i + 1;
                }

            for (i = 0; i != 6; i += 1)
                if (tallies[i] == 3)
                {
                    _3 = true;
                    _3_at = i + 1;
                }

            if (_2 && _3)
                return _2_at * 2 + _3_at * 3;
            else
                return 0;
        }
    }
}
