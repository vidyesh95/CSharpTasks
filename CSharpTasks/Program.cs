// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("Task and solutions!");*/

/*
 * LEVEL 1 & 2 TASK
 *
 * 1. Perform all Mathematical operations (i.e., addition, subtraction, multiplication, division, Modulus division)
 * with numbers.
 */
/*decimal total = 0m;
decimal tempValue = 0m;
while (true)
{
    Console.WriteLine("Enter two numbers to perform all Mathematical operations");

    Console.WriteLine("Enter first number");
    decimal num1;
    while (!decimal.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    Console.WriteLine("Enter second number");
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
    var stringOperation = Console.ReadLine();

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
Console.WriteLine("Enter a number to check it is even or odd");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine(number % 2 == 0 ? "Number is even" : "Number is odd");

/*
 * 6. Enter 10 numbers and find sum of all numbers.
 */
/*
 * 7. Enter number and find its factorial.
 */
/*
 * 8. Print Fibonacci series. (0 1 1 2 3 5 8 ….)
 */
/*
 * 9. Enter three-digit number and display the sum of digits(Example: Input - 123 Output - 6).
 */
/*
 * 10. Enter three-digit number and display its reverse(Example: Input - 123 Output - 321).
 * 11. Enter a number and print its prime or not.
 * 12. Print multiplication table of a number entered by user.
 * 13. Enter year and print it is leap year or not.
 * 14. Enter a number and print it is palindrome or not.
 * 15. Enter a number and print it is Armstrong or not.
 * 16. Create Calculator program using switch case.
 * 17. Print all whole numbers between 20 to 50.
 * 18. Print greater among two numbers using ternary operator.
 * 19. Enter a number and print it is positive or negative.
 * 20. Enter marks and check pass or fail.
 * 21. Enter marks and print according to criteria:
 *     70-100 ->distinction
 *     50-70 -> first class
 *     40-45 -> second class
 *     <40 -> fail
 * 22. Print all prime numbers between 1 to 100.
 * 23. Enter day name (Example: Monday, Tuesday, etc.) and print it is weekday or weekend using switch case.
 * 24. Print all even numbers between 1 to 50.
 * 25. Write a login program to enter username and password, continue the loop till the user enters correct credentials.
 * 26. Enter age and print the eligibility to vote using goto statement.
 * 27. Find the minimum or maximum element from the Array.
 * 28. Accept 10 numbers from the user in the array and perform sorting.
 * 29. Accept 10 numbers in an array and reverse the values (without using any inbuilt functions)
 * 30. Accept 10 numbers in an array and print which numbers are even or odd.
 * 31. Create two arrays with 5 numbers in each. Merge all the numbers in the third array in sorted order.
 * 32. Accept values in 2D array and perform matrix Addition and multiplication.
 * 33. Accept 10 numbers in an array and calculate sum of all the elements.
 * 34. Accept 10 numbers in an array and calculate average of all the elements.
 * 35. Insert a new element in a particular position of an array and display the array.
 * 36. Delete an already existing element from an array and display the array.
 * 37. Print the following patterns:
1) * 2) 1 3) 1 4) 1
** 1 2 2 2 2 3
*** 1 2 3 3 3 3 4 5 6
 **** 1 2 3 4 4 4 4 4 7 8 9 10
5) 6) 7)
 * * *
 * * * * * * *
 * * * * * * * * * * *
* * * * * * * * * * * * * * *
8) 9) 10)
1
2*
33*
444*
5555*
11) 12) 13)
********
*******
******
*****
****
***
**
*
14) 15) 16)
5
54
543
5432
54321
17) 18) 19) 20) $
 # #
 $ $ $
 # # # #
38. Print the following patterns using 2D Array :
1) * 2) 1 3) 1 4) 1
** 1 2 2 2 2 3
*** 1 2 3 3 3 3 4 5 6
 **** 1 2 3 4 4 4 4 4 7 8 9 10
5) 6) 7)
 * * *
 * * * * * * *
 * * * * * * * * * * *
* * * * * * * * * * * * * * *
LEVEL 3 TASK
1. Swap two number using Call by Value and Call by Reference.
2. Calculate area and circumference of circle using functions (with
return type and without return type)
3. Calculate area of rectangle using out parameter.
4. Display max and min number from the following string array:
{“1”, “Rohan”, “Avinash”, “5”, “tina”, “100”, “Rahul”, “38”}
5. Calculate sum of numbers from the string array:
{“1”, “Sona”, “David”, “50”, “Fardeen”, “19”, “Rishi”, “68”}
6. Calculate the sum of Integer values as well as decimal values
separately from the given string array:
{“1”,”10.5”,”11”,”12.5”,”14”,”15.5”,”16”,”17”,”18.5”}
7. Accept the Number of Students from 1st std to 5th std, Accept their
Name and Roll no from user and display them using Jagged Array.
LEVEL 4 TASK
STRING TASK:
1. Enter a sentence and find the number of spaces, words, vowels and
consonants.
2. Enter a sentence and capitalize first letter of each word.
Input: my name is tom.
Output: My Name Is Tom.
3. Input: Rohan.Singh@featsystems.com
Output: First name: Rohan
 Last name: Singh
 Company: featsystems
4. Input: “Please feel free to contact me on abhishek.solanki@gmail.com
anytime between 10 am to 6 pm.”
Output: abhishek.solanki@gmail.com
5. Enter a name and display the frequency of each letter.
Input: address
Output: a =01, d=02, r=01, e=01, s=02
6. Enter a word and reverse it.
Input: Sunday Output: yadnus
7. Enter a word and check it is palindrome or not.
Input: dad = palindrome
Input: mom = palindrome
Input: good = not a palindrome
8. Enter a sentence and display the frequency of each word.
9. Enter a word and remove the duplicate letters.
 Input: teen Output: tn

10. Enter 10 names in a string array and display only those names
which are starting with “H”.
11. Replace (.) with (,) and vice versa in the following string:
 Input: “Sanjay.Rahul.Gautam,tina.farooq,yash.ketan”
 Output: “Sanjay,Rahul,Gautam.tina,farooq.yash,ketan”
12. String str = “Client ID: A1234
 Account Number: P12345
 Account Amount: 5690350”
Extract the Client ID, Account Number and Account amount and
display them.
13)Extract the last 10 numbers from the following phone numbers using
string functions:
Input: +91 9892345679 Output: 9892345679
Input: +913 9862343629 Output: 9862343629
Input: 986-234-3629 Output: 9862343629
Input: 986 234 362 8 Output: 9862343628
REGEX TASK:
1. Enter the following input and validate it:
Email id, URL, PAN Card no, Aadhaar Card no, Phone no.
2. Input: “Please feel free to contact me on abhishek.solanki@gmail.com
anytime between 10 am to 6 pm.”
Extract email id and timings using Regex.
3. Extract the last 10 numbers from the following phone numbers using
Regex functions:
Input: +91 9892345679 Output: 9892345679
Input: +913 9862343629 Output: 9862343629
Input: 232-888-986-234-3629 Output: 9862343629
Input: 101 986 234 362 8 Output: 9862343628
DATE TIME TASK:
1. Enter any random date and print it is weekday or weekend.
2. Enter your birth date and print the current age.
3. Enter your and your sibling’s birth date and print the age difference.
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