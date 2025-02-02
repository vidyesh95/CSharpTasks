// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("Task and solutions!");*/

/*
 * LEVEL 1 & 2 TASK
 *
 * 1. Perform all Mathematical operations (i.e., addition, subtraction, multiplication, division, Modulus division)
 * with numbers.
 */
/*decimal total = 0M;
decimal tempValue = 0M;
while (true)
{
    Console.WriteLine("Enter two numbers to perform all Mathematical operations");

    Console.Write("Enter first number : ");
    decimal num1;
    while (!decimal.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    Console.Write("Enter second number : ");
    decimal num2;
    while (!decimal.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    Console.WriteLine($"first number is {num1} and second number is {num2}");

    Console.WriteLine("Now what operation you want to perform on numbers?");
    Console.WriteLine("Addition => +");
    Console.WriteLine("Subtraction => -");
    Console.WriteLine("Multiplication => *");
    Console.WriteLine("Division => /");
    Console.WriteLine("Modulus division => %");
    Console.WriteLine("Enter operation symbol");
    string? stringOperation;
    while (true)
    {
        stringOperation = Console.ReadLine();
        if (stringOperation == "+" || stringOperation == "-" || stringOperation == "*" || stringOperation == "/" || stringOperation == "%")
        {
            break;
        }
        Console.WriteLine("Invalid operation. Please enter a valid operation symbol.");
    }

    switch (stringOperation)
    {
        case "+":
            tempValue = num1 + num2;
            Console.WriteLine($"Addition of {num1} and {num2} is {tempValue}");
            break;
        case "-":
            tempValue = num1 - num2;
            Console.WriteLine($"Subtraction of {num1} and {num2} is {tempValue}");
            break;
        case "*":
            tempValue = num1 * num2;
            Console.WriteLine($"Multiplication of {num1} and {num2} is {tempValue}");
            break;
        case "/":
            tempValue = num1 / num2;
            Console.WriteLine($"Division of {num1} and {num2} is {tempValue}");
            break;
        case "%":
            tempValue = num1 % num2;
            Console.WriteLine($"Modulus division of {num1} and {num2} is {tempValue}");
            break;
        default:
            Console.WriteLine("Invalid operation");
            break;
    }

    total += tempValue;
    Console.WriteLine($"Total is {total}");

    Console.WriteLine("Enter c to clear total or any other key to continue");
    var isTotalClear = Console.ReadLine();
    if (isTotalClear == "c")
    {
        total = 0;
    }
    Console.WriteLine($"Total is {total}");

    Console.WriteLine("Enter y to continue or any other key to exit");
    var isContinue = Console.ReadLine();
    if (isContinue != "y")
    {
        break;
    }
}*/


/*
 * 2. Swap two numbers with third variable and without third variable.
 */
/*Console.WriteLine("Enter two numbers to swap");

Console.WriteLine("Enter first number");
int number1;
while (!int.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine("Enter second number");
int number2;
while (!int.TryParse(Console.ReadLine(), out number2))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine($"Before swap: first number is {number1} and second number is {number2}");
number2 += number1;
number1 = number2 - number1;
number2 -= number1;
Console.WriteLine($"After swap: first number is {number1} and second number is {number2}");*/


/*
 * 3. Find the greatest of three numbers.
 */
/*Console.WriteLine("Enter three numbers to find the greatest number");
int number1;
while (!int.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

int number2;
while (!int.TryParse(Console.ReadLine(), out number2))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

int number3;
while (!int.TryParse(Console.ReadLine(), out number3))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine($"Entered numbers are {number1}, {number2} and {number3}");

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"Greatest number is {number1}");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"Greatest number is {number2}");
}
else if (number3 > number1 && number3 > number2)
{
    Console.WriteLine($"Greatest number is {number3}");
}
else if (number1 == number2 && number1 > number3)
{
    Console.WriteLine($"Greatest number is {number1} and {number2}");
}
else if (number2 == number3 && number2 > number1)
{
    Console.WriteLine($"Greatest number is {number2} and {number3}");
}
else if (number1 == number3 && number1 > number2)
{
    Console.WriteLine($"Greatest number is {number1} and {number3}");
}
else
{
    Console.WriteLine("All numbers are equal");
}*/


/*
 * 4. Enter principal, no of years, rate of interest and calculate simple interest as well as compound interest.
 */

/*Console.WriteLine("Enter principal amount");
double principal;
while (!double.TryParse(Console.ReadLine(), out principal))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine("Enter number of years");
int numberOfYears;
while (!int.TryParse(Console.ReadLine(), out numberOfYears))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine("Enter rate of interest");
double rateOfInterest;
while (!double.TryParse(Console.ReadLine(), out rateOfInterest))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine($"Simple Interest is {principal * numberOfYears * rateOfInterest / 100}");*/
/*
 * P = Initial Principal Amount
 * r = Annual Interest Rate
 * c = Number of Times Interest is Compounded
 *     Annually     (c = 1)     : Interest is compounded once per year.
 *     Semiannually (c = 2)     : Interest is compounded twice per year.
 *     Quarterly    (c = 4)     : Interest is compounded four times per year.
 *     Monthly      (c = 12)    : Interest is compounded twelve times per year.
 *     Daily        (c = 365)   : Interest is compounded every day.
 * n = Number of Years
 */
/*Console.WriteLine("Enter number of times interest is compounded (1, 2, 4, 12, 365)");
int compoundTimes;
while (
    !int.TryParse(Console.ReadLine(), out compoundTimes) ||
    (compoundTimes != 1 && compoundTimes != 2 && compoundTimes != 4 && compoundTimes != 12 && compoundTimes != 365)
)
{
    Console.WriteLine("Invalid input. Please enter a valid number (1, 2, 4, 12, 365).");
}

decimal compoundInterest = (decimal)(principal * Math.Pow(
    (1 + rateOfInterest / 100 / compoundTimes),
    compoundTimes * numberOfYears));
Console.WriteLine($"Compound Interest is {compoundInterest}");*/

/*
 * 5. Enter number and check it is even-odd.
 */
/*Console.WriteLine("Enter a number to check it is even or odd");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine(number % 2 == 0 ? "Number is even" : "Number is odd");*/

/*
 * 6. Enter 10 numbers and find sum of all numbers.
 */
/*decimal sum = 0m;
Console.WriteLine("Enter 10 numbers to find sum of all numbers");
for (var i = 1; i < 11; i++)
{
    Console.Write($"Enter number {i} : ");
    decimal number;
    while (!decimal.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    sum += number;
}
Console.WriteLine($"Sum of all numbers is {sum}");*/

/*
 * 7. Enter number and find its factorial.
 */
/*Console.Write("Enter a number to find its factorial : ");
long number;
while (!long.TryParse(Console.ReadLine(), out number) || number < 0)
{
    Console.WriteLine("Invalid input. Please enter a valid number greater than or equal to 0.");
}

long factorial = 1L;
for (var i = number; i > 0; i--)
{
    factorial *= i;
}
Console.WriteLine($"Factorial of {number} is {factorial}");*/


/*
 * 8. Print Fibonacci series. (0 1 1 2 3 5 8 ….)
 */
/*Console.Write("Enter a natural number to print that number of elements in Fibonacci series : ");
int number;
while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 140)
{
    Console.WriteLine("Invalid input. Please enter a valid number greater than 0 and smaller than 141.");
}
switch (number)
{
    case 1:
        Console.WriteLine("0");
        break;
    case 2:
        Console.WriteLine("0 1");
        break;
    default:
    {
        Console.Write("0 1 ");
        decimal first = 0M;
        decimal second = 1M;
        for (var i = 3; i <= number; i++)
        {
            decimal temporary = first + second;
            Console.Write($"{temporary} ");
            first = second;
            second = temporary;
        }

        break;
    }
}*/


