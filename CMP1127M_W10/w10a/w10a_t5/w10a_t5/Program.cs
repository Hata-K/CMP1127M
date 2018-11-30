using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w10a_t5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Diction = new Dictionary<string, int>();
            Diction.Add("Steve", 34);
            Diction.Add("Jimmy", 78);
            Diction.Add("Simon", 67);
            Diction.Add("Anna", 38);
            Diction.Add("Bob", 0);
            Diction.Add("Philip", 45);
            Diction.Add("Kevin", 67);
            Diction.Add("Helen", 76);

            ArrayList sortArray = new ArrayList();
            ArrayList sortArray2 = new ArrayList();

            Diction.ToList().ForEach(x => sortArray.Add(x.Key));
            //Diction.ToList().ForEach(x => Console.WriteLine(x.Key));s

            //Console.WriteLine(Diction["Steve"]);

            sortArray.Sort();

            for (int i = 0; i < sortArray.Count; i++)
            {
                Console.WriteLine(sortArray[i] + "\t" + Diction[sortArray[i].ToString()]);
                
            }

            Console.WriteLine("\n");

            Diction.ToList().ForEach(x => sortArray2.Add(x.Value));
            sortArray2.Sort();
            sortArray2.Reverse();
            for (int i = 0; i < sortArray2.Count; i++)
            {

                var myKey = Diction.FirstOrDefault(x => x.Value.ToString() == sortArray2[i].ToString()).Key;

                Console.WriteLine(sortArray2[i] + "\t" + myKey);
            }
        }
    }
}
