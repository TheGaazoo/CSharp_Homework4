void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(new Random().Next(100, 999)) / 100;
}
Console.Clear();
double min = Int32.MaxValue;
double max = Int32.MinValue;
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
for (int z = 0; z < array.Length; z++)
{
    if (array[z] > max)
            max = array[z];
    if (array[z] < min)
            min = array[z];
}
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {max - min}");
