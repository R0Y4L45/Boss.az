using System.Diagnostics;


namespace Boss.az
{
    public class Menu
    {

        public static StackFrame callStack = new StackFrame(1, true);

        static Human CurrentUser = new Human();

        static Vacancy vacancy1 = new Vacancy
        {
            CompanyName = "IT STEP ACADEMY",
            Name = ".NET Developer",
            Requirements = new List<string>
          {
              "Müvafiq sahədə ən azı 2 il iş təcrübəsi",
              "ASP.NET Web Forms, ASP.NET MVC haqqında biliklər, bu platformalarda yeni proyektlərin tərtib edilməsi",
              "SOAP/REST tipli veb servislər ilə ən az 1 il iş təcrübəsi olması",
              "Minimum 2 il C# dili və .NET Framework ilə proqramlaşdırma təcrübəsi",
              "MS SQL haqqında bilik və bacarıqlar",
          },
            Salary = 10000
        };

        static Vacancy vacancy2 = new Vacancy
        {
            CompanyName = "Code ACADEMY",
            Name = "SMM",
            Requirements = new List<string>
          {
              "Sosial Media təqvimini, effektiv planı, mövzuları zamana görə planlaşdırır və hazırlayır ",
              "Brendin məqsədi və imicinə uyğun, gündəlik olaraq şəkil, mətn, video daxil olmaqla sosial mediada paylaşımları yaradır və yerləşdirir",
              "Brendlərin sosial səhifələrini yaradır və işlədir ",
              "Korporativ standartlara əsasən sosial mediada tələb olunan məlumatlar ilə müştərilərin və izləyicilərin suallarına cavab verir ",
              "Davamlı olaraq izləyicilərin, bəyənmələrin, rəylərin və paylaşımların sayının artırılmasını təmin edir ",
          },
            Salary = 3500
        };

        static Vacancy vacancy3 = new Vacancy
        {
            CompanyName = "Veyseloglu LLC",
            Name = "SMM",
            Requirements = new List<string>
          {
              "Sosial Media təqvimini, effektiv planı, mövzuları zamana görə planlaşdırır və hazırlayır ",
              "Brendin məqsədi və imicinə uyğun, gündəlik olaraq şəkil, mətn, video daxil olmaqla sosial mediada paylaşımları yaradır və yerləşdirir",
              "Brendlərin sosial səhifələrini yaradır və işlədir ",
              "Korporativ standartlara əsasən sosial mediada tələb olunan məlumatlar ilə müştərilərin və izləyicilərin suallarına cavab verir ",
              "Davamlı olaraq izləyicilərin, bəyənmələrin, rəylərin və paylaşımların sayının artırılmasını təmin edir ",
          },
            Salary = 3500
        };


        static Worker worker1 = new Worker
        {
            Name = "Asif",
            Surname = "Qehramanov",
            Age = 24,
            City = "Baki",
            Phone = "0998234751",
            Mail = "asif@gmail.com",
            Password = "asif123",
            WorkerCV = new List<CV>
            {
                 new CV
                 {
                      Qualification ="BioMedical Engineering",
                      School ="48 numbered secondary school",
                      Languages = new List<string>{ "English - UpperIntermediate","Russian - Intermediate"},
                      Skils = new List<string>{ "Time Management and Efficiency", "Leadership skills", "Negotiation skills","Presentation and Communication skills" },
                      UniScore = 373,
                      HasCertificate = true,
                      previousWorkedCompanies = new List<PreviousWorkedCompanies>
                      {
                         new PreviousWorkedCompanies
                           {
                                  CompanyName = "M-Trans LLC",
                                   Position="Logistic Specialist",
                                    StartDate=new DateTime(2020,01,27),
                                     EndDate=new DateTime(2022,06,03)
                           }
                      },
                      WebsiteLinks = "in/asif-qehramanov-682642385/"
                 }
            }
        };

        static Employer employer1 = new Employer
        {
            Name = "Samir",
            Surname = "Kazimov",
            Age = 45,
            City = "Gence",
            Phone = "0704431213",
            Mail = "samir@gmail.com",
            Password = "samir123",
            vacancies = new List<Vacancy> { vacancy1, vacancy2 },
        };

        static Employer employer2 = new Employer
        {
            Name = "Anar",
            Surname = "Aliyev",
            Age = 34,
            City = "Baku",
            Phone = "0558751568",
            Mail = "anar@inbox.ru",
            Password = "anar123",
            vacancies = new List<Vacancy> { vacancy3 },
        };



