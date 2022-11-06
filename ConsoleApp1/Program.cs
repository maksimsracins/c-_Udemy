using System;
using System.Text;

class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Writeline");
    }
    static void Homework5()
    {
        System.Console.Write("First value: ");
        int input1 = int.Parse(System.Console.ReadLine());
        System.Console.Write("Second value: ");
        int input2 = int.Parse(System.Console.ReadLine());

        int maxValue = input1 > input2 ? input1 : input2;
        Console.WriteLine($"Max value is: {maxValue}");
    }
    static void IndexWeight()
    {
        Console.WriteLine("Please enter surname:");
        string surname = Console.ReadLine();
        Console.WriteLine("Please enter name:");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter height:");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter weight:");
        double weight = double.Parse(Console.ReadLine());

        double resultIMT = weight / (height * height);

        Console.WriteLine($"Your profile: \n Full name: {surname}, {name} \n Age: {age} \n Weight: {weight} \n Height:{height} \n Body Mass Index: {resultIMT}");
    }
    static void Howework1_4()
    {
        Console.WriteLine("Please enter 1st value: ");
        double value1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter 2nd value: ");
        double value2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter 3rd value: ");
        double value3 = Convert.ToDouble(Console.ReadLine());

        double p = (value1 + value2 + value3) / 2;

        double S = Math.Sqrt(p * (p - value1) * (p - value2) * (p - value3));

        Console.WriteLine($"{S} cm^2");

    }
    static void Homework1_3(){
        string name = Console.ReadLine();
    Console.WriteLine($"Hello,{name}");

        Console.WriteLine("Please enter first value: ");
        var input1 = Console.ReadLine();
    int firstVar = Convert.ToInt32(input1);

    Console.WriteLine("Please enter second value: ");
        var input2 = Console.ReadLine();
    int secondVar = Convert.ToInt32(input2);

    int temp = 0;

    temp = firstVar;
        firstVar = secondVar;
        secondVar = temp;

        Console.WriteLine($"This is value of first value: {firstVar}");
        Console.WriteLine($"This is value of second value: {secondVar}");


        Console.WriteLine("Please enter value: ");
        var input3 = Console.ReadLine();
    int input3Int = Convert.ToInt32(input3);

    Console.WriteLine(input3Int.ToString().Length);}
    static void DateTimeFunctions()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString());

        Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");

        DateTime dt = new DateTime(2022, 09, 12);
        DateTime newDt = dt.AddDays(1);
        Console.WriteLine(newDt);

        TimeSpan timeSpan = now - dt;
        timeSpan = now.Subtract(dt);
        Console.WriteLine(timeSpan.Days);
    }
    static void IntroToArray()
    {
        int[] a1;
        a1 = new int[10];

        int[] a2 = new int[5];

        int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

        int[] a4 = { 1, 3, 2, 4, 5 };
    }
    static void MathClassOperations()
    {
        Console.WriteLine(Math.Pow(2, 3));
        Console.WriteLine(Math.Sqrt(9));
        Console.WriteLine(Math.Round(1.7));
        Console.WriteLine(Math.Round(1.4));

        Console.WriteLine();
        Console.WriteLine(Math.Round(2.5));
        Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
        Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
    }
    static void CommentRules()
    {
        // a single-line comment

        /* Multi-line command
         * asd
         * asd
         */

        //description how and why! Not what.
    }
    static void CastingAndParsing()
    {
        byte b = 3; //0000 0011
        int i = b; //0000 0000 0000 0000 0000 0000 0000 0011
        long l = i; //0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

        float f = i; //3.0

        Console.WriteLine(f);

        b = (byte)i;
        Console.WriteLine(b);
    }
    static void ConsoleBasics()
    {
        Console.WriteLine("Hi, please tell me your name");

        string name = Console.ReadLine();
        string sentence = $"Your name is {name}";

        Console.WriteLine(sentence);

        Console.WriteLine("age: ");
        string input = Console.ReadLine();
        int age = int.Parse(input);
        Console.WriteLine(age);

        Console.Clear();
        //Console.BackgroundColor = ConsoleColor.Cyan;
        //Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.Write("New Style 1 ");
        Console.Write("New Style 2\n");
        Console.Write("New Style 3");
    }
    static void ComparingStrings()
    {
        string str1 = "abcde";
        string str2 = "abcde";

        bool areEq = str1 == str2;
        Console.WriteLine(areEq);

        areEq = string.Equals(str1, str2, StringComparison.Ordinal);
        Console.WriteLine(areEq);

       // string str1 = "Strasse";
       // string str2 = "Strasse";

        areEq = string.Equals(str1, str2, StringComparison.Ordinal);
        Console.WriteLine(areEq);
        areEq = string.Equals(str1, str2, StringComparison.InvariantCulture);
        Console.WriteLine(areEq);
        areEq = string.Equals(str1, str2, StringComparison.CurrentCulture);
        Console.WriteLine(areEq);
    }
    static void StringFormat()
    {
        string name = "Max";
        int age = 30;
        string str1 = string.Format("My name is {0} and I'm {1}", name, age);
        string str2 = $"My name is {name} and I'm {age} years old";

        Console.WriteLine(str1);
        Console.WriteLine(str2);

        string str3 = "My name is \nMax";
        Console.WriteLine(str3);

        string str4 = "I'm \t30";
        Console.WriteLine(str4);

        str3 = $"My name is {Environment.NewLine}Max";
        string str5 = "I'm Max and i'm good \"good\" progremmer";

        string str6 = @"C:\tmp\test_file.txt";
        Console.WriteLine(str5);
        Console.WriteLine(str6);

        double answer = 42.08;

        string result = string.Format("{0:f}", answer);
        string result2 = string.Format("{0:f1}", answer);

        Console.WriteLine(result);
        Console.WriteLine(result2);

        Console.OutputEncoding = Encoding.UTF8;

        double money = 12.9;
        result = string.Format("{0:C}", money);
        result2 = string.Format("{0:C2}", money);

        Console.WriteLine(money.ToString("C2"));
        Console.WriteLine(result2);

        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RUS");
        Console.WriteLine(money.ToString("C2"));
    }
    static void StringBuilderDemo()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("My ");
        sb.Append("name ");
        sb.Append("is ");
        sb.Append("Max");

        sb.AppendLine("!");
        sb.AppendLine("Check");

        string str = sb.ToString();
        Console.WriteLine(str);
    }
    static void StringModification()
    {
        string nameConcat = "abcdef";

        nameConcat = nameConcat.Remove(0, 1);
        Console.WriteLine(nameConcat);
        nameConcat = nameConcat.Replace('a', 'y');
        Console.WriteLine(nameConcat);
        string data = "12;28;34;25;64";
        string[] spliData = data.Split(';');
        string first = spliData[0];
        Console.WriteLine(first);

        char[] chars = nameConcat.ToCharArray();
        Console.WriteLine(chars[0]);
        Console.WriteLine(nameConcat[0]);

    }
    static void MathOperations()
    {
        int x = 1;
        int y = 2;

        bool areEqual = x == y;
        Console.WriteLine(areEqual);
        bool result = x > y;
        Console.WriteLine(result);

        result = x >= y;
        Console.WriteLine(result);

        result = x < y;
        Console.WriteLine(result);

        result = x <= y;
        Console.WriteLine(result);

        result = x != y;
        Console.WriteLine(result);
    }
    static void StringOperations()
    {
        string name = "abracadabra";
        bool result = name.Contains('a');
        Console.WriteLine(result);

        string abc = string.Concat('a', "b", 'c');
        Console.WriteLine(abc);

        name = "abracadabra";

        bool endsWithAbra = name.EndsWith("abra");
        Console.WriteLine(endsWithAbra);

        bool startsWithAbra = name.StartsWith("abra");
        Console.WriteLine(startsWithAbra);

        int indexOfA = name.IndexOf('b', 1);
        Console.WriteLine(indexOfA);

        int lastIndexOfR = name.LastIndexOf('r');
        Console.WriteLine(lastIndexOfR);

        Console.WriteLine(name.Length);

        string substri = name.Substring(5);
        Console.WriteLine(substri);

        string empty = "";
        string whiteSpaced = " ";
        string notEmpty = " b";
        string nullString = null;

        Console.WriteLine("is null or empty?!");

        bool isNullOrEmpty = string.IsNullOrEmpty(empty);
        Console.WriteLine(isNullOrEmpty);

        bool iswhiteSpaced = string.IsNullOrWhiteSpace(whiteSpaced);
        Console.WriteLine(iswhiteSpaced);

        bool isNotEmpty = string.IsNullOrEmpty(notEmpty);
        Console.WriteLine(isNotEmpty);

        bool isnullString = string.IsNullOrEmpty(nullString);
        Console.WriteLine(isnullString);
    }
}