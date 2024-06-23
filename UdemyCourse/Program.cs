using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UdemyCourse.Math; // This is how we import a namespace.

namespace UdemyCourse // Namesoace is a container for classes.
{
    class Program // Class is a container for data and methods. It is a blueprint for creating objects.
    {
        public enum ShippingMethod // Enum is a set of named constants. It is a value type so it is declared on the same level as the class.
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }
        static void Main(string[] args) // Main method is the entry point of the program. What is in parenthesis is the input arguments.
        {
            byte number = 2; // Declaring a variable.
            int count = 10; // Declaring a variable.
            float totalPrice = 20.95f; // f is used to indicate that this is a float, because by default, C# uses double.
            char character = 'A'; // Single quotes are used for characters.
            string firstName = "Mosh"; // Double quotes are used for strings.
            bool isWorking = false; // Boolean values are true or false.
            const float Pi = 3.14f; // Constants are used for values that do not change.

            Console.WriteLine(number); // Console is a class, WriteLine is a method.
            Console.WriteLine(count); // This will print the value of count.
            Console.WriteLine(totalPrice); // This will print the value of totalPrice.
            Console.WriteLine(character); // This will print the character A.
            Console.WriteLine(firstName); // This will print the string Mosh.
            Console.WriteLine(isWorking); // This will print false.
            Console.WriteLine(Pi); // This will print the value of Pi.

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // {0} and {1} are placeholders for the values of byte.MinValue and byte.MaxValue.
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue); // This will print the minimum and maximum values of a float.       

            byte b = 1;
            int i = b; // Implicit conversion. No data loss.

            int j = 1;
            byte c = (byte)j; // Explicit conversion. Data loss.

            Console.WriteLine(i);
            Console.WriteLine(c);

            int k = 1000;
            byte d = (byte)k; // Data loss. 1000 is out of range for a byte.
                              // For primitive types we can conversion between them using casting.
                              // For non-primitive types we can use methods like Parse and TryParse.
            Console.WriteLine(d);

            var number1 = "1234"; // var is used to implicitly declare a variable.
            int l = Convert.ToInt32(number1); // Convert is a class, ToInt32 is a method.
                                              // This will convert the string "1234" to an integer.
                                              // If we try to convert it to a byte, it will throw an exception. Because 1234 is out of range for a byte.
            Console.WriteLine(l);

            var m = 10;
            var n = 3;
            var o = 5;
            Console.WriteLine(m + n);
            Console.WriteLine(m / n); // This will print 3, because both m and n are integers.
                                      // If we want a decimal result, we need to cast one of the variables to a float.
            Console.WriteLine((float)m / (float)n); // This will print 3.333333, because we casted m and n to floats.
            Console.WriteLine(m > n && o > n);
            Console.WriteLine(m > n && o == n);
            Console.WriteLine(m > n || o == n);

            var john = new Person(); // This is how we create an object.
            john.FirstName = "John"; // This is how we set the value of a field.
            john.LastName = "Smith"; // This is how we set the value of a field.
            john.Introduce(); // This is how we call a method.

            Calculator calculator = new Calculator(); // This is how we create an object.
            var result = calculator.Add(1, 2); // This is how we call a method.
            Console.WriteLine(result); // This will print 3.

