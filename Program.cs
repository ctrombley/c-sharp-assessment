using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewExercises.Model;

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

		private static async Task<string> SaySomething()
		{
			await Task.Delay(5);
			result = "Hello world!";
			return "Something";
		}

		#endregion

		#region Ex3 

		public List<Movie> Ex3(bool useIEnumerable = true)
		{
			var dc = new MyDataContext();

			// What is the difference in the SQL generation between the following two snippets?

			if (useIEnumerable)
			{
				IEnumerable<Movie> moviesIEnumerable = dc.Movies.Where(p => p.Name.StartsWith("S"));
				moviesIEnumerable = moviesIEnumerable.Take<Movie>(10);

				return moviesIEnumerable.ToList();
			}

			IQueryable<Movie> moviesIQueryable = dc.Movies.Where(p => p.Name.StartsWith("S"));
			moviesIQueryable = moviesIQueryable.Take<Movie>(10);

			return moviesIQueryable.ToList();
		}

		#endregion
	}
}