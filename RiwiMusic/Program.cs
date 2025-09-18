using MyNamespace.Models;

namespace MyNamespace;

class Program
{
    public static void FirstMenu(List<Concert> concert)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Welcome to Concert Management");
            Console.Write("\n 1.Register concert");
            Console.Write("\n 2.List concerts");
            Console.Write("\n 3.Edit concert");
            Console.Write("\n 4.Delete concert");
            Console.Write("\n 5.Back to principal menu \n");
                
            int method = Convert.ToInt32(Console.ReadLine());

            switch (method)
            {
                case 1: 
                    Console.Write("Register a  concert");
                    Console.Write("\n 1.Id of concert: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n 2.Title of concert: ");
                    string title = Console.ReadLine();
                    Console.Write("\n 2.Artist of concert: ");
                    string artist = Console.ReadLine();
                    Console.Write("\n 3.Genre of concert: ");
                    string genre = Console.ReadLine();
                    Console.WriteLine("Concert city ");
                    string city = Console.ReadLine();


                    Concert concierto = new Concert { concertId = id, Title = title, Artist = artist, Genre = genre ,City = city};
                    concert.Add(concierto);
                            
                    break;
                case 2:
                    Console.Write("list concert: \n");
                    var listConcert = concert.Select(l => l.Title + "-----" + l.Artist);
                    foreach (var order in listConcert)
                    {
                        Console.WriteLine(order);
                    }
                    Console.ReadLine();
                    break;
                case 3:
                    
                    
                    break;
            } 
        }
    }
    
    public static void Main(string[] args)
    {
        // Concert list
         #region MyRegion

          var concert = new List<Concert>
                {
                    new Concert{concertId = 01,Title = "Malcriado",Artist = "Lasso",Genre = "Pop",City = "Venezuela"},
                    new Concert{concertId = 02,Title = "Lollapalooza",Artist = "Katseye",Genre = "Pop",City = "USA"},
                    new Concert{concertId = 03,Title = "LMYNL",Artist = "Shakira",Genre = "Pop",City = "London"},
                    new Concert{concertId = 04,Title = "DAPA",Artist = "Camilo",Genre = "Pop",City = "USA"},
                    new Concert{concertId = 02,Title = "Deadline",Artist = "BlackPink",Genre = "K-pop",City = "USA"},
                };
                

        #endregion

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome select an option ");
            Console.WriteLine("1.Concert Management");
            Console.WriteLine("2.Customers Management");
            Console.WriteLine("3.Ticket Management");
            Console.WriteLine("4.Purchase History");
            Console.WriteLine("5.Exit");

            int choice = int.Parse(Console.ReadLine());
            //char second = char.Parse(Console.ReadLine().ToLower());
            switch (choice)
            {
                case 1: 
                    FirstMenu(concert);
                    break;
                default:
                    Console.WriteLine("Error, intentelo de nuevo");
                    Console.ReadLine();
                    continue;
                    
                    
                
                

                   // switch (second)
                    //{
                        //case 'A': 
                            
                            //break;
                        //case 'B':
                            //Console.WriteLine("List of concerts");
                            //var list = concert.Select(c => c.Title);
                            //foreach (var c in list)
                            //{
                                //Console.WriteLine(list);
                            //}
                            //break;
                    //}
                    //break;
            }
        }
        
        /*/
        var client = new List<Client>
        {
            new Client{Id = 01,Name = "John",Age = 20},
            new Client{Id = 02,Name = "Juan",Age = 28},
            new Client{Id = 03,Name = "Mary",Age = 30},
            new Client{Id = 04,Name = "Marcos",Age = 25},
            new Client{Id = 05,Name = "Joseph",Age = 20},
        };
        /*/
        
        
        
    }
}