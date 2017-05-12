using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
   
    public class Multivaluereturn
    {
                
        static void Main(string[] args)
        {
            int x = 10, y = 20, max = 0, min = 0;
            MinMaxValue objMinMax = new MinMaxValue();

            // Ref example  
            Console.WriteLine("Return Ref");
            objMinMax.MultipleReturnsValue(x, y, ref max, ref min);
            Console.WriteLine("Minimum Value: " + min);
            Console.WriteLine("Maximum Value: " + max);
            Console.ReadLine();

            // Out example
            Console.WriteLine("Return Out");
            objMinMax.OutMultipleReturnsValue(x, y, out max, out min);
            Console.WriteLine("Minimum Value: " + min);
            Console.WriteLine("Maximum Value: " + max);
            Console.ReadLine();

            // Array example
            Console.WriteLine("Return Array");
            int[] minMax = objMinMax.ArrayMultipleReturnsValue(x, y);
            Console.WriteLine("Minimum Value: " + minMax[1]);
            Console.WriteLine("Maximum Value: " + minMax[0]);
            Console.ReadLine();

            //ArrayList example 
            Console.WriteLine("Return ArrayList");
            ArrayList ar = new ArrayList();
            ar = objMinMax.ArrayListultipleReturnsValue(x, y);
            Console.WriteLine("Minimum Value: " + ar[1]);
            Console.WriteLine("Maximum Value: " + ar[0]);
            Console.ReadLine();

            // Return Struct 
            Console.WriteLine("Return Struct");
            StructMinMax results = objMinMax.StructMultipleReturnsValue(x, y);
            Console.WriteLine("Minimum Value: " + results.min);
            Console.WriteLine("Maximum Value: " + results.max);
            Console.ReadLine();

            // Return Tupple 
            Console.WriteLine("Return Tupple");
            var tuple = objMinMax.TupleMultipleReturnsValue(x, y);
            Console.WriteLine("Minimum Value: " + tuple.Item1);
            Console.WriteLine("Maximum Value: " + tuple.Item2);
            Console.ReadLine();


            // Return Object 
            Console.WriteLine("Return Object");
            MinMaxValue objMinnax = new MinMaxValue();
            objMinnax = objMinMax.ObjectMultipleReturnsValue(x, y);
            Console.WriteLine("Minimum Value: " + objMinnax.min);
            Console.WriteLine("Maximum Value: " + objMinnax.max);
            Console.ReadLine();

        }
        

}
}
