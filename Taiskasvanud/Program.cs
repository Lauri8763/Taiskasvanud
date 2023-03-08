public static void SumLINQ()
{
    Console.BackgroundColor = ConsoleColor.DarkYellow;

    Console.WriteLine("Sum LINQ");

    var sumAge = PeopleList.people.Sum(x => x.Age);

    Console.WriteLine(sumAge);

    Console.WriteLine("Täisealiste isikute koondvanus");

    var sumAdult = 0;

    var numAdults = PeopleList.people.Sum(x =>
    {
        if (x.Age >= 18)
        {
            //tahan teada t'iskasvanud t;;tajate koondvanust
            Adult[] people = {new Adult("Moona", 21), new Adult("Ron", 18), new Adult("Anna", 20), new Adult("Jumbo", 21)};
            sumAdult = PeopleList.people.Sum(x => x.Age);
            return 1;
        }
        else
        {
            return 0;
        }
    });

    Console.WriteLine("Täiskasvanud isikute arv " + numAdults);
    Console.WriteLine("Täiskasvanute koondvanuse tulemus " + sumAdult);
}
    }
}