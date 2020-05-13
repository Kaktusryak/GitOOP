using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8._2
{
    delegate void DelEventType();//делегат
    class Vehicle
    {
        private double limit;//максимальна дальність 
        private double limit1;//максимальна дальність(додаткова) 
        private double status;//поточна дальність
        private double mileage;//пройдена дистанція за весь час
        public void Control()//функція, що керує діями авто
        {
            int i = 1;
            while (i == 1)
            {
                Console.WriteLine("If you want to Start, press 1\nIf you want to Move, press 2\nIf you want to Restore, press 3\nIf you want to check Mileage, press 4\nIf you want to check Fuel Consumption, press 5\nIf you want to Stop The Car, press 6\nIf you want to End Session. press 7 ");
                int c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        this.Start();//початок руху
                        break;
                    case 2:
                        this.Movement();//рух
                        break;
                    case 3:
                        this.Restore();//дозаправка
                        break;
                    case 4:
                        this.Mileage();//кілометраж
                        break;
                    case 5:
                        this.FuelConsumption();//витрати пального
                        break;
                    case 6:
                        this.End();//остаточна зупинка
                        break;


                }
                if (c == 7)
                {
                    i = 0;
                    Console.WriteLine("Session is ended");
                }
            }
        }
        
        public Vehicle (double Limit)//конструктор
        {
            limit = Limit;
            limit1 = Limit;

        }
        public event DelEventType MyEvent;//подія
        protected virtual void OnMyEvent()//функція, що перевіряє подію на нуль
        {
            if (MyEvent != null)
            {
                MyEvent();
            }
        }
       
        public void Start()//початок руху
        {
            limit = limit1;
            status = 0;
            Console.WriteLine("It is Start. You have reached {0} kilometers\n", status);
        }
        public void Movement()//рух
        {
            Console.Write("Enter Range: ");
            double Range = Convert.ToDouble(Console.ReadLine());
            double status1 = status;
            status1 += Range;
            if (status1 >= limit)
            {
                OnMyEvent();

                mileage = mileage + (limit-status);
                status = limit;
                
            }
            else
            {
                status += Range;
                mileage += Range;
            }
            Console.WriteLine("You have reached {0} kilometers\n", status);

        }
        public void Restore()//дозаправка
        {
            Console.Write("Enter Additional Limit: ");
            limit = limit + Convert.ToDouble(Console.ReadLine());


        }
        public void Mileage()//кілометраж
        {
            Console.WriteLine("Mileage is {0}\n", mileage);
        }
        public void FuelConsumption()//витрати пального
        {
            Console.WriteLine("Fuel Consumption: {0} liters\n", status * 2);
        }
        public void End()//остаточна зупинка
        {
            Console.WriteLine("This is the end of the movement. Range is {0}\n", status);
            status = 0;
        }
    }
    class Program
    {
        static void Empty()//вимушена зупинка(перевищення максимальної довжини пробігу)
        {
            Console.WriteLine("Not enough fuel to move\n");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Denis Shulman IS-92 Var 15");
            Console.Write("Enter Limit: ");
            double Limit = Convert.ToDouble(Console.ReadLine());//встановлення ліміту(максимальної дальності
            Vehicle car1 = new Vehicle(Limit);//створення об'єкту автомобіля
            car1.MyEvent += Empty;//додавання до події функції
           
            car1.Control();//основна функція керування авто
            
            Console.ReadKey();

        }
    }
}