/*
 * 9. Enter three-digit number and display the sum of digits(Example: Input - 123 Output - 6).
 */

/*Console.Write("Enter a three-digit number to display the sum of digits : ");
int number;
while (!int.TryParse(Console.ReadLine(), out number) || number < 100 || number > 999)
{
    Console.WriteLine("Invalid input. Please enter a valid three-digit number.");
}

int numberCopy = number;

List<int> digits = new List<int>();
Console.WriteLine("Method 1 using List and LINQ");
while (number > 0)
{
    digits.Add(number % 10);
    number /= 10;
}
foreach (var digit in digits)
{
    Console.WriteLine(digit);
}
Console.WriteLine($"Sum of digits is {digits.Sum()}");

Console.WriteLine("Method 2 using temporary variable");
var sum = 0;
while (numberCopy > 0)
{
    sum += (numberCopy % 10);
    numberCopy /= 10;
}
Console.WriteLine($"Sum of digits is {sum}");*/

/*
 * 10. Enter three-digit number and display its reverse(Example: Input - 123 Output - 321).
 */
/*Console.Write("Enter a three-digit number to display its reverse : ");
int number;
while (!int.TryParse(Console.ReadLine(), out number) || number < 100 || number > 999)
{
    Console.WriteLine("Invalid input. Please enter a valid three-digit number.");
}

int tempNumber = number;

Console.WriteLine("Method 1 using List");
List<int> digits = new List<int>();
while (number > 0)
{
    digits.Add(number % 10);
    number /= 10;
}

foreach (var digit in digits)
{
    Console.Write(digit);
}

Console.WriteLine();
Console.WriteLine("Method 2 using temporary variable");
int reversedNumber = 0;
Console.Write("Reversed number is ");
while (tempNumber > 0)
{
    int digit = tempNumber % 10;
    reversedNumber = reversedNumber * 10 + digit;
    tempNumber /= 10;
    Console.Write(reversedNumber);
}*/


/*
 * 11. Enter a number and print its prime or not.
 */
/*Console.Write("Enter a number to check it is prime or not : ");
int number;
while (!int.TryParse(Console.ReadLine(), out number) || number < 2)
{
    Console.WriteLine("Invalid input. Please enter a valid number greater than or equal to 2.");
}

bool isPrime = true;
for (var i = 2; i <= number / 2; i++)
{
    if (number % i == 0)
    {
        isPrime = false;
        break;
    }
}
Console.WriteLine(isPrime ? "Number is prime" : "Number is not prime");*/


/*
 * 12. Print multiplication table of a number entered by user.
 */
/*Console.Write("Enter a number to print its multiplication table : ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
Console.WriteLine($"Multiplication table of {number}");
for (var i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} * {i} = {number * i}");
}*/


/*
 * 13. Enter year and print it is leap year or not.
 */
/*Console.WriteLine("Enter a year to check it is leap year or not");
int year;
while (!int.TryParse(Console.ReadLine(), out year) || year < 1)
{
    Console.WriteLine("Invalid input. Please enter a valid year.");
}

if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
{
    Console.WriteLine("Year is leap year");
}
else
{
    Console.WriteLine("Year is not leap year");
}*/

/*
 * 14. Enter a number and print it is palindrome or not.
 */
/*Console.Write("Enter a number to check it is palindrome or not : ");
int number;
while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
{
    Console.WriteLine("Invalid input. Please enter a valid number greater than or equal to 0.");
}

int tempNumber = number;
int reversedNumber = 0;
while (tempNumber > 0)
{
    int digit = tempNumber % 10;
    reversedNumber = reversedNumber * 10 + digit;
    tempNumber /= 10;
}

Console.WriteLine(reversedNumber == number ? "Number is palindrome" : "Number is not palindrome");*/


/*
 * 15. Enter a number and print it is Armstrong or not.
 * (Armstrong numbers : 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370, 371, 407, 1634, 8208, 9474)
 */
/*Console.Write("Enter a number to check it is Armstrong or not : ");
int number;
while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
{
    Console.WriteLine("Invalid input. Please enter a valid number greater than or equal to 0.");
}

int tempNumber = number;
string numberString = number.ToString();
int lengthOfNumber = numberString.Length;
int sum = 0;
while (tempNumber > 0)
{
    var digit = tempNumber % 10;
    sum += (int)Math.Pow(digit, lengthOfNumber);
    tempNumber /= 10;
}

Console.WriteLine(sum == number ? "Number is Armstrong" : "Number is not Armstrong");*/


/*
 * 16. Create Calculator program using switch case.
 */
/*decimal total = 0M;
decimal tempValue = 0M;
while (true)
{
    Console.WriteLine("Enter two numbers to perform all Mathematical operations");

    Console.Write("Enter first number : ");
    decimal num1;
    while (!decimal.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    Console.Write("Enter second number : ");
    decimal num2;
    while (!decimal.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    Console.WriteLine($"first number is {num1} and second number is {num2}");

    Console.WriteLine("Now what operation you want to perform on numbers?");
    Console.WriteLine("Addition => +");
    Console.WriteLine("Subtraction => -");
    Console.WriteLine("Multiplication => *");
    Console.WriteLine("Division => /");
    Console.WriteLine("Modulus division => %");
    Console.WriteLine("Enter operation symbol");
    string? stringOperation;
    while (true)
    {
        stringOperation = Console.ReadLine();
        if (stringOperation == "+" || stringOperation == "-" || stringOperation == "*" || stringOperation == "/" || stringOperation == "%")
        {
            break;
        }
        Console.WriteLine("Invalid operation. Please enter a valid operation symbol.");
    }

    switch (stringOperation)
    {
        case "+":
            tempValue = num1 + num2;
            Console.WriteLine($"Addition of {num1} and {num2} is {tempValue}");
            break;
        case "-":
            tempValue = num1 - num2;
            Console.WriteLine($"Subtraction of {num1} and {num2} is {tempValue}");
            break;
        case "*":
            tempValue = num1 * num2;
            Console.WriteLine($"Multiplication of {num1} and {num2} is {tempValue}");
            break;
        case "/":
            tempValue = num1 / num2;
            Console.WriteLine($"Division of {num1} and {num2} is {tempValue}");
            break;
        case "%":
            tempValue = num1 % num2;
            Console.WriteLine($"Modulus division of {num1} and {num2} is {tempValue}");
            break;
        default:
            Console.WriteLine("Invalid operation");
            break;
    }

    total += tempValue;
    Console.WriteLine($"Total is {total}");

    Console.WriteLine("Enter c to clear total or any other key to continue");
    var isTotalClear = Console.ReadLine();
    if (isTotalClear == "c")
    {
        total = 0;
    }
    Console.WriteLine($"Total is {total}");

    Console.WriteLine("Enter y to continue or any other key to exit");
    var isContinue = Console.ReadLine();
    if (isContinue != "y")
    {
        break;
    }
}*/


/*
 * 17. Print all whole numbers between 20 to 50.
 */
