using System;
using System.Threading.Tasks;

namespace InterviewExercises
{
	internal class Program
	{
		#region Ex1

		private static String location;
		private static DateTime time;

		// What does the following method write to the console?
		public static void Ex1()
		{
			Console.WriteLine(location == null ? "location is null" : location);
			Console.WriteLine(time == null ? "time is null" : time.ToString());
		}

		#endregion

		#region Ex2

		private static string result;

		// What does the following method write to the console?
		public static void Ex2()
		{
			SaySomething();
			Console.WriteLine(result);
		}

		private async Task<string> SaySomething()
		{
			await Task.Delay(5);
			result = "Hello world!";
			return "Something";
		}

		#endregion
	}
}