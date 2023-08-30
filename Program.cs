Console.Clear();
Console.Write("Введите элементы массива через запятую: ");
string input = Console.ReadLine();
string[] inputArray = input.Split(',');

for (int i = 0; i < inputArray.Length; i++)
{
    inputArray[i] = inputArray[i].Trim();
}