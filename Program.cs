using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESCO_Electric_Bill
{
    class Electric_bill 
    {
       
        int ConsumerId;
        string ConsumerName;
        int unit;
        double totalBill;
        string consumerType;
        public
        Electric_bill() 
        {
        
        }
        public void setter(int c_i, string c_n, int u, int t, string typ)
        {
            ConsumerId = c_i;
            ConsumerName = c_n;
            unit = u;
            totalBill = t;
            consumerType = typ;
        }
        
        public void GetData() 
        {
            Console.WriteLine("Consumer ID: {0}",ConsumerId );
            Console.WriteLine("Consumer Name {0}:", ConsumerName );
            Console.WriteLine("Consumer Name {0}:", ConsumerName );
            Console.WriteLine("Units {0}:", unit);
            Console.WriteLine("total Bill {0}:", totalBill);
            Console.WriteLine("consumer Type {0}:", consumerType);
        }


    }
    class Residential :  Electric_bill
    { 
        public
        Residential(int id, string name, int unit)
        {
            int bill_Bal = 0;
            if (unit <= 100)
                bill_Bal = unit * 5;
            else if (unit > 100 && unit <= 200)
                bill_Bal = 100 * 5 + (unit - 100) * 17;
            else if (unit > 200 && unit <= 500)
                bill_Bal = 100 * 5 + 100 * 17 + (unit - 200) * 23;
            else if (unit > 500)
                bill_Bal = 100 * 5 + 100 * 17 + 300 * 23 + (unit - 500) * 69;
            else {
                bill_Bal = 1;
            }
            bill_Bal = bill_Bal + (bill_Bal / 100) * 13;
            setter(id, name, unit, bill_Bal, "Residential");
        }
    }
    class Commercial : Electric_bill
    {
        public
    Commercial(int id, string name, int unit)
        {
            int bill_Bal = 0;
            if (unit <= 100)
                bill_Bal = unit* 8;
            else if (unit > 100 && unit <= 200)
                bill_Bal = 100 * 8 + (unit - 100) * 21;
            else if (unit > 200 && unit <= 500)
                bill_Bal = 100 * 8 + 100 * 21 + (unit - 200) * 23;
            else if (unit > 500)
                bill_Bal = 100 * 8 + 100 * 21 + 300 * 23 + (unit - 500) * 79;
            else {
                bill_Bal = 1;
            }
            bill_Bal = bill_Bal + (bill_Bal / 100) * 17;
            setter(id, name, unit, bill_Bal, "Commercial");
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Residential e = new Residential(3, "Hamza", 123);           
            e.GetData();
            Commercial c = new Commercial(4, "Ibrahim",500);
            c.GetData();
        }
    }
}
