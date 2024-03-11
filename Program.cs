namespace constructor_methods
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Söz Dizimi
            // class Sınıf Adı
            // {
            // [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            // [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            // {
            //     Method Komutları
            // }
            // }

            // Erişim Belirleyiciler
            //  * Public
            //  * Private
            //  * internal sadece proje içerisinden erişilebilir
            //  * Protected  bulunduğu sınıf ya da kaltım alınan sınıflardan kullanılabilir.
            Console.WriteLine("Employee 1");
            Employee employee = new Employee("Erkan", "Yüksel", 2, "IT");
            // employee.name = "Erkan";
            // employee.surname = "Yüksel";
            // employee.empNo = 2;
            // employee.deparment = "IT";

            employee.EmployeeInformation();
            Console.WriteLine("***************");
            Console.WriteLine("Employee 2");

            Employee employee2 = new Employee();
            employee2.name = "Deniz";
            employee2.surname = "Arda";
            employee2.empNo = 3;
            employee2.deparment = "HR";

            employee2.EmployeeInformation();

            Console.WriteLine("***************");
            Console.WriteLine("Employee 3");
            Employee employee3 = new Employee("Hakan", "Yüksel");

            employee3.EmployeeInformation();

        }

        class Employee
        {
            public string name;
            public string surname;
            public int empNo;
            public string deparment;
            public Employee(string name, string surname, int empNo, string deparment)
            {
                this.name = name;
                this.surname = surname;
                this.empNo = empNo;
                this.deparment = deparment;
            }

            public Employee(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
            }
            public Employee()
            {

            }
            public void EmployeeInformation()
            {
                Console.WriteLine("Emloyee Name : {0}", name);
                Console.WriteLine("Emloyee SurName : {0}", surname);
                Console.WriteLine("Emloyee no : {0}", empNo);
                Console.WriteLine("Emloyee Deparment : {0}", deparment);
            }
        }
    }
}