using System.Collections.Generic;
using Xunit;
using WeekDaynamespace;


namespace  WeekDaynamespace
{
  public class WeekDayTest
  {
    [Fact]
    public void Testforinput_monthfinder_true()
    {
      int month = 1;
      int day = 3;
      int year = 4000;

      Assert.Equal ("Wednesday", WeekDay.monthfinder(month,day,year));
    }
    [Fact]
    public void Testforinput_monthandDayfinder_true()
    {
      int month = 9;
      int day = 3;
      int year = 1984;
      Assert.Equal ("Friday", WeekDay.monthfinder(month,day,year));
    }
    [Fact]
    public void Testforinput_Daysarefunnny_Monday()
    {
      int month = 2;
      int day = 15;
      int year = 2100;

      Assert.Equal ("Wednesday", WeekDay.monthfinder(month,day,year));
    }
    [Fact]
    public void Testforinput_YearsAre365_true()
    {
      int month = 2;
      int day = 15;
      int year = 2010;

      Assert.Equal ("Wednesday", WeekDay.monthfinder(month,day,year));
    }
  }
}
