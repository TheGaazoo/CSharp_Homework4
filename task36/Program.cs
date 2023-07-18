void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
}
Console.Clear();
int summa_nechet = 0;
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
for (int i = 0; i < array.Length; i = i + 2)
    summa_nechet = summa_nechet + array[i];
Console.WriteLine($"Сумма нечетных элементов массива = {summa_nechet}");