/*using System.Text;

Console.Write("All whole numbers between 20 to 50 : ");
for (var i = 20; i < 51; i++)
{
    Console.Write($"{i}, ");
}


Console.WriteLine("Without comma and space at the end");

Console.Write("All whole numbers between 20 to 50 : ");
StringBuilder result = new StringBuilder();
for (var i = 20; i < 51; i++)
{
    result.Append($"{i}, ");
}
Console.Write(result.ToString().TrimEnd(',', ' ').Insert(result.Length-2 , "."));*/ //-2 to remove comma and
//space and insert dot at the end


/*
 * 18. Print greater among two numbers using ternary operator.
 */
/*Console.WriteLine("Enter two numbers to print greater among two numbers using ternary operator");
int num1;
while (!int.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

int num2;
while (!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine(num1 > num2 ? $"{num1} is greater than {num2}" : $"{num2} is greater than {num1}");*/


/*
 * 19. Enter a number and print it is positive or negative.
 */
/*Console.WriteLine("Enter a number to check it is positive or negative");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

switch (number)
{
    case < 0:
        Console.WriteLine("Number is negative");
        break;
    case > 0:
        Console.WriteLine("Number is positive");
        break;
    default:
        Console.WriteLine("Number is neutral");
        break;
}*/


/*
 * 20. Enter marks and check pass or fail.
 */
/*Console.Write("Enter marks to check pass or fail : ");
int marks;
while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
{
    Console.WriteLine("Invalid input. Please enter a valid number between 0 and 100.");
}

Console.WriteLine(marks >= 40 ? "Pass" : "Fail");*/


/*
 * 21. Enter marks and print according to criteria:
 *     70-100 ->distinction
 *     50-70 -> first class
 *     40-45 -> second class
 *     <40 -> fail
 */
/*while (true)
{
    Console.WriteLine("Enter marks to print according to criteria");
    Console.WriteLine(" 70-100 ->distinction, 50-69 -> first class, 40-49 -> second class, <39 -> fail");
    int marks;
    while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
    {
        Console.WriteLine("Invalid input. Please enter a valid number between 0 and 100.");
    }

    switch (marks)
    {
        case >= 70:
            Console.WriteLine("Distinction");
            break;
        case >= 50:
            Console.WriteLine("First class");
            break;
        case >= 40:
            Console.WriteLine("Second class");
            break;
        default:
            Console.WriteLine("Fail");
            break;
    }

    Console.WriteLine("If you want to continue press y or any other key to exit");
    var isContinue = Console.ReadLine();
    if (isContinue != "y")
    {
        break;
    }
}*/


/*
 * 22. Print all prime numbers between 1 to 100.
 */
/*Console.WriteLine("All prime numbers between 1 to 100");
for (var i = 2; i < 101; i++)
{
    bool isPrime = true;
    for (var j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.Write($"{i}, ");
    }
}*/


/*
 * 23. Enter day name (Example: Monday, Tuesday, etc.) and print it is weekday or weekend using switch case.
 */
/*Console.Write("Enter day name to check it is weekday or weekend : ");
string? dayName = Console.ReadLine();
if (dayName != null)
{
    switch (dayName.ToLower())
    {
        case "monday":
        case "tuesday":
        case "wednesday":
        case "thursday":
        case "friday":
            Console.WriteLine("Weekday");
            break;
        case "saturday":
        case "sunday":
            Console.WriteLine("Weekend");
            break;
        default:
            Console.WriteLine("Invalid day name");
            break;
    }
}*/


/*
 * 24. Print all even numbers between 1 to 50.
 */
/*Console.WriteLine("All even numbers between 1 to 50");
for (var i = 1; i < 51; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
}*/


/*
 * 25. Write a login program to enter username and password, continue the loop till the user enters correct credentials.
 */
/*Console.WriteLine("Login");
while (true)
{
    Console.Write("Enter username : ");
    string? username = Console.ReadLine();
    Console.Write("Enter password : ");
    string? password = Console.ReadLine();

    if (username == "admin" && password == "admin")
    {
        Console.WriteLine("Login successful");
        break;
    }
    Console.WriteLine("Invalid credentials. Please enter correct credentials.");
}*/


/*
 * 26. Enter age and print the eligibility to vote using goto statement.
 */
/*start:
Console.WriteLine("Enter age to check the eligibility to vote");
int age;
while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
{
    Console.WriteLine("Invalid input. Please enter a valid age greater than or equal to 0.");
}

Console.WriteLine(age >= 18 ? "Eligible to vote" : "Not eligible to vote");

Console.WriteLine("Enter y to continue or any other key to exit");
var isContinue = Console.ReadLine();
if (isContinue == "y")
{
    goto start;
}*/


/*
 * 27. Find the minimum or maximum element from the Array.
 */
/*Console.Write("Enter number of integer elements in the array : ");
int numberOfElements;
while (!int.TryParse(Console.ReadLine(), out numberOfElements) || numberOfElements < 1)
{
    Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
}

int[] array = new int[numberOfElements];

for (var i = 0; i < numberOfElements; i++)
{
    int number;
    Console.Write($"Enter an {i + 1} element : ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer element.");
    }

    array[i] = number;
}

foreach (var element in array)
{
    Console.Write($"{element} ");
}

Console.WriteLine();
Console.WriteLine("Using LINQ");
Console.WriteLine($"Minimum element is {array.Min()}");
Console.WriteLine($"Maximum element is {array.Max()}");

Console.WriteLine("Using normal method");
int min = int.MaxValue;
int max = int.MinValue;
foreach (var element in array)
{
    if (element < min)
    {
        min = element;
    }

    if (element > max)
    {
        max = element;
    }
}

Console.WriteLine($"Minimum element is {min}");
Console.WriteLine($"Maximum element is {max}");*/


/*
 * 28. Accept 10 numbers from the user in the array and perform sorting.
 */
/*Console.WriteLine("Enter 10 elements");
int[] array = new int[10];
for (var i = 0; i < 10; i++)
{
    int number;
    Console.Write($"Enter an {i + 1} element : ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer element.");
    }

    array[i] = number;
}

Console.WriteLine("Before sorting");
foreach (int element in array)
{
    Console.Write($"{element} ");
}

Console.WriteLine();
Console.WriteLine("After sorting");
Console.WriteLine("Using normal method");
for (var i = 0; i < array.Length; i++)
{
    for (var j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            // int temp = array[i];
            // array[i] = array[j];
            // array[j] = temp;
            (array[i], array[j]) = (array[j], array[i]);
        }
    }
}
// Console.WriteLine("Using Array.Sort method");
// Array.Sort(array);
foreach (int element in array)
{
    Console.Write($"{element} ");
}*/

/*
 * 29. Accept 10 numbers in an array and reverse the values (without using any inbuilt functions)
 */
/*Console.WriteLine("Enter 10 elements");
int[] array = new int[10];
for (var i = 0; i < 10; i++)
{
    int number;
    Console.Write($"Enter an {i + 1} element : ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer element.");
    }

    array[i] = number;
}

Console.WriteLine("Before sorting");
foreach (int element in array)
{
    Console.Write($"{element} ");
}

for (int i = 0; i < array.Length/2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length-1-i];
    array[array.Length-1-i] = temp;
}

Console.WriteLine();
Console.WriteLine("After sorting");
foreach (int element in array)
{
    Console.Write($"{element} ");
}*/


/*
 * 30. Accept 10 numbers in an array and print which numbers are even or odd.
 */
/*Console.WriteLine("Enter 10 elements");
int[] array = new int[10];
for (var i = 0; i < 10; i++)
{
    int number;
    Console.Write($"Enter an {i + 1} element : ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer element.");
    }

    array[i] = number;
}

foreach (int element in array)
{
    Console.Write($"{element} ");
}
Console.WriteLine();
foreach (int element in array)
{
    if (element%2==0)
    {
        Console.WriteLine($"{element} is even");
    }
    else
    {
        Console.WriteLine($"{element} is odd");
    }
}*/


