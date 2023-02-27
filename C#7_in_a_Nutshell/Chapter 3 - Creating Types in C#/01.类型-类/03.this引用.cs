using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.类型_类
{
    class _03
    {
		public class Panda
		{
			public Panda Mate;

			public void Marry(Panda partner)
			{
				Mate = partner;
				partner.Mate = this;
			}
		}

		//static void Main()
		//{
			
		//	new Panda().Marry(new Panda());
		//}
	}
}
