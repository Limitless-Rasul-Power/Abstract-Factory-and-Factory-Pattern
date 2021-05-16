using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace _16_May_Step_Ders
{
    #region Abstract Factory Pattern

    #region Interfaces
    public interface ISmartPhone
    {
        string Model { get; set; }
        double Price { get; set; }
    }

    public interface ISmartWatch
    {
        string Model { get; set; }
        double Price { get; set; }

        string Something { get; set; }
    }

    public interface ITablet
    {
        string Model { get; set; }
        double Price { get; set; }
        int Width { get; set; }
        int Height { get; set; }
    }


    public interface IMobileTechCompany
    {
        ISmartPhone BuySmartPhone();
        ISmartWatch BuySmartWatch();
        ITablet BuyTablet();
    }

    #endregion

    #region Smart Phones
    public class AppleSmartPhone : ISmartPhone
    {
        public AppleSmartPhone()
        {
            Model = "Iphone X";
            Price = 999;
        }
        public string Model { get; set; }
        public double Price { get; set; }
    }

    public class SamsungSmartPhone : ISmartPhone
    {
        public SamsungSmartPhone()
        {
            Model = "Galaxy 10";
            Price = 888;
        }
        public string Model { get; set; }
        public double Price { get; set; }
    }


    public class HuaweiSmartPhone : ISmartPhone
    {
        public HuaweiSmartPhone()
        {
            Model = "Huawei Infinity";
            Price = 888;
        }
        public string Model { get; set; }
        public double Price { get; set; }
    }

    #endregion

    #region Smart Watches


    public class AppleSmartWatch : ISmartWatch
    {
        public AppleSmartWatch()
        {
            Model = "Apple Smart Watch";
            Price = 1000;
        }
        public string Model { get; set; }
        public double Price { get; set; }
        public string Something { get; set; }
    }

    public class SamsungSmartWatch : ISmartWatch
    {
        public SamsungSmartWatch()
        {
            Model = "Samsung Smart Watch";
            Price = 1000;
        }
        public string Model { get; set; }
        public double Price { get; set; }
        public string Something { get; set; }
    }

    public class HuaweiSmartWatch : ISmartWatch
    {
        public HuaweiSmartWatch()
        {
            Model = "Huawei Smart Watch";
            Price = 1000;
        }
        public string Model { get; set; }
        public double Price { get; set; }
        public string Something { get; set; }
    }

    #endregion

    #region Tablets

    public class AppleTablet : ITablet
    {
        public AppleTablet()
        {
            Model = "Apple Tablet";
            Price = 1000;
            Width = 600;
            Height = 400;
        }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class SamsungTablet : ITablet
    {
        public SamsungTablet()
        {
            Model = "Samsung Tablet";
            Price = 900;
            Width = 300;
            Height = 400;
        }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class HuaweiTablet : ITablet
    {
        public HuaweiTablet()
        {
            Model = "Huawei Tablet";
            Price = 888;
            Width = 500;
            Height = 500;
        }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    #endregion

    #region Companies



    public class Apple : IMobileTechCompany
    {
        public ISmartPhone BuySmartPhone()
        {
            return new AppleSmartPhone();
        }

        public ISmartWatch BuySmartWatch()
        {
            return new AppleSmartWatch();
        }

        public ITablet BuyTablet()
        {
            return new AppleTablet();
        }
    }

    public class Samsung : IMobileTechCompany
    {
        public ISmartPhone BuySmartPhone()
        {
            return new SamsungSmartPhone();
        }

        public ISmartWatch BuySmartWatch()
        {
            return new SamsungSmartWatch();
        }

        public ITablet BuyTablet()
        {
            return new SamsungTablet();
        }
    }

    public class Huawei : IMobileTechCompany
    {
        public ISmartPhone BuySmartPhone()
        {
            return new HuaweiSmartPhone();
        }

        public ISmartWatch BuySmartWatch()
        {
            return new HuaweiSmartWatch();
        }

        public ITablet BuyTablet()
        {
            return new HuaweiTablet();
        }
    }

    #endregion


    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            #region Abstract Factory Pattern

            Console.WriteLine("Which Company do you want for Apple 'A' and for Samsung 'S' and for Huawei 'H': ");
            string choice = Console.ReadLine().ToUpper();

            IMobileTechCompany mobileTechCompany = null;

            if (choice == "A")
            {
                mobileTechCompany = new Apple();
            }
            else if (choice == "S")
            {
                mobileTechCompany = new Samsung();
            }
            else if (choice == "H")
            {
                mobileTechCompany = new Huawei();
            }

            Console.WriteLine(mobileTechCompany.BuySmartPhone().Model);
            Console.WriteLine(mobileTechCompany.BuySmartWatch().Model);
            Console.WriteLine(mobileTechCompany.BuyTablet().Model);

            #endregion





            //Abstract Factory Pattern

            //Console.WriteLine("Choose your UI Toolkit, 'R' for Retro and 'F' for Flat: ");
            //string choice = Console.ReadLine().ToUpper();

            //UIToolKit_Abstract_Factory factory = null;

            //if (choice == "R")
            //{
            //    factory = new RetroUI();
            //}
            //else if (choice == "F")
            //{
            //    factory = new FlatUI();
            //}
            //  Console.WriteLine(factory.CreateButton().Style);




            //Second implementation of Factory Pattern

            //Console.WriteLine("Select App type 'W' for Windows and 'H' for Web");
            //string choice = Console.ReadLine().ToUpper();

            //Dialog dialog = null;

            //if (choice == "W")
            //{
            //    dialog = new WindowsDialog();
            //}
            //else if (choice == "H")
            //{
            //    dialog = new WebDialog();
            //}

            //IButton button = dialog.CreateButton();

            //button.Render();



            //First implementation of Factory Pattern

            //Console.WriteLine("For Swordsamn press \'S\', for Archery press \'A\': ");
            //string selection = Console.ReadLine().ToUpper();

            //Soldier s = FactoryMethod.GetSoldier(selection);


            //Console.Clear();

            //s?.Attack();
            //s?.Defend();

        }
    }
}


/**/
