namespace Lab7
{
    public class Program
    {
        public static void Main()
        {
           Truck truck1 = new Truck(2018, "Volvo", 13);
            Truck truck2 = new Truck(2022, "Scania", 18);

            truck1.Print();
            truck2.Print();

            Machine unit = new Truck(2007, "Камаз", 25);
            unit.Print();

            unit.Alarm();
            unit.Service();

            Truck t3 = unit as Truck;
            t3.Print(); 
        }
    }

     public abstract class Machine
    {
        protected int _year;
        protected string _model;

        public Machine(int year, string model)
        {
            _year = year;
            _model = model;
        }

        public virtual void Service()
        {
            Console.WriteLine("выполнено: базовая проверка");
        }

        public abstract void Alarm();

        public void Print()
        {
            Console.WriteLine(_year + " " + _model);
        }
    }

    public class Truck : Machine
    {
        private int _payloadTons;

        public int PayloadTons => _payloadTons;

        public Truck(int year, string model, int payloadTons) : base(year, model)
        {
            _year -= 1; 
            _payloadTons = payloadTons;
        }

        public override void Alarm()
        {
            Console.WriteLine("Би-Бииииииппп");
        }

        public override void Service()
        {
            Console.WriteLine("выполнено: проверка тормозов + грузовые ремни");
        }

        public void Print()
        {
            Console.WriteLine(_year + " " + _model + " " + _payloadTons);
        }
    }
}
