using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15._07._2019
{
    class Program
    {

        static void Main(string[] args)
        {

            #region  Ededi_Tapmaq
            //Action<int> EdediTapmaq = TekVeCutTapmaq;
            //{
            //    EdediTapmaq += SadeVeMurekkebEdediTapmaq;
            //    EdediTapmaq += MenfiVeMusbetEdediTapmaq;
            //}
            //EdediTapmaq(6);
            #endregion

            #region Kart
            //Cart cart = new Cart(500);
            //cart.MyMoney += (i, k) =>
            //{
            //    Console.WriteLine($"Kifayet qeder pulunuz yoxdur");
            //};
            //cart.Money(400);
            #endregion
            
        }
        #region Ededi_Tapmaq
        //static void TekVeCutTapmaq(int a)
        //{

        //    if (a % 2 == 0)
        //    {
        //        Console.WriteLine($"{a} cutdur");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{a} tekdir");
        //    }

        //}
        //static void SadeVeMurekkebEdediTapmaq(int a)
        //{
        //    int count = 0;
        //    for (int i = 1; i <= a; i++)
        //    {
        //        if (a % i == 0)
        //        {
        //            count++;
        //        }
        //    }
        //    if (count == 2)
        //    {
        //        Console.WriteLine($"{a} ededi sadedir");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{a} ededi murekkebdir");
        //    }
        //}
        //static void MenfiVeMusbetEdediTapmaq(int a)
        //{
        //    if (a < 0)
        //    {
        //        Console.WriteLine($"{a} menfi ededdir");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{a} musbet ededdir");
        //    }
        //}
        #endregion
        
    }
    #region Kart
    //class Cart
    //{
    //    public event Action<int, int> MyMoney;

    //    public int MyAccount { get; private set; }

    //    public Cart(int a)
    //    {
    //        MyAccount = a;
    //    }
    //    public void Money(int b)
    //    {
    //        if (MyAccount > b)
    //        {
    //            Console.WriteLine($"Buyurun pulunuzu goturun");
    //        }
    //        else
    //        {
    //            MyMoney.Invoke(b, MyAccount);
    //        }
    //    }
    //}
    #endregion

}
