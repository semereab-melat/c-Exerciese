public class MultNumbers
{
    public void Mult(int consNumber)
    {
        Console.WriteLine("Please enter the number you want to multiply with 0 - 10: ");
        consNumber = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(consNumber * i);
        }
    }

    public bool palindrom(string word)
    {
        //palindrome -- example


        //palindrome with numbers
        int n, r, sum = 0, temp;
        Console.Write("Enter the Number: ");
        n = int.Parse(Console.ReadLine());
        temp = n;
        while (n > 0)
        {
            r = n % 10;
            sum = (sum * 10) + r;
            n = n / 10;
        }
        if (temp == sum)
            Console.Write("Number is Palindrome.");
        else
            Console.Write("Number is not Palindrome");


        // palindrome with String
        int i = 0; // first index
        int j = word.Length - 1; //last index

        while (true)
        {
            if (i > j)
            {
                return true;
            }
            char a = word[i];
            char b = word[j];
            if (a != b)
            {
                return false;
            }
            i++;
            j--;
        }

    }

    public static void Collected()
    {
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("you look like older than {0}{0}{0}{0}", age);
            for (int j = 1; j < 3; j += 2)
            {
                Console.WriteLine("you look like older than {0} {0} {0} {0}", age);

            }
        }

    }

    public static void MathsOperation()
    {

        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}", 10 % 3);

        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2);

        //swappinf two numbers without temp variable
        int x = 3;
        int y = 4;
        Console.WriteLine("The values are {0} and {1} before swapped!", x, y);

        x += y; //x = 7
        y = x - y; //y = 3
        x -= y; //x = 4
        Console.WriteLine("The values are {0} and {1} after swapped!", x, y);
    }

    public void reversedWord(string word)
    {

        int j = word.Length - 1;


        char[] cWord = word.ToCharArray();

        string temp = "";
        for (int last = j; last > -1; last--)
        {
            temp += cWord[last];
        }
        Console.WriteLine("the reversed of {0} is {1}", word, temp);
    }
    // Write a C# program that takes a number as input and then displays a rectangle of 3 columns
    // wide and 5 rows tall using that digit.
    public void rectangularNumber(int number)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

    }

    public void rectangularStar(char a)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }

    }

    public void fromCelToFar(double celcuis)
    {
        double res = (double)9 / 5;
        Console.WriteLine("{0} Celcuis to fahranite is: {1}", celcuis, (celcuis * res) + 32);

    }
    public double fromCelToFarRetunr(double celcuis)
    {
        double res = (double)9 / 5;
        return celcuis * res + 32;
    }
    //a method to remove a specified character from non-empty string

    public void removeChar(string word, int number)
    {
        Char[] chars = word.ToCharArray();
        Console.WriteLine(chars[3]);
        Console.WriteLine(word.Remove(number, 1));
    }

    //this method exchange the first and last chars of the given word
    public string ExchangeeChar(string ustr)
    {
        return ustr.Length > 1 ?
        ustr.Substring(ustr.Length - 1)
        + ustr.Substring(1, ustr.Length - 2)
        + ustr.Substring(0, 1)
        : ustr;
    }
    //create a new string from a given string (length 1 or more ) with the first character 
    //added at the front and back. 

    public string AddCharToFirstAndLast(string word)
    {
        string substrings = word.Substring(0, 1);
        if (word.Length > 1)
        {
            return substrings + word + substrings;
        }
        else
            return (word + " is too short! Try again!");
    }
    //to check two given integers and return true if one is negative and one is positive.
    public bool methodChecker(int num1, int num2)
    {
        if ((num1 > 0 && num2 < 0) || (num1 < 0 && num2 > 0))
        {
            return true;
        }
        else
            return false;
    }

    //to compute the sum of two given integers, if two values are equal then 
    //return the triple of their sum. 
    public int SumAndTriple(int num1, int num2)
    {
        return (num1 == num2 ? 3 * (num1 + num2) : num1 + num2);
    }

    // get the absolute value of the difference between two given numbers. Return double 
    //the absolute value of the difference if the first number is greater than second number.

    public int AbsoluteDouble(int num1, int num2)
    {
        return num1 > num2 ? 2 * (num1 - num2) : -1 * (num1 - num2);
    }

    //program to check if an given integer is within 20 of 100 or 200.
    //if a given number - 100 or number - 200 is 2o or less (<=20)
    public bool result(int n)
    {
        if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
            return true;
        return false;
    }
    //program to find the longest word in a string.

    public string LongestWord(string sentence)
    {
        string[] words = sentence.Split(" ");

        string longest = words[0];
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longest.Length)
            {
                longest = words[i];
            }
        }
        return longest;
    }

    // program to compute the sum of the first 500 prime numbers.
    private static bool isPrime(int n)
    {
        int x = (int)Math.Floor(Math.Sqrt(n));

        if (n == 1) return false;
        if (n == 2) return true;

        for (int i = 2; i <= x; ++i)
        {
            if (n % i == 0) return false;
        }

        return true;
    }

    public void SumOfPrimes()
    {

        Console.WriteLine("\nSum of the first 20 prime numbers: ");
        int sum = 0;
        int ctr = 0;
        int n = 2;
        while (ctr < 20)
        {
            if (isPrime(n))
            {
                sum += n;
                ctr++;
            }
            n++;
        }

        Console.WriteLine(sum);
    }









}