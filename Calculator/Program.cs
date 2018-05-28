using System;


namespace Calculator
{
    class Program
    {
        //Set contants
        const string ADD = "Where Sum = OperandA + OperandB:";
        const string SUBTRACT = "Where Difference = OperandA - OperandB:";
        const string MULTIPLY = "Where Product = OperandA * OperandB:";
        const string DIVIDE = "Where Quotient = OperandA / OperandB:";
        const string MODULUS = "Where Modulus = OperandA % OperandB:";
        const string SUCCESS = "The operation has successfully completed.\n" +
            "Please press 'Enter' to stop the program.";

        //Display the options menu to user
        public static void DisplayMenu()
        {
            Console.WriteLine(
                @"CALCULATOR MENU  
                  1) Add two numbers.
                  2) Subtract one number from another.
                  3) Multiply two numbers.
                  4) Divide one number by another.
                  5) Calculate the remainder from dividing one number by another.");
        }

        //This method takes care of validating the user input 
        // before proceeding to calculation.
        //The input dialog remains in a loop until the input is validated
        public static float[] Option(String option)
        {
            Console.WriteLine(option);

            bool isWrong = true;
            float[] Operand = new float[2];
            while (isWrong)
            {
                Console.Write("Please enter OperandA: ");
                string userInputA = Console.ReadLine();//Get first number from user input
                float OperandA;
                
                //Validate first number
                if (!float.TryParse((userInputA), out OperandA) || userInputA.Contains(" "))
                {
                    Console.WriteLine("invalid input");
                }
                else
                {
                    Console.Write("Please enter OperandB: ");
                    string userInputB = Console.ReadLine();//Get second number if first is valid
                    float OperandB;
                    
                    //Validate second number
                    if (!float.TryParse((userInputB), out OperandB) || userInputB.Contains(" "))
                    {
                        Console.WriteLine("Invalid input. Start again.");
                    }
                    else
                    {
                        Operand[0] = Convert.ToSingle(OperandA); //Add to first index in array
                        Operand[1] = Convert.ToSingle(OperandB); //Add to second index in array
                        isWrong = false; //exit loop
                    }
                }
            }
            return Operand;

        }

        //Method to add two numbers 
        static void AddNumbers(float a, float b)
        {
            float result = a + b;
            Console.WriteLine("Sum = " + result);
            Console.WriteLine(SUCCESS);
        }

        //Method to subtract two numbers
        static void SubtractNumbers(float a, float b)
        {
            float result = a - b;
            Console.WriteLine("Difference = " + result);
            Console.WriteLine(SUCCESS);
        }

        //Method to multiply two numbers
        static void MultiplyNumbers(float a, float b)
        {
            float result = a * b;
            Console.WriteLine("Product = " + result);
            Console.WriteLine(SUCCESS);
        }

        //Method to divide two numbers
        static void DivideNumbers(float a, float b)
        {
            float result = a / b;
            Console.WriteLine("Quotient = " + result);
            Console.WriteLine(SUCCESS);
        }

        //Method to find the modulo
        static void ModulusNumbers(float a, float b)
        {
            float result = a % b;
            Console.WriteLine("Modulus = " + result);
            Console.WriteLine(SUCCESS);
        }

        static void Main()
        {
            DisplayMenu();
            float[] Operand;
            bool isWrong = true;


            while (isWrong)
            {
                Console.Write("Please make your selection: ");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Operand = Option(ADD);
                        AddNumbers(Operand[0], Operand[1]);
                        isWrong = false;
                        break;
                    case "2":
                        Operand = Option(SUBTRACT);
                        SubtractNumbers(Operand[0], Operand[1]);
                        isWrong = false;
                        break;
                    case "3":
                        Operand = Option(MULTIPLY);
                        MultiplyNumbers(Operand[0], Operand[1]);
                        isWrong = false;
                        break;
                    case "4":
                        Operand = Option(DIVIDE);
                        DivideNumbers(Operand[0], Operand[1]);
                        isWrong = false;
                        break;
                    case "5":
                        Operand = Option(MODULUS);
                        ModulusNumbers(Operand[0], Operand[1]);
                        isWrong = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

