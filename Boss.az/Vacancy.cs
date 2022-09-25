  
namespace Boss.az
{
    public class Vacancy
    {
        public int ID { get; set; }

        static int id;
        public string? CompanyName { get; set; } = default;
        public string? Name { get; set; } = default;
        public List<string>? Requirements { get; set; } = default;
        public double Salary { get; set; } = default;
        public List<Notifications>? Notify { get; set; } = default;
        public int UnreadNotifyCount { get; set; } = default;


        public Vacancy()
        {
            ID = ++id;
        }

        public Vacancy(string CompanyName, string Name, List<string> Requirements, double Salary, List<Notifications> Notify, int UnreadNotifyCount)
        {
            ID = ++id;
            this.CompanyName = CompanyName;
            this.Name = Name;
            this.Requirements = Requirements;
            this.Salary = Salary;
            this.Notify = Notify;
            this.UnreadNotifyCount = UnreadNotifyCount;
        }

        public void ShowVacancy()
        {
            Console.WriteLine($"Vacancy ID   : {ID}");
            Console.WriteLine($"Company Name : {CompanyName}");
            Console.WriteLine($"Name         : {Name}");

            foreach (var item in Requirements!)
                if (Requirements != null)
                    Console.WriteLine($"Requirments : {item}");

            Console.WriteLine($"Salary : {Salary}");
        }
    }
}
