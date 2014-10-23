using InterviewExercises.Model;

namespace InterviewExercises
{
	using System;
	using System.Data.Entity;

	public class MyDataContext : DbContext
	{
		public MyDataContext()
			: base("name=MyDataContext")
		{
		}
		
		public virtual DbSet<Movie> Movies { get; set; }
	}
}