using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.类型_类
{
    class _11
    {
        //方法修饰符  方法返回值类型  方法名 （参数类型1，参数名1，参数类型2，参数名2）
        public string Foo(int x,int y)
        {
            return "kaixin";
        }

        // 表达式体的方法
        int Foo(int x) => x + 2;        // 方法签名  Foo(int)
        /*
        // 方法的重载 需要 方法签名不同
        int Foo(int x,int y) { return 2; } //与 第一个 public string Foo(int x,int y）冲突，因为 方法签名是 方法名 + 一定顺序的参数类型
        void Foo(int x,double y) {}
        void Foo(string x) { }
        void Foo(int[] x) { }
        void Foo(params int[] x) { } // params 不是方法签名的一部分

        void Foo(ref int x) { }

        void Foo(out int x) { }  // ref  和 out 不能同时出现

        */
        // 局部方法 
        int temp_全局 = 1;
        /// <summary>
        /// C#7 允许在 方法中 定义 另一个方法，即 局部方法
        /// 简化 ，可阅读；避免方法名称空间膨胀
        /// 可以访问父方法的局部变量和参数
        /// 
        /// 局部方法 可以 在  方法、构造器、属性访问器中出现，也可以在局部方法中出现 
        /// 语句块的lambda表达式中出现 
        /// 可迭代，可异步
        /// </summary>
        void WriteCubes(int x)
        {
            int temp_局部 = 2;

            int Cube(int value) => value * temp_局部 * temp_全局 * x;

            Console.WriteLine(Cube(2));
            Console.WriteLine(Cube(3));
            Console.WriteLine(Cube(4));
        }

        // Foo1 and Foo2 are equivalent:

        int Foo1(int x) { return x * 2; }
        int Foo2(int x) => x * 2;

    }
}
