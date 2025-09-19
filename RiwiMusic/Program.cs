using MyNamespace.Models;

namespace MyNamespace;

class Program
{
    public static DateTime generateDate(int year, int month, int day)
    {
        return new DateTime(year, month, day);
    }
    //FirstMenu === menu de Gestión de Conciertos
    public static void FirstMenu(List<Concert> concert)
    {
        while (true)
        {

            // Concert Management Submenu
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
                //Register a concert
                case 1: 
                    Console.Write("Register a  concert");
                    Console.Write("\n Id of concert: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Title of concert: ");
                    string title = Console.ReadLine();
                    Console.Write(" Artist of concert: ");
                    string artist = Console.ReadLine();
                    Console.Write(" Genre of concert: ");
                    string genre = Console.ReadLine();
                    Console.WriteLine("Concert city ");
                    string city = Console.ReadLine();


                    Concert concierto = new Concert { concertId = id, Title = title, Artist = artist, Genre = genre ,City = city};
                    concert.Add(concierto);
                            
                    break;
                //List all concerts
                case 2:
                    Console.Write("list concert: \n");
                    Console.Write("Id ----------- Tittle ------- Artist ------- Gender ------- City \n");
                    foreach (var order in concert)
                    {
                        Console.WriteLine($"{order.concertId, -15}{order.Title, -15}{order.Artist, -15}" +
                                          $"{order.Genre, -15}{order.City, -15}");
                    }
                    Console.Write("Prees 'Enter' to continue: ");
                    Console.ReadLine();
                    break;
                //Edit a concert
                case 3:
                    Console.WriteLine("Edit a concert");

                    Console.Write("Enter the Id of the concert to edit: ");
                    string input = Console.ReadLine();
                    int editId;

                    if (!int.TryParse(input, out editId))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.ReadLine();
                        break;
                    }

                    var editConcert = concert.FirstOrDefault(c => c.concertId == editId);

                    if (editConcert != null)
                    {
                        Console.Write(" New Title of concert: ");
                        editConcert.Title = Console.ReadLine();
                        Console.Write(" New Artist of concert: ");
                        editConcert.Artist = Console.ReadLine();
                        Console.Write(" New Genre of concert: ");
                        editConcert.Genre = Console.ReadLine();
                        Console.Write(" New City of concert: ");
                        editConcert.City = Console.ReadLine();

                        Console.WriteLine("Concert updated successfully!");
                        Console.Write("Press 'Enter' to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Concert not found");
                        Console.Write("Press 'Enter' to continue");
                        Console.ReadLine();
                    }
                    break;
                //Delete a concert

                case 4:
                    Console.WriteLine("Delete a concert");
                    Console.Write("Enter the Id of the concert to delete: ");
                    string deleteInput = Console.ReadLine();
                    int deleteId;
                    if (!int.TryParse(deleteInput, out deleteId))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.ReadLine();
                        break;
                    }
                    var deleteConcert = concert.FirstOrDefault(c => c.concertId == deleteId);
                    if (deleteConcert != null)
                    {
                        concert.Remove(deleteConcert);
                        Console.WriteLine("Concert deleted successfully!");
                        Console.Write("Press 'Enter' to continue");
                    }
                    else
                    {
                        Console.WriteLine("Concert not found");
                        Console.Write("Press 'Enter' to continue");
                    }
                    Console.ReadLine();

