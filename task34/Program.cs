void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
}
Console.Clear();
int count = 0;
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
        count++;
Console.WriteLine($"Количество четных элементов = {count}");