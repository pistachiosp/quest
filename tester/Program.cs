// in c# Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
// using System;

// namespace tester
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             bool repeatGram = true;

//             while (repeatGram)
//             {
//                 Console.Write("Enter a number between 1 to 10: ");
//                 string input = Console.ReadLine();
//                 int num;

//                 if (int.TryParse(input, out num) && num >= 1 && num <= 10)
//                 {
//                     Console.WriteLine("Valid");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Invalid");
//                 }

//                 Console.WriteLine("Would you like to repeat the quest? (yes/no)");
//                 string userResponse = Console.ReadLine();

//                 if (userResponse.ToLower() != "yes")
//                 {
//                     repeatGram = false;
//                 }
//             }
//         }
//     }
// }






// in c# Write a program which takes two numbers from the console and displays the maximum of the two.
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the first number: ");
//         int num1 = int.Parse(Console.ReadLine());

//         Console.Write("Enter the second number: ");
//         int num2 = int.Parse(Console.ReadLine());

//         int max = Math.Max(num1, num2);

//         Console.WriteLine("The maximum of {0} and {1} is {2}", num1, num2, max);
//     }
// }







// in c# Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the width of the image: ");
//         int width = int.Parse(Console.ReadLine());

//         Console.Write("Enter the height of the image: ");
//         int height = int.Parse(Console.ReadLine());

//         if (width > height)
//         {
//             Console.WriteLine("The image is landscape.");
//         }
//         else if (width < height)
//         {
//             Console.WriteLine("The image is portrait.");
//         }
//         else
//         {
//             Console.WriteLine("The image is square.");
//         }
//     }
// }






// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the speed limit: ");
//         int speedLimit = int.Parse(Console.ReadLine());

//         Console.Write("Enter the speed of the car: ");
//         int carSpeed = int.Parse(Console.ReadLine());

//         if (carSpeed <= speedLimit)
//         {
//             Console.WriteLine("Ok");
//         }
//         else
//         {
//             int demeritPoints = (carSpeed - speedLimit) / 5;

//             if (demeritPoints > 12)
//             {
//                 Console.WriteLine("License Suspended");
//             }
//             else
//             {
//                 Console.WriteLine("Demerit points: " + demeritPoints);
//             }
//         }
//     }
// }








//enums
// using System;
// namespace tester
// {
//     public enum ShippingMethod
//     {
//         RegularAirMail = 1,
//         RegisteredAirMail = 2,
//         Express = 3
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var method = ShippingMethod.Express;
//             Console.WriteLine((int)method);

//             var methodId = 3;
//             Console.WriteLine((ShippingMethod)methodId);

//             Console.WriteLine(method.ToString());
//             Console.Write(method);

//             var methodName = "Express";
//             var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName);
//         }
//     }

// }





// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
// using System;
// namespace tester
// {
//     class program
//     {
//         static void Main(string[] args)
//         {
//             int count = 0;

//             for (int i = 0; i <= 100; i++)
//             {
//                 // In the for loop, we use the modulo operator % to determine if a number is divisible by 3 with no remainder. If the remainder is 0, then the number is divisible by 3 with no remainder, so we increment the count variable.
//                 if (i % 3 == 0)
//                 {
//                     count++;
//                 }
//             }
//             System.Console.WriteLine("The number of numbers between 1 and 100 that are divisible by 3 with no remainder is: " + count);
//         }
//     }
// }





// Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
//while loop
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int sum = 0;

//         while (true)
//         {
//             Console.Write("Enter a number or 'ok' to exit: ");
//             string input = Console.ReadLine();

//             if (input.ToLower() == "ok")
//             {
//                 break;
//             }

//             int num = int.Parse(input);
//             sum += num;
//         }

//         Console.WriteLine("The sum of all the previously entered numbers is: " + sum);
//     }
// }





// Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter a number: ");
//         int num = int.Parse(Console.ReadLine());

//         int factorial = 1;

//         for (int i = num; i >= 1; i--)
//         {
//             factorial *= i;
//         }

//         Console.WriteLine(num + "! = " + factorial);
//     }
// }






// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
// using System;

// class Program {
//     static void Main(string[] args) {
//         Random random = new Random();
//         int secretNumber = random.Next(1, 11);
//         int numGuesses = 4;

//         Console.WriteLine("Guess the secret number between 1 and 10. You have {0} chances.", numGuesses);

//         for (int i = 1; i <= numGuesses; i++) {
//             Console.Write("Guess #{0}: ", i);
//             int guess = int.Parse(Console.ReadLine());

//             if (guess == secretNumber) {
//                 Console.WriteLine("You won!");
//                 return;
//             }
//         }

//         Console.WriteLine("You lost. The secret number was {0}.", secretNumber);
//     }
// }







// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
// using System;
// using System.Linq;

