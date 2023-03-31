namespace AnagramString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the First String");
            string firstString = Console.ReadLine();
            Console.WriteLine("Please Enter Second String");
            string secondString = Console.ReadLine();
            
            AnagramLogic.checkAnagramString(firstString, secondString);
        }
    }
}