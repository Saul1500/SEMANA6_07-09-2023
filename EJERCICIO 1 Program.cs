using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] scores = { 97, 92, 81, 60 };

        var queryLowNums =
            from score in scores
            where score > 80
            select score;

        foreach (var i in queryLowNums)
        {
            Console.WriteLine(i.ToString() + " ");
        }
    }
}
//ALUMNO: JOSE SAUL SIBRIAN SERRANO


