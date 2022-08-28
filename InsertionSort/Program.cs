
int[] array = { 8, 5, 2, 9, 5, 6, 3 };
int[] result = InsertionSort(array);
foreach (var item in result)
{
	Console.Write(" " + item);
}
Console.ReadKey();

int[] InsertionSort(int[] array)
{
	for (int i = 1; i < array.Length; i++)
	{
		int j = i;
		while (j > 0 && array[j] < array[j-1])
		{
			Swap(j, j - 1, array);
			j--;
		}
	}
    return array;
}
void Swap(int i, int j, int[] array)
{
	int temp = array[i];
	array[i] = array[j];
	array[j] = temp;
}