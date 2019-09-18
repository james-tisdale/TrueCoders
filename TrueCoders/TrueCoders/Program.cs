using System;

namespace TrueCoders
{
    class Program
    {
        static void Main(string[] args)
        {
            var james = new People();
            james.Age = 30;
            james.FirstName = "James"; 
            james.LastName = "Tisdale";
            james.HairColor = "Blonde";

            var wes = new People();
            wes.Age = 21;
            wes.FirstName = "Wesley";
            wes.LastName = "Hendon";
            wes.HairColor = "Blonde";

            var nate = new People();
            nate.Age = 21;
            nate.FirstName = "Nate";
            nate.LastName = "McCay";
            nate.HairColor = "Brown";

            Console.WriteLine($"Name : {james.FirstName} {james.LastName}, Age : {james.Age}, Hair Color: {james.HairColor}.");
            Console.WriteLine($"Name : {nate.FirstName} {nate.LastName}, Age : {nate.Age}, Hair Color : {nate.HairColor}.");
            Console.WriteLine($"Name : {wes.FirstName} {wes.LastName}, Age : {wes.Age}, Hair Color : {wes.HairColor}.");
        }
    }
}
