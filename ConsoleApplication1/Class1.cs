using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace ConsoleApplication1
{
   public partial class Class1 : IClass1
    {
        public void For(int start,int end,Action a,int step=1)
        {
            int i = start;
            do
            {
                if (a!=null)
                {
                    a.Invoke();
                }
                i += step;
                
            } while (i<end);
        }
        public void For<T1>(int start, int end, Action<T1> a, T1 t1, int step = 1)
        {
            int i = start;
            do
            {
                if (a != null)
                {
                    if (t1 != null )
                    {
                        a.Invoke(t1);
                    }

                }
                i += step;
                
            } while (i < end);
        }
        public void For<T1,T2>(int start, int end, Action<T1,T2> a,T1 t1,T2 t2, int step = 1)
        {
            int i = start;
            do
            {
                if (a != null)
                {
                    if (t1!=null&&t2!=null)
                    {
                     a.Invoke(t1,t2);
                    }
                    
                }
                i += step;
                
            } while (i < end);
        }
     
        public void For<T1,T2,T3>(int start, int end, Action<T1,T2,T3> a, T1 t1,T2 t2,T3 t3,int step = 1)
        {
            int i = start;
            do
            {
                if (a != null)
                {
                    if (t1 != null&& t2 != null&& t3 != null)
                    {
                        a.Invoke(t1,t2,t3);
                    }

                }
                i += step;
                
            } while (i < end);
        }
        public void For<T1, T2, T3,T4>(int start, int end, Action<T1, T2, T3,T4> a, T1 t1, T2 t2, T3 t3,T4 t4,int step = 1)
        {
            int i = start;
            do
            {
                if (a != null)
                {
                    if (t1 != null && t2 != null && t3 != null&& t4!=null)
                    {
                        a.Invoke(t1, t2, t3,t4);
                    }

                }
                i += step;
                
            } while (i < end);
        }
        public Result For<T1, Result>(int start, int end, Func<T1,Result> f, T1 t1, int step = 1)
        {
            int i = start;
            do
            {
                if (f != null)
                {
                    if (t1 != null )
                    {
                        
                        return f.Invoke(t1);
                    }

                }
                i += step;
            } while (i < end);
            
            return default(Result);
        }
        public Result For<T1,T2,Result>(int start, int end,Func<T1,T2,Result> f,T1 t1,T2 t2, int step = 1)
        {
            int i = start;
            do
            {
                if (f != null)
                {
                    if (t1!=null&&t2!=null)
                    {

                    }
                    
                   return  f.Invoke(t1,t2);
                }
                i += step;
                
            } while (i < end);
            
            return default(Result);
        }
        public Result For<T1, T2,T3,Result>(int start, int end, Func<T1, T2,T3,Result> f, T1 t1, T2 t2,T3 t3, int step = 1)
        {
            int i = start;
            do
            {
                if (f != null)
                {
                    if (t1!=null&&t2!=null&&t3!=null)
                    {
                        
                      return  f.Invoke(t1, t2,t3);
                    }
                    
                }
                i += step;
            } while (i < end);
            
            return default(Result);
        }

        public Result For<T1, T2, T3,T4, Result>(int start, int end, Func<T1, T2, T3,T4, Result> f, T1 t1, T2 t2, T3 t3,T4 t4, int step = 1)
        {
            int i = start;
            do
            {
                if (f != null)
                {
                    if (t1 != null && t2 != null && t3 != null && t4 != null)
                    {
                        
                        return f.Invoke(t1, t2, t3,t4);
                    }

                }
                i += step;
            } while (i < end);
            
            return default(Result);
        }
        public List<T> Foreach<T>(IEnumerable<T> source)
        {
            List<T> l=new List<T>();
            if (source!=null &&source is IEnumerable<T>)
            {
                using (var x=source.GetEnumerator())
                {
                    while (x.MoveNext())
                    {
                        l.Add(x.Current);
                    }
                }
            }
                if (l!=null)
                {
                    return l;
                }
                return null;
        }
        public List<T> Foreach<T>(IEnumerator<T> source)
        {
            List<T> l = new List<T>();
            if (source != null && source is IEnumerator<T>)
            {
                while (source.MoveNext())
                {
                    l.Add(source.Current);
                }
            }
            if (l != null)
            {
                return l;
            }
            return null;
        }
        public List<object> Foreach(IEnumerator<object> source)
        {
            List<object> l = new List<object>();
            if (source != null && source is IEnumerator<object>)
            {
                while (source.MoveNext())
                {
                    l.Add(source.Current);
                }
            }
            if (l != null)
            {
                return l;
            }
            return null;
        }
        public List<object> Foreach(IEnumerable<object> source)
        {
            List<object> l = new List<object>();
            if (source != null && source is IEnumerable<object>)
            {
                using (var x = source.GetEnumerator())
                {
                    while (x.MoveNext())
                    {
                        l.Add(x.Current);
                    }
                }
            }
            if (l != null)
            {
                return l;
            }
            return null;
        }
        public void Write(string filename, out XmlDocument xmldocc, out XmlWriter writer)
        {
            XmlDocument xmlDoc = new XmlDocument();
            //创建Xml声明部分，即<?xml version="1.0" encoding="utf-8" ?>
            XmlDeclaration Declaration = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            //创建根节点
            XmlNode rootNode = xmlDoc.CreateElement("root");
            //创建student子节点
            XmlNode testPointNode = xmlDoc.CreateElement("testPoint");
            //创建一个属性
            XmlAttribute testPointID = xmlDoc.CreateAttribute("TestPointID");
            testPointID.Value = "1";
            XmlAttribute caseID = xmlDoc.CreateAttribute("CaseId");
            caseID.Value = "TEST_0001";
            XmlAttribute name = xmlDoc.CreateAttribute("Name");
            name.Value = "111";
            //xml节点附件属性
            testPointNode.Attributes.Append(testPointID);
            testPointNode.Attributes.Append(caseID);
            testPointNode.Attributes.Append(name);
            rootNode.AppendChild(testPointNode);
            //附加根节点
            xmlDoc.AppendChild(rootNode);
            xmlDoc.InsertBefore(Declaration, xmlDoc.DocumentElement);
            xmlDoc.AsParallel();
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Async = true,
                Indent = true,
                NewLineOnAttributes = true
            };
            XmlWriter w = XmlWriter.Create(filename, settings);
            xmlDoc.WriteTo(w);
            //保存Xml文档
            w.Flush();
            //xmlDoc.Save(filename);
            xmldocc = xmlDoc;
            writer = w;
        }
    }
}
