



Console.WriteLine("Vítej ve hře kámen nůžky papír\n");

var volba = "";
do
{
    Random rnd = new Random();
    int i = rnd.Next(1, 4); // (1-99)

    Console.WriteLine("Zvol jedno z následujících:\n(K)ámen\n(N)ůžky\n(P)apír\n(E)xit");

    Console.Write("->");

    volba = Console.ReadLine().ToUpper();

    switch (volba)
    {
        case "K":

            switch (i)
            {
                case 1:
                    Console.WriteLine("Kámen vs Kámen\nRemíza!\n\n");
                    break;
                case 2:
                    Console.WriteLine("Kámen vs Nůžky\nVyhrál jsi!\n\n");
                    break;
                case 3:
                    Console.WriteLine("Kámen vs Papír\nProhrál jsi!\n\n");
                    break;
            }
            break;
        case "N":

            switch (i)
            {
                case 1:
                    Console.WriteLine("Nůžky vs Kámen\nProhrál jsi!\n\n");
                    break;
                case 2:
                    Console.WriteLine("Nůžky vs Nůžky\nRemíza!\n\n");
                    break;
                case 3:
                    Console.WriteLine("Nůžky vs Papír\nVyhrál jsi!\n\n");
                    break;
            }
            break;
        case "P":
            switch (i)
            {
                case 1:
                    Console.WriteLine("Papír vs Kámen\nVyhrál jsi!\n\n");
                    break;
                case 2:
                    Console.WriteLine("Papír vs Nůžky\nProhrál jsi!\n\n");
                    break;
                case 3:
                    Console.WriteLine("Papír vs Papír\nRemíza!\n\n");
                    break;
            }
            break;
        // else
        case "E":
            
            break;
        default:
            Console.WriteLine("Neznama volba...\n\n");
            break;
    }
} while (volba != "E");

