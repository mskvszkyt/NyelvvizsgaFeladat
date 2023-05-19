
using NyelvvizsgaFeladat;
using System.Text;

List<Nyelvvizsga> osszes = new List<Nyelvvizsga>();

foreach (var item in File.ReadAllLines("sikertelen.csv", Encoding.UTF8).Skip(1))
{
    osszes.Add(new Nyelvvizsga(item, "sikertelen"));
}

foreach(var item in File.ReadAllLines("sikeres.csv", Encoding.UTF8).Skip(1))
{
    osszes.Add(new Nyelvvizsga(item, "sikeres"));
}

int input = 0;
do
{
    Console.WriteLine("kérem az évet: ");
    input = Convert.ToInt32(Console.ReadLine());

} while (input <= 2017 && input >= 2009);


//List<Nyelvvizsga> sikertelen = osszes.Select(x => x).Where(x => x.Eredmeny == "sikertelen").ToList();
//sikertelen.ForEach(x =>
//{
//    x.K2014 / osszes.GroupBy(x => x.K2014).Select(y => y.K2014);
//});

osszes.Where(z => z.K2014 == 0).GroupBy(y => y.Nyelv);
Console.WriteLine();


