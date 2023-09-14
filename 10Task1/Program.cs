Console.WriteLine("Hello, Евгений!");

//Задание 1
// char ch = ' ';
// int counter = 0;
// for (int i = 0; ch != '.'; ++i)
// {
//     ch = Console.ReadKey().KeyChar;
//     if (ch == ' ') { counter++; }
// }
// Console.WriteLine();
// Console.WriteLine(counter);


//Задание 5
// int num = Int32.Parse(Console.ReadLine());
// int[] arr = new int [num.ToString().Length];
// for (int i = 0; i < arr.Length; ++i)
// {
//     arr[i] = num % 10;
//     num = num / 10;
// }
//
// arr.Reverse();
//
// for (int i = 0; i < arr.Length; ++i)
// {
//     Console.Write(arr[i]);
// }


//Задание 3
// char[] input = Console.ReadLine().ToCharArray();
//
// for (int i = 0; i < input.Length; ++i)
// {
//     if (input[i] >= 32 && input[i] <= 90)
//     {
//         input[i] = (char)(input[i] + 32);
//     }
//     else if (input[i] >= 97 && input[i] <= 122)
//     {
//         input[i] = (char)(input[i] - 32);
//     }
// }
// Console.WriteLine(string.Join("", input));


//Задание 9
// int num = 234 - (234 % 7);
// Console.WriteLine(num / 7);


//Задание 4
// Console.WriteLine("Число A");
// int A = Int32.Parse(Console.ReadLine());
// Console.WriteLine("Число B");
// int B = Int32.Parse(Console.ReadLine());
// Console.WriteLine();
//
// for (int i = A; i <= B; ++i, ++A)
// {
//     for (int j = A; j > 0; --j)
//     {
//         Console.Write(A);
//     }
//     Console.WriteLine();
// }


//Задание 8
// int num = 456 - (456 % 100);
// num = num / 100;


//Задание 14
// float first = 123.456f;
// float second = 113.456f;
//
// //Ток не дурак, он идет по самому легкому пути
// if (first > second)
// {
//     Console.WriteLine(first);
// }
// else
// {
//     Console.WriteLine(second);
// }


//Задание 6
// int first = Int32.Parse(Console.ReadLine());
// int second = Int32.Parse(Console.ReadLine());
// int third = Int32.Parse(Console.ReadLine());
//
// Console.WriteLine("{0},   {1},   {2}", first, second, third);


//Задание 2
Console.WriteLine("Впишш 6 значное число");
int ticket = Int32.Parse(Console.ReadLine());

int firstHalf = 0;
int secondHalf = 0;
string ticketStr = ticket.ToString();
string firstHalfStr = ticketStr.Substring(0, 3);
string secondHalfStr = ticketStr.Substring(3, 3);


for (int i = 0; i < 3; ++i)
{
    firstHalf += Int32.Parse(firstHalfStr[i].ToString());
}
for (int i = 0; i < 3; ++i)
{
    secondHalf += Int32.Parse(secondHalfStr[i].ToString());
}

if (secondHalf == firstHalf)
{
    Console.WriteLine("Тебе повезло!");
}
else
{
    Console.WriteLine("Тебе не повезло!");
}

