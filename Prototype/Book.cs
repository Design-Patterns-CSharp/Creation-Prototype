namespace Prototype;

public class Book
{
	public Book(int id, string? title)
	{
		Id = id;
		Title = title;
	}

	public int Id { get; set; }

	public string? Title { get; set; }

	public override string ToString()
	{
		var result = $"(Book: {Id}-{Title})";

		return result;
	}
}
