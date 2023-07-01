using System;

//ref link:https://www.youtube.com/watch?v=E1_D6BJWLZg&list=PL90AF0EFFEF782D27&index=3
// (this -- 

/*static class MyExtensionHelpers
{
    public static DateTime Combine(this DateTime datePart, DateTime timePart) // extension method ---added (this
    {
        return new DateTime(
            datePart.Year, datePart.Month, datePart.Day,
            timePart.Hour, timePart.Minute, timePart.Second);
    }
}*/

/*static class MainClass // extension method --added static
{
    //static DateTime Combine(DateTime datePart, DateTime timePart)
    /*static DateTime Combine(this DateTime datePart, DateTime timePart) // extension method ---added (this
    {
        return new DateTime(
            datePart.Year, datePart.Month, datePart.Day,
            timePart.Hour, timePart.Minute, timePart.Second);
    }*/
/*static void Main()
{
    DateTime date = DateTime.Parse("1/5/2025");
    DateTime time = DateTime.Parse("1/1/0001 9:55pm");

    DateTime combined1 = MyExtensionHelpers.Combine(date, time); // normal static call
    DateTime combined2 = date.Combine(time); // extension method .Combine()

    Console.WriteLine(combined1);
    Console.WriteLine(combined2);
}
}*/

static class CowMethods
{
    public static void Moo(this Cow _this)
    {
        //numMoo++; // the compiler implicitly add the method this.
        _this.numMoos++;
        Console.WriteLine("Moooo " + _this.numMoos);
    }
}

class Cow
//static class Cow
{   // All methods are static
     public int numMoos;
    //public void Moo() // the compiler implicitly add the method this.
    //public static void Moo(Cow _this)
    /*public static void Moo(this Cow _this)
    {
        //numMoo++; // the compiler implicitly add the method this.
        _this.numMoos++;
        Console.WriteLine("Moooo " + _this.numMoos);
    }*/
}

static class MainClass
{
    static void Main()
    {
        Cow c = new Cow();
        Cow c2 = new Cow();
        //c2.Moo(); // the compiler implicitly add the method this.
        //Cow.Moo(c2); // i called static
        //Cow.Moo(c2); // i called static
        //Cow.Moo(c2); // i called static
        c2.Moo();
        //c.Moo(); c.Moo(); c.Moo();
        //Cow.Moo(c); Cow.Moo(c); Cow.Moo(c); // i called static
    }
}