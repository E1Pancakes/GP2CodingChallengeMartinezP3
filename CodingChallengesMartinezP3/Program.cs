using System;
using System.Globalization;
using System.Net.Security;
using System.Security;

class Challenges
{
    public static void Main(string[] args)
    {
        var keepLoop = true;

        while (keepLoop)
        {
            Console.WriteLine("Welcome to my Coding Challenge program. There will be a variety of different functions you will have to choose from. Please pick one. (Provide a number. There are 30 challenges total currently.)");

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

                Convertion(minutesToConvertint);

                Console.WriteLine("In " + minutesToConvert + " amount of minutes, there are " + Convertion(minutesToConvertint) + " amount of seconds.");


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
            if (programChooserint == 14)
            {
                Console.WriteLine("Now let's add Edabit to the end of your own sentence. \n Please type out any sentence");
                var number17 = Console.ReadLine();
                Console.WriteLine(Edabit(number17));
            }
            if (programChooserint == 15)
            {
                Console.WriteLine("Give me two values using true and false ");
                var a = Console.ReadLine();
                bool abool = bool.Parse(a);
                Console.WriteLine("Give me two values using true and false ");
                var b = Console.ReadLine();
                bool bbool = bool.Parse(b);
                Console.WriteLine("And(" + a + ", " + b + ") -> " + TOrF(abool, bbool) + ".");
            }
            if (programChooserint == 16)
            {
                Console.WriteLine("Now we are going to count the score of a basketball game. \n.how many 3 pointers were scored.");
                var number18 = Console.ReadLine();
                int number18int = int.Parse(number18);
                Console.WriteLine("How many 2 pointers were scored.");
                var number19 = Console.ReadLine();
                int number19int = int.Parse(number19);
                Console.WriteLine("Point(" + number18 + "," + number19 + ")-->" + BasketBallScore(number18int, number19int));
            }
            if (programChooserint == 17)
            {
                Console.WriteLine("Now we are going to find the perimeter. \n. give me two numbers to find the perimeter.");
                var number20 = Console.ReadLine();
                int number20int = int.Parse(number20);
                var number21 = Console.ReadLine();
                int number21int = int.Parse(number21);
                Console.WriteLine("Point(" + number20 + "," + number21 + ")-->" + FP(number20int, number21int));
            }
            if (programChooserint == 18)
            {
                Console.WriteLine("give me a word and hello will be added infront of that word.");
                var words = Console.ReadLine();

                Console.WriteLine(hello(words) + "!");
            }
            if (programChooserint == 19)
            {
                Console.WriteLine("Now we are going to find out how many limbs are in three diffrent animals. \n. We will combine the total ");
                var number22 = Console.ReadLine();
                int number22int = int.Parse(number22);
                var number23 = Console.ReadLine();
                int number23int = int.Parse(number23);
                var number24 = Console.ReadLine();
                int number24int = int.Parse(number24);
                Console.WriteLine("animals(" + number22 + "," + number23 + "," + number24 + ")-->" + Farm(number22int, number23int, number24int));
            }
            if (programChooserint == 20)
            {
                Console.WriteLine("Now we are going to find out how many wins, draws, and losses are in the Football game. \n. We will combine the total ");
                var number25 = Console.ReadLine();
                int number25int = int.Parse(number25);
                var number26 = Console.ReadLine();
                int number26int = int.Parse(number26);
                var number27 = Console.ReadLine();
                int number27int = int.Parse(number27);
                Console.WriteLine("FootballPoints(" + number25 + "," + number26 + "," + number27 + ")-->" + Points(number25int, number26int, number27int));
            }
            if (programChooserint == 21)
            {
                Console.WriteLine("Now lets get the month of the year by th the month number.");
                var number28 = Console.ReadLine();
                int number28int = int.Parse(number28);
                if (number28int == 0)
                {
                    Console.WriteLine("invalid");
                }
                if (number28int == 1)
                {
                    Console.WriteLine("month name(1)-> January");
                }
                if (number28int == 2)
                {
                    Console.WriteLine("month name(2)-> Febuary");
                }
                if (number28int == 3)
                {
                    Console.WriteLine("month name(3)-> March");
                }
                if (number28int == 4)
                {
                    Console.WriteLine("month name(4)-> April");
                }
                if (number28int == 5)
                {
                    Console.WriteLine("month name(5)-> May");
                }
                if (number28int == 6)
                {
                    Console.WriteLine("month name(6)-> June");
                }
                if (number28int == 7)
                {
                    Console.WriteLine("month name(7)-> July");
                }
                if (number28int == 8)
                {
                    Console.WriteLine("month name(8)-> August");
                }
                if (number28int == 9)
                {
                    Console.WriteLine("month name(9)-> September");
                }
                if (number28int == 10)
                {
                    Console.WriteLine("month name(10)-> October");
                }
                if (number28int == 11)
                {
                    Console.WriteLine("month name(11)-> November");
                }
                if (number28int == 12)
                {
                    Console.WriteLine("month name(12)-> December");
                }
                if (number28int == 13)
                {
                    Console.WriteLine("invalid");
                }
            }
            if (programChooserint == 22)
            {

                int[] arr1 = new int[5];
                int max, min;
                Console.WriteLine("Enter Array Element");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Element {0} - ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }
                max = arr1[0];
                min = arr1[0];

                for (int i=0;i<arr1.Length;i++)
                {
                    if (arr1[i]>max)
                    {
                        max = arr1[i];
                    }
                    if (arr1[i]<min)
                    {
                        min = arr1[i];
                    }
                }
                Console.WriteLine("Maximum number from an array is {0}", max);
                Console.WriteLine("Minimum number from an array is {0}", min);

            }
            if (programChooserint == 23)
            {
                Console.WriteLine("Now we are going to get the absolute value of four numbers.\n please inpute your first number.");
                var number31 = Console.ReadLine();
                int number31int = int.Parse(number31);
                Console.WriteLine("Great, now give me your second number \n");
                var number32 = Console.ReadLine();
                int number32int = int.Parse(number32);
                Console.WriteLine("Great, now give me your third number \n");
                var number33 = Console.ReadLine();
                int number33int = int.Parse(number33);
                Console.WriteLine("Great, now give me your last number \n");
                var number34 = Console.ReadLine();
                int number34int = int.Parse(number34);
                Console.WriteLine("getAbsSum([" + number31 + "," + number32 + "," + number32 + "," + number34 + "])->" + getAbsSum(number31int, number32int, number33int, number34int));

            }
            if (programChooserint == 24)
            {
                Console.WriteLine("Give a number that will take that base number and multiply it by it's self with.\n the same number to the power.");
                var number29 = Console.ReadLine();
                int number29int = int.Parse(number29);

                var number30 = Console.ReadLine();
                int number30int = int.Parse(number30);

                Console.WriteLine("CalculateExponent(" + number29 + "," + number30 + ")-->" + CalculateExponent(number29int, number30int));
            }
            if (programChooserint == 25)
            {
                Console.WriteLine("Enter the numbers for the array, separated by spaces:");
                string input = Console.ReadLine();

                // Convert the input string into an array of integers
                string[] inputArray = input.Split(' ');
                int[] numbers = Array.ConvertAll(inputArray, int.Parse);

                Console.WriteLine("Original array:");
                foreach (var num in numbers)
                {
                    Console.Write(num + " ");
                }

                // Multiply each element by the length of the array
                MultiplyByLength(numbers);

                Console.WriteLine("\nArray after multiplicationn:");
                foreach (var num in numbers)
                {
                    Console.Write(num + " \n");
                }
            }
            if (programChooserint == 26)
            {
                Console.WriteLine("Hamming Distance give me two");
                var firstStrand = Console.ReadLine();


                var SecondStrand = Console.ReadLine();


                Console.WriteLine("HammingDistance(" + firstStrand + "," + SecondStrand + ")-->" + Distance(firstStrand, SecondStrand));
            }
            if (programChooserint == 27)
            {
                var number35 = Console.ReadLine();
                var number36 = Console.ReadLine();

                Console.WriteLine("NameShuffle(" + number35 + "," + number36 + ")-->" + Switch(number35, number36));
            }
            if (programChooserint == 28)
            {
                Console.WriteLine("");
                var number37 = Console.ReadLine();
                int number37int = int.Parse(number37);
                Console.WriteLine("");
                var number38 = Console.ReadLine();
                int number38int = int.Parse(number38);
                Console.WriteLine("");
                Console.WriteLine("smallerNum(" + number37 + "," + number38 + ")-->" + smallerNum(number37int, number38int));
            }
            if (programChooserint == 29)
            {
                Console.WriteLine("Please provide a number to calculate its factorial.");

                var factorialNumber = Console.ReadLine();
                int factorialNumberInt = int.Parse(factorialNumber);

                Console.WriteLine("The factorial of " + factorialNumber + " is " + Factorial(factorialNumberInt));
            }
            if (programChooserint == 30)
            {
                int total = 0;
                // Build a list of vowels up front:
                var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

                Console.WriteLine("Enter a Sentence");
                string sentence = Console.ReadLine().ToLower();

                for (int i = 0; i < sentence.Length; i++)
                {
                    if (vowels.Contains(sentence[i]))
                    {
                        total++;
                    }
                }
                Console.WriteLine("CountVowels(" + sentence + ")------->" + total);

                Console.ReadLine();
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
    public static int Convertion(int number)
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
    public static string Edabit(string number17)
    {
        var bit = "Edabit";
        return number17 + bit;
    }
    public static bool TOrF(bool a, bool b)
    {
        if (a == true && b == true)
        {
            Console.WriteLine("True");
            return true;
        }
        else
        {
            Console.WriteLine("False");
            return false;
        }
    }
    public static int BasketBallScore(int number18, int number19)
    {
        return (number18 * 3) + number19 * 2;
    }
    public static int FP(int number20, int number21)
    {
        return (number20 * 2) + number21 * 2;
    }
    public static string hello(string words)
    {
        var hello = " Hello ";
        return hello + words;
    }
    public static int Farm(int number22, int number23, int number24)
    {
        return (number22 * 2 + number23 * 4 + number24 * 4);
    }
    public static int Points(int number25, int number26, int number27)
    {
        return (number25 * 3 + number26 * 1 + number27 * 0);
    }
    public static int getAbsSum(int number31, int number32, int number33, int number34)
    {
        return (Math.Abs(number31)) + (Math.Abs(number33)) + (Math.Abs(number33)) + (Math.Abs(number34));
    }
    public static double CalculateExponent(double number29, double number30)
    {
        return (Math.Pow(number29, number30));
    }
    public static void MultiplyByLength(int[] array)
    {
        int length = array.Length;

        for (int i = 0; i < length; i++)
        {
            array[i] *= length;
        }
    }
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) { throw new ArgumentException(); }

        return firstStrand.Zip(secondStrand, (abcde, bcdef) => abcde != bcdef).Count(f => f);
    }
    public static string Switch(string number35, string number36)
    {
        return number36 + " " + number35;
    }
    public static int smallerNum(int numfirst, int numsecond)
    {
        if (numfirst < numsecond)
        {
            return numfirst;
        }
        else
        {
            return numsecond;
        }
    }
    public static int Factorial(int number)
    {
        if (number == 0)
            return 1;  // Base case: 0! = 1
        else
            return number * Factorial(number - 1);  // Recursive case
    }

}