// class Program {
//     static void Main(string[] args) {
//         Console.Write("Enter a series of numbers separated by commas: ");
//         string input = Console.ReadLine();

//         int[] numbers = input.Split(',').Select(int.Parse).ToArray();

//         int max = numbers.Max();

//         Console.WriteLine("The maximum of the numbers is: " + max);
//     }
// }









// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] numbers = new[] { 3, 5, 7, 5, 6, 14 };
//         //or var numbers
//         //Length
//         Console.WriteLine("Length:" + numbers.Length);

//         //IndexOf()
//         //Array.IndexOf(numbers, 9);
//         var index = Array.IndexOf(numbers, 6);
//         Console.WriteLine("Index of 9:" + index);

//         //Clear()
//         Array.Clear(numbers, 0, 3);
//         Console.WriteLine("effect of clear()");

//         foreach (var n in numbers)
//         {
//             Console.WriteLine(n);
//         }

//         //Copy()
//         int[] another = new int[3];
//         Array.Copy(numbers, another, 3);
//         Console.WriteLine("effect of Copy()");
//         foreach (var n in another)
//         {
//             Console.WriteLine(n);
//         }

//         //Sort()
//         Array.Sort(numbers);
//         Console.WriteLine("effect of Sort()");
//         foreach (var n in numbers)
//         {
//             Console.WriteLine(n);
//         }

//         //Reverse()
//         Array.Reverse(numbers);
//         Console.WriteLine("effect of Reverse()");
//         foreach (var n in numbers)
//         {
//             Console.WriteLine(n);
//         }
//     }
// }





// using System;
// using System.Collections.Generic;

// namespace tester
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var numbers = new List<int>() { 1, 2, 3, 4 };
//             numbers.Add(1);
//             numbers.AddRange(new int[3] { 5, 6, 7 });

//             foreach (var number in numbers)
//             {
//                 Console.WriteLine(number);
//             }

//             System.Console.WriteLine();
//             Console.WriteLine("index of 1:" + numbers.IndexOf(1));
//             System.Console.WriteLine("last index of 1:" + numbers.LastIndexOf(1));

//             System.Console.WriteLine("count:" + numbers.Count);

//             for (var i = 0; i < numbers.Count; i++)
//             {
//                 if (numbers[i] == 1)
//                     numbers.Remove(numbers[i]);
//             }
//             foreach (var number in numbers)
//                 System.Console.WriteLine(number);

//         }
//     }
// }







//  When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

// If no one likes your post, it doesn't display anything.
// If only one person likes your post, it displays: [Friend's Name] likes your post.
// If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
// If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
// Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<string> names = new List<string>();
//         string inputName = "";

//         while (true)
//         {
//             Console.Write("Enter a name (press Enter to stop): ");
//             inputName = Console.ReadLine().Trim();
//             if (inputName == "")
//             {
//                 break;
//             }
//             names.Add(inputName);
//         }

//         int numLikes = names.Count;
//         if (numLikes == 0)
//         {
//             Console.WriteLine("No one likes your post.");
//         }
//         else if (numLikes == 1)
//         {
//             Console.WriteLine(names[0] + " likes your post.");
//         }
//         else if (numLikes == 2)
//         {
//             Console.WriteLine(names[0] + " and " + names[1] + " like your post.");
//         }
//         else
//         {
//             Console.Write(names[0] + ", " + names[1] + ", and " + (numLikes - 2));
//             if (numLikes == 3)
//             {
//                 Console.Write(" other person");
//             }
//             else
//             {
//                 Console.Write(" others");
//             }
//             Console.WriteLine(" like your post.");
//         }

//         Console.WriteLine("Press any key to exit.");
//         Console.ReadKey();
//     }
// }








// Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter your name: ");
//         string name = Console.ReadLine().Trim();

//         char[] nameChars = name.ToCharArray();
//         Array.Reverse(nameChars);
//         string reversedName = new string(nameChars);

//         Console.WriteLine("Your name reversed is: " + reversedName);

//         Console.WriteLine("Press any key to exit.");
//         Console.ReadKey();
//     }
// }







// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] numbers = new int[5];
//         int count = 0;

//         while (count < 5)
//         {
//             Console.Write("Enter 5 numbers: ");
//             int num = int.Parse(Console.ReadLine());

//             if (Array.IndexOf(numbers, num) != -1)
//             {
//                 Console.WriteLine("Error: Number already entered. Please enter a different number.");
//             }
//             else
//             {
//                 numbers[count] = num;
//                 count++;
//             }
//         }

//         Array.Sort(numbers);
//         Console.WriteLine("The sorted list of ur numbers is: " + string.Join(", ", numbers));

//         Console.WriteLine("Press any key to exit.");
//         Console.ReadKey();
//     }
// }




//  Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         HashSet<int> uniqueNumbers = new HashSet<int>();

