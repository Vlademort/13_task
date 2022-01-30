using System;

namespace _13_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string add = "ул. Московская, д 163";
            double length = 50000;
            double width = 30000;
            double height_1 = 15000;
            double height_2 = 21000;
            Building building = new Building(add, length, width, height_1);
            building.Print();
            Console.WriteLine();
            Console.WriteLine();
            MultiBuilding multibuilding = new MultiBuilding(add, length, width, height_2);
            multibuilding.Print();


            Console.ReadKey();
        }
    }
    class Building    
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

       
        public Building (string add, double l, double w, double h)
        {
            Address = add;
            Length = l;
            Width = w;
            Height = h;
        }
        //public virtual void Print()
        //{
        //    Console.WriteLine(" Длина здания: {0} \n Ширина здания: {1} \n Высота здания: {2} \n Находится по адресу: {3}", Length, Width, Height, Address);
        //}

        public void Print()
        {
            Console.WriteLine(" Длина здания: {0} \n Ширина здания: {1} \n Высота здания: {2} \n Находится по адресу: {3}", Length, Width, Height, Address);
        }
    }

    sealed class MultiBuilding : Building
    {
        
        public double Floors { get; set; }

        public MultiBuilding(string add, double l, double w, double h)
            : base (add, l, w, h)
        {            
            Floors = h/3000;
        }

        //public override void Print()
        //{            
        //    base.Print();
        //    Console.WriteLine(" Этажность здания: {0} ", Floors);
        //}
        public void Print()
        {
            base.Print();
            Console.WriteLine(" Этажность здания: {0} ", Floors);
        }
    }
}
