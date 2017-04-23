using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Class1().For(0, 100, new Action(() => { Console.WriteLine(100); }));
            Console.WriteLine("-----------------------------------------------");
            new Class1().Write(".\\Test.xml",out var xml,out var w);
            int[] i = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var v = from f in i select f;
            List<int> l=new Class1().Foreach(v);
            l.ForEach(new Action<int>((ipp)=> { Console.WriteLine(ipp); }));
            Console.WriteLine("-----------------------------------------------");
            List<int>.Enumerator j=i.ToList().GetEnumerator();
            new Class1().Foreach(j).ForEach((oo)=> { Console.WriteLine(oo); });
            //Console.WriteLine("-----------------------------------------------");
            //new Class1().For(0, 50, () =>
            //{
            //    bool[] b = new bool[] { true, true, true, false, true, false, true, true, true, false, true, false, true, false, true, false, true, false, true, false, false, false, true, true, false, false, true, false, false, true, false, true, true, false, true, true, true, false, false, false, bool.Parse("true"), false, false, bool.Parse("false") };
            //    var bb = from g in b select g;
            //    new Class1().Foreach(bb).ForEach((bx) => { Console.WriteLine(bx); });
            //    Console.WriteLine("-----------------------------------------------");
            //    List<bool>.Enumerator ee = b.ToList().GetEnumerator();
            //    new Class1().Foreach(ee).ForEach((bc) => { Console.WriteLine(bc); });
            //    Console.WriteLine("-----------------------------------------------");
            //    var vtt = from t in b group b by b into c select c;
            //    new Class1().Foreach(vtt).ForEach((bbh) => { new Class1().Foreach(bbh).ForEach((kjj) => { new Class1().Foreach(kjj).ForEach((nbm) => { Console.WriteLine(nbm); }); }); });
            //    Console.WriteLine("-----------------------------------------------");
            //},5);
            Console.ReadKey();
        }
    }
}
