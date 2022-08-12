using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
    public partial class Form1 : Form
    {
        string betöltendő_pálya = "palya003.txt";

        void TANÁR_ROBOTJAI()
        {
            new Robot("Karesz", 10, 10, 10, 10, 0, 1, 2, 1);


            Robot janesz = new Robot("Janesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 15, 39, 2, 3);
            

            janesz.Feladat = delegate ()
            {
                while (pálya.MiVanItt(new Vektor(38, 3)) == sárga)
                { 
                    janesz.Lőjj();
                    for (int j = 0; j < 10; j++)
                    {
                        janesz.Várj();
                    }

                }
            };

        }
    }
}
