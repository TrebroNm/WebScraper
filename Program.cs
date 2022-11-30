using HtmlAgilityPack;

class MyClass
{
    static void Main(string[] args)
    {
        var url = "https://www.timeanddate.no/vaer/?continent=europe&low=c";
        var web = new HtmlWeb();
        var doc = web.Load(url);

        Console.WriteLine(doc.Text);
    }
}