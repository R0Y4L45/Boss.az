
namespace Boss.az
{
    public class CV
    {
        public string? Qualification { get; set; }
        public string? School { get; set; }
        public double UniScore { get; set; }
        public List<string>? Skils { get; set; }
        public List<PreviousWorkedCompanies>? previousWorkedCompanies { get; set; }
        public List<string>? Languages { get; set; }
        public bool HasCertificate { get; set; }
        public string? WebsiteLinks { get; set; }

        public CV() { }
        public CV(string? qualification, string? school, double uniScore, List<string>? skils, List<PreviousWorkedCompanies>? previousWorkedCompanies, List<string>? languages, bool hasCertificate, string? websiteLinks)
        {
            Qualification = qualification;
            School = school;
            UniScore = uniScore;
            Skils = skils;
            this.previousWorkedCompanies = previousWorkedCompanies;
            Languages = languages;
            HasCertificate = hasCertificate;
            WebsiteLinks = websiteLinks;
        }

        public void ShowCV()
        {
            Console.WriteLine($"-Qualificaation    : {Qualification}-");
            Console.WriteLine(" ---------------------------------------");
            Console.WriteLine($"-School            : {School}");
            Console.WriteLine(" ---------------------------------------");

            Console.WriteLine($"-University score  : {UniScore}-");
            int c = 0;
            foreach (var item in Skils!)
            {
                Console.WriteLine($"[{++c}] Skill : {item}");
            }
            Console.WriteLine(" ---------------------------------------");

            foreach (var item in previousWorkedCompanies!)
            {
                item.Show();
            }
            Console.WriteLine(" ---------------------------------------");

            int k = 0;
            foreach (var item in Languages!)
            {
                Console.WriteLine($"[{++k}] Language : {item}");

            }
            Console.WriteLine(" ---------------------------------------");

            Console.WriteLine($"Certificate  : {HasCertificate}");
            Console.WriteLine(" ---------------------------------------");

            Console.WriteLine($"Website Link : {WebsiteLinks}");
            Console.WriteLine(" **********************************************");
        }
    }
}
