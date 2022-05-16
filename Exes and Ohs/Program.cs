//Check to see if a string has the same amount of 'x's and 'o's.
//The method must return a boolean and be case insensitive.
//The string can contain any char.

//Examples input/output:

//XO("ooxx") => true
//XO("xooxx") => false
//XO("ooxXm") => true
//XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
//XO("zzoo") => false

using System.Linq;
using System;
public static class Kata
{
    public static void GetXO()
    {
        XO("xo");
        XO("xxOo");
        XO("xxxm");
        XO("Oo");
        XO("ooom");
    }
   
    public static bool XO(string input)
    {
        return input.
  }
}