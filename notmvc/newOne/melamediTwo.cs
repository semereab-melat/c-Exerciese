// // See https://aka.ms/new-console-template for more information
public class melamediTwo
{

    //program and compute the sum of the digits of an integer. i.e 12 = 1+2 = 3
    public void SumOfNumbers(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine("Sum of the digits of the said integer: " + sum);
    }

    //program to reverse the words of a sentence.
    public void reverseWords(string v)
    {
        string[] words = v.Split(new[] { " " }, StringSplitOptions.None);
        string em = "";
        List<string> lists = new();
        for (int i = words.Length - 1; i >= 0; i--)
        {
            em += words[i] + " ";
        }
        lists.Add(em);
        foreach (var item in lists)
        {
            Console.WriteLine("Reverse String is " + item);
        }

    }
    //program to find the size of a specified file in bytes.
    public void SizeOfFile()
    {
        FileInfo file = new FileInfo("c#exercise.txt");
        Console.WriteLine("The size of the file is:" + ((byte)file.Length));
        // output -- The size of the file is:1354 using ToString()
        //output -- The size of the file is:74 using (byte)
    }

    //program to convert a hexadecimal number to decimal number
    public void haxaToDecimal()
    {
        string hexval = "4B0";
        Console.WriteLine("Hexadecimal number: " + hexval);
        int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("Convert to-");
        Console.WriteLine("Decimal number: " + decValue);
    }
    //program to multiply corresponding elements of two arrays of integers

    public int[] multiplyCorrosponding()
    {
        int[] arr1 = new int[] { 1, 3, -5, 4 };
        int[] arr2 = new int[] { 1, 4, -5, -2 };

        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", arr1));
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", arr2));

        int[] finalArr = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            finalArr[i] = arr1[i] * arr2[i];
        }
        return finalArr;
    }

    //program to create a new string of four copies, taking last four characters from a given string.
    // If the length of the given string is less than 4 return the original one.
    public string StringCopier(string str)
    {
        //if the given dtring has less than four length
        int len = str.Length;
        string words = "";

        if (len < 4)
        {
            return str;
        }
        words = str.Substring(str.Length - 4);
        return words;
    }

    //C# program to check if a given positive number is a multiple of 3 or a multiple of 7
    internal string multipleofFiveOrSeven(int num)
    {
        //return num%3 == 0 || num%7 == 0 ? true : false;
        return num % 3 == 0 || num % 7 == 0 ? "The num is multiply of 3 or 7" : "The number is not multiply of 3 or 7";
    }

    //C# program to check if a string starts with a specified word.
    internal void StatsWith(string v)
    {
        string[] word = v.Split(" ");
        //Console.WriteLine(string.Join("", word));
        if (word[0].Equals("Hello", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("The sentence or word starts with Hello!");
        }
        else
        {
            Console.WriteLine("The sentence or word doesn't starts with Hello!");
        }
    }

    //C# program to check two given numbers where one is less than 100 and other is greater than 200
    internal string CheckGreaterOrLess(int num1, int num2)
    {
        return num1 < 100 && num2 > 200 || num1 > 200 && num2 < 100 ?
        "One of the number is greater than 200 and the aother is less than 100" :
         "The given numbers doesn't satisfied the given condition";
    }

    // C# program to check if an integer (from the two given integers) is in the range -10 to 10
    internal string CheckBetweentenAndNegTen(int num1, int num2)
    {
        return num1 >= -10 && num1 <= 10 || num2 >= -10 && num2 <= 10 ?
         "One or both numbers is between -10 and 10" :
         "Both numbers are not in the range of -10 and 10";
    }

    //C# program to find the largest and lowest values from three integer values.
    internal void largestAndLowestValue(int v1, int v2, int v3)
    {
        int[] nums = new int[] { v1, v2, v3 };
        Console.WriteLine(nums.Max());
        Console.WriteLine(nums.Min());

    }

    // Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times
    // internal string AppearanceOFChar(string v)
    // {
    //     char[] word = v.ToCharArray();
    //     int sum = 0;
    //     for (int i = 0; i < v.Length; i++)
    //     {
    //         if (word[i] == 'w')
    //         {
    //             sum++;
    //         }
    //     }
    //     Console.WriteLine(sum);
    //     return sum >= 1 && sum <= 3 ?
    //      "The given word has between 1 and 3 W's" :
    //      "The given word doesn't has between 1 and 3 W's";
    // }

    internal string AppearanceOFChar(string str)
    {
        var count = str.Count(w => w == 'w');
        Console.WriteLine(count);

        return count >= 1 && count <= 3 ?
         "The given word has between 1 and 3 W's" : "The given word doesn't has between 1 and 3 W's";
    }
















}


