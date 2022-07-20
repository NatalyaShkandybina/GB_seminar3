Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов: ");
for (int i = 1; i <= number; i++){
    Console.Write($"{i*i*i} ");
}