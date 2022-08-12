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
        void DIÁK_ROBOTJAI()
        {
            Robot karesz = Robot.Get("Karesz");

            karesz.Feladat = delegate ()
            {
                for(int i = 0; i < 16; i++)
                {
                    karesz.Lépj();
                }
                karesz.Fordulj(jobbra);
                karesz.Lépj();
                karesz.Fordulj(balra);
                karesz.Fordulj(balra);
                karesz.Várj();
                karesz.Várj();
                while(karesz.SzélesUltrahangSzenzor()==(2, 1, 2))
                {
                    karesz.Várj();
                }
                karesz.Lépj();
                karesz.Fordulj(jobbra);
                for(int j = 0; j < 3; j++)
                {
                    karesz.Lépj();
                }
                karesz.Fordulj(balra);
                karesz.Lépj();
                karesz.Fordulj(balra);
                karesz.Fordulj(balra);
                for(int k = 0; k < 9; k++)
                {
                    karesz.Várj();
                }
                while(karesz.SzélesUltrahangSzenzor()==(2, 1, 2))
                {
                    karesz.Várj();
                }
                karesz.Lépj();
                karesz.Fordulj(balra);
                for(int l = 0; l < 3; l++)
                {
                    karesz.Lépj();
                }
                karesz.Fordulj(jobbra);
                karesz.Lépj();
                karesz.Fordulj(balra);
                karesz.Fordulj(balra);
                while(karesz.SzélesUltrahangSzenzor()==(2, 1, 2))
                {
                    karesz.Várj();
                }
                for(int i = 0; i < 9; i++)
                {
                    karesz.Várj();
                }
                karesz.Lépj();
                karesz.Fordulj(jobbra);
                for(int j = 0; j < 3; j++)
                {
                    karesz.Lépj();
                }
                karesz.Fordulj(balra);
                karesz.Lépj();
                karesz.Fordulj(balra);
                karesz.Fordulj(balra);
                while(karesz.SzélesUltrahangSzenzor()==(2, 1, 2))
                {
                    karesz.Várj();
                }
                karesz.Lépj();
                karesz.Fordulj(balra);
                for(int i = 0; i < 3; i++)
                {
                    karesz.Lépj();
                }
                karesz.Fordulj(jobbra);
                karesz.Lépj();
                karesz.Fordulj(balra);
                karesz.Fordulj(balra);
                while(karesz.SzélesUltrahangSzenzor()==(2, 1, 2))
                {
                    karesz.Várj();
                }
                for(int i = 0; i < 9; i++)
                {
                    karesz.Várj();
                }
                karesz.Lépj();
                karesz.Fordulj(jobbra);
                for(int i = 0; i < 3; i++)
                {
                    karesz.Lépj();
                }
                karesz.Fordulj(balra);
                karesz.Lépj();
                karesz.Fordulj(balra);
                karesz.Fordulj(balra);
                while(karesz.SzélesUltrahangSzenzor()==(2, 1, 2))
                {
                    karesz.Várj();
                }
                karesz.Lépj();
                karesz.Fordulj(balra);
                for(int i = 0; i < 3; i++)
                {
                    karesz.Lépj();
                }
                karesz.Fordulj(jobbra);
                karesz.Lépj();
                karesz.Fordulj(balra);
                karesz.Fordulj(balra);
                while(karesz.SzélesUltrahangSzenzor()==(2, 1, 2))
                {
                    karesz.Várj();
                }
                for(int i = 0; i < 9; i++)
                {
                karesz.Várj();
                }
                karesz.Lépj();
                karesz.Fordulj(jobbra);
                for(int i = 0; i < 3; i++)
                {
                    karesz.Lépj();
                }
                karesz.Fordulj(balra);
                karesz.Lépj();
                karesz.Fordulj(balra);
                karesz.Fordulj(balra);
                while(karesz.SzélesUltrahangSzenzor()==(2, 1, 2))
                {
                    karesz.Várj();
                }
                while(karesz.Alatt_ez_van() != sárga)
                {
                    karesz.Lépj();
                }
                karesz.Vegyél_fel_egy_kavicsot();
                karesz.Mondd("EZ");
            };
        }
    }
}

/* LEGFONTOSABB PARANCSOK

MOZGÁSOK

karesz.Lépj();                          -------- Karesz előre lép egyet.
karesz.Fordulj(jobbra);                 -------- Karesz jobbra fordul.
karesz.Fordulj(balra);                  -------- Karesz balra fordul.
karesz.Vegyél_fel_egy_kavicsot();       -------- Karesz felvesz egy kavicsot.
karesz.Tegyél_le_egy_kavicsot();        -------- Karesz letesz egy fekete kavicsot
karesz.Tegyél_le_egy_kavicsot(piros);   -------- Karesz letesz egy piros kavicsot.

Minden mozgás után a robot köre véget ér és a következő robot jön. 



SZENZOROK

karesz.Előtt_fal_van();                 -------- igaz, ha Karesz fal előtt áll, egyébként hamis.
karesz.Ki_fog_lépni_a_pályáról();       -------- igaz, ha Karesz a pálya szélén kifele néz, egyébként hamis.
karesz.Alatt_van_kavics();              -------- igaz, ha Karesz épp kavicson áll, egyébként hamis.
karesz.Köveinek_száma_ebből(piros)      -------- Karesz piros köveinek a száma.
karesz.Alatt_ez_van();                  -------- a kavics színe, amin Karesz áll. (Ez igazából egy szám!)
karesz.UltrahangSzenzor();              -------- a Karesz előtt található tárgy távolsága. Ez a tárgy lehet fal vagy másik robot is. 
karesz.SzélesUltrahangSzenzor();        -------- ugyanaz, mint az ultrahangszenzor, de ez nem csak a Karesz előtti mezőket pásztázza, hanem a szomszédos mezőket is. Egy számhármast ad vissza. 
karesz.Hőmérő();                        -------- a Karesz által mért hőmérséklet. A láva forrása 1000 fok, amitől lépésenként távolodva a hőmérséklet 200 fokonként hűl. Az alapértelmezett hőmérséklet 0 fok.

A szenzorokat bármennyiszer használhatja a robot a saját körén belül.

*/