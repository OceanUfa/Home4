/* Напишите программу, которая принимает на вход длину массива и в последующих строках элементы массива.
5
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
3
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[a];


for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Введите число массива: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}


Console.Write("Итог: [");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(" " + Method(i) + " ");
}
Console.Write("]");

int Method(int a)
{
    return numbers[a];
}