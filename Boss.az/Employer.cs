

namespace Boss.az
{
    public class Employer : Human
    {
        public List<Vacancy>? vacancies = default;

        public Employer() : base() { }

        public Employer(string? name, string? surname, string? city, string? phone, int age, string? mail, string? password, List<Vacancy> vacancies)
            : base(name, surname, city, phone, age, mail, password)
        {
            this.vacancies = vacancies;
        }

        public void ShowVacancies()
        {
            foreach (var item in vacancies!)
            {
                item.ShowVacancy();
                Console.WriteLine("**************************************");
                Console.WriteLine("\n");
            }

        }

        public void AddNewVacancies()
        {
            Vacancy newVacancy = new Vacancy();

            Console.Write("Company Name : ");
            newVacancy.CompanyName = Console.ReadLine();

            Console.Write("Position Name : ");
            newVacancy.Name = Console.ReadLine();

            Console.Write("Salary per month : ");
            newVacancy.Salary = double.Parse(Console.ReadLine()!);

            Console.Write("Enter Count of Requirments : ");
            int requirmentCount = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < requirmentCount; i++)
            {
                Console.Write($"[{i + 1}] Requirment : ");
                string? requirment = Console.ReadLine();
                newVacancy?.Requirements?.Add(requirment!);
            }

            vacancies?.Add(newVacancy!);
        }

        public void ShowNotifications()
        {
            foreach (var item in vacancies!)
            {
                foreach (var item2 in item.Notify!)
                    item2.ShowNotification();
            }

        }

        public void ShowNotificationByID(int id)
        {

            foreach (var item in vacancies!)
            {
                foreach (var item2 in item.Notify!)
                {
                    if (item2.Id == id)
                        item2.ShowNotification();
                    else
                        Console.WriteLine("Such Notification is not valid!");
                }

            }
        }
    }
}
