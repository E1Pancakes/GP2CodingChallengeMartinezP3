﻿using System;

class Challenges
{
    public static void Main(string[] args)
    {
        var keepLoop = true;

        while (keepLoop)
        {
            Console.WriteLine("Welcome to my Coding Challenge program. There will be a variety of different functions you will have to choose from. Please pick one. (Provide a number. There are 13 challenges total currently.)");

            var programChooser = Console.ReadLine();
            int programChooserint = int.Parse(programChooser);

            if (programChooserint == 1)
            {
                // Challenge 1 - Increment of 1
                Console.WriteLine("Today we are gonna use the number adder function called Sum. Please input two numbers for us to add.\n");

                var number1 = Console.ReadLine();
                int number1int = int.Parse(number1);

                Console.WriteLine("Great! Type one more number.");

                var number2 = Console.ReadLine();
                int number2int = int.Parse(number2);

                Sum(number1int, number2int);

                Console.WriteLine("The sum of the number : " + number1 + " and the number: " + number2 + " is equal to: " + Sum(number1int, number2int));
            }
            if (programChooserint == 2)
            {
                //challenge 2 - minutes converter
                Console.WriteLine("This program converts Minutes to Seconds. Please input Minutes.");

                var minutesToConvert = Console.ReadLine();
                int minutesToConvertint = int.Parse(minutesToConvert);

                Convert(minutesToConvertint);

                Console.WriteLine("In " + minutesToConvert + " amount of minutes, there are " + Convert(minutesToConvertint) + " amount of seconds.");


            }

            if (programChooserint == 3)
            {

                //challenge 3 - increment counter
                Console.WriteLine("Provide a number.");

                var challenge2Number = Console.ReadLine();
                int challenge2Numberint = int.Parse(challenge2Number);

                Console.WriteLine("The given number " + challenge2Number + " with an increment of 1 is " + PlusOne(challenge2Numberint));

            }

            if (programChooserint == 4)
            {

                //Challenge 4 - what is the power of a voltage * current ?
                Console.WriteLine("Provide a voltage.");

                var Voltage = Console.ReadLine();
                int Voltageint = int.Parse(Voltage);

                Console.WriteLine("Now provide a current.");

                var Current = Console.ReadLine();
                int Currentint = int.Parse(Current);

                Console.WriteLine("The power will be " + Multiplier(Currentint, Voltageint));

            }


            if (programChooserint == 5)
            {

                //Challenge 5 - how many days old are you?
                Console.WriteLine("Please provide an age to calculate.");

                var Age = Console.ReadLine();
                int Ageint = int.Parse(Age);

                Console.WriteLine("Someone " + Age + " years old is " + CalcAge(Ageint) + " days old.");

            }


            if (programChooserint == 6)
            {

                //Challenge 6 - calculate a triangle's area

                Console.WriteLine("Provide the base, then height to calculate the area of a triangle.");

                var triBase = Console.ReadLine();
                int triBaseint = int.Parse(triBase);

                Console.WriteLine("Great! now provide the height.");

                var triHeight = Console.ReadLine();
                int triHeightint = int.Parse(triHeight);

                Console.WriteLine("The area of a triangle with a base of " + triBase + " and height of " + triHeight + " is " + triArea(triBaseint, triHeightint));

            }


            if (programChooserint == 7)
            {

                //Challenge 7 - Is a number equal to or less than 0?

                Console.WriteLine("Please provide a number to check is equal or less than 0.");

                var lessThanZero = Console.ReadLine();
                int lessThanZeroint = int.Parse(lessThanZero);

                Console.WriteLine("The number provided is equal to or less than 0: " + lessThanOrEqualToZero(lessThanZeroint));
            }
            
            if (programChooserint == 8)
            {
                Console.WriteLine(" put two numbers that could sup up to 100");
                var number11 = Console.ReadLine();
                int int11int = int.Parse(number11);
                var number12 = Console.ReadLine();
                int int12int = int.Parse(number12);
                Console.WriteLine(lessthanhundred(int11int, int12int));
            }
            if (programChooserint == 9)
            {
                Console.WriteLine(" Please give me integers that I can check if they are equal");
                var number13 = Console.ReadLine();
                int int13int = int.Parse(number13);
                var number14 = Console.ReadLine();
                int int14int = int.Parse(number14);
                Console.WriteLine(equaltoo(int13int, int14int));
            }
            if (programChooserint == 10)
            {
                Console.WriteLine(" Please give me a a word and that word must contain SOMETHING \n. `");
                var words10 = Console.ReadLine();
                Console.WriteLine(GiveMeSomething(words10));
            }
            if (programChooserint == 11)
            {
                Console.WriteLine(" Please give me the word true or false and I will reverse that word \n. ");
                var TrueorFalse = Console.ReadLine();
                if (TrueorFalse == "true")
                {
                    Console.WriteLine(" False");
                }
                else if (TrueorFalse == "false")
                {
                    Console.WriteLine(" True");
                }
            }
            if (programChooserint == 12)
            {
                Console.WriteLine("Give me a number in hours that I willl convert into seconds. ");
                var number15 = Console.ReadLine();
                int number15int = int.Parse(number15);

                Console.WriteLine(HoursintoSeconds(number15int));
            }
            if (programChooserint == 13)
            {
                Console.WriteLine("Give me a number and it will give you the n-sided regular polygon. ");
                var number16 = Console.ReadLine();
                int number16int = int.Parse(number16);

                Console.WriteLine(SumOfPolygon(number16int));
            }
            //for uhhhhh. failsafe?
            //this should be fine i think
            else
            {
                Console.WriteLine("----\n This program will repeat now. If you are done, close the window. \n ----"); 
            }


        }

    }

    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
    public static int Convert(int number)
    {
        return number * 60;
    }
    public static int PlusOne(int number)
    {
        return number + 1;
    }
    public static int Multiplier(int number1, int number2)
    {
        return number1 * number2;
    }
    public static int CalcAge(int number)
    {
        return number * 365;
    }

    public static float triArea(float number1, int number2)
    {
        return (number1 * number2) / 2;
    }

    public static bool lessThanOrEqualToZero(int number)
    {
        return number <= 0;
    }

    public static bool lessthanhundred(int number11, int number12)
    {
        if (number11 + number12 < 100)
        {
            return true;
        }
        return false;
    }
    public static bool equaltoo(int number13, int number14)
    {
        if (number13 == number14)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static string GiveMeSomething(string words10)
    {
        var Smthn = " Something ";
        return Smthn + words10;
    }
    public static int HoursintoSeconds(int number15)
    {
        return (number15 * 60 * 60);
    }
    public static int SumOfPolygon(int number16)
    {
        return (number16 - 2)* 180;
    }
}