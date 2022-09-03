// See https://aka.ms/new-console-template for more information

/*QUIZ04.Solution.Soal1();
QUIZ04.Solution.Soal2();
QUIZ04.Solution.Soal3a();
*//*QUIZ04.Solution.hitungBuah();*/
//QUIZ04.Solution.InitHasSet();// No1

/*QUIZ04.Solution.Soal1();
QUIZ04.Solution.Soal2();
QUIZ04.Solution.Soal3();
QUIZ04.Solution.Soal4();
QUIZ04.Solution.Soal5();
QUIZ04.Solution.Soal6();
QUIZ04.Solution.Soal7();
QUIZ04.Solution.Soal8();
QUIZ04.Solution.Soal9();
*/


bool testing = false;
while (!testing)
{
    Console.Write("Masukan No Soal (N0 1-9):");
    int no = Convert.ToInt32(Console.ReadLine());
    switch (no)
    {
        case 1:
            QUIZ04.Solution.Soal1();
            break;
        case 2:
            QUIZ04.Solution.Soal2();
            break;
        case 3:
            QUIZ04.Solution.Soal3();
            break;
        case 4:
            QUIZ04.Solution.Soal4();
            break;
        case 5:
            QUIZ04.Solution.Soal5();
            break;
        case 6:
            QUIZ04.Solution.Soal6();
            break;
        case 7:
            QUIZ04.Solution.Soal7();
            break;
        case 8:
            QUIZ04.Solution.Soal8();
            break;
        case 9:
            QUIZ04.Solution.MasukSoal9();
            break;
        case 10:
            QUIZ04.Solution.MasukSoal9();
            break;
        default:
            Console.WriteLine($"Tidak ada nomor soal {no}");
            break;
    }
option:
    Console.Write("Lanjut?(Ya(y)/Tidak(n)/Mungkin(m))");
    string opt = Console.ReadLine();
    if (opt == "n")
    {
        Console.WriteLine("Terima Kasih");
        testing = true;
    }
    else if (opt == "y")
    {
        Console.Clear();

    }
    else if (opt == "m")
    {
        Console.Clear();
        Console.WriteLine("Jangan Bingung Dong");
        Console.WriteLine();
        goto option;
    }
    else
    {
        Console.Clear();
        goto option;
    }
}