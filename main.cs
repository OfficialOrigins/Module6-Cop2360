//Greenville Idol 
//Module 6 Part one
// using System;

// class Program
// {

//     public static void Main(string[] args)
//     {

//         string option;
//         bool loop = true;

//         while (loop)
//         {

//             menu();
//             Console.WriteLine(" ");
//             Console.Write("Please pick an option: ");
//             option = Console.ReadLine();

//             switch (option)
//             {
//                 case "1":
//                     Console.WriteLine(" ");
//                     calculate();
//                     break;

//                 case "2":
//                     Console.WriteLine(" ");
//                     Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
//                     loop = false;
//                     break;
//             }
//         }
//     }

//     static void menu()
//     {
//         Console.WriteLine("************************************");
//         Console.WriteLine("*  The stars shine in Greenville.  *");
//         Console.WriteLine("************************************");

//         Console.WriteLine(" ");

//         Console.WriteLine("Please Enter the following number below from the following menu:");

//         Console.WriteLine(" ");

//         Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
//         Console.WriteLine("2. Exit program");
//     }

//     static void calculate()
//     {

//         Console.Write("Enter the amount of contestants last year: ");
//         int lastYearContestants = int.Parse(Console.ReadLine());

//         Console.WriteLine(" ");

//         Console.Write("Enter the amount of contestants this year: ");
//         int thisYearContestants = int.Parse(Console.ReadLine());

//         int totalRevenue = (thisYearContestants * 25);

//         Console.WriteLine(" ");

//         Console.WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants.", lastYearContestants, thisYearContestants);

//         Console.WriteLine(" ");

//         Console.WriteLine("This year's revenue is expected to be ${0}.", totalRevenue);

//         Console.WriteLine(" ");

//         if (lastYearContestants < thisYearContestants)
//         {
//             Console.WriteLine(" ");
//             Console.WriteLine("It is true that this year's competition is bigger than last year's.");
//             Console.WriteLine(" ");
//         }

//         if (lastYearContestants > thisYearContestants)
//         {
//             Console.WriteLine(" ");
//             Console.WriteLine("It is false that this year's competition is bigger than last year's.");
//             Console.WriteLine(" ");
//         }

//         else if (lastYearContestants == thisYearContestants)
//         {
//             Console.WriteLine("It seems that this year's and last year's contestants are the same amount");
//             Console.WriteLine(" ");
//         }
//     }
// }


//Module 7 version 02 

using System;

class Program
{

    public static void Main(string[] args)
    {

        string option;
        bool loop = true;

        while (loop)
        {

            menu();
            Console.WriteLine(" ");
            Console.Write("Please pick an option: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine(" ");
                    calculate();
                    break;

                case "2":
                    Console.WriteLine(" ");
                    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                    loop = false;
                    break;
            }
        }
    }

    static void menu()
    {
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");

        Console.WriteLine(" ");

        Console.WriteLine("Please Enter the following number below from the following menu:");

        Console.WriteLine(" ");

        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit program");
    }

    static void calculate()
    {

        Console.Write("Enter the amount of contestants last year: ");
        int lastYearContestants = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.Write("Enter the amount of contestants this year: ");
        int thisYearContestants = int.Parse(Console.ReadLine());

        int totalRevenue = (thisYearContestants * 25);

        Console.WriteLine(" ");

        Console.WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants.", lastYearContestants, thisYearContestants);

        Console.WriteLine(" ");

        Console.WriteLine("This year's revenue is expected to be ${0}.", totalRevenue);

        Console.WriteLine(" ");

        if (lastYearContestants < thisYearContestants)
        {
            Console.WriteLine(" ");
            Console.WriteLine("It is true that this year's competition is bigger than last year's.");
            Console.WriteLine(" ");
        }

        if (lastYearContestants > thisYearContestants)
        {
            Console.WriteLine(" ");
            Console.WriteLine("It is false that this year's competition is bigger than last year's.");
            Console.WriteLine("Come out and cast your vote!");
            Console.WriteLine(" ");
        }

        // if(thisYearContestants > (2*lastYearContestants))
        // {
        //     Console.WriteLine(" ");
        //     Console.WriteLine("The competition is more than twice as big this year!");
        //     Console.WriteLine(" ");
        // }

        if ((thisYearContestants > lastYearContestants) && (thisYearContestants < (2 * lastYearContestants)))
        {
            Console.WriteLine(" ");
            Console.WriteLine("The competition is bigger than ever!");
            Console.WriteLine(" ");
        }


        else if (lastYearContestants == thisYearContestants)
        {
            Console.WriteLine("It seems that this year's and last year's contestants are the same amount");
            Console.WriteLine(" ");
        }
    }
}
