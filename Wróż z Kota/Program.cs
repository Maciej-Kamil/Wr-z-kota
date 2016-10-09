using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wróż_z_Kota
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("#####");
            Console.WriteLine("  # ");
            Console.WriteLine("#####");
            Console.WriteLine("  # ");
            Console.WriteLine("#####");
            Console.WriteLine("Witaj w grze, która powróży z kota za ciebie.");
            Console.WriteLine("Najpierw stawiasz przed NIM: kredę, balonik, monetę, kostkę i pierścień.");
            Console.WriteLine("Teraz musisz wybrać, poprzez wpisanie liczby: 1, 2, 3, 4, lub 5. Wybranie litery zakończy rozgrywkę.");
            string userValue = Console.ReadLine();
            string message = "";
            if (userValue == "1")
                message = "Kot przez chwile gapi się na kredę, a potem próbuje ją polizać. Po degustacji   odrzuca ją w twoją stronę. Znaczy to, że spróbujesz zrobić coś złego, ale         stwierdzisz, że nie opłaca ci się to.";
            else if (userValue == "2")
                message = "Kot zaczyna bawić się balonikiem, ale jego łapy go rozrywają. Wygląda na to, że w przyszłości otrzymasz wielką szansę, ale ją zmarnujesz.";
            else if (userValue == "3")
                message = "Kot próbuje złapać monetę łapą, ale nie udaje się mu i przypadkowo wyrzuca ją za łóżko. Przewidział w ten sposób, że w pewnym momencie będziesz miał dużo            pieniędzy, ale wszysko zmarnujesz.";
            else if (userValue == "4")
                message = "Kot dotyka monetę łapą i wypada 6. Wynika z tego, że będziesz miał bardzo dobre oceny w szkole i na studiach, a w pracy dostaniesz podwyżkę.";
            else if (userValue == "5")
                message = "Kot wkłada PIERŚĆIEŃ na pazur.                                                  Jeden, by nimi władać, Jeden, by je znaleźć,                                    Jeden, by je zgromadzić i wszystkie skrępować                                   W Mordorze, ziemi, gdzie Ciemność zaległa.                                      Witaj, Panie Mój, Sauronie. Nie, to nie do ciebie, mierny ludzki pomiocie.      Przez tyle lat nie udało ci się odkryć, że mieszka z tobą WYŻSZA istota, której przeznaczono WŁADZĘ NAD ŚWIATEM ? !";
            else
                message = "Kot dalej się liże";
           Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
