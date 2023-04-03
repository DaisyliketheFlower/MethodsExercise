namespace MethodsExercise
{
    public class Program
    {

        public static void MadLib()
        {
            Console.WriteLine("Whats your Name?"); // output
            var fullName = Console.ReadLine(); // input

            Console.WriteLine($"My name is {fullName},whats your favorite color?");
            var faveColor = Console.ReadLine();

            Console.WriteLine("Whats your favorite animal?");
            var faveAnimal = Console.ReadLine();

            Console.WriteLine("Whats your favorite music?");
            var faveMusic = Console.ReadLine();

            Console.WriteLine($"One day,{fullName} was walking through New York City wearing a {faveColor} outfit." +
                $"Suddenly, a{faveAnimal} appeared with an Bag. The Bag had {faveMusic} on it.{fullName} was shocked" + $" it liked {faveMusic}, too!");


        }

        static void Main(string[] args)
        {

            //Method Call
            //Madlib();

            Console.WriteLine($"The answer is: {Add(2,7,3,9,4,10,15)}");

            //var result = Subtract(5, 1);
            // Console.WriteLine($"The subtraction result is:{result}");

            //Multiply();


            //Console.WriteLine(Divide(8, 2));
            //Console.WriteLine(Modulus(11, 4));
        }
    }
    //Exercise 2

    // public static int Add(int num1, int num2)
    //{

    // var answer = num1 + num2;

    // return answer;

    //}

    public static int Add(params int[] nums)
    {
        var sum = 0;

        foreach(var x in nums)
        {
            sum += x; //sum = sum + x;
        }

          return sum;
    } 
        
   
    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }


    public static void Multiply()
    {
        Console.WriteLine("What is the 1st number you want to multiply?");
        var num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the 2nd number?");
        var num2 = int.Parse(Console.ReadLine());

        var answer = num1 * num2;

        Console.WriteLine($"The multiplication answer is: {answer}");
    }

    public static double Divide(double num1, double num2)
    {
        return num1 / num2;
    }

    public static int Modulus(int num1, int num2)
    {
        return num1 % num2;
    }

    
  
}




   
  