/*
 * 31. Create two arrays with 5 numbers in each. Merge all the numbers in the third array in sorted order.
 */
/*int[] array1 = new int[5];
int[] array2 = new int[5];
int thirdArrayLenth = array1.Length + array2.Length;
int[] array3 = new int[thirdArrayLenth];

Console.WriteLine("Enter 5 elements for first array");
for (var i = 0; i < array1.Length; i++)
{
    int number;
    Console.Write($"Enter an {i + 1} element : ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer element.");
    }

    array1[i] = number;
}

foreach (int element in array1)
{
    Console.Write($"{element} ");
}

Console.WriteLine();

Console.WriteLine("Enter 5 elements for second array");
for (var i = 0; i < array2.Length; i++)
{
    int number;
    Console.Write($"Enter an {i + 1} element : ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer element.");
    }

    array2[i] = number;
}

foreach (int element in array2)
{
    Console.Write($"{element} ");
}

Console.WriteLine();

for (int i = 0; i < array1.Length; i++)
{
    array3[i] = array1[i];
}

for (int i = 0; i < array2.Length; i++)
{
    array3[array1.Length + i] = array2[i];
}

Console.WriteLine("Third array before sort is");

foreach (int element in array3)
{
    Console.Write($"{element} ");
}

Console.WriteLine();
Console.WriteLine("Third array after sort is");

for (int i = 0; i < array3.Length; i++)
{
    for (int j = i + 1; j < array3.Length; j++)
    {
        if (array3[i] > array3[j])
        {
            int temp = array3[i];
            array3[i] = array3[j];
            array3[j] = temp;
        }
    }
}

foreach (int element in array3)
{
    Console.Write($"{element} ");
}*/


/*
 * 32. Accept values in 2D array and perform matrix Addition and multiplication.
 */

/*using System;

namespace CSharpTasks
{
    static class MatrixOperations
    {
        static int[,] InputMatrixDetails()
        {
            Console.WriteLine("Enter number of rows");
            int rows;
            while (!int.TryParse(Console.ReadLine(), out rows) || rows < 1)
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
            }

            Console.WriteLine("Enter number of columns");
            int columns;
            while (!int.TryParse(Console.ReadLine(), out columns) || columns < 1)
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
            }

            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Enter the elements {i}, {j}");
                    // matrix[i, j] = int.Parse(Console.ReadLine());
                    while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                    }

                    ;
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2, int rows1, int columns1, int rows2, int columns2)
        {
            /*
             * Check if dimensions of matrices match and throw exception if dimensions dont match
             #1#
            if (rows1 != rows2 || columns1 != columns2)
            {
                throw new InvalidOperationException("Matrices must have same dimensions for addition");
            }

            int[,] matrixAddition = new int[rows1, columns1];

            /*
             * Addition of Matrices
             #1#
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns1; j++)
                {
                    matrixAddition[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return matrixAddition;
        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2, int rows1, int columns1, int rows2, int columns2)
        {
            /*
             * Check if number of rows in first match with number of columns in second matrix and also
             * number of columns in first match with number of rows in second matrix
             * rows1 != columns2 || columns1 != rows2 is redundant so only check 1 condition
             #1#
            if (columns1 != rows2)
            {
                throw new InvalidOperationException("Matrices must have number of rows in first match with number \n" +
                                                    "of columns in second matrix and also number of columns in \n" +
                                                    "first match with number of rows in second matrix");
            }

            int[,] matrixMultiplication = new int[rows1, columns2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < columns1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }

                    matrixMultiplication[i, j] = sum;
                }
            }

            return matrixMultiplication;
        }

        static void Main()
        {
            Console.WriteLine("Enter details for first 2D array");
            int[,] matrix1 = InputMatrixDetails();

            Console.WriteLine();

            Console.WriteLine("Enter details for second 2D array");
            int[,] matrix2 = InputMatrixDetails();

            Console.WriteLine();

            Console.WriteLine("First matrix is");
            PrintMatrix(matrix1);

            Console.WriteLine();

            Console.WriteLine("Second matrix is");
            PrintMatrix(matrix2);

            Console.WriteLine();

/*
 * matrix1.GetLength(0) returns the number of rows in matrix1.
 * matrix1.GetLength(1) returns the number of columns in matrix1.
 * matrix2.GetLength(0) returns the number of rows in matrix2.
 * matrix2.GetLength(1) returns the number of columns in matrix2.
 #1#
            int rows1 = matrix1.GetLength(0);
            int columns1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int columns2 = matrix2.GetLength(1);

            Console.WriteLine("Addition of two matrices is : ");
            try
            {
                int[,] matrixAddition = AddMatrices(matrix1, matrix2, rows1, columns1, rows2, columns2);
                PrintMatrix(matrixAddition);
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }

            Console.WriteLine();

            Console.WriteLine("Multiplication of two matrices is : ");
            try
            {
                int[,] matrixMultiplication = MultiplyMatrices(matrix1, matrix2, rows1, columns1, rows2, columns2);
                PrintMatrix(matrixMultiplication);
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}*/


/*
 * 33. Accept 10 numbers in an array and calculate sum of all the elements.
 */
/*Console.WriteLine("Enter 10 elements");
int[] array = new int[10];
for (var i = 0; i < 10; i++)
{
    int number;
    Console.Write($"Enter an {i + 1} element : ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer element.");
    }

    array[i] = number;
}

decimal sumOfElements = 0m;
foreach (int element in array)
{
    sumOfElements += element;
}
Console.WriteLine($"Sum of all elements is {sumOfElements}");
Console.WriteLine("Using LINQ");
Console.WriteLine($"Sum of all elements is {array.Sum()}");*/

/*
 * 34. Accept 10 numbers in an array and calculate average of all the elements.
 */
/*Console.WriteLine("Enter 10 elements");
int[] array = new int[10];
for (var i = 0; i < 10; i++)
{
    int number;
    Console.Write($"Enter an {i + 1} element : ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer element.");
    }

    array[i] = number;
}

decimal sumOfElements = 0m;
foreach (int element in array)
{
    sumOfElements += element;
}
Console.WriteLine($"Sum of all elements is {sumOfElements}");

Console.WriteLine($"Average of all elements is {sumOfElements / array.Length}");
Console.WriteLine("Using LINQ");
Console.WriteLine($"Average of all elements is {array.Average()}");*/


/*
 * 35. Insert a new element in a particular position of an array and display the array.
 */
/*Console.Write("Enter the size of array : ");
int sizeOfArray;
while (!int.TryParse(Console.ReadLine(), out sizeOfArray))
{
    Console.WriteLine("Invalid input. Please enter a valid natural number.");
}

int[] array = new int[sizeOfArray];
for (int i = 0; i < sizeOfArray; i++)
{
    int number;
    Console.Write($"Enter an {i + 1} element : ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer element.");
    }

    array[i] = number;
}

Console.WriteLine("Array before inserting a new element");
foreach (int element in array)
{
    Console.Write($"{element} ");
}

Console.WriteLine();
Console.Write("Enter the position to insert a new element : ");
int position;
while (!int.TryParse(Console.ReadLine(), out position) || position < 0 || position > sizeOfArray)
{
    Console.WriteLine("Invalid input. Please enter a valid position between 1 and size of array.");
}
Console.WriteLine($"Position is {position}");

int[] newArray = new int[sizeOfArray + 1];
Console.Write("Enter a new element to insert in the array : ");
int newElement;
while (!int.TryParse(Console.ReadLine(), out newElement))
{
    Console.WriteLine("Invalid input. Please enter a valid integer element.");
}

for (int i = 0; i < position ; i++)
{
    newArray[i] = array[i];
}

// Add element at position
newArray[position] = newElement;

// Add rest of array elements from position
for (int i = 0; i < sizeOfArray-position; i++)
{
    newArray[i+position+1] = array[i+position];
}

Console.WriteLine("Array after inserting a new element");
foreach (int element in newArray)
{
    Console.Write($"{element} ");;
}*/


