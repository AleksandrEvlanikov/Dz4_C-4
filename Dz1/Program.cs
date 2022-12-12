Console.WriteLine("Введите число A ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int number1 = Convert.ToInt32(Console.ReadLine());

int result = 1;
  for (int i = 1; i <= number1; i++)
    result = result * number;

Console.WriteLine(result);