            var numbers = new int[3]; // This is how we create an array.
            numbers[0] = 1; // This is how we set the value of an element.

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]); // This will print 0, because the default value of an integer is 0.

            var flags = new bool[3]; // This is how we create an array.
            flags[0] = true; // This is how we set the value of an element.

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]); // This will print false, because the default value of a boolean is false.

            var names = new string[3] { "Jack", "John", "Mary" }; // This is how we create an array and initialize it.
            Console.WriteLine(names[0]);

            var firstName1 = "Mosh";
            String lastName1 = "Hamedani"; // String is a class, so we can use it with a capital S. It is the same as string and it is a part of the System namespace.

            var fullName = firstName1 + " " + lastName1; // This is how we concatenate strings.
            var myFullName = string.Format("My name is {0} {1}", firstName1, lastName1); // This is how we format strings.
                                                                                         // {0} and {1} are placeholders for the values of firstName1 and lastName1.
            var names1 = new string[3] { "Jack", "John", "Mary" };
            var formattedNames = string.Join(", ", names1); // This is how we join strings.
                                                            //Join is a static method of the string class.
            Console.WriteLine(formattedNames);

            var method = ShippingMethod.Express; // This is how we create an enum.
            Console.WriteLine((int)method); // This will print 3, because Express is 3rd in the enum.
                                            // Enaums are integer types, so we can cast them to integers.
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); // This will print Express, because 3 is the 3rd in the enum.
                                                         // We can cast integers to enums.
            Console.WriteLine(method.ToString()); // This will print Express.
            var methodName = "Express";
            var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName); // This will parse the string "Express" to the enum Express.

            var a1 = 10;
            var b1 = a1;
            b1++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a1, b1)); // This will print a: 10, b: 11.
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0; // This will change the value of the first element in both arrays.

            Person.Increment(a1); // Value a1 in not affected by this method, because it is passed by value.
            Console.WriteLine(a1); // This will print 10.

            var old_person = new Person() { Age = 20 };
            Person.MakeOld(old_person); // This will change the value of the Age field in the old_person object.
            Console.WriteLine(old_person.Age); // This will print 30.

            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f; // this is the same as above
            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got a promotion");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }

            byte number2 = 5;
            if (number2 >= 1 && number2 <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            for (var ii = 1; ii < 10; ii++)
            {
                if (ii % 2 == 0)
                {
                    Console.WriteLine(ii);
                }
            }

            for (var iii = 10; iii >= 1; iii--)
            {
                if (iii % 2 == 0)
                {
                    Console.WriteLine(iii);
                }
            }
            var name = "John Smith";

            for (var iii = 0; iii < name.Length; iii++)
            {
                Console.WriteLine(name[iii]);
            }
            foreach (var characterr in name) //with for each we do not have to worry about a counter varialble like i and don't have to set an initial value like 0
            {
                Console.WriteLine(characterr);
            }
            var numberss = new int[] { 1, 2, 3, 4 };

            foreach (var numberr in numberss)
            {
                Console.WriteLine(numberr);
            }
            var iiii = 0;
            while (iiii <= 10) // same as one of the above loops, better to use for loop in sucha a case
                               // while loop usually is used when we don't know ahead of time how many times you're going to do an iteration
            {
                if (iiii % 2 == 0)
                    Console.WriteLine(iiii);

                iiii++;
            }
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
            }
            {
                var random = new Random();
                for (var iii = 0; iii <= 10; iii++)
                    Console.WriteLine(random.Next(1, 10));
            }
            {
                var random = new Random();

                const int passrodLength = 10;

                var buffer = new char[passrodLength];
                for (var ii = 0; ii < passrodLength; ii++)
                    buffer[ii] = (char)('a' + random.Next(0, 26));

                var password = new string(buffer);
                Console.WriteLine(password);
            }
            {
                for (var ii = 0; ii <= 100; ii++)
                    if (ii % 10 == 0)
                        Console.WriteLine(ii);
            }
            {
                double sum = 0;
                while (true)
                {
                    Console.WriteLine("Enter a number or 'ok' to exit");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "ok")
                        break;

                    double nnumber;
                    if (double.TryParse(input, out nnumber))
                    {
                        sum += nnumber;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a number or 'ok'");
                    }
                    Console.WriteLine("The sum of all numbers are " + sum);
                }
                Console.WriteLine("Enter a number to calculate its factorial: ");
                int nnnumber = Convert.ToInt32(Console.ReadLine());

                long factorial = 1;
                for (int ii = 1; ii <= nnnumber; ii++)
                {
                    factorial *= ii;
                }
                Console.WriteLine($"{nnnumber}! = {factorial}");
                {
                    Random random = new Random();
                    int secret_number = random.Next(1, 11);

                    for (int ii = 1; ii < 4; ii++)
                    {
                        Console.WriteLine("Enter you guess ");
                        int user_guess = Convert.ToInt32(Console.ReadLine());

                        if (user_guess == secret_number)
                        {
                            Console.WriteLine("You won!");
                            Console.WriteLine("The secret numbers were: " + secret_number);
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                            Console.WriteLine("The secret numbers were " + secret_number);
                        }
                    }
                }
                Console.WriteLine("Enter a series of numbers separated by comma: ");
                string userInput = Console.ReadLine();

                int[] nuumbers = userInput.Split(',').Select(int.Parse).ToArray();
                int maxNumber = nuumbers.Max();

                Console.WriteLine("The max number is " + maxNumber);

                var numberrs = new[] { 3, 7, 9, 2, 14, 6 };

                //Lentgth - returns the size of an array
                Console.WriteLine("Length: " + numberrs.Length);
                //IndexOf() - we use this method to find the position of an element in the array
                var index = Array.IndexOf(numberrs, 9);
                Console.WriteLine("Index of 9: " + index);
                //Clear
                Array.Clear(numberrs, 0, 2); //clear two first elements (index 0)

                Console.WriteLine("Effect of Clear()");
                foreach (var nn in numberrs)
                    Console.WriteLine(nn); //first two items are 0 and that's the meaning of clear.
                                           //If we have an array of booleans clearing that means setting some of its items to false
                                           //Copy()
                int[] another = new int[3];
                Array.Copy(numberrs, another, 3);

                Console.WriteLine("Effect of Copy()");
                foreach (var nn in another)
                    Console.WriteLine(nn);
                //Sort()
                Array.Sort(numberrs);

                Console.WriteLine("Effect of Sort()");
                foreach (var nn in numberrs)
                    Console.WriteLine(nn);
                var numberrrs = new List<int>() { 1, 2, 3, 4 };
                numberrrs.Add(1); //the difference between lists and arrays, in arrays we don't have add method because we cannot change it
                numberrrs.AddRange(new int[] { 5, 6, 7 }); //we can add evan a range

                foreach (var numberrr in numberrrs)
                    Console.WriteLine(numberrr);

                Console.WriteLine(); // to separate the below line from the above loop
                Console.WriteLine("Index of 1: " + numberrrs.IndexOf(1));
                Console.WriteLine("Last Index of 1: " + numberrrs.LastIndexOf(1)); //In case we have more than one ones
                Console.WriteLine("Count: " + numberrrs.Count);
                numberrrs.Remove(1); //removes only one one, the firts one
                                     //to remove all ones we can iterate over the list using foreach loop
                for (var iiiii = 0; iiiii < numberrrs.Count; iiiii++) //foreach would throw an exception
                {
                    if (numberrrs[iiiii] == 1)
                        numberrrs.Remove(numberrrs[iiiii]);
                }
                foreach (var numberrr in numberrrs)
                    Console.WriteLine(numberrr);

                {
                    List<string> fbnames = new List<string>();
                    string fbinput;

                    Console.WriteLine("Enter names (press enter to finish):");

                    while ((fbinput = Console.ReadLine()) != "")
                    {
                        fbnames.Add(fbinput);
                    }
                    switch (fbnames.Count)
                    {
                        case 0:
                            Console.WriteLine("No one likes your post");
                            break;
                        case 1:
                            Console.WriteLine($"{fbnames[0]} likes your post");
                            break;
                        case 2:
                            Console.WriteLine($"{fbnames[0]} and {fbnames[1]} like your post");
                            break;
                        default:
                            Console.WriteLine($"{fbnames[0]}, {fbnames[1]} and {fbnames.Count - 2} like your post");
                            break;
                    }
                }
            }
            {
                Console.WriteLine("Enter your name:");
                string revname = Console.ReadLine();
                char[] charArray = revname.ToCharArray();
                Array.Reverse(charArray);
                string reversedName = new string(charArray);
                Console.WriteLine($"Your name in reverse is {reversedName}");
            }
            {
                HashSet<int> nnumbers = new HashSet<int>();
                while (nnumbers.Count < 5)
                {
                    Console.WriteLine("Enter a number: ");
                    if (!int.TryParse(Console.ReadLine(), out int nnumber)) //! use to convert True to False to not enter the if statement
                    {
                        Console.WriteLine("Invalid input, please enter a number");
                    }
                    if (!nnumbers.Add(nnumber)) //cannot add the number which has already been provided to HashSet
                    {
                        Console.WriteLine("This number has already been entered, try again");
                    }
                }
                int[] sortedNnumbers = new int[5];
                nnumbers.CopyTo(sortedNnumbers);
                Array.Sort(sortedNnumbers);
                Console.WriteLine("The sorted numbers are: ");
                    foreach (int nnumber in sortedNnumbers)
                    {
                    Console.WriteLine(nnumber);
                    }
            }
            {
                HashSet<int> nnumbers = new HashSet<int>();
                string input;
                Console.WriteLine("Enter a number or type Q to exit");

                while ((input  = Console.ReadLine()) != "qq")
                {
                    if(int.TryParse(input, out int nnumber))
                    {
                        nnumbers.Add(nnumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, type qq to exit");
                    }
                }
                Console.WriteLine("The unique numbers are: ");
                foreach(int nnumber in nnumbers)
                {
                    Console.WriteLine(nnumber);
                }
            }
            while(true)
            {
                Console.WriteLine("Enter a list o comma separated numbers: ");
                string input = Console.ReadLine();
                string[] numbersStr = input.Split(',');
                if (numbersStr.Length < 5 )
                {
                    Console.WriteLine("Invalid list, please provide at least 5 numbers");
                    continue;
                }
                try
                {
                    int[] nnumbers = numbersStr.Select(int.Parse).ToArray();
                    var smallestNumbers = nnumbers.OrderBy(nn => nn).Take(3);

                    Console.WriteLine("The 3 smalles numbers are: ");
                    foreach (int nnumber in smallestNumbers)
                    {
                        Console.WriteLine(nnumber);
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input please enter only numbers separated by commas");
                }
            }
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            // DateTime objects are immutable. Once you create them you cannot change them, but you can modify them

            var tommorow = now.AddDays(1);
            var yesterday = today.AddDays(-1);

            // Converting to strings

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            // TimeSpan - represents a length of time

            var timeSpan = new TimeSpan(1, 2, 3); //1 hour, 2 minutes, 3 seconds 

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1); //the same as above line

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start; // This will result a timespan
            Console.WriteLine("Duration: " +  duration);

        }
        }
    }