/*
 * 36. Delete an already existing element from an array and display the array.
 */
/*Console.Write("Enter the size of array : ");
int sizeOfArray;
while (!int.TryParse(Console.ReadLine(), out sizeOfArray))
{
    Console.WriteLine("Invalid input. Please enter a valid natural number.");
}

int[] array = new int[sizeOfArray];
for (int i = 0; i < sizeOfArray; i++)
{
    int number;
    Console.Write($"Enter an {i + 1} element : ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer element.");
    }

    array[i] = number;
}

Console.WriteLine("Array before deleting element");
foreach (int element in array)
{
    Console.Write($"{element} ");
}

Console.WriteLine();
Console.Write("Enter the position to delete a new element : ");
int position;
while (!int.TryParse(Console.ReadLine(), out position) || position < 0 || position > sizeOfArray-1)
{
    Console.WriteLine("Invalid input. Please enter a valid position between 1 and size of array -1.");
}
Console.WriteLine($"Position is {position}");

int[] newArray = new int[sizeOfArray - 1];

for (int i = 0; i < position ; i++)
{
    newArray[i] = array[i];
}

// Delete element at position by adding rest of array elements from position
for (int i = 0; i < sizeOfArray-position-1; i++)
{
    newArray[i+position] = array[i+position+1];
}

Console.WriteLine("Array after deleting element");
foreach (int element in newArray)
{
    Console.Write($"{element} ");;
}*/


/*
 * 37. Print the following patterns :
 */
/*
 * 1)
 *      *
 *      **
 *      ***
 *      ****
 */
/*for (int i = 0; i < 4; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/


/*
 * 2)
 *      1
 *      12
 *      123
 *      1234
 */
/*for (int i = 1; i < 5; i++)
{
    for (int j = 1; j < i+1; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}*/


/*
 * 3)
 *      1
 *      22
 *      333
 *      4444
 */
/*for (int i = 1; i < 5; i++)
{
    for (int j = 1; j < i+1; j++)
    {
        Console.Write(i);
    }
    Console.WriteLine();
}*/


/*
 * 4)
 *      1
 *      23
 *      456
 *      78910
 */
/*int n = 1;
for (int i = 1; i < 5; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(n);
        n++;
    }
    Console.WriteLine();
}*/


/*
 * 5)
 *         *
 *        * *
 *       * * *
 *      * * * *
 */
/*int rows = 4;
for (int i = 1; i < rows+1; i++)
{
    for (int j = rows; j > i; j--)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < i; j++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}*/


/*
 * 6)
 *            *
 *          * *
 *        * * *
 *      * * * *
 */
/*int rows = 4;
for (int i = 1; i < rows+1; i++)
{
    for (int j = rows; j >i; j--)
    {
        Console.Write("  ");
    }

    for (int j = 1; j < i+1; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}*/


/*
 * 7)
 *            *
 *          * * *
 *        * * * * *
 *      * * * * * * *
 */
/*int rows = 4;
for (int i = 1; i < rows+1; i++)
{
    for (int j = rows; j > i; j--)
    {
        Console.Write("  ");
    }

    for (int j = 1; j < i+i; j++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}*/


/*
 * 8)
 *      1
 *      2*
 *      33*
 *      444*
 *      5555*
 */
/*int rows = 5;
for (int i = 1; i < rows + 1; i++)
{
    if (i > 1)
    {
        for (int j = 0; j < i-1; j++)
        {
            Console.Write(i);
        }
        Console.Write("*");
    }
    else
    {
        Console.Write(i);
    }
    Console.WriteLine();
}*/
/*int rows = 5;
Console.Write("1");
for (int i = 1; i < rows+1; i++)
{
    for (int j = 1; j < i; j++)
    {
        Console.Write(i);
    }

    if (i>1)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/


/*
 * 9)
 *      *******
 *      *     *
 *      *     *
 *      *     *
 *      *     *
 *      *     *
 *      *******
 */
/*int rows = 7;
for (int i = 1; i < rows+1; i++)
{
    if (i==1 || i==rows)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write("*");
        }
    }
    else
    {
        Console.Write("*");
        for (int j = 0; j < rows-2; j++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
    }
    Console.WriteLine();
}*/


/*
 * 10)
 *                  *
 *                * * *
 *              * * * * *
 *            * * * * * * *
 *          * * * * * * * * *
 *        * * * * * * * * * * *
 *      * * * * * * * * * * * * *
 *        * * * * * * * * * * *
 *          * * * * * * * * *
 *            * * * * * * *
 *              * * * * *
 *                * * *
 *                  *
 */
/*int rows = 13;
for (int i = 1; i < rows + 1; i++)
{
    //upper spacing
    for (int j = rows - i - 5; j > 1; j--)
    {
        Console.Write("  ");
    }
    //lower spacing
    for (int j = 1; j < i - 6; j++)
    {
        Console.Write("  ");
    }

    if (i < 8)
    {
    //upper triangle
        for (int j = 1; j < i + i; j++)
        {
            Console.Write("* ");
        }
    }
    else
    {
    // lower triangle
        for (int j = 1; j < rows + rows - i -i + 2; j++)
        {
            Console.Write("* ");
        }
    }
    Console.WriteLine();
}*/

/*
 * Using minimum number of loops
 */

/*int rows = 13;
for (int i = 1; i <= rows; i++)
{
    int leadingSpaces = Math.Abs(i - 7) * 2;
    Console.Write(new string(' ', leadingSpaces));

    int starCount = i < 8 ? 2 * i - 1 : rows * 2 + 1 - 2 * i;
    Console.WriteLine(new string('*', starCount).Replace("*", "* "));
}*/

/*const int rows = 13;
for (int i = 1; i <= rows; i++)
{
    // Calculate spaces and star count
    int space;
    int starCount;
    if (i < 8)
    {
        space = 2 * (7 - i); // Upper half spaces
        starCount = 2 * i - 1; // Upper triangle stars
    }
    else
    {
        space = 2 * (i - 7); // Lower half spaces
        starCount = rows * 2 + 1 - 2 * i; // Lower triangle stars}
    }

    // Print spaces
    for (int j = 0; j < space; j++)
        Console.Write(" ");

    // Print stars with spacing
    for (int j = 0; j < starCount; j++)
        Console.Write("* ");

    Console.WriteLine();
}*/


/*
 * 11)
 *      ********
 *      *******
 *      ******
 *      *****
 *      ****
 *      ***
 *      **
 *      *
 */
/*int rows = 8;
for (int i = 0; i < rows; i++)
{
    for (int j = rows; j > i; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/


/*
 * 12)
 *                *
 *               * *
 *              *   *
 *             *     *
 *            *       *
 *           *         *
 *          *           *
 *         *             *
 *        *               *
 *       *                 *
 *      *                   *
 *       *                 *
 *        *               *
 *         *             *
 *          *           *
 *           *         *
 *            *       *
 *             *     *
 *              *   *
 *               * *
 *                *
 */