//         while (true)
//         {
//             Console.Write("Enter a number or type 'Quit' to exit: ");
//             string input = Console.ReadLine();

//             if (input.ToLower() == "quit")
//             {
//                 break;
//             }

//             if (int.TryParse(input, out int num))
//             {
//                 uniqueNumbers.Add(num);
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input. Please enter a number or 'Quit'.");
//             }
//         }

//         Console.WriteLine("The unique numbers entered are: " + string.Join(", ", uniqueNumbers));

//         Console.WriteLine("Press any key to exit.");
//         Console.ReadKey();
//     }
// }






// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.







//DateTime
//C# datetime custom 
//both datetime and timespan are immutable which means once you set them you cannot change them

// using System;
// class Program
// {
//     static void Main(string[] args)
//     {                           //year month day
//         var datetime = new DateTime(2022, 1, 1);
//         var now = DateTime.Now;
//         var today = DateTime.Today;

//         Console.WriteLine("hour:" + now.Hour);
//         Console.WriteLine("minute:" + now.Minute);

//         var tomorrow = now.AddDays(1);
//         var yesterday = now.AddDays(-1);

//         Console.WriteLine(now.ToLongDateString());
//         Console.WriteLine(now.ToShortDateString());
//         Console.WriteLine(now.ToLongTimeString());
//         Console.WriteLine(now.ToShortTimeString());
//         Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

//         //hours, minutes, seconds
//         var timeSpan = new TimeSpan(1, 2, 3);

//         var start = DateTime.Now;
//         var end = DateTime.Now.AddMinutes(3.5);
//         var duration = end - start;
//         System.Console.WriteLine("Duration:" + duration);
//         //prints 03:30:0000063


//         //properties
//         System.Console.WriteLine("minutes:" + timeSpan.Minutes);
//         //prints 2
//         System.Console.WriteLine("total minutes:" + timeSpan.TotalMinutes);
//         //prints 62.05

//         //add
//         System.Console.WriteLine("add ex:" + timeSpan.Add(TimeSpan.FromMinutes(8)));
//         //prints 01:10:03

//         //par
//         System.Console.WriteLine("parse " + TimeSpan.Parse("1:04:03"));

//         //tostring
//         System.Console.WriteLine("tostring " + timeSpan.ToString());

//         //AateTime objects are immutable which means once there set they cannot be changed

//     }

// }




// 1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter numbers separated by hyphen: ");
//             var input = Console.ReadLine();

//             var numbers = input.Split('-');
//             var cons = true;

//             for (var i = 1; i < numbers.Length; i++)
//             {
//                 if (Convert.ToInt32(numbers[i]) - Convert.ToInt32(numbers[i - 1]) != 1)
//                 {
//                     cons = false;
//                     break;
//                 }
//             }

//             if (cons)
//             {
//                 Console.WriteLine("Consecutive");
//             }
//             else
//             {
//                 Console.WriteLine("Not Consecutive");
//             }
//         }
//     }
// }







// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

//namespaces
// using System;
// using System.Collections.Generic;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         //main method is the entry point of the program
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter numbers separated by hyphen: ");
//             var input = Console.ReadLine();

//             if (String.IsNullOrWhiteSpace(input))
//             {
//                 //return and exit
//                 return;
//             }
//             //The Split method returns an array of string elements, which are then converted to an array of int elements using the HashSet constructor
//             var numbers = input.Split('-');
//             // A HashSet is a collection that contains no duplicate elements.
//             var dup = numbers.Length != new HashSet<string>(numbers).Count;

//             if (dup)
//             {
//                 Console.WriteLine("Duplicate");
//             }
//             else
//             {
//                 var cons = true;

//                 for (var i = 1; i < numbers.Length; i++)
//                 {
//                     if (Convert.ToInt32(numbers[i]) - Convert.ToInt32(numbers[i - 1]) != 1)
//                     {
//                         cons = false;
//                         break;
//                     }
//                 }

//                 if (cons)
//                 {
//                     Console.WriteLine("Consecutive");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Not Consecutive");
//                 }
//             }
//         }
//     }
// }





// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
// using System;
// using System.Text.RegularExpressions;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a time value in 24-hour format (e.g. 19:00):");
//             string input = Console.ReadLine();

//             if (String.IsNullOrWhiteSpace(input))
//             {
//                 Console.WriteLine("Invalid Time");
//                 return;
//             }

//             string pattern = "([01]?[0-9]|2[0-3]):[0-5][0-9]";
//             bool isValid = Regex.IsMatch(input, pattern);

//             if (isValid)
//             {
//                 Console.WriteLine("Ok");
//             }
//             else
//             {
//                 Console.WriteLine("Invalid Time");
//             }
//         }
//     }
// }







// Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a few words separated by a space:");
//             string input = Console.ReadLine();

