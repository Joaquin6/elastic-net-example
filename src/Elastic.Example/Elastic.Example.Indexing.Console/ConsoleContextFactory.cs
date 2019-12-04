using Elastic.Example.Data;

namespace Elastic.Example.Indexing.Console {
	public class ConsoleContextFactory : IDataContextFactory {
		public MoviesDbContext Create ()
		{
			return new MoviesDbContext ();
		}
	}
}
