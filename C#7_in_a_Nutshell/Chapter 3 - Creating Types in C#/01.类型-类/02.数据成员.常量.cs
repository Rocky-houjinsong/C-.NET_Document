using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.类型_类
{
    class _02
    {
        // const 可以修饰的 数据类型如下，未写全，
        const char char_a = 'a';
        const bool bool_true = true;
        const string string_demo = "demo";
        const Season Season_enum = 0;
        const int int_1 = 1;

        enum Season { Spring, Summer, Autumn, Winter }

        // const 与 static readonly 的区别
        /*其他程序集引用以下字段，const的，永远是2.0，而 static readonly可以随时同步更新
         */
        const string Version_OverWatch = "2.0";
        static readonly string Version_OverWatch_1 = "1.5"; // 可以同步修改
    }
}
