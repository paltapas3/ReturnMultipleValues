using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Returnultiplevalues
{

    public struct StructMinMax
    {
        public int min;
        public int max;
    }

    public class MinMaxValue
    {
        public int min { get; set; }
        public int max { get; set; }
        public void MultipleReturnsValue(int x, int y, ref int maxvalue, ref int minvalue)
        {
            minvalue = x < y ? x : y;
            maxvalue = x > y ? x : y;
      
        }
        public void OutMultipleReturnsValue(int x, int y, out int maxvalue, out int minvalue)
        {
            minvalue = x < y ? x : y;
            maxvalue = x > y ? x : y;
            
        }

        public int[] ArrayMultipleReturnsValue(int x, int y)
        {
            int[] minMax = new int[2];
            minMax[1] = x < y ? x : y;
            minMax[0] = x > y ? x : y;
            return minMax;
        }

        public StructMinMax StructMultipleReturnsValue(int x, int y)
        {
            StructMinMax values = new StructMinMax();
            values.min = x < y ? x : y;
            values.max = x > y ? x : y;
            return values;
        }

        public Tuple<int, int> TupleMultipleReturnsValue(int x, int y)
        {
            int minvalue, maxvalue;
            minvalue = x < y ? x : y;
            maxvalue = x > y ? x : y;
            return new Tuple<int, int>(minvalue, maxvalue);
        }

        public ArrayList ArrayListultipleReturnsValue(int x, int y)
        {
            ArrayList array = new ArrayList();
            array.AddRange(new int[] { 0, 0 });
            array[1] = x < y ? x : y;
            array[0] = x > y ? x : y;
            return array;
        }

        public MinMaxValue ObjectMultipleReturnsValue(int x, int y)
        {
            MinMaxValue objMinMaxValue = new MinMaxValue();
            if (x > y)
            {
                objMinMaxValue.max = x;
                objMinMaxValue.min = y;
            }
            else
            {
                objMinMaxValue.max = y;
                objMinMaxValue.min = x;
            }
            return objMinMaxValue;

        }
    }

}
