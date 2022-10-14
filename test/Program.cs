using System;

enum Menu
{
    Register = 1,
    AttendantList = 2,
    Login = 3
}
class Program
{
    
    public static void Main(string[] args)
    {
        PrintMenuScreen();
        InputMenuFromKeyboard();

     
    }
    public static void PrintMenuScreen()
    {
        Console.Clear();
        PrintListMenu();
        
        
    }
    public static void PrintListMenu()
    {
        Console.WriteLine("Welcome to Idea Camp 2022.");
        Console.WriteLine("***************************************************");
        Console.WriteLine("1.Register");
        Console.WriteLine("2.Attendant Lists");
        Console.WriteLine("3.Login");
        Console.WriteLine("***************************************************");
    }
    public static void InputMenuFromKeyboard()
    {
        Console.Write("Please Input Menu: ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

    }
}