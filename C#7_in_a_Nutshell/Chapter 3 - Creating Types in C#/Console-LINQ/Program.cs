using System;
using System.Collections.Generic;
using System.Linq;   //上述需要的引用
namespace Console_LINQ
{
    //创建两个序列来分别表示花色和点数
    #region snippet2
    public enum Suit
    {
        梅花,
        方块,
        红心,
        黑桃
    }
    #endregion
    //创建数据集
    #region snippet3
    public enum Rank
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    #endregion
    class Program
    {
        #region snippet4
        static IEnumerable<Suit> Suits() => Enum.GetValues(typeof(Suit)) as IEnumerable<Suit>;
        #endregion

        #region snippet5
        static IEnumerable<Rank> Ranks() => Enum.GetValues(typeof(Rank)) as IEnumerable<Rank>;
        #endregion

        #region snippet1
        public static void Main(string[] args)
        {
            //使用迭代器组成一副扑克牌
            //顺序很重要,先花色,后登记 才会形成同花色13张
            var startingDeck = (from s in Suits().LogQuery("Suit Generation")
                                            from r in Ranks().LogQuery("Value Generation")
                                            select new { Suit = s, Rank = r })
                                            .LogQuery("Starting Deck")
                                            .ToArray();

            foreach (var c in startingDeck)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

            var times = 0;
            var shuffle = startingDeck;

            do
            {
                /*
                shuffle = shuffle.Take(26)
                    .LogQuery("Top Half")
                    .InterleaveSequenceWith(shuffle.Skip(26).LogQuery("Bottom Half"))
                    .LogQuery("Shuffle")
                    .ToArray();
                */

                shuffle = shuffle.Skip(26)
                    .LogQuery("Bottom Half")
                    .InterleaveSequenceWith(shuffle.Take(26).LogQuery("Top Half"))
                    .LogQuery("Shuffle")
                    .ToArray();

                foreach (var c in shuffle)
                {
                    Console.WriteLine(c);
                }

                times++;
                Console.WriteLine(times);
            } while (!startingDeck.SequenceEquals(shuffle));

            Console.WriteLine(times);
        }
        #endregion
    }
}
