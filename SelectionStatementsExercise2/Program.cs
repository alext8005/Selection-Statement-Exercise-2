namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("The infinite in mathematics is always unruly, unless is properly trated");
                    break;
                
                case "science":
                    Console.WriteLine("Science is organized knowledge. Wisdom is organized life.");
                    break;
                
                case "history":
                    Console.WriteLine("Those who cannot remember the past are condemned to repeat it.");
                    break;
                
                case "english":
                    Console.WriteLine("Change your language and you change your thoughts");
                    break;
                default:
                    Console.WriteLine("Learning is a treasure that will follow its owner everywhere");
                    break;
                
                
                
                
                
                
                
            }

            
        }
    }
}