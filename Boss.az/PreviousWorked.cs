
namespace Boss.az
{
    public class PreviousWorkedCompanies
    {
        public Guid id;
        public string? CompanyName { get; set; } = default;
        public string? Position { get; set; } = default;
        public DateTime StartDate { get; set; } = default;
        public DateTime EndDate { get; set; } = default;

        public PreviousWorkedCompanies()
        {
            id = Guid.NewGuid();
        }

        public PreviousWorkedCompanies(string? CompanyName, string? Position, DateTime StartDate, DateTime EndDate)
        {
            id = Guid.NewGuid();
            this.CompanyName = CompanyName;
            this.Position = Position;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }

        public void Show()
        {
            Console.WriteLine($"Company Name : {CompanyName}");
            Console.WriteLine($"Position     : {Position}");
            Console.WriteLine($"Start Date   : {StartDate}");
            Console.WriteLine($"End Date     : {EndDate}");
        }


    }
}