        static DataBase dataBase = new DataBase
        {
            humans = new List<Human> { employer1, employer2, worker1 }
        };

        public static void SignIn()
        {
            Console.Write("E-Mail : ");
            string? email = Console.ReadLine();

            Console.Write("Password : ");
            var password = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && password.Length > 0)
                {
                    Console.Write("\b \b");
                    password = password.Remove(password.Length - 1, 1);
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    password += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in dataBase.humans!)
            {
                if (email == item.Mail && password == item.Password)
                {
                    CurrentUser = item;
                    break;
                }
            }

            if (CurrentUser is Employer) EmployerPage();
            else if (CurrentUser is Worker) WorkerPage();
            else Console.WriteLine("User is not excist!!");

        }

        public static void SignUp()
        {
            Console.Clear();
            Console.Write(@"You are Empoyer or Worker?

Employer   [1]
Worker     [2]
HomePage   [0]

Add Here : ");
            int opt = int.Parse(Console.ReadLine()!);
            if (opt == 0)
            {
                Console.Clear();
                Start();
            }
            Console.Write("Name : ");
            string? name = Console.ReadLine();

            Console.Write("Surname : ");
            string? surname = Console.ReadLine();

            Console.Write("Age : ");
            int age = int.Parse(Console.ReadLine()!);

            Console.Write("City :");
            string? city = Console.ReadLine();

            Console.Write("Phone : ");
            string? phone = Console.ReadLine();

            Console.Write("E-Mail : ");
            string? mail = Console.ReadLine();

            Console.Write("Add Password : ");
            string? password = Console.ReadLine();

            foreach (var item in dataBase.humans!)
            {
                if (mail == item.Mail)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("This E-Mail has already used!");
                    SignUp();
                }
            }



            if (opt == 1)
            {
                Console.Clear();
                Employer newEmployer = new Employer
                {
                    Name = name,
                    Surname = surname,
                    Age = age,
                    City = city,
                    Mail = mail,
                    Password = password,
                    Phone = phone,
                };

                Console.Write("Please add count of Vacancy to add : ");
                int vacCount = int.Parse(Console.ReadLine()!);
                for (int i = 0; i < vacCount; i++)
                {
                    newEmployer.AddNewVacancies();
                }
                Console.Clear();
                Start();
            }
            else if (opt == 2)
            {
                Console.Clear();
                Worker newWorker = new Worker
                {
                    Name = name,
                    Surname = surname,
                    Age = age,
                    City = city,
                    Mail = mail,
                    Password = password,
                    Phone = phone,

                };
                Console.Write("Please enter how many CV you want to create : ");
                int count = int.Parse(Console.ReadLine()!);
                for (int i = 0; i < count; i++)
                {
                    newWorker.AddCV();
                }
                Console.Clear();
                Start();
            }

        }


        public static void Start()
        {

            while (true)
            {
                try
                {
                    FrileWriterFileReadercs.WriteFile(dataBase);

                    Console.Write(@"Sign In   [1]
Sign up   [2]

Add Here : ");
                    int select = int.Parse(Console.ReadLine()!);
                    if (select == 1)
                    {
                        Console.Clear();
                        SignIn();
                    }
                    else if (select == 2)
                    {
                        Console.Clear();
                        SignUp();
                    }
                    else
                    {
                        throw new CustomExceptionClass("Please choose between 1-2", DateTime.Now, callStack.GetFileLineNumber(), System.Reflection.Assembly.GetExecutingAssembly().Location);
                    }
                }
                catch (Exception ex)
                {
                    File.AppendAllText("Error.log", ex.ToString());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex);
                    Console.ResetColor();
                    Thread.Sleep(2000);
                }
            }
        }