/*const int rows = 21;
for (int i = 1; i < rows + 1; i++)
{
    if (i < (rows + 1) / 2)
    {
        for (int j = (rows + 1) / 2; j > i; j--)
        {
            Console.Write(" ");
        }

        for (int j = 1; j < i + i; j++)
        {
            if (j == 1 || j == i + i - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
    else
    {
        for (int j = 0; j < i - (rows + 1) / 2; j++)
        {
            Console.Write(" ");
        }

        for (int j = 1; j <  2 * ((rows + 1) - i); j++)
        {
            if (j == 1 || j ==  2 * ((rows + 1) - i) - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }

    Console.WriteLine();
}*/


/*
 * 13)
 *           1
 *          1 1
 *         1 2 1
 *        1 3 3 1
 *       1 4 6 4 1
 *      1 5 10 10 5 1
 */

/*int rows = 6;

for (int i = 0; i < rows; i++)
{
    for (int j = rows - i; j > 0; j--)
    {
        Console.Write(" ");
    }

    int temp = 1;
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write($"{temp} ");
        temp = temp * (i - j) / (j + 1);
    }

    Console.WriteLine();
}*/


/*
 * 14)
 *      5
 *      54
 *      543
 *      5432
 *      54321
 */

/*int rows = 5;
for (int i = 1; i < rows+1; i++)
{
    for (int j = rows; j > rows-i; j--)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}*/


/*
 * 15)
 *      1******
 *      12*****
 *      123****
 *      1234***
 *      12345**
 *      123456*
 *      1234567
 */
/*const int rows = 7;
for (int i = 1; i < rows+1; i++)
{
    for (int j = 1; j < i+1; j++)
    {
        Console.Write(j);
    }

    for (int j = 0; j < rows-i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/


/*
 * 16)
 *      1
 *      21
 *      321
 *      4321
 *      54321
 */
/*const int rows = 5;
for (int i = 1; i < rows+1; i++)
{
    for (int j = i+1; j > 1; j--)
    {
       Console.Write(j-1);
    }
    Console.WriteLine();
}*/


/*
 * 17)
 *      5
 *      45
 *      345
 *      2345
 *      12345
 */

/*const int rows = 5;
for (int i = 1; i < rows + 1; i++)
{
    for (int j = rows - i + 1; j < rows + 1; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}*/


/*
 * 18)
 *      12345
 *      2345
 *      345
 *      45
 *      5
 */
/*const int rows = 5;
for (int i = 0; i < rows; i++)
{
    for (int j = 1; j < rows-i+1; j++)
    {
        Console.Write(j+i);
    }
    Console.WriteLine();
}*/


/*
 * 19)
 *      54321
 *       5432
 *        543
 *         54
 *          5
 */
/*const int rows = 5;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }

    for (int j = rows; j > i; j--)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}*/


/*
 * 20)
 *      $
 *      # #
 *      $ $ $
 *      # # # #
 */

/*const int row = 4;
for (int i = 1; i < row + 1; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(i % 2 == 0 ? "# " : "$ ");
    }

    Console.WriteLine();
}*/


/*
 * 38. Print the following patterns using 2D Array :
 */
/*
 * 1)
 *      *
 *      **
 *      ***
 *      ****
 */

/*const int arraySize = 4;
string[,] starsArray = new string[arraySize, arraySize];

// add * values to array
for (int i = 0; i < arraySize; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        starsArray[i, j] = "*";
    }
}

// Print array
for (int i = 0; i < arraySize; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write(starsArray[i, j]);
    }
    Console.WriteLine();
}*/


/*
 * 2)
 *      1
 *      12
 *      123
 *      1234
 */

/*const int arraySize = 4;
int[,] intArray = new int[arraySize, arraySize];

// Add values to array
for (int i = 1; i < arraySize + 1; i++)
{
    for (int j = 1; j < i + 1; j++)
    {
        intArray[i - 1, j - 1] = j;
    }
}

// Print array
for (int i = 0; i < arraySize; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write(intArray[i, j]);
    }

    Console.WriteLine();
}*/

/*
 * 3)
 *      1
 *      22
 *      333
 *      4444
 */

/*const int arraySize = 4;
int[,] intArray = new int[arraySize, arraySize];
// Add values to array
for (int i = 1; i < arraySize + 1; i++)
{
    for (int j = 1; j < i + 1; j++)
    {
        intArray[i - 1, j - 1] = i;
    }
}

// Print array
for (int i = 0; i < arraySize; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write(intArray[i, j]);
    }

    Console.WriteLine();
}*/

/*
 * 4)
 *      1
 *      23
 *      456
 *      78910
 */

/*const int size = 4;
int[,] intArray = new int[size, size];

// Add values to array
int number = 1;
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        intArray[i, j] = number;
        number++;
    }
}

// Print array
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write(intArray[i, j]);
    }

    Console.WriteLine();
}*/


/*
 * 5)
 *         *
 *        * *
 *       * * *
 *      * * * *
 */

/*const int arraySize = 4;
string[,] starsArray = new string[arraySize, arraySize];

// Adding * values to array
for (int i = 0; i < arraySize; i++)
{
    for (int j = arraySize - 1; j > i; j--)
    {
        starsArray[i, j] = "  ";
    }

    for (int j = 0; j < i + 1; j++)
    {
        starsArray[i, j] = "* ";
    }
}

// Print array
for (int i = 0; i < arraySize; i++)
{
    for (int j = 0; j < arraySize; j++)
    {
        Console.Write(starsArray[i, j]);
    }

    Console.WriteLine();
}*/

/*
 * 5)
 *         *
 *        * *
 *       * * *
 *      * * * *
 */

/*const int arraySize = 4;
// Use [rows, columns] dimensions that match the pattern width
string[,] starsArray = new string[arraySize, 2 * arraySize - 1];

// Add values to array
for (int i = 0; i < arraySize; i++)
{
    int stars = i + 1;
    int spaces = arraySize - i - 1;

    // Add spaces
    for (int j = 0; j < spaces; j++)
    {
        starsArray[i, j] = " ";
    }

    // Fill stars with spacing
    for (int j = 0; j < stars; j++)
    {
        int position = spaces + j * 2;
        starsArray[i, position] = "*";
    }
}

// Print array
for (int i = 0; i < arraySize; i++)
{
    for (int j = 0; j < 2 * arraySize - 1; j++)
    {
        Console.Write(starsArray[i, j] ?? " ");
    }

    Console.WriteLine();
}*/


/*
 * 6)
 *            *
 *          * *
 *        * * *
 *      * * * *
 */

/*const int rows = 4;
string[,] starsArray = new string[rows, rows];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows; j++)
    {
        if (j < rows - i - 1)
        {
            starsArray[i, j] = "  ";
        }
        else
        {
            starsArray[i, j] = "* ";
        }
    }
}

// Print array
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write(starsArray[i, j]);
    }

    Console.WriteLine();
}*/


/*
 * 7)
 *            *
 *          * * *
 *        * * * * *
 *      * * * * * * *
 */

/*const int rows = 4;
const int cols = 7;
string[,] starsArray = new string[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        if (j < rows - i - 1)
        {
            starsArray[i, j] = "  ";
        }
        else if (j < rows + i)
        {
            starsArray[i, j] = "* ";
        }
    }
}

// Print array
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(starsArray[i, j]);
    }

    Console.WriteLine();
}*/


