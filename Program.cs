namespace TestConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var numberFilter = new NumberFilter();
			var numbers = new List<int> { 5, 3, 8, 6, 2, 9, 4, 7, 1, 10 };

			var sortedEvenNumbers = numberFilter.FilterAndSortEvenNumbers(numbers);

			Console.WriteLine("Sorted Even Numbers: " + string.Join(", ", sortedEvenNumbers));
		}
	}
}