        public static void EmployerPage()
        {
            Employer CurrentEmployer = (Employer)CurrentUser;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"WELCOME {CurrentUser.Name} {CurrentUser.Surname}");
            Console.ResetColor();
            Console.Write(@"Show your vacancies    [1]
Add vacancy            [2]
Show Notification      [3]
Return Home Page       [0]

Enter your option  : ");

            int option = int.Parse(Console.ReadLine()!);
            if (option == 1)
            {
                Console.Clear();
                CurrentEmployer.ShowVacancies();
                EmployerPage();
            }
            else if (option == 2)
            {
                Console.Clear();
                CurrentEmployer.AddNewVacancies();
                EmployerPage();

            }
            else if (option == 3)
            {
                Console.Clear();
                CurrentEmployer.ShowNotifications();
                Console.WriteLine("\n\n");
                Console.WriteLine("Enter Notification ID to Accept or Reject : ");
                int id = int.Parse(Console.ReadLine()!);
                Console.Clear();
                CurrentEmployer.ShowNotificationByID(id);
                Console.WriteLine("\n\n");
                Console.Write(@"Do you ACCEPT or REJECT?
ACCEPT  [1]
Reject  [2]

Add Here : ");
                int choosen = int.Parse(Console.ReadLine()!);
                if (choosen == 1)
                {
                    Console.Clear();
                    Console.Write("Enter Applicant ID : ");
                    int iD = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Enter note to accepted Applicant : ");
                    string notification = Console.ReadLine()!;
                    dataBase?.GetWorkerByID(iD)?.Notifications?.Add(notification);
                    EmployerPage();

                }
                else if (choosen == 2)
                {
                    Console.Clear();
                    Console.Write("Enter Applicant ID : ");
                    int _id = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Enter note to Rejected Applicant : ");
                    string? notification = Console.ReadLine();
                    dataBase?.GetWorkerByID(_id)?.Notifications?.Add(notification!);
                    EmployerPage();
                }
                else
                {
                    throw new CustomExceptionClass("Please choose between 1-2", DateTime.Now, callStack.GetFileLineNumber(), System.Reflection.Assembly.GetExecutingAssembly().Location);

                }
            }
            else if (option == 0)
            {
                Start();
            }
            else
            {
                throw new CustomExceptionClass("Please choose between 0-3", DateTime.Now, callStack.GetFileLineNumber(), System.Reflection.Assembly.GetExecutingAssembly().Location);
            }
        }

        public static void WorkerPage()
        {
            Worker CurrentWorker = (Worker)CurrentUser;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"WELCOME {CurrentWorker.Name} {CurrentWorker.Surname}");
            Console.ResetColor();

            Console.Write(@"
Show Vacancies    [1]
Apply Vacancies   [2]
Add CV            [3]
Show CV           [4]
Notification      [5]
Return HomePage   [0]

Add your option  : ");
            Console.WriteLine();
            int option = int.Parse(Console.ReadLine()!);
            Console.Clear();
            if (option == 1)
            {
                foreach (var item in dataBase.humans!)
                {
                    if (item is Employer)
                    {
                        Employer employer = (Employer)item;
                        employer.ShowVacancies();
                    }
                }
                WorkerPage();
            }
            else if (option == 2)
            {
                Console.Clear();
                foreach (var item in dataBase.humans!)
                {
                    if (item is Employer)
                    {
                        Employer employer = (Employer)item;
                        employer.ShowVacancies();
                    }
                }
                Console.WriteLine("\n\n");
                Console.Write("Enter Id to Apply Vacancy : ");
                int id = int.Parse(Console.ReadLine()!);
                Notifications newNotification = new Notifications
                {
                    ApplicantName = CurrentWorker.Name!,
                    ApplicantID = CurrentWorker.Id,
                    ApplicantCV = CurrentWorker.WorkerCV!,
                    NotificationDate = DateTime.Now,
                };
                dataBase?.GetVacancyByID(id)?.Notify?.Add(newNotification);
                Console.WriteLine("\n");
                Thread.Sleep(1000);
                Console.Clear();
                WorkerPage();

            }
            else if (option == 3)
            {
                Thread.Sleep(1000);
                Console.Clear();
                CurrentWorker.AddCV();
                WorkerPage();

            }
            else if (option == 4)
            {
                Console.Clear();
                dataBase.ShowCV();
                Console.WriteLine("\n");
                WorkerPage();

            }
            else if (option == 5)
            {
                Console.Clear();
                if (CurrentWorker.Notifications != null)
                {
                    foreach (var item in CurrentWorker.Notifications)
                    {
                        Console.WriteLine(item);
                    }
                }
                WorkerPage();

            }
            else if (option == 0)
            {
                Console.Clear();
                Start();
            }
            else
            {
                throw new CustomExceptionClass("Please choose between 0-6", DateTime.Now, callStack.GetFileLineNumber(), System.Reflection.Assembly.GetExecutingAssembly().Location);
            }
        }

    }
}
