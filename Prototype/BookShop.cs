using System.Text;

namespace Prototype;

public class BookShop : ICloneable
{
	public BookShop()
	{
		Books = new List<Book>();
	}

	public string? Name { get; set; }
	public List<Book> Books { get; set; }

	public object Clone()
	{
		return this.MemberwiseClone();
	}

	public void LoadData()
	{
		for (int index = 0; index < 5; index++)
		{
			var id = index + 1;
			var title = $"Book{id}";

			Book book = new(id, title);

			Books.Add(book);
		}
	}

	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();
		sb.Append(Name);
		sb.Append('(');
		foreach (var book in Books)
		{
			sb.Append(book.ToString());
			sb.Append(", ");
		}
		sb.Append(')');

		return sb.ToString();
	}
}
