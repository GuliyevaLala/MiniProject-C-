using MiniProject.Controllers;
using ServiceLayer.Helpers;

LibraryController libraryController = new LibraryController();

while (true)
{
    ConsoleColor.DarkRed.WriteConsole("Select one option: ");
    ConsoleColor.DarkRed.WriteConsole("Library options 1.Create, 2.Get by id, 3.Delete");

Return: string option = Console.ReadLine();

    int selectedOption;

    bool isParseOption = int.TryParse(option, out selectedOption);

    if (isParseOption)
    {
        switch (selectedOption)
        {
            case 1:
                libraryController.Create();
                break;
            case 2:
                libraryController.GetById();
                break;
            //case 3:
            //    libraryController.GetAll();
            //    break;
            //case 4:
            //    libraryController.Delete();
            //    break;
            default:
                break;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Please select again right option: ");
        goto Return;
    }
}