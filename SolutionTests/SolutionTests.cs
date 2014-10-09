using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewExercises.SolutionTests
{
	[TestClass]
	public class SolutionTests
	{
		[TestMethod]
		public void TestFizzBuzz()
		{
			var fizzBuzz = Exercises.FizzBuzz().ToArray();

			Assert.IsTrue(fizzBuzz.Length == 100);

			for (var i = 1; i <= 100; i++)
			{
				var current = fizzBuzz[i-1];

				if (i%5 == 0 && i%3 == 0)
				{
					Assert.IsTrue(current.Equals("FizzBuzz"));
				}
				else if (i%5 == 0)
				{
					Assert.IsTrue(current.Equals("Buzz"));
				}
				else if (i%3 == 0)
				{
					Assert.IsTrue(current.Equals("Fizz"));
				}
				else
				{
					Assert.IsTrue(current.Equals(i.ToString()));
				}
			}
		}
	}
}