                    break;
                case 5:
                    return;

            }
        }
    }

    //secondMenu === menu de Gestión de Clientes
    public static void secondMenu(List<Client> clients)
    {
        
        while (true)
        {

            // Concert Management Submenu
            Console.Clear();
            Console.Write("Welcome to Clients Management");
            Console.Write("\n 1.Register client");
            Console.Write("\n 2.List client");
            Console.Write("\n 3.Edit client");
            Console.Write("\n 4.Delete client");
            Console.Write("\n 5.Back to principal menu \n");
                
            int method = Convert.ToInt32(Console.ReadLine());

            switch (method)
            {
                //Register a concert
                case 1: 
                    Console.Write("Register a client");
                    Console.Write("\n Id of client: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Name of client: ");
                    string name = Console.ReadLine();
                    Console.Write(" Age of client: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    
                    Client client = new Client() { clientId = id, Name = name, Age = age };
                    clients.Add(client);
                            
                    break;
                //List all clients
                case 2:
                    Console.Write("list of clients: \n");
                    Console.Write("Id ------ Name --------- Age \n");
                    foreach (var order in clients)
                    {
                        Console.WriteLine($"{order.clientId, -10}{order.Name, -15}{order.Age, -15}");
                    }
                    Console.Write("Press 'Enter' to continue");
                    Console.ReadLine();
                    break;
                //Edit a client
                case 3:
                    Console.WriteLine("Edit a client");

                    Console.Write("Enter the Id of the client to edit: ");
                    string input = Console.ReadLine();
                    int editId;

                    if (!int.TryParse(input, out editId))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.ReadLine();
                        break;
                    }

                    var editClient = clients.FirstOrDefault(c => c.clientId == editId);

                    if (editClient != null)
                    {
                        Console.Write(" New Name of client: ");
                        editClient.Name = Console.ReadLine();
                        Console.Write(" New Age of client: ");
                        editClient.Age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Client updated successfully!");
                        Console.Write("Press 'Enter' to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Client not found");
                        Console.ReadLine();
                    }
                    break;
                //Delete a client

                case 4:
                    Console.WriteLine("Delete a client");
                    Console.Write("Enter the Id of the client to delete: ");
                    string deleteInput = Console.ReadLine();
                    int deleteId;
                    if (!int.TryParse(deleteInput, out deleteId))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.ReadLine();
                        break;
                    }
                    var deleteClient = clients.FirstOrDefault(c => c.clientId == deleteId);
                    if (deleteClient != null)
                    {
                        clients.Remove(deleteClient);
                        Console.WriteLine("Client deleted successfully!");
                        Console.Write("Press 'Enter' to continue");
                    }
                    else
                    {
                        Console.WriteLine("Client not found");
                        Console.Write("Press 'Enter' to continue");
                    }
                    Console.ReadLine();
                    break;
                case 5:
                    return;

            }
        }
        
    }
    
    //ThirdMenu === menu de Gestión de Tiquetes
    public static void ThirdMenu(List<Tickets> tickets)
    {
        while (true)
        {

            // Tickets Management Submenu
            Console.Clear();
            Console.Write("Welcome to Concert Management");
            Console.Write("\n 1.Register ticket purchase");
            Console.Write("\n 2.List sold tickets");
            Console.Write("\n 3.Edit purchase");
            Console.Write("\n 4.Delete purchase");
            Console.Write("\n 5.Back to principal menu \n");
                
            int method = Convert.ToInt32(Console.ReadLine());

            switch (method)
            {
                //Register a tickect
                case 1: 
                    Console.Write("Register a ticket");
                    Console.Write("\n Id of ticket: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Ticket Name: ");
                    string name = Console.ReadLine();
                    Console.Write(" Ticket Price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Ticket Date: ");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Ticket Place: ");
                    string place = Console.ReadLine();
                    Console.WriteLine("Ticket Available (true/false): ");
                    bool available = Convert.ToBoolean(Console.ReadLine());
                    
                    Tickets ticket = new Tickets
                    {
                        ticketsId = id, Name = name, Price = price, Date = date ,Place = place,
                        Available = available
                    };
                    tickets.Add(ticket);
                            
                    break;
                //List all tickets
                case 2:
                    Console.Write("list tickets: \n");
                    Console.Write($"Id ------ Name --------- Price -------- Date --------- Place -------- Available \n");
                    foreach (var order in tickets)
                    {
                        Console.WriteLine($"{order.ticketsId, -10}{order.Name, -15}{order.Price, -15}{order.Date.ToString("d"), -15}" +
                                          $"{order.Place, -15}{order.Available, -15}");
                    }

                    Console.Write("Press 'Enter' to continue");
                    Console.ReadLine();
                    break;
                //Edit a ticket
                case 3:
                    Console.WriteLine("Edit a ticket");

                    Console.Write("Enter the Id of the ticket to edit: ");
                    string input = Console.ReadLine();
                    int editId;

                    if (!int.TryParse(input, out editId))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.ReadLine();
                        break;
                    }

                    var editTicket = tickets.FirstOrDefault(c => c.ticketsId == editId);

                    if (editTicket != null)
                    {
                        Console.Write(" New Name of ticket: ");
                        editTicket.Name = Console.ReadLine();
                        Console.Write(" New Price of ticket: ");
                        editTicket.Price = Convert.ToDouble(Console.ReadLine());
                        Console.Write(" New Date of ticket: (dd/mm/aaaa)");
                        editTicket.Date = Convert.ToDateTime(Console.ReadLine());
                        Console.Write(" New Place of ticket: ");
                        editTicket.Place = Console.ReadLine();
                        Console.Write(" New Available of ticket: (true/false)");
                        editTicket.Available = Convert.ToBoolean(Console.ReadLine());
                        
                        Console.WriteLine("Ticket updated successfully!");
                        Console.Write("Press 'Enter' to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Ticket not found");
                        Console.Write("Press 'Enter' to continue");
                        Console.ReadLine();
                    }
                    break;
                //Delete a Ticket

                case 4:
                    Console.WriteLine("Delete a Ticket");
                    Console.Write("Enter the Id of the ticket to delete: ");
                    string deleteInput = Console.ReadLine();
                    int deleteId;
                    if (!int.TryParse(deleteInput, out deleteId))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.ReadLine();
                        break;
                    }
                    var deleteTicket = tickets.FirstOrDefault(c => c.ticketsId == deleteId);
                    if (deleteTicket != null)
                    {
                        tickets.Remove(deleteTicket);
                        Console.WriteLine("Ticket deleted successfully!");
                        Console.Write("Press 'Enter' to continue");
                    }else
                    {
                        Console.WriteLine("Ticket not found");
                        Console.Write("Press 'Enter' to continue");
                    }
                    Console.ReadLine();
                    
                    break;
                case 5:
                    return;
            }
        }
    }
    
    public static void Main(string[] args)
    {
        
        // Concert list

      var concert = new List<Concert>
            {
                new Concert{concertId = 01,Title = "Malcriado",Artist = "Lasso",Genre = "Pop",City = "Venezuela"},
                new Concert{concertId = 02,Title = "Lollapalooza",Artist = "Katseye",Genre = "Pop",City = "New York"},
                new Concert{concertId = 03,Title = "LMYNL",Artist = "Shakira",Genre = "Pop",City = "London"},
                new Concert{concertId = 04,Title = "DAPA",Artist = "Camilo",Genre = "Pop",City = "New York"},
                new Concert{concertId = 05,Title = "Deadline",Artist = "BlackPink",Genre = "K-pop",City = "Seoul"},
            };
      
        //client list

        var client = new List<Client>
        {
            
            new Client{clientId = 01, Name = "Ana", Age = 25},
            new Client{clientId = 02, Name = "Maria", Age = 20},
            new Client{clientId = 03, Name = "Mario", Age = 18},
            new Client{clientId = 04, Name = "Daniel", Age = 32},
            new Client{clientId = 05, Name = "Orianna", Age = 23}
            
        };
        
        //ticket list

        var tickets = new List<Tickets>
        {
            
            new Tickets{ticketsId = 01, Name = "Malcriado", Price = 1000, Date = generateDate(2010, 05, 10), Place = "Medellin", Available = true},
            new Tickets{ticketsId = 02, Name = "Lollapalooza", Price = 1000, Date = generateDate(2025, 08, 29), Place = "Medellin", Available = true},
            new Tickets{ticketsId = 03, Name = "LMYNL", Price = 1000, Date = generateDate(2021, 03, 18), Place = "Medellin", Available = true},
            new Tickets{ticketsId = 04, Name = "DAPA", Price = 1000, Date = generateDate(2007, 01, 25), Place = "Medellin", Available = true},
            new Tickets{ticketsId = 05, Name = "Deadline", Price = 1000, Date = generateDate(2006, 04, 28), Place = "Medellin", Available = true}
            
        };
        

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome select an option ");
            Console.WriteLine("1.Concert Management");
            Console.WriteLine("2.CLient Management");
            Console.WriteLine("3.Ticket Management");
            Console.WriteLine("4.Purchase History");
            Console.WriteLine("5.Advanced Queries(LINQ)");
            Console.WriteLine("6.Exit");

            int choice = int.Parse(Console.ReadLine());
            //char second = char.Parse(Console.ReadLine().ToLower());
            switch (choice)
            {
                case 1: 
                    FirstMenu(concert);
                    break;
                case 2:
                    secondMenu(client);
                    break;
                case 3:
                    ThirdMenu(tickets);
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                case 6:
                    Console.WriteLine("Finalizando programa...");
                    return;
                default:
                    Console.WriteLine("Error, intentelo de nuevo");
                    Console.ReadLine();
                    continue;
                
            }
        }
        
    }
}