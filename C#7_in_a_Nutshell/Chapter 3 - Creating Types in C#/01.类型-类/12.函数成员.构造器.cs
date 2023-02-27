using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.类型_类
{
    /// <summary>
    ///  构造器 的名字 一定是 类型名 ，create是否也可以? 
    /// </summary>
    class _12
    {
        /*构造器用来 构造实例的，构造 类 或者 结构体的实例 
         * 执行 类/结构体的初始化代码；
         * 定义上 和方法类似；区别在于 构造器 名 和返回值 只能和封装它的类型相同
         */

        public class Panda
        {
            string 姓;
            string 名;
            int 年;
            // 构造器的定义 和写法
            public Panda (string n)
            {
                名 = n;
            }

            public Panda(int x) => 名 = x.ToString();
            // 构造器的重载 this调用另一个构造器；向另一个构造器传递表达式
            public Panda(string xing , string ming):this ("xing") { 名 = ming; }
            public Panda(string xing,int year) : this("xing") { 年 = year; }
            public Panda(string xing, DateTime year) : this(xing, year.Year) { }

            // 表达式内 不能使用this引用——不能调用实例方法，表达式可以调用静态方法

            Panda p = new Panda("Petry");  // 调用构造器 p是数据成员

            // 字段初始化 和 构造器 之间, 初始化 按照声明的顺序先后进行， 在构造器之前执行 

            
        }

        // 非公有 构造器 —— 重点，要结合 单例模式来理解
        public class Class1
        {
            Class1() { }        // Private constructor

            public static Class1 Create()
            {
                // Perform custom logic here to create & configure an instance of Class1
                /* ... */
                return new Class1();
            }
        }
        //static void Main()
        //{
        //    Class1 c1 = Class1.Create();    // OK
        //    Class1 c2 = new Class1();       // Error: Will not compile
        //}
    }
}
