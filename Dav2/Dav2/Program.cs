//1) შექმენით კონსოლური აპლიკაცია, რომელიც შეასრულებს მარტივ არითმეტიკულ ოპერაციებს რიცხვებზე.
//* გამოაცხადეთ ორი ცვლადი
//* შეასრულეთ მიმატების, გამოკლების, გამრავლების, გაყოფისა და ნაშთის ოპერაციები.
//* შედეგები დაბეჭდეთ კონსოლში

int a = 16;
int b = 31;
Console.WriteLine("Addition: " + (a + b));
Console.WriteLine("Subtraction: " + (a - b));
Console.WriteLine("Multiplication: " + (a * b));
Console.WriteLine("Division: " + ((double)a / b));
Console.WriteLine("Modulus: " + (a % b));
#endregion







//2) წარმოაჩინეთ float, double და decimal შორის სიზუსტის სხვაობა:
//*შექმენით სამი ცვლადი float, double და decimal ტიპებით. თითოეულს მიანიჭეთ მნიშვნელობად 1.0/7.0 ზე
//* თითოეული ცვლადი გაამრავლეთ 7 ზე
//* დაბეჭდეთ თითოეული შედეგი და შეადარეთ


float floatValue = 1.0f / 7.0f;
double doubleValue = 1.0 / 7.0;
decimal decimalValue = 1.0m / 7.0m;

Console.WriteLine("\nFloat Result: " + (floatValue * 7));
Console.WriteLine("Double Result: " + (doubleValue * 7));
Console.WriteLine("Decimal Result: " + (decimalValue * 7));

#endregion




//3) გადაიყვანეთ სხვადასხვა მონაცემთა ტიპები განსხვავებულ ტიპებში
//* გამოაცხადეთ int, double, float და decimal ტიპის ცვლადები
//* მიანიჭეთ თითეულ მათგანს მნიშვნელობები
//* შეასრულეთ explicit და implicit კონვერტაციებით ამ ტიპებს შორის (სადაც რომელია შესაძლებელი)


float f = 1.0f / 7.0f;
double d = 1.0 / 7.0;
decimal dec = 1.0m / 7.0m;
f = f * 7;
d = d * 7;
dec = dec * 7;
Console.WriteLine("float: " + f);
Console.WriteLine("double: " + d);
Console.WriteLine("decimal: " + dec);

Console.WriteLine("\nPrecision Comparison:");
Console.WriteLine($"Float precision: {f == 1.0f}");
Console.WriteLine($"Double precision: {d == 1.0}");
Console.WriteLine($"Decimal precision: {dec == 1.0m}");

Console.WriteLine();
Console.WriteLine();



#endregion





//4) შექმენით კონსოლური აპლიკაცია, როკმელიც ორ ცვლადს მნიშვნელობას გაუცვლის.
//მაგ.:
//before:
//int x = 5;
//int b = 10;

//after:
//int x = 10;
//int b - 5;

int x = 5;
int b = 10;

Console.WriteLine($"\nBefore: x = {x}, y = {y}");

// Swap
int temp = x;
x = y;
y = temp;

Console.WriteLine($"After: x = {x}, y = {y}");

#endregion






//5) შექმენით კონსოლური აპლიკაცია, რომელიც დაითვლის BMI (Body Mass Index) მნიშვნელობას და ამის შესაბამისად
//დაბეჭდავს რჩევებს.
//* შემოატანინეთ მომხმარებელს კონსოლიდან ინფორმაცია - სიმაღლე და წონა (https://www.geeksforgeeks.org/console-readline-method-in-c-sharp/)
//*დაითვალეთ BMI https://en.wikipedia.org/wiki/Body_mass_index
//*მიღებული შედეგების მიხედვით დაბეჭდეთ სხვადასხვა რჩევები

//პასუხები გაუშვით GitHub ზე და ლინკები ატვირთეთ აქ. შეგიძლიათ ყველა დავალება 1 კონსოლურ აპლიკაციაში შეასრულოთ და რამენაირად გამოყოთ ვიზუალურად (მაგ.: // -------------------- კომენტარით) 

Console.Write("insert weight in double, use kg-s: ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.Write("insert height in double, use meters: ");
double height = Convert.ToDouble(Console.ReadLine());

double bmiResult = weight / Math.Pow(height, 2);
Console.WriteLine($"Your BMI is : {bmiResult}");

if (bmiResult < 16.0)
    Console.WriteLine("Category: Underweight (Severe thinness)");
else if (bmiResult >= 16 && bmiResult <= 16.9)
    Console.WriteLine("Category: Underweight (Moderate thinness)");
else if (bmiResult >= 17 && bmiResult <= 18.4)
    Console.WriteLine("Category: Underweight (Mild thinness)");
else if (bmiResult >= 18.5 && bmiResult <= 24.9)
    Console.WriteLine("Category: Normal range");
else if (bmiResult >= 25 && bmiResult <= 29.9)
    Console.WriteLine("Category: Overweight (Pre-obese)");
else if (bmiResult >= 30 && bmiResult <= 34.9)
    Console.WriteLine("Category: Obese (Class I)");
else if (bmiResult >= 35 && bmiResult <= 39.9)
    Console.WriteLine("Category: Obese (Class II)");
else if (bmiResult >= 40)
    Console.WriteLine("Category: Obese (Class III)");
else
    Console.WriteLine("Program does not have your category");

Console.WriteLine();
Console.WriteLine();
Console.ReadKey();
#endregion
