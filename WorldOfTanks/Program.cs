using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfTanks
{

    public class Tank
    {
        private string Name { get; set; }
        private int AmmunitionLvL { get; set; }
        private int ArmorLvL { get; set; }
        private int ManeuverabilityLvL { get; set; }

        public void Print()
        {
            Console.WriteLine("name - " + Name);
            Console.WriteLine("boekomplekt = " + AmmunitionLvL + " lvlBroni = " + ArmorLvL + " lvlManevr = " + ManeuverabilityLvL);
        }


        public Tank(int AmmunitionLvL, int ArmorLvL, int ManeuverabilityLvL, string Name)
        {
            this.Name = Name;

            this.AmmunitionLvL = AmmunitionLvL;

            this.ArmorLvL = ArmorLvL;
            this.ManeuverabilityLvL = ManeuverabilityLvL;
        }

        public static Tank operator ^(Tank d, Tank d2)
        {
            int t1Score = 0;
            if (d.AmmunitionLvL > d2.AmmunitionLvL) t1Score++;
            if (d.ArmorLvL > d2.ArmorLvL) t1Score++;
            if (d.ManeuverabilityLvL > d2.ManeuverabilityLvL) t1Score++;
            if (t1Score > 1) return d;
            else return d2;

        }



    }


    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 4; i++)
            //{

            //}
            Random rand = new Random();
            
            Tank t1 = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "Pantera");
            Tank t2 = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "Pantera");
            Tank t3 = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "Pantera");
            Tank t4 = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "Pantera");
            Tank t5 = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "Pantera");

            Tank p1 = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "T34");
            Tank p2 = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "T34");
            Tank p3 = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "T34");
            Tank p4 = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "T34");
            Tank p5 = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "T34");

            Tank[] T_34 = new Tank[5] { t1, t2, t3, t4, t5 };
            Tank[] Pantera = new Tank[5] { p1, p2, p3, p4, p5 };
            Tank[] WIN = new Tank[5];



            for (int i = 0; i < 5; i++)
            {
                
                WIN[i] = T_34[i] ^ Pantera[i];
                Console.WriteLine();
                Console.WriteLine($"В {i + 1} схватке победил");
                WIN[i].Print();
                Console.WriteLine();
            }



            Console.ReadLine();
        }

    }
}
