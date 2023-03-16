
//functions call
Snack1();
Snack2();
Snack3();
Snack4();
Snack5();
Snack6();
Snack7();
Snack8();
Snack9();
Snack10();
Snack11();
Snack12();

//functions
void Snack1()
{
    Console.Write("Digit the first number: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Digit the second number: ");
    int n2 = Convert.ToInt32(Console.ReadLine());
    if (n1 == n2)
    {
        Console.WriteLine($"Both numbers are equals to: {n1}");
    }
    else if(n1 > n2)
    {
        Console.WriteLine($"The greater number is: {n1}");
    }
    else
    {
        Console.WriteLine($"The greater number is: {n2}");   
    }
    
    Console.WriteLine("----------------------");
}

void Snack2()
{
    Console.Write("Write a word: ");
    string s1 = Console.ReadLine() ?? "";
    
    Console.Write("Write another word: ");
    string s2 = Console.ReadLine() ?? "";
        
    if(s1.Length < s2.Length)
    {
        Console.WriteLine("{0} {1}", s1, s2);
    }
    else
    {
        Console.WriteLine("{0} {1}", s2, s1);
    }
    
    Console.WriteLine("----------------------");

}

void Snack3()
{
    int sum = 0;
    for(int i = 0; i < 10; i++)
    {
        Console.Write("Digit a number: ");
        sum += Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"The sum of all numbers is: {sum}");
    Console.WriteLine("----------------------");

}

void Snack4()
{
    int sum = 0;
    int totalNumbers = 0;
    for(int i = 2;  i <= 10; i++)
    {
        totalNumbers++;
        sum += i;
    }
    int average = sum / totalNumbers;
    Console.WriteLine("The sum of the numbers from 2 to 10 is: {0}", sum);
    Console.WriteLine("The average number is: {0}", average);
    Console.WriteLine("----------------------");
}

void Snack5()
{
    Console.Write("Digit a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n % 2 is 0) Console.WriteLine("{0} is pair", n);
    Console.WriteLine("----------------------");
}

void Snack6()
{
    string[] invites =
    {
        "Francesco",
        "Marco",
        "Paolo",
        "Carlo",
        "Piero",
        "Giovanni"
    };
    Console.WriteLine("What's your name?");
    string name = Console.ReadLine() ?? "";
    if(invites.Contains(name, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine("You're invited to the party.");
    }
    else
    {
        Console.WriteLine("You're not invited to the party.");
    }
    Console.WriteLine("----------------------");
}

void Snack7()
{
    int[] numbers = new int[6];
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write("Digit a number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        if(x % 2 is 1) numbers[i] = x;
    }

    foreach(int i in numbers)
    {
        if(i % 2 is 1) Console.Write($"{i}; ");
    }
    Console.WriteLine("");
    Console.WriteLine("----------------------");
}

void Snack8()
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
    int sum = 0;
    //Se si conta numbers[0] come posizione 1
    for(int i = 0;  i <= numbers.Length; i+= 2)
    {
        sum += numbers[i];
    }
    //se si conta invece numbers[0] come posizione 0
    //for (int i = 1; i <= numbers.Length; i += 2)
    //{
    //    sum += numbers[i];
    //}
    Console.WriteLine(sum);
    Console.WriteLine("----------------------");
}

void Snack9()
{
    int[] numbers = new int[60];
    
    int i = 0;
    do
    {
        Console.Write("Digit a number: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }while (i < 50);
    
    Console.WriteLine("----------------------");
}

void Snack10(){
    Console.Write("How many array should we create? ");
    int n = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    for(int i = 0; i < n; i++)
    {
        var numbers = new int[10];
        for(int j = 0; j < 10; j++)
        {
            numbers[j] = rnd.Next(1, 100);
        }

        foreach (var item in numbers)
        {
            Console.Write($"{item}; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("----------------------");

}

void Snack11()
{
    Console.Write("Write a word: ");
    string wrd1 = Console.ReadLine() ?? "";

    Console.Write("Write another word: ");
    string wrd2 = Console.ReadLine() ?? "";

    StrLength(wrd1 , wrd2);

    Console.WriteLine("----------------------");
}


void Snack12()
{
    Console.Write("Digit a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    OddOrEven(num);
}

void StrLength(string str1, string str2)
{
    if (str1.Length == str2.Length) 
    {
        Console.WriteLine("{0} {1}", str1, str2);
    }
    else if (str1.Length > str2.Length)
    {
        Console.WriteLine("{0}", str1);
    }
    else
    {
        Console.WriteLine("{0}", str2);
    }
}

void OddOrEven(int n)
{
    if (n % 2 is 0) Console.WriteLine("The number {0} is even", n);
    else Console.WriteLine("The number {0} is odd", n);
}