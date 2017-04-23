using System;
using System.Collections.Generic;
using System.Xml;

namespace ConsoleApplication1
{
    public interface IClass1
    {
        Class2 Class2 { get; set; }
        int Id { get; set; }
        string Text { get; set; }
        void For(int start, int end, Action a, int step = 1);
        void For<T1>(int start, int end, Action<T1> a, T1 t1, int step = 1);
        Result For<T1, Result>(int start, int end, Func<T1, Result> f, T1 t1, int step = 1);
        void For<T1, T2>(int start, int end, Action<T1, T2> a, T1 t1, T2 t2, int step = 1);
        Result For<T1, T2, Result>(int start, int end, Func<T1, T2, Result> f, T1 t1, T2 t2, int step = 1);
        void For<T1, T2, T3>(int start, int end, Action<T1, T2, T3> a, T1 t1, T2 t2, T3 t3, int step = 1);
        Result For<T1, T2, T3, Result>(int start, int end, Func<T1, T2, T3, Result> f, T1 t1, T2 t2, T3 t3, int step = 1);
        void For<T1, T2, T3, T4>(int start, int end, Action<T1, T2, T3, T4> a, T1 t1, T2 t2, T3 t3, T4 t4, int step = 1);
        Result For<T1, T2, T3, T4, Result>(int start, int end, Func<T1, T2, T3, T4, Result> f, T1 t1, T2 t2, T3 t3, T4 t4, int step = 1);
        List<object> Foreach(IEnumerator<object> source);
        List<object> Foreach(IEnumerable<object> source);
        List<T> Foreach<T>(IEnumerator<T> source);
        List<T> Foreach<T>(IEnumerable<T> source);
        void Write(string filename, out XmlDocument xmldocc, out XmlWriter writer);
    }
}