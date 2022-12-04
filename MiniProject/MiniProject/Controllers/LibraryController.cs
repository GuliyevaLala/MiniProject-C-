using Domain.Entities;
using ServiceLayer.Helpers;
using ServiceLayer.Sevices;


namespace MiniProject.Controllers
{
    public class LibraryController
    {
        private readonly LibraryService libraryservice;

        public LibraryController()
        {
            libraryservice = new LibraryService();
        }

        public void GetById()
        {
            try
            {

                ConsoleColor.DarkMagenta.WriteConsole("Add library id: ");
                Id: string idStr = Console.ReadLine();
                int id;

                bool isParseId = int.TryParse(idStr, out id);
                if (isParseId)
                {
                    var result = libraryservice.GetById(id);
                    ConsoleColor.Green.WriteConsole($"Id: {result.Id}, Name: {result.Name}, SeatCount: {result.Seats}");
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct id:");
                    goto Id;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void Create()
        {
            try
            {
                ConsoleColor.DarkMagenta.WriteConsole("Add library name: ");
                string name = Console.ReadLine();
                ConsoleColor.DarkMagenta.WriteConsole("Add library seat count: ");
                SeatCount: string seatCountStr = Console.ReadLine();

                int seatCount;

                bool isParseSeatCount = int.TryParse(seatCountStr, out seatCount);

                if (isParseSeatCount)
                {
                    Library library = new()
                    {
                        Name = name,
                        Seats = seatCount
                    };

                    var result = libraryservice.Create(library);

                    ConsoleColor.Green.WriteConsole($"Id: {result.Id}, Name: {result.Name}, SeatCount: {result.Seats}");
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct seat count:");
                    goto SeatCount;
                }
            }
            catch (Exception ex)
            {
                ConsoleColor.Red.WriteConsole(ex.Message);
            }
        }
    }
}