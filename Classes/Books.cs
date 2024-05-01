using System.Reflection;

namespace OOPSecondTopic.Classes;

class Cars
{
public string Model { get; set; }
public int Year { get; set; }
public decimal Price { get; set; }
public decimal Speed { get; set; }
private decimal newprice { get; set; } 
private decimal useyear { get; set; }
private decimal lessprice { get; set; }
private decimal yearprice { get; set; }
public Cars()
{
    Model= "";  
    Year= 0;
    Price= 0;
    Speed= 0;
}
public Cars(string model, int year, decimal price, decimal speed)
{
    Model= model;
    Year= year;
    Price= price;
    Speed= speed;
    GetCarInfo();
    CalculateDepreciation();
}
private void GetCarInfo()
{
    System.Console.WriteLine($"Mashina markasi: {Model} \nIshlab chiqarilgan yili: {Year} \nmashina narxi: {Price} \nMashina tezligi: {Speed}");
}
private void CalculateDepreciation()
{

    useyear = 2024 - Year;
    yearprice = Price / 10;
    lessprice = useyear * yearprice;
    newprice = Price - lessprice;
    System.Console.WriteLine($"\nMashina {useyear} yildan beri foydalanilyapti va uni hozirgi narxi: {newprice}");
}










}