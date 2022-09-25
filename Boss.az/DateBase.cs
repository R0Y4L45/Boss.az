
namespace Boss.az
{
    public class DataBase
    {
        public List<Human>? humans;
        public Vacancy GetVacancyByID(int id)
        {
            if (humans != null)
            {
                foreach (var item in humans)
                {
                    if (item is Employer)
                    {
                        Employer? emp = item as Employer;
                        foreach (var i in emp?.vacancies!)
                        {
                            if (i.ID == id)
                            {
                                Console.WriteLine("Succesfully Applied");
                                return i;
                            }
                        }
                        return null!;

                    }
                    else
                        return null!;
                }
                return null!;
            }
            else
                return null!;
        }

        public void ShowCV()

        {
            Console.WriteLine("*************Worker CV**********************");

            foreach (var item in humans!)
            {
                if (item is Worker)
                {
                    Worker? worker = item as Worker;
                    foreach (var i in worker?.WorkerCV!)
                        i.ShowCV();
                }
            }

        }

        public Worker GetWorkerByID(int id)
        {
            foreach (var i in humans!)
            {
                if (i is Worker && i.Id == id)
                {
                    Worker? worker = i as Worker;
                    return worker!;
                }
            }
            return null!;
        }


    }
}
