using System.Diagnostics.Metrics;

//1.შექმენით კონსოლური აპლიკაცია რომელიც ხმოვანებს დაითვლის
//* მომხმარებელს შეაყვანინეთ input
//* მიღებულ input ში დაითვალეთ ხმოვნები
//* დაბეჭდეთ სულ რამდენი ხმოვანი იყო

//Enter a string: Hello World
//Number of vowels: 3


//Console.WriteLine("Enter Word here");
//string vowels = "aeiouAEIOU";
//int count = 0;
//String s=Console.ReadLine();
//for (int i = 0; i < s.Length; i++)
//{
//    if (vowels.Contains(s[i])) count++;
//}
//Console.WriteLine("numerofvowels:" +count );





//2.შექმენით კონსოლური აპლიკაცია, რომელიც დააგენერირებს და შეინახავს გამრავლების ტაბულას მასივში და შემდეგ მის მნიშვნელობებს დაბეჭდავს.
//მაგ.:
//Enter a number: 5
//Multiplication Table of 5:
//5 x 1 = 5
//5 x 2 = 10
//...
//5 x 10 = 50

//Console.WriteLine("enter a numer");


//int[] MUltiplicatenumers = new int[10];
//String w = Console.ReadLine();
//int n = int.Parse(w);
//int MaxValue = 9;

//int Minvalue = 1;
//for (int i = 1; i < 10; i++)
//{
//    int m = i * n;
//    Console.WriteLine(i + "*" + n + "=" + m);
//}






//3. მატრიცების შეკრება:
//*შექმენით ორი 3x3 ზე მატრიცა (ორ განზომილებიანი მასივი)
//* მოხმარებელს შეავსებინეთ მატრიცაში მნიშვნელობები
//* შეკრიბეთ მატრიცები https://en.wikipedia.org/wiki/Matrix_addition

//int[,] matrix1 = new int[3, 3];

//int[,] matrix2 = new int[3, 3];
//int[,] matrix3 = new int[3, 3];
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        String w = Console.ReadLine();
//        int n = int.Parse(w);
//        matrix1[i, j] = n;

//    }
//}

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        String w = Console.ReadLine();
//        int n = int.Parse(w);
//        matrix2[i, j] = n;

//    }
//}
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {

//        matrix3[i, j] = matrix1[i, j] + matrix2[i,j];
//        Console.WriteLine(matrix3[i, j]+" ");
//    }

//}




//4.შექმენით კონსოლური კალკულატორი რომელსაც მენიუ ექნება. კალკულატორი მანამდე უნდა მუშაობდეს
//სანამ მომხმარებელს არ მოუნდება მისი გათიშვა.
//მაგ.:
//Calculator Menu:
//1) Addition
//2) Subtraction
//3) Multiplication
//4) Division
//5) Exit
//Choose an option: 1
//Enter first number: 10
//Enter second number: 5
//Result: 15
//[The menu repeats until the user selects Exit]

//Console.WriteLine("calculator" );

//String x = Console.ReadLine();
//int n = int.Parse(x);


//while (n != 5)
//{
//    String y = Console.ReadLine();
//    int m = int.Parse(y);


//    String t = Console.ReadLine();
//    int v = int.Parse(t);
//    if (n == 1)
//    {
//        int res = m + v;
//        Console.WriteLine("result " + res);
//    }
//    if (n == 2)
//    {
//        int res = m - v;
//        Console.WriteLine("result " + res);
//    }
//    if (n == 3)
//    {
//        int res = m * v;
//        Console.WriteLine("result " + res);
//    }
//    if (n == 4)
//    {
//        int res = m / v;
//        Console.WriteLine("result " + res);
//    }
//    x = Console.ReadLine();
//    n = int.Parse(x);
//}
//Console.WriteLine("stop");

