using System;


namespace DEV8
{
    class Car
    {
        public string CarInputType()
        {
            string type;
            Console.Write("input type of car: ");
            type = Console.ReadLine();
            return type;
        }
        public string CarInputModel()
        {
            string model;
            Console.Write("input model of car: ");
            model = Console.ReadLine();
            return model;
        }
        public int CarInputCount()
        {
            int count;
            Console.Write("input count: ");
            count = int.Parse(Console.ReadLine());
            return count;
        }
        public int CarInputPrice()
        {
            int price;
            Console.Write("input price of car: ");
            price = int.Parse(Console.ReadLine());
            return price;
        }
    }
}
