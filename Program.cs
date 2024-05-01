using  OOPSecondTopic;
using OOPSecondTopic.Classes;

System.Console.WriteLine("moshina markasini kiriting: ");
string marka = Console.ReadLine();
System.Console.WriteLine("moshina yilini kiriting: ");
int yili = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("moshina narxini kiriting: ");
decimal narxi = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("moshina tezligini kiriting: ");
decimal tezlik = Convert.ToDecimal(Console.ReadLine());

Cars cars = new Cars(model: marka, year: yili, price: narxi, speed: tezlik);

cars.CalculateDepreciation();
