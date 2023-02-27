using System.Collections.Generic;
using System.IO;
namespace Console_LINQ
{
    /// <summary>
    /// 编写IEnumerable<T>静态扩展方法 来完成洗牌操作
    /// </summary>
    public static class Extensions
    {
        #region snippet1
        public static IEnumerable<T> InterleaveSequenceWith<T>
            (this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while (firstIter.MoveNext() && secondIter.MoveNext())
            {
                yield return firstIter.Current;
                yield return secondIter.Current;
            }
        }
        //第一个自变量中添加了 this 修饰符。 也就是说，调用扩展方法，就像是第一个自变量类型的成员方法一样 输入和输出类型为 IEnumerable<T>
        #endregion

        #region snippet2
        /// <summary>
        /// 确定两个序列是否相等
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool SequenceEquals<T>
            (this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while (firstIter.MoveNext() && secondIter.MoveNext())
            {
                if (!firstIter.Current.Equals(secondIter.Current))
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        #region snippet3
        public static IEnumerable<T> LogQuery<T>
            (this IEnumerable<T> sequence, string tag)
        {
            // File.AppendText creates a new file if the file doesn't exist.
            using (var writer = File.AppendText("debug.log"))
            {
                writer.WriteLine($"Executing Query {tag}");
            }

            return sequence;
        }
        #endregion
    }
}