namespace Prototype;

internal class Program
{
	static void Main(string[] args)
	{
		var bookShop1 = new BookShop();
		bookShop1.Name = "Tehran-BookShop";
		bookShop1.LoadData();

		var bookShop2 = (BookShop)bookShop1.Clone();
		bookShop2.Name = "Karaj-BookShop";

		bookShop1.Books[0].Title = "Editted";

		Console.WriteLine(bookShop1);
		Console.WriteLine(Environment.NewLine);
		Console.WriteLine(bookShop2);
	}
}

// زمانی که بخواهیم شی از کلاسی مشابه شی دیگری از همان کلاس بسازیم
// برای مثال بدون اینکه مجدد از دیتابیس همان دیتای تکراری را برا شی جدید فچ کنیم
// پراپرتی شی قبلی را 
// Clone
// کنیم. در اینصورت در تابع 
// Clone
// از کلاس جاری یک 
// اصطلاحا 
// ShallowCopy
// برمیگردانیم. این کار مقادیر 
// Reference Type
// را در حافظه ی مجزا اما مشترک در نظر میگیرد
// و با تغییر یکی از آنها طبعا برای شی دیگر هم تغییر میکند
// صورت دیگری هم از کپی هست به صورت
// Deep Copy
// که شی مجزا کپی می شود