//             if (String.IsNullOrWhiteSpace(input))
//             {
//                 Console.WriteLine("Invalid input");
//                 return;
//             }

//             string[] words = input.Split(' ');
//             string pascalCase = "";

//             foreach (string word in words)
//             {
//                 pascalCase += char.ToUpper(word[0]) + word.Substring(1).ToLower();
//             }

//             Console.WriteLine(pascalCase);
//         }
//     }
// }






//  Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter an English word:");
//             string input = Console.ReadLine();

//             if (String.IsNullOrWhiteSpace(input))
//             {
//                 Console.WriteLine("Invalid input");
//                 return;
//             }

//             string word = input.ToLower();
//             int vowelCount = 0;

//             for (int i = 0; i < word.Length; i++)
//             {
//                 if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
//                 {
//                     vowelCount++;
//                 }
//             }

//             Console.WriteLine("The number of vowels in the word is: {0}", vowelCount);
//         }
//     }
// }






// using System;

// namespace NSS
// {
//     public class Cohort
//     {
//         public string

//     }
// }








//  Lightning Exercise :lightningbolt: :
// Create an abstraction of a cohort at NSS.  The class should have properties, one field (to accomplish encapsulation), a constructor, and at least one method. (edited) 
// using System;
// using System.Collections.Generic;

// namespace NSS
// {
//     public class Cohort
//     {

//         // properties name start and end date; students a list of student objects that represent the students in the cohort
//         public string Name { get; set; }
//         public DateTime StartDate { get; set; }
//         public DateTime EndDate { get; set; }

//         // field a string that represents the name of the instructor for the cohort this field is private to capture encapsulation
//         private string _instructor;
//         public List<Student> Students { get; set; }

//         //      a constructor that initalizes the name start date end date and instructor properties of the cohort object
//         public Cohort(string name, DateTime startDate, DateTime endDate, string instructor)
//         {
//             Name = name;
//             StartDate = startDate;
//             EndDate = endDate;
//             _instructor = instructor;
//             Students = new List<Student>();
//         }

//         //  a method that adds a student object to the students list
//         public void AddStudent(Student student)
//         {
//             Students.Add(student);
//         }
//     }
// }





//Aggregation
// using System;
// using System.Collections.Generic;

// class Customer
// {
//     public string AccountNumber { get; set; }
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
// }

// class Bank
// {
//     public string Name { get; set; }
//     public string Address { get; set; }

//     // Customers are aggregated into the bank
//     public List<Customer> Customers { get; set; } = new List<Customer>();

// }

// class Program {
//     public static void Main () {
//         // Create a bank
//         Bank FirstTennessee = new Bank() {
//             Name = "First Tennessee",
//             Address = "100 Infinity Way"
//         };

//         // Create a customer
//         Customer steve = new Customer();
//         steve.FirstName = "Steve";
//         steve.LastName = "Brownlee";
//         steve.AccountNumber = "110405821101";

//         // Add Steve to First Tennessee's list of customers
//         FirstTennessee.Customers.Add(steve);

//         // Add another customer using in-line, concise syntax
//         FirstTennessee.Customers.Add(
//             new Customer() {
//             FirstName = "Caitlin",
//             LastName = "Stein",
//             AccountNumber = "0592382394589" }
//         );

//         // Iterate over the list of customers and display the first name
//         foreach (Customer cust in FirstTennessee.Customers)
//         {
//             Console.WriteLine(cust.firstName);
//         }
//     }
// }


//Composition
// class Pancreas
// {
//     public bool Filtering { get; set; }
// }

// class Liver
// {
//     public bool Poisoned { get; set; }
// }

// class Body
// {
//     /*
//         Making these private. Don't want anyone
//         messing around with my liver and pancreas
//     */
//     private Pancreas _pancreas;
//     private Liver _liver;

//     public Body ()
//     {
//         // Create a brand new pancreas and assign it to this body
//         _pancreas = new Pancreas(){
//             Filtering = true
//         };

//         // Create a brand new liver and assign it to this body
//         _liver = new Liver(){
//             Poisoned = false
//         };
//     }
// }




//Inheritance
// /*
//     This parent class will contain properties that
//     are common across all of the specific kinds of
//     balls in our program.
// */
// class Ball
// {
//     public double Radius { get; set; }
//     public double Weight { get; set; }
// }

// /*
//     By putting `: Ball` after the definition of
//     Baseball, any object created from this class
//     would automatically have the two properties of
//     radius and weight.
// */
// class Baseball : Ball
// {
//     // Stitches is not common to every kind of ball
//     public int Stitches { get; set; }
// }

// // All soccer balls will also have radius and weight
// class SoccerBall : Ball
// {
//     // Panels is not common to every kind of ball
//     public int Panels { get; set; }
// }