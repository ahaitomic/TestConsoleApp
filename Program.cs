namespace TestConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var testClass = new MyClass();
			var numbers = new List<int> { 5, 3, 8, 6, 2, 9, 4, 7, 1, 10 };

			var result = testClass.MyMethod(numbers);

			Console.WriteLine("Numbers: " + string.Join(", ", result));
		}
	}
}
