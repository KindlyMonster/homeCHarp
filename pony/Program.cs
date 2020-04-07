using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = { "pip", "w" , "pop", "pip", "we", "pop", "wqe", "1", "1", "wqrewfdsc", "ewqfdsvdfbserb" };
            string[] inputArr1 = { "pop", "ываw", "аыв", "мсчмв", "ы", "выфц", "pip", "666", "41", "asfewvdvrew" , "d123rf4re" };

            FirstClass name = new FirstClass(inputArr);
            FirstClass name1 = new FirstClass(inputArr1);

            Console.WriteLine("List1 \n{0}",name);
            Console.WriteLine("List2 \n{0}", name1);

            Console.WriteLine("List1 + List2 \n{0}", name1 + name);

            Console.WriteLine("Return min elem in list1 \n{0}", name.minElemList());
            Console.WriteLine("Return min elem in list2 \n{0}", name1.minElemList());

            Console.WriteLine("Return an elem by index in list1 \n{0}", name.getElem2Index(5));
            Console.ReadKey();
        }
    }
}
