using System;
using System.Collections.Generic;
using System.Linq;

namespace WeekDaynamespace
{

    public class WeekDay
  {



//construtor//

  public WeekDay()
  {
  }

  public static string monthfinder(int month, int day, int year)
      {
        // int[] array = day.ToIntArray();
        int test7 = month;
        int test8 = year;

        int rickjames = test8 - 1810;
        int dave = rickjames * 52;
         day = dave * 7;
         Console.WriteLine(day);

          Dictionary<int, int> newdictionary = new Dictionary<int, int> {};
          newdictionary.Add(1, 1);
          newdictionary.Add(2, 31);
          newdictionary.Add(3, 59);
          newdictionary.Add(4, 90);
          newdictionary.Add(5, 120);
          newdictionary.Add(6, 151);
          newdictionary.Add(7, 181);
          newdictionary.Add(8, 212);
          newdictionary.Add(9, 243);
          newdictionary.Add(10, 273);
          newdictionary.Add(11, 304);
          newdictionary.Add(12, 334);

          foreach ( KeyValuePair<int, int> supatest in newdictionary) {
             if( test7 == supatest.Key)
            {
              day += (supatest.Value);
            }
          }
        int test2 = day % 7;

          string final = "";
          // int[] array = day.ToIntArray();
            Dictionary<int, string> testDictionary = new Dictionary<int, string> {};
            testDictionary.Add(1, "Monday");
            testDictionary.Add(2, "Tuesday");
            testDictionary.Add(3, "Wednesday");
            testDictionary.Add(4, "Thursday");
            testDictionary.Add(5, "Friday");
            testDictionary.Add(6, "Saturday");
            testDictionary.Add(7, "Sunday");

            foreach (KeyValuePair<int, string> test in testDictionary) {
               if( test2 == test.Key)
              {
                final = test.Value;
              }

            }
            return final;
          }

      }
      }


// int[] testarray = [];
//  for (int i = 1; i <30 ; i++) {
//    if ( i == day)
//    {
//      day % 7 = test2;
