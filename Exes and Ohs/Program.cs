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
public static class Program
{
    public static void Main()
    {
        GetXOAmount("xo");
        GetXOAmount("xxOo");
        GetXOAmount("xxxm");
        GetXOAmount("Oo");
        GetXOAmount("ooom");
        GetXOAmount("zpzpzpp");
    }
   
    public static bool GetXOAmount(string input)
    {       
        if(!input.ToLower().Contains('x') && !input.ToLower().Contains('o'))
        {
            return true;
        }
        return input.ToLower().Count(x => x == 'x') == input.ToLower().Count(x => x == 'o');
    }
}