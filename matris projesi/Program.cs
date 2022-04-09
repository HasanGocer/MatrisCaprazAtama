using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matris_projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region sayı isteme ve değerler
            Console.Write("Matrisin satırını giriniz : ");
            int satir = Convert.ToInt32(Console.ReadLine());

            Console.Write("Matrisin sütununu giriniz : ");
            int sutun = Convert.ToInt32(Console.ReadLine());

            int[,] Dizi1 = new int[satir,sutun];

            Random rnd = new Random();


            int belirtec;
            bool kontrol;

            #endregion

            #region belirleme
            if (satir > sutun)
            {
                belirtec = 1;
            }
            else if (satir < sutun)
            {
                belirtec = 2;
            }
            else
            {
                belirtec = 0;
            }

            #endregion

            #region kare
            if (belirtec == 0)
            {
                for(int i1 = 0; i1 < satir; i1++)
                {
                    for(int i2 = 0; i2 <= i1; i2++)
                    {
                        Dizi1[i2, (i1 - i2)] = 1;
                    }
                }
                
                
                int i5 = satir-1;
                for(int i3 = 1; i3 < satir; i3++)
                {
                    for(int i4 = i5; i4 < satir; i4++)
                    {
                        Dizi1[i3, i4] = 2;
                    }
                    i5--;
                }
            }
            #endregion

            #region dikey dikdörtgen
            if (belirtec == 1)
            {
                int fark = satir - sutun - 1;
                for (int i1 = 0; i1 < sutun; i1++)
                {
                    for (int i2 = 0; i2 <= i1; i2++)
                    {
                        Dizi1[i2, (i1 - i2)] = 1;
                    }
                }
                int i8 = 1;

                for (int i1 = 0; i1 <= fark; i1++)
                {
                    
                    int i7 = i8;
                    int i4 = sutun-1;
                    for(int i2 = 0; i2 < sutun; i2++)
                    {
                        
                        Dizi1[i7,i4]=2;
                        i4--;
                        i7++;
                    }
                    i8++;
                }
                

                int i6 = satir - sutun;
                int i5 = sutun - 1;
                for (int i3 = i6; i3 < satir; i3++)
                {
                    for (int i4 = i5; i4 < sutun; i4++)
                    {
                        Dizi1[i3, i4] = 3;
                    }
                    i5--;
                }
            }

            #endregion

            #region yatay dikdörtgen
            if (belirtec == 2)
            {
                int fark = sutun - satir - 1;
                for (int i1 = 0; i1 < satir; i1++)
                {
                    for (int i2 = 0; i2 <= i1; i2++)
                    {
                        Dizi1[i2, (i1 - i2)] = 1;
                    }
                }
                
                int i8 = 1;
                for (int i1 = 0; i1 <= fark; i1++)
                {

                    int i7 = i8;
                    int i4 = satir - 1;
                    for (int i2 = 0; i2 < satir; i2++)
                    {

                        Dizi1[i4, i7] = 2;
                        i4--;
                        i7++;
                    }
                    i8++;
                }
                
                int i6 =sutun-satir;
                int i5 = satir - 1;
                for (int i3 = i6; i3 < sutun; i3++)
                {
                    for (int i4 = i5; i4 < satir; i4++)
                    {
                        Dizi1[i4, i3] = 3;
                    }
                    i5--;
                }
            }

            #endregion

            #region okuma
            for (int i1 = 0; i1 < satir; i1++)
            {
                for(int i2 = 0; i2 < sutun; i2++)
                {
                    Console.Write("{0}",Dizi1[i1, i2]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();

            #endregion
        }
    }
}
