using System;
using System.Net.NetworkInformation;

namespace TestApp
{
    internal class Sample
    {
        static void Main(string[] args)
        {
            /* 
             1
            Write a C# program to calculate "area of circle" based on the given "radius" value.

            The radius value can be assigned to a variable; need not to take the value from the keyboard input.
            Formula: PI * radius * radius
            PI is a constant value, approximately equal to 3.14159, which is equal to the ratio of the circumference of any circle to its diameter.
            -----------------------

            int radius = 2;
            double PI = 3.14159;
            double areaOfCircle = PI * radius * radius;
            System.Console.WriteLine(areaOfCircle);
            System.Console.Read();
            -----------------------------------
             */

            /* 
             2
            Write a C# program convert a person's height (in feet and inches) to centimeters.
            Eg:
            feet = 5
            inches = 7
            output: 170.18 cm

            Formula:
            1 inch = 2.54 cm
            1 feet = 12 inches
             -----------------------------------
            int feet = 5;
            int inches = 7;
            int total_inches = feet * 12 + inches;
            double centimeters= total_inches * 2.54;
            System.Console.WriteLine(centimeters);
            System.Console.Read();
            */

            /* 
            3
            Write a C# program to get nearest thousand of given integer number. Here, let name the input value as "number".
            If the number's last three digits are greater than or equal to 500; it should "round up" the number.
            If the number's last three digits are less than 500; it should "round down" the number.
            If the number is less than 500; it should round up to 1000.
            Eg:
            Input: 499  Output: 1000
            Input: 500  Output: 1000
            Input: 999  Output: 1000
            Input: 1000 Output: 1000
            Input: 1499 Output: 1000
            Input: 1500 Output: 2000
            */

            /* 
            int totalSeconds = 288970;
            int days = totalSeconds / 86400;
            int hours = (totalSeconds - days * 86400) / 3600;
            int minutes = (totalSeconds - days * 86400 - hours * 3600) / 60;
            int seconds = totalSeconds - days * 86400 - hours * 3600 - minutes * 60; ;
            System.Console.WriteLine(days + " days," + hours + " hours," + minutes + " minutes" + seconds + " seconds");
            System.Console.Read();
            */

            /* 
            4
            Height is less than 150 cm = "Dwarf"
            Height is between 150 cm and 165 cm = "Average height"
            Height is between 165 cm and 195 cm = "Tall"
            Height is above 195 cm = "Abnormal height"
            Note: 1 inch = 2.54 centimeter
            You need to convert the input value(inches) into centimeters.
            */
            /* 
            int inches = 75;
            double centimeters = inches * 2.54;
            string result;
            if (centimeters < 150)
               result = "Dwarf";
            else if (centimeters >= 150 && centimeters <= 165)
               result = "Average height";
            else if (centimeters > 165 && centimeters <= 195)
               result = "Tall";
            else
               result = "Abnormal height";

            System.Console.WriteLine(result);
            System.Console.ReadKey();
            /*
            Eg:
            num1 = 60
            num2 = 45
            num3 = 123
            Output: 123
            */

            /*
            int num1 = 160;
            int num2 = 200;
            int num3 = 180;

            if (num1 > num2 && num1 > num3)
             System.Console.WriteLine(num1);
            else if (num2 > num1 && num2 > num3)
             System.Console.WriteLine(num2);
            else if (num3 > num1 && num3 > num2)
             System.Console.WriteLine(num3);
            System.Console.Read();
             */

            /*
            int x = 0;
            while (x < 6)
            {
              Console.Write(x + "");
              x++;
            }
            System.Console.Read();


            int y = 0;

            do
            {
              y++;
            } while (y < 3);
             */


            /*
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine("i = " + i);
            }
            System.Console.Read();
            */

            /*
            for (int i = 0; i < 10; i++)
            {
               if (i == 5)
               {
                   continue;
               }
               Console.WriteLine("i = " + i);
            }
            System.Console.Read();
             */


            /*
             Write a C# program to print the following output:

                1 2 3 4 7 8 9 10
                1 2 3 4 7 8 9 10
                1 2 3 4 7 8 9 10
                10 9 8 7 6 5 4 3 2 1
                10 9 8 7 6 5 4 3 2 1
                10 9 8 7 6 5 4 3
                10 9 8 7 6 5 4 3 2 1
                1 2 3 4 5 6 7 9 10

            ----------------------------------------------
                Each number should be printed by using the loop variable.
                Don't print full line at-a-time as string.
                For example, don't write statements as:
                System.Console.WriteLine("1 2 3 4 7 8 9 10");
                Use for loop, break and continue statements to bring the output.
             */

            /*
            for (int i = 1; i <= 8; i++)
            {
               if (i == 4)
               {
                   break;
               }

               for (int j = 1; j <= 10; j++)
               {
                   if (i == 1 && j == 5 || j == 6 || i == 2 && j == 5 || j == 6 || i == 3 && j == 5 || j == 6)
                       continue;

                   if (i == 4 || i == 5 || i == 6 || i == 7)
                   {
                       break;
                   }


                   System.Console.Write(" " + j);

               }
               System.Console.WriteLine();
            }


            for (int i = 1; i <= 5; i++)
            {
               if (i == 5)
               {
                   break;
               }
               for (int j = 10; j >= 1; j--)
               {
                   if (i == 3 && j == 2 || i == 3 && j == 1)
                       continue;
                   System.Console.Write(" " + j);
               }
               if (i == 5)
               {
                   break;
               }
               System.Console.WriteLine();
            }


            for (int i = 1; i <= 1; i++)
            {
               for (int j = 1; j <= 10; j++)
               {
                   if (j == 8)
                       continue;
                   System.Console.Write(" " + j);
               }
               System.Console.WriteLine();
            }
            System.Console.ReadKey();
             */


            /*  Create User Menu

            Console.WriteLine("Test Bank");
            Console.WriteLine("Login");
            Console.WriteLine("Please enter Username and Password to proceed");

            string username = null, password = null;

            Console.Write("username: ");
            username = Console.ReadLine();

            if (username != "")
            {
               Console.Write("password: ");
               password = Console.ReadLine();
            }

            if (username == "vagg" && password == "test")
            {
               Console.WriteLine("Welcome to the Customer Management System ");

               int menuChoice = -1;
               do
               {
                   Console.WriteLine(":::Main Menu:::");
                   Console.WriteLine("1. Customers");
                   Console.WriteLine("2. Accounts");
                   Console.WriteLine("3. Funds Transfers");
                   Console.WriteLine("4. Funds Transfer Statement");
                   Console.WriteLine("5. Account Statement");
                   Console.WriteLine("0. Exit");

                   Console.WriteLine("Enter Choice: ");
                   menuChoice = int.Parse(Console.ReadLine());

                   switch (menuChoice)
                   {
                       case 1:
                           CustomerMenu();
                           break;
                       case 2:
                           AccountsMenu();
                           break;
                       case 3:
                           Console.WriteLine();
                           break;

                       case 4:
                           Console.WriteLine();
                           break;
                       case 5:
                           Console.WriteLine();
                           break;
                   }
               } while (menuChoice != 0);
            }

            Console.WriteLine("Thanks for visitng us");
            Console.ReadKey();
            }

            static void CustomerMenu()
            {
            Console.WriteLine("Select Customer Action ");
            int customerChoice = -1;

            do
            {
               Console.WriteLine(":::Customer Menu:::");
               Console.WriteLine("1. Add Customer");
               Console.WriteLine("2. Delete Customer");
               Console.WriteLine("3. Update Customer");
               Console.WriteLine("4. View Customer");
               Console.WriteLine("0. Back To Main Menu");

               Console.WriteLine("Enter Choice: ");
              customerChoice = int.Parse(Console.ReadLine());

               switch (customerChoice)
               {
                   case 1:
                       break;
                   case 2:
                       break;
                   case 3:
                       break;
                   case 4:
                       break;
               }
            } while (customerChoice != 0);

            }

            static void AccountsMenu()
            {
            Console.WriteLine("Select Account Action ");
            int AccountChoice = -1;

            do
            {
               Console.WriteLine(":::Customer Menu:::");
               Console.WriteLine("1. Add Account");
               Console.WriteLine("2. Delete Account");
               Console.WriteLine("3. Update Account");
               Console.WriteLine("4. View Account");
               Console.WriteLine("0. Back To Main Menu");

               Console.WriteLine("Enter Choice: ");
               AccountChoice = int.Parse(Console.ReadLine());

               switch (AccountChoice)
               {
                   case 1:
                       break;
                   case 2:
                       break;
                   case 3:
                       break;
                   case 4:
                       break;
               }
            } while (AccountChoice != 0);
              */
            //Customer c1;
            //Customer c2;
            //c1 = new Customer();
            //c2 = new Customer();


            // -------------------- //

            //Create a C# program with a class called DebitCard with a property called "Pin" with validations in the set accessor.

            //The Pin should be exactly 4 digits or 6 digits.

            //If the supplied pin is invalid, it shows error message.


            //DebitCard card = new DebitCard();

            //card.Pin = "1234";
            //card.Pin = "1234ef";
            //card.Pin = "123456";
            //card.Pin = "0";
            //card.Pin = "a4";

            //Console.ReadLine();

            // -------------------- //
        }
    }
}
