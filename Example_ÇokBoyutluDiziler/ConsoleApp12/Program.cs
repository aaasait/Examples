using System;
using System.Diagnostics;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {

        /*
            Çok Boyutlu Dizi Türleri

                - Düzenli Çok Boyutlu Diziler
                    - İki Boyutlu Diziler
                    - Üç Boyutlu Diziler
                - Düzensiz (Jagged) Çok Boyutlu Diziler

            https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays
            https://www.w3schools.com/cs/cs_arrays_multi.php
         */

        #region İki Boyutlu Diziler

        //int[,] ikiBoyut;
        //int[,] ikiBoyut = new int[4,2];
        //int[,] ikiBoyut = {
        //                { 1, 2 },
        //                { 3, 4 },
        //                { 5, 6 },
        //                { 7, 8 }
        //              };
        //Console.WriteLine(ikiBoyut.Length);

        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    {
        //        Console.WriteLine(ikiBoyut[i, j]);
        //    }
        //}

        //Console.WriteLine("---------------->");

        //ikiBoyut[0, 0] = 10;
        //ikiBoyut[0, 1] = 20;
        //ikiBoyut[1, 0] = 30;
        //ikiBoyut[1, 1] = 40;
        //ikiBoyut[2, 0] = 50;
        //ikiBoyut[2, 1] = 60;
        //ikiBoyut[3, 0] = 70;
        //ikiBoyut[3, 1] = 80;

        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    {
        //        Console.WriteLine(ikiBoyut[i, j]);
        //    }
        //}

        #endregion

        #region Üç Boyutlu Diziler

        //int[,,] ucBoyut;
        //int[,,] ucBoyut = new int[4, 2, 2];
        //int[,,] ucBoyut = {
        //                           {{1,2},{3,4}},
        //                           {{5,6},{7,8}},
        //                           {{9,10},{11,12}},
        //                           {{13,14},{15,16}}
        //                       };

        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    {
        //        for (int k = 0; k < 2; k++)
        //        {
        //            Console.WriteLine(ucBoyut[i, j, k]);
        //        }
        //    }
        //}

        //ucBoyut[0, 0, 0] = 10;
        //ucBoyut[0, 0, 1] = 20;
        //ucBoyut[0, 1, 0] = 30;
        //ucBoyut[0, 1, 1] = 40;
        //ucBoyut[1, 0, 0] = 50;
        //ucBoyut[1, 0, 1] = 60;

        #endregion

        #region Düzensiz(Jagged) Diziler

        int[][] jagged =
        {
            new int[] { 1, 2, 3, 4, 5, 6 },
            new int[] { 1, 2 },
            new int[] { 1, 2, 3, 4 },
            new int[] { 1 }
        };

        Console.WriteLine(jagged.Length);

        //foreach (var jag in jagged)
        //{
        //    foreach (var ged in jag)
        //    {
        //        Console.Write(ged);
        //    }
        //    Console.WriteLine();
        //}

        #endregion
    }
}
