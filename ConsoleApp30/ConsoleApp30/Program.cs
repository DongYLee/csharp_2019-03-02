using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication6
{
    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가="
                    + danga + "]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get; set; }

        public override String ToString()
        {
            return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum
                    + "]";
        }
    }

    class CartTest
    {
        static void Main()
        {
            Goods good1 = new Goods(1001, "볼펜", 1000);
            Goods good2 = new Goods(1002, "연필", 500);
            Goods good3 = new Goods(1003, "딸기", 6000);

            Cart cart1 = new Cart(); cart1.goods = good1; cart1.count = 2; cart1.sum = cart1.goods.danga * cart1.count;
            Cart cart2 = new Cart(); cart2.goods = good2; cart2.count = 3; cart2.sum = cart2.goods.danga * cart2.count;
            Cart cart3 = new Cart(); cart3.goods = good3; cart3.count = 2; cart3.sum = cart3.goods.danga * cart3.count;

            Hashtable cart = new Hashtable();
            cart.Add(1, cart1);
            cart.Add(2, cart2);
            cart.Add(3, cart3);

            SortedList s = new SortedList(cart);

            foreach (DictionaryEntry d in s)
            {
                Console.WriteLine("{0} : {1} : {2} : {3} : {4}", d.Key, ((Cart)d.Value).goods.goodsno, ((Cart)d.Value).goods.gname, ((Cart)d.Value).goods.danga, ((Cart)d.Value).sum);
            }
        }
    }
}
