namespace Core
{
	/// <summary>
	/// Custom lazy load event.
	/// </summary>
	public class TableLazyLoadEvent
	{
		public int Rows;
		public int First;
		public int Last;

		public TableLazyLoadEvent(int Rows, int First, int Last)
		{
			this.Rows = Rows;
			this.First = First;
			this.Last = Last;
		}
	}
}
