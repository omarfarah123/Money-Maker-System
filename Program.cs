/*
Omar Farah
C# Programming
This Program takes in an amount of coins in cents and then returns the amount in gold, silver, and bronze coins*/
using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter Amount In Coins: ");
      string totalAsString = Console.ReadLine();
      double total = Convert.ToDouble(totalAsString);
      Console.WriteLine($"{total} cents is equal to....");
      int goldCoin = 10;
      int silverCoin = 5;
      double goldCoins = Math.Floor(total/goldCoin);
      double remainder = total % goldCoin;
      double silverCoins = Math.Floor(remainder / silverCoin);
      remainder = remainder % silverCoin;
      Console.WriteLine($"Gold Coins: {goldCoins}");
       Console.WriteLine($"Silver Coins Coins: {silverCoins}");
        Console.WriteLine($"Bronze Coins: {remainder}");
    }
  }
}
