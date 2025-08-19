//    public class Car
//    {
//        public string Model;
//        public void Honk()
//        {
//            Console.WriteLine("Beep!");
//        }
//        static void Main(string[] args)
//        {
//            Car c1=new Car();
//            Console.WriteLine();
          
//        }
//}


    public class Person
    {
        private int age;              
        public string Name;           
        
        public void SetAge(int a)
        {
            age = a; 
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person p = new Person();
            p.Name = "Sinthu";  
            p.SetAge(22);       
            p.ShowInfo();       
        }
    }
 

