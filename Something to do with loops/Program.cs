using System;

namespace MyFirstProgram
{

    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("This is a data base building program (answer all questions with a yes or a no unless a different answer is required)");
            Console.WriteLine("Press any key to begin");
            Console.ReadKey ();
            Console.WriteLine("I will take some information from you and produce a database from that");
            Console.ReadKey();
            Console.WriteLine("Firstly enter your name");
            String name = Console.ReadLine ();
            Console.WriteLine("Are you sure your name is " + name + "?");
            String choice1 = Console.ReadLine ();
            while (choice1 == "no")
            {
                Console.WriteLine("Please re-enter your name");
                name = Console.ReadLine ();
                Console.WriteLine("Are you sure your name is " + name + "?");
                choice1 = Console.ReadLine();
            } 
            if (choice1 == "yes")
            {
                Console.WriteLine("Now enter your age");
                String age = Console.ReadLine();
                Console.WriteLine("Are you sure your age is " + age + "?");
                String choice2 = Console.ReadLine();
                while (choice2 == "no")
                {
                    Console.WriteLine("Please re-enter your age");
                    age = Console.ReadLine();
                    Console.WriteLine("Are you sure your age is " + age + "?");
                    choice2 = Console.ReadLine();
                }
                if (choice2 == "yes")
                {
                    Console.WriteLine("Next is your height, would u like it in cm or m?");
                    String unitHeight = Console.ReadLine();
                    if (unitHeight == "cm")
                    {
                        Console.WriteLine("You have chosen " + unitHeight + ", would u like to change your decision?");
                        String choice3 = Console.ReadLine();
                        while (choice3 == "yes")
                        {
                            Console.WriteLine("Please re-enter if you would like to use cm or m");
                            unitHeight = Console.ReadLine();
                            Console.WriteLine("You have chosen " + unitHeight +", would u like to change your decision?");
                            choice3 = Console.ReadLine();
                        }
                        if (choice3 == "no")
                        {
                            Console.WriteLine("Enter your height");
                            String height = Console.ReadLine();
                            Console.WriteLine("You have entered " + height + " as your height, is this correct?");
                            String choice6 = Console.ReadLine();
                            while (choice6 == "no")
                            {
                                Console.WriteLine("Please re-enter your height");
                                height = Console.ReadLine();
                                Console.WriteLine("You have entered " + height + " as your height, is this correct?");
                                choice6 = Console.ReadLine();
                            }
                            if (choice6 == "yes")
                            {
                                Console.WriteLine("Next is your weight, would u like it in lbs or kg?");
                                String unitWeight = Console.ReadLine();
                                if (unitWeight == "lbs")
                                {
                                    Console.WriteLine("You have chosen " + unitWeight + ", would u like to change your decision?");
                                    String choice4 = Console.ReadLine();
                                    while (choice4 == "yes")
                                    {
                                        Console.WriteLine("Please re-enter if you would like to use lbs or kg");
                                        unitWeight = Console.ReadLine();
                                        Console.WriteLine("You have chosen " + unitWeight + ", would u like to change your decision");
                                        choice4 = Console.ReadLine();
                                    }
                                    if (choice4 == "no")
                                    {
                                        Console.WriteLine("Finally enter your weight");
                                        String weight = Console.ReadLine();
                                        Console.WriteLine("You have entered " + weight + " as your weight? is this correct?");
                                        String choice5 = Console.ReadLine();
                                        while (choice5 == "no")
                                        {
                                            Console.WriteLine("Please re-enter your weight");
                                            weight = Console.ReadLine();
                                            Console.WriteLine("You have entered " + weight + "as your weight? is this correct?");
                                            choice5 = Console.ReadLine();
                                        }
                                        if (choice5 == "yes")
                                        {
                                            Console.WriteLine("I have enough information, i will now create a database, press any key to continue");
                                            Console.ReadKey();
                                            name = name.ToUpper();
                                            Console.WriteLine("Name : " + name);
                                            Console.WriteLine("Age : " + age);
                                            Console.WriteLine("Height : " + height + "" + unitHeight);
                                            Console.WriteLine("Weight : " + weight + "" + unitWeight);
                                            Console.ReadKey();
                                        }
                                    }
                                }
                                else if (unitWeight == "kg")
                                {
                                    Console.WriteLine("You have chosen kg, would u like to change your decision?");
                                    String choice4 = Console.ReadLine();
                                    while (choice4 == "yes")
                                    {
                                        Console.WriteLine("Please re-enter if you would like to use lbs or kg");
                                        unitWeight = Console.ReadLine();
                                        Console.WriteLine("You have chosen kg, would u like to change your decision");
                                        choice4 = Console.ReadLine();
                                    }
                                    if (choice4 == "no")
                                    {
                                        Console.WriteLine("Finally enter your weight");
                                        String weight = Console.ReadLine();
                                        Console.WriteLine("You have entered " + weight + " as your weight? is this correct?");
                                        String choice5 = Console.ReadLine();
                                        while (choice5 == "no")
                                        {
                                            Console.WriteLine("Please re-enter your weight");
                                            weight = Console.ReadLine();
                                            Console.WriteLine("You have entered " + weight + "as your weight? is this correct?");
                                            choice5 = Console.ReadLine();
                                        }
                                        if (choice5 == "yes")
                                        {
                                            Console.WriteLine("I have enough information, i will now create a database, press any key to continue");
                                            Console.ReadKey();
                                            name = name.ToUpper();
                                            Console.WriteLine("Name : " + name);
                                            Console.WriteLine("Age : " + age);
                                            Console.WriteLine("Height : " + height + "" + unitHeight);
                                            Console.WriteLine("Weight : " + weight + "" + unitWeight);
                                            Console.ReadKey();
                                        }
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Error, lol learn to use a program");
                                }
                            }
                        }
                    }
                    else if (unitHeight == "m")
                    {
                        Console.WriteLine("You have chosen m, would u like to change your decision?");
                        String choice3 = Console.ReadLine();
                        while (choice3 == "yes")
                        {
                            Console.WriteLine("Please re-enter if you would like to use cm or m");
                            unitHeight = Console.ReadLine();
                            Console.WriteLine("You have chosen " + unitHeight +", would u like to change your decision?");
                            choice3 = Console.ReadLine();
                        }
                        if (choice3 == "no")
                        {
                            Console.WriteLine("Now enter your height");
                            String height = Console.ReadLine();
                            Console.WriteLine("Your height is " + height + ", correct?");
                            String choice = Console.ReadLine();
                            while (choice == "no")
                            {
                                Console.WriteLine("Okay, re-enter your height");
                                height = Console.ReadLine();
                                Console.WriteLine("Your height is " + height + ", correct?");
                                choice = Console.ReadLine();
                            }
                            if (choice == "yes")
                            {
                                Console.WriteLine("Next is your weight, would u like it in lbs or kg?");
                                String unitWeight = Console.ReadLine();
                                if (unitWeight == "lbs")
                                {
                                    Console.WriteLine("You have chosen " + unitWeight + ", would u like to change your decision?");
                                    String choice4 = Console.ReadLine();
                                    while (choice4 == "yes")
                                    {
                                        Console.WriteLine("Please re-enter if you would like to use lbs or kg");
                                        unitWeight = Console.ReadLine();
                                        Console.WriteLine("You have chosen " + unitWeight + ", would u like to change your decision");
                                        choice4 = Console.ReadLine();
                                    }
                                    if (choice4 == "no")
                                    {
                                        Console.WriteLine("Finally enter your weight");
                                        String weight = Console.ReadLine();
                                        Console.WriteLine("You have entered " + weight + " as your weight? is this correct?");
                                        String choice5 = Console.ReadLine();
                                        while (choice5 == "no")
                                        {
                                            Console.WriteLine("Please re-enter your weight");
                                            weight = Console.ReadLine();
                                            Console.WriteLine("You have entered " + weight + "as your weight? is this correct?");
                                            choice5 = Console.ReadLine();
                                        }
                                        if (choice5 == "yes")
                                        {
                                            Console.WriteLine("I have enough information, i will now create a database, press any key to continue");
                                            Console.ReadKey();
                                            name = name.ToUpper();
                                            Console.WriteLine("Name : " + name);
                                            Console.WriteLine("Age : " + age);
                                            Console.WriteLine("Height : " + height + "" + unitHeight);
                                            Console.WriteLine("Weight : " + weight + "" + unitWeight);
                                            Console.ReadKey();
                                        }
                                    }
                                }
                                else if (unitWeight == "kg")
                                {
                                    Console.WriteLine("You have chosen kg, would u like to change your decision?");
                                    String choice4 = Console.ReadLine();
                                    while (choice4 == "yes")
                                    {
                                        Console.WriteLine("Please re-enter if you would like to use lbs or kg");
                                        unitWeight = Console.ReadLine();
                                        Console.WriteLine("You have chosen kg, would u like to change your decision");
                                        choice4 = Console.ReadLine();
                                    }
                                    if (choice4 == "no")
                                    {
                                        Console.WriteLine("Finally enter your weight");
                                        String weight = Console.ReadLine();
                                        Console.WriteLine("You have entered " + weight + " as your weight? is this correct?");
                                        String choice5 = Console.ReadLine();
                                        while (choice5 == "no")
                                        {
                                            Console.WriteLine("Please re-enter your weight");
                                            weight = Console.ReadLine();
                                            Console.WriteLine("You have entered " + weight + "as your weight? is this correct?");
                                            choice5 = Console.ReadLine();
                                        }
                                        if (choice5 == "yes")
                                        {
                                            Console.WriteLine("I have enough information, i will now create a database, press any key to continue");
                                            Console.ReadKey();
                                            name = name.ToUpper();
                                            Console.WriteLine("Name : " + name);
                                            Console.WriteLine("Age : " + age);
                                            Console.WriteLine("Height : " + height + "" + unitHeight);
                                            Console.WriteLine("Weight : " + weight + "" + unitWeight);
                                            Console.ReadKey();
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error, lol learn to use a program");
                                }
                            }
                        }
                   
                    }
                }
                else
                {
                    Console.WriteLine("error");
                } 
            } 
            else
            {
                Console.WriteLine("error");
            } 
        }
    }
}