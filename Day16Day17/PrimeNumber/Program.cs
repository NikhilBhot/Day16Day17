namespace PrimeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come Prime Number Program");
            Console.WriteLine("Enter The Start Postion From Where You Want To Find Prime Number");
            int startPos=int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter The End Postion From Where You Want To Find Prime Number");
            int endPos=int.Parse(Console.ReadLine());

            if(startPos==1) 
            {
                startPos = startPos + 1;
            }
            PrimeNumberLogic.findPrimeNumber(startPos, endPos);
        }
    }
}