/*
 * LEVEL 3 TASK
 */
/*
 * 1. Swap two number using Call by Value and Call by Reference.
 */

/*int number1 = 10;
int number2 = 20;

Console.WriteLine($"Before swapping: number1 = {number1}, number2 = {number2}");
Console.WriteLine("Swapping numbers using call by value");
SwapNumbersCallByValue(number1, number2);

static void SwapNumbersCallByValue(int i, int j)
{
    int temp = i;
    i = j;
    j = temp;
}

Console.WriteLine($"After swapping: number1 = {number1}, number2 = {number2}");

Console.WriteLine();

Console.WriteLine($"Before swapping: number1 = {number1}, number2 = {number2}");
Console.WriteLine("Swapping numbers using call by reference using ref");

SwapNumbersCallByReference(ref number1, ref number2);

void SwapNumbersCallByReference(ref int i, ref int j)
{
    int temp = i;
    i = j;
    j = temp;
}

Console.WriteLine($"After swapping: number1 = {number1}, number2 = {number2}");*/


/*
 * 2. Calculate area and circumference of circle using functions (with return type and without return type)
 */

/*namespace Cal
{
    class Calculate
    {
        public static void Main()
        {
            Console.WriteLine("Circle calculations");
            Console.Write("Enter the radius of the circle : ");
            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }

            Console.WriteLine("Calculating area and circumference of the circle using functions with return type");
            Console.WriteLine($"Area of the circle is {CalculateArea(radius)}");
            Console.WriteLine($"Circumference of the circle is {CalculateCircumference(radius)}");

            Console.WriteLine("Calculating area and circumference of the circle using functions without return type");
            double area = 0;
            double circumference = 0;
            CalculateAreaAndCircumference(radius, ref area, ref circumference);
            Console.WriteLine($"Area of the circle is {area}");
            Console.WriteLine($"Circumference of the circle is {circumference}");
        }

        private static void CalculateAreaAndCircumference(double radius, ref double area, ref double circumference)
        {
            area = Math.PI * Math.Pow(radius, 2);
            circumference = 2 * Math.PI * radius;
        }

        private static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        private static double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}*/


/*
 * 3. Calculate area of rectangle using out parameter.
 */

/*namespace Cal
{
    class Calculate
    {
        public static void Main()
        {
            Console.WriteLine("Rectangle area calculation");
            Console.Write("Enter the length of the rectangle : ");
            double length;
            while (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }

            Console.Write("Enter the breadth of the rectangle : ");
            double breadth;
            while (!double.TryParse(Console.ReadLine(), out breadth) || breadth <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }

            CalculateArea(length, breadth, out double area);
            Console.WriteLine($"Area of the rectangle is {area}");
        }

        private static void CalculateArea(double length, double breadth, out double area)
        {
            area = length * breadth;
        }
    }
}*/


/*
 * 4. Display max and min number from the following string array:
 *    {“1”, “Rohan”, “Avinash”, “5”, “tina”, “100”, “Rahul”, “38”}
 */

/*namespace CSharpTasks
{
    internal static class MinMax
    {
        public static void Main()
        {
            string[] array = { "1", "Rohan", "Avinash", "5", "tina", "100", "Rahul", "38" };
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach (string element in array)
            {
                if (int.TryParse(element, out int number))
                {
                    if (number > max)
                    {
                        max = number;
                    }

                    if (number < min)
                    {
                        min = number;
                    }
                }
            }

            Console.WriteLine($"Maximum number is {max}");
            Console.WriteLine($"Minimum number is {min}");
        }
    }
}*/


/*
 * 5. Calculate sum of numbers from the string array:
 *    {“1”, “Sona”, “David”, “50”, “Fardeen”, “19”, “Rishi”, “68”}
 */

/*namespace CSharpTasks
{
    internal static class Sum
    {
        public static void Main()
        {
            string[] array = { "1", "Sona", "David", "50", "Fardeen", "19", "Rishi", "68" };
            int sum = 0;
            foreach (string element in array)
            {
                if (int.TryParse(element, out int number))
                {
                    sum += number;
                }
            }

            Console.WriteLine($"Sum of numbers is {sum}");
        }
    }
}*/


/*
 * 6. Calculate the sum of Integer values as well as decimal values separately from the given string array:
 *    {“1”,”10.5”,”11”,”12.5”,”14”,”15.5”,”16”,”17”,”18.5”}
 */

/*namespace CSharpTasks
{
    internal static class SumOfIntegersAndDecimals
    {
        public static void Main()
        {
            string[] array = { "1", "10.5", "11", "12.5", "14", "15.5", "16", "17", "18.5" };
            decimal sumOfIntegers = 0;
            decimal sumOfDecimals = 0;
            foreach (string element in array)
            {
                if (decimal.TryParse(element, out decimal number))
                {
                    if (number % 1 == 0)
                    {
                        sumOfIntegers += number;
                    }
                    else
                    {
                        sumOfDecimals += number;
                    }
                }
            }

            Console.WriteLine($"Sum of integers is {sumOfIntegers}");
            Console.WriteLine($"Sum of decimals is {sumOfDecimals}");
        }
    }
}*/


/*
 * 7.   Accept the Number of Students from 1st std to 5th std, Accept their Name and
 *      Roll no from user and display them using Jagged Array.
 */

/*namespace CSharpTasks
{
    internal static class RegisterStudents
    {
        public static void Main()
        {
            string[][][] students = new string[5][][];

            string name;
            string rollNo;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter the number of students for {i + 1} standard : ");
                int numberOfStudents;
                while (!int.TryParse(Console.ReadLine(), out numberOfStudents) || numberOfStudents <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive number.");
                }

                // Intialize array
                students[i] = new string[numberOfStudents][];

                //Input student details
                for (int j = 0; j < numberOfStudents; j++)
                {
                    Console.Write($"Enter the name of student {j + 1} : ");
                    name = Console.ReadLine();
                    Console.Write($"Enter the roll number of student {j + 1} : ");
                    rollNo = Console.ReadLine();
                    students[i][j] = new string[] { name, rollNo };
                }
            }

            // Student details
            Console.WriteLine("Student details");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Standard {i + 1}");
                for (int j = 0; j < students[i].Length; j++)
                {
                    Console.WriteLine($"Name : {students[i][j][0]}, Roll number : {students[i][j][1]}");
                }
            }
        }
    }
}*/


/*
 * LEVEL 4 TASK
 */
/*
 * STRING TASK:
 */
/*
 * 1. Enter a sentence and find the number of spaces, words, vowels and consonants.
 */

/*namespace CSharpTasks
{
    class StringUtility
    {
        public static void Main()
        {
            Console.Write("Enter a sentence : ");
            string? sentence;
            while (string.IsNullOrWhiteSpace(sentence = Console.ReadLine()))
            {
                Console.WriteLine("Input cannot be null or empty or only space. Please enter a valid sentence:");
            }

            int spaces = 0;
            int words = 0;
            int vowels = 0;
            int consonants = 0;

            foreach (char ch in sentence.Trim())
            {
                if (char.IsWhiteSpace(ch))
                {
                    spaces++;
                }
                else if (char.IsLetter(ch))
                {
                    if (char.ToLower(ch) == 'a' || char.ToLower(ch) == 'e' || char.ToLower(ch) == 'i' ||
                        char.ToLower(ch) == 'o' || char.ToLower(ch) == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            words = spaces + 1;
            Console.WriteLine($"Number of spaces : {spaces}");
            Console.WriteLine($"Number of words : {words}");
            Console.WriteLine($"Number of vowels : {vowels}");
            Console.WriteLine($"Number of consonants : {consonants}");
        }
    }
}*/


