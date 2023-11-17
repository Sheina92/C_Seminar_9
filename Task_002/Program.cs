// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
    
} 
  
void PrintSumNumbers(int M, int N)
{ 
    int start = Math.Min (M, N);
    int end = Math.Max (M, N);
    int sum = 0;

    for (int i = start; i <= end; i++)
    {
         sum += i;
    }

    Console.WriteLine("Сумма натуральных чисел: " + sum);
}

//.......................................................

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
PrintSumNumbers(M, N);

