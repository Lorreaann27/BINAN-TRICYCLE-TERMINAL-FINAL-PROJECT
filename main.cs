using System;

class Program
{
    static void Main(string[] args)
    {
        int totalIncome = 0;
        string destination = "";
        
        
        Console.WriteLine("-----WELCOME TO BIÑAN TRICYCLE TERMINAL-----\n");
        Console.WriteLine("-----List of Barangay in Biñan-----");
        ShowMainMenu();

        while (true)
        {
           
            Console.Write("\nPlease enter a number base on your destination (or 'exit' to end): ");
            destination = Console.ReadLine();

            if (destination == "exit")
            {
                break;
            }

            int fare = CalculateFare(destination);

            if (fare == -1)
            {
                Console.WriteLine("Invalid destination.");
                continue;
            }
            Console.Write("\nEnter payment amount: ");
            int payment = int.Parse(Console.ReadLine());
            
            
            if (payment < fare)
            {
                Console.WriteLine("Insufficient payment.");
                continue;
            }

            int change = payment - fare;
            Console.WriteLine("Your change is {0} php.", change);

            totalIncome += fare;
            Console.WriteLine("\nWelcome to your destination!");
			Console.WriteLine("Thankyou!");
        }

        Console.WriteLine("Total income for the day: {0} php", totalIncome);
    }

    static int CalculateFare(string destination)//method signature
    {
        switch (destination)
        {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            return 15;
                ShowMainMenu();
                break;
                
            case "6":
            case "7":
            return 25;
                ShowMainMenu();
                break;
                
            case "8":
            case "9":
            case "10":
            case "11":
            case "12":
            case "13":
            case "14":
            case "15":
            case "16":
            case "17":
            case "18":
            return 40;
                ShowMainMenu();
                break;
                
            case "19":
            case "20":
            case "21":
            case "22":
            case "23":
            case "24":
                return 60;
                ShowMainMenu();
                break;
            default:
                return -1;
        }
    }
    
    static void ShowMainMenu()//method signature
    {
       Console.WriteLine("List of Barangay in Biñan");
			Console.WriteLine("1. Biñan Poblacion - 15 php");
			Console.WriteLine("2. Casile - 15 php");
			Console.WriteLine("3. Dela Paz - 15 php");
			Console.WriteLine("4. Poblacion - 15 php");
			Console.WriteLine("5. San Antonio - 15 php");
			Console.WriteLine("6. Canlalay - 25 php");
			Console.WriteLine("7. Santo Domingo - 25 php");
			Console.WriteLine("8. Bungahan - 40 php");
			Console.WriteLine("9. Ganado - 40 php");
			Console.WriteLine("10. Platero - 40 php");
			Console.WriteLine("11. San Francisco - 40 php");
			Console.WriteLine("12. San Jose - 40 php");
			Console.WriteLine("13. Santo Niño - 40 php");
			Console.WriteLine("14. Santo Thomas - 40 php");
			Console.WriteLine("15. San Vicente - 40 php");
			Console.WriteLine("16. Soro Soro - 40 php");
			Console.WriteLine("17. Tubigan - 40 php");
			Console.WriteLine("18. Zapote - 40 php");
			Console.WriteLine("19. Langkiwa - 60 php");
			Console.WriteLine("20. Loma - 60 php");
			Console.WriteLine("21. Malamig - 60 php");
			Console.WriteLine("22. Mamplasan - 60 php");
			Console.WriteLine("23. Timbao - 60 php");

    }
}