/*
 * 2.
 *      Enter a sentence and capitalize first letter of each word.
 *      Input: my name is tom.
 *      Output: My Name Is Tom.
 */

/*namespace CSharpTasks
{
    internal static class StringUtility
    {
        public static void Main()
        {
            Console.Write("Enter a sentence : ");
            string? sentence;
            while (string.IsNullOrWhiteSpace(sentence = Console.ReadLine()))
            {
                Console.WriteLine("Input cannot be null or empty or only space. Please enter a valid sentence:");
            }

            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }

            string result = string.Join(" ", words);
            Console.WriteLine($"Capitalized sentence : {result}");
        }
    }
}*/


/*
 * 3.
 *      Input: Rohan.Sigh@featsystems.com
 *      Output: First name: Rohan
 *              Last name: Singh
 *              Company: featsystems
 */

/*namespace CSharpTasks
{
    internal static class StringUtility
    {
        public static void Main()
        {
            Console.Write("Enter an email address : ");
            string? email;
            while (string.IsNullOrWhiteSpace(email = Console.ReadLine()))
            {
                Console.WriteLine("Input cannot be null or empty or only space. Please enter a valid email address:");
            }

            string[] emailParts = email.Split('@');
            string[] nameParts = emailParts[0].Split('.');
            string firstName = nameParts[0];
            string lastName = nameParts[1];
            string company = emailParts[1].Split('.')[0];

            Console.WriteLine($"First name : {firstName}");
            Console.WriteLine($"Last name : {lastName}");
            Console.WriteLine($"Company : {company}");
        }
    }
}*/


/*
 * 4.
 *      Input: “Please feel free to contact me on abhishek.solanki@gmail.com anytime between 10 am to 6 pm.”
 *      Output: abhishek.solanki@gmail.com
 */

/*using System.Text.RegularExpressions;

namespace CSharpTasks
{
    internal static class StringUtility
    {
        public static void Main()
        {
            Console.Write("Enter a sentence : ");
            string? sentence;
            while (string.IsNullOrWhiteSpace(sentence = Console.ReadLine()))
            {
                Console.WriteLine("Input cannot be null or empty or only space. Please enter a valid sentence:");
            }

            string emailPattern = @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b";
            MatchCollection matches = Regex.Matches(sentence, emailPattern, RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.ToLower());
            }
        }
    }
}*/


/*
 * 5.
 *      Enter a name and display the frequency of each letter.
 *      Input: address
 *      output: a =01, d=02, r=01, e=01, s=02
 */

/*namespace CSharpTasks
{
    internal static class StingUtility
    {
        public static void Main()
        {
            Console.Write("Enter a name : ");
            string? name;
            while (string.IsNullOrWhiteSpace(name = Console.ReadLine()))
            {
                Console.WriteLine("Input cannot be null or empty or only space. Please enter a valid name:");
            }

            
        }
    }
}*/


/*
 * 6.
 *      Enter a word and reverse it.
 *      Input: Sunday
 *      Output: yadnus
 */

namespace CSharpTasks
{
    internal static class StingUtility
    {
        public static void Main()
        {
            Console.Write("Enter a word : ");
            string? word;
            while (string.IsNullOrWhiteSpace(word = Console.ReadLine()))
            {
                Console.WriteLine("Input cannot be null or empty or only space. Please enter a valid name:");
            }
            Console.WriteLine($"Original word : {word}");
            Console.WriteLine($"Reversed word : {ReverseWord(word).ToLower()}");
        }

        private static string ReverseWord(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}


/*
 * 7.
 *      Enter a word and check it is palindrome or not.
 *      Input: dad = palindrome
 *      Input: mom = palindrome
 *      Input: good = not a palindrome
 */


/*
 * 8. Enter a sentence and display the frequency of each word.
 */


/*
 * 9. Enter a word and remove the duplicate letters.
 *      Input: teen
 *      Output: tn
 */


/*
 * 10. Enter 10 names in a string array and display only those names which are starting with “H”.
 */


/*
 *  11. Replace (.) with (,) and vice versa in the following string:
        Input: “Sanjay.Rahul.Gautam,tina.farooq,yash.ketan”
        Output: “Sanjay,Rahul,Gautam.tina,farooq.yash,ketan”
 */


/*
 * 12. String str = “Client ID: A1234
 *      Account Number: P12345
 *     Extract the Client ID, Account Number and Account amount and display them.
 */


/*
 * 13.  Extract the last 10 numbers from the following phone numbers using string functions:
 *      Input: +91 9892345679           Output: 9892345679
        Input: +913 9862343629          Output: 9862343629
        Input: 986-234-3629             Output: 9862343629
        Input: 986 234 362 8            Output: 9862343628
 */


/*
 * REGEX TASK:
 */
/*
 * 1. Enter the following input and validate it:
 *      Email id, URL, PAN Card no, Aadhaar Card no, Phone no.
 */

/*
 * 2. Input: “Please feel free to contact me on abhishek.solanki@gmail.com
 * anytime between 10 am to 6 pm.”
 * Extract email id and timings using Regex.
 */
/*
 * 3. Extract the last 10 numbers from the following phone numbers using
 * Regex functions:
 * Input: +91 9892345679 Output: 9892345679
 * Input: +913 9862343629 Output: 9862343629
 * Input: 232-888-986-234-3629 Output: 9862343629
 * Input: 101 986 234 362 8 Output: 9862343628
 */

/*
 * DATE TIME TASK:
 */

/*
 * 1. Enter any random date and print it is weekday or weekend.
 */

/*
 * 2. Enter your birth date and print the current age.
 */

/*
 * 3. Enter your and your sibling’s birth date and print the age difference.
 */

/*
4. Enter your birthdate and print on which weekday you were born.
Input: 3/4/2015
Output: I was born on Friday.
5. If the age of a person is 400000459 seconds find his date of birth.
6. String str[]={“14/05/2024”, “05/01/1987”, “21/08/1988”,
“29/05/2016”, “25/12/2027”, “21/05/2030”, “24/05/2024”}
In the output separate the past, present and future dates from the
above string array.

7. Enter your birth date and print this year on which weekday your
birthday is.
Input: 3/4/2015
Output: This year (2024) my birthday falls on Wednesday.
COLLECTION TASK:
1. Create a List / Array List of Stationary items and perform insert,
delete and search operation.
2. String str= “London Tokyo Paris Sydney Toronto Berlin Mumbai
Beijing Dubai Los-Angeles Singapore Rome Istanbul São-Paulo
Chicago Madrid Shanghai Seoul Hong-Kong Buenos Aires Moscow
Amsterdam Cairo Delhi”
 Create a list of cities from the above string.
3. Create a dictionary of state names and their capital and perform
insert, delete and search operation.
EXCEPTION HANDLING:
1. Enter two numbers and handle division by zero exception.
2. Enter numbers in an array and handle array index out of bound
exception.
3. Enter a value and handle number format exception.
4. Enter a value and handle format exception.
5. Handle all the above-mentioned exceptions using try with multiple
catch method.
6. Combine the scenarios from the Question 1 and 2 and implement the
nested try catch concept. It should handle the exceptions from both the
scenarios.
7. Perform a task to deposit and withdraw money using functions and
switch case. Display a custom exception message if the balance
amount goes below Rs.1000 during withdrawal transaction.
 */