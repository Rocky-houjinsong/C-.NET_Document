using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.类型_类
{
    class _01
    {
        // 字段 field 是类 或者结构体的变量成员
        string name;                // 不一定要初始化，有默认值，为 null
        public int Age = 10;        // 字段的初始化在构造器之前
        static readonly string birty_city = "浙江",
                               birty_weather = "晴"; //同时声明多个字段

        
    }
}
