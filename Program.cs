// See https://aka.ms/new-console-template for more information

using System;
using System.Text;
class Program
{

    enum MonthsOfYear{
            jan, feb, march, april
    }

    enum DaysOfTheWeek{

        mon, tue, wed,thur, fri, sat, sun
        }

enum Seasonsoftheyear{
    summer,winter,aurtum,spring
}
enum Gamedifficulty{
            low, mid, high
        }

enum Planats{
jupiter, saturn, neptune, venus

}
    static void Main()
    {
        MonthsOfYear currentmonth = MonthsOfYear.march;
        Console.WriteLine("this month is " + currentmonth);

       
         
       DaysOfTheWeek CurrentDay = DaysOfTheWeek.thur;
        Console.WriteLine("this day is " + CurrentDay);
       
       Seasonsoftheyear CurrentSeason = Seasonsoftheyear.aurtum;
       Console.WriteLine("this season is "+ CurrentSeason);

        
        
    Gamedifficulty Gamedifficulty = Gamedifficulty.mid;
    Console.WriteLine("current difficulty is "+ Gamedifficulty);


      Console.WriteLine(Enum.GetName(typeof(Planats), 5)); 
      Console.WriteLine("jupiter, saturn, neptune, venus");
      
      foreach (string str in Enum.GetNames(typeof(Planats))) 
      Console.WriteLine(str); 
      Console.WriteLine("Enum.TryParse(mars):"); 
 
  


         
    







    

       
       /*
       Console.WriteLine("enter number");
        int max = Convert.ToInt32(Console.ReadLine());  
        Console.WriteLine("The factors of  " + max + "  are:");
        for (int x = max; x > 0; x--)
        {          
                if (max % x == 0){
                 Console.Write(x + ",");  
                }                
        }
        */
    }
}




