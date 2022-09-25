
namespace Boss.az
{
    public class Notifications
    {
        static int staticId;
        public int Id { get; set; }
        public int ApplicantID { get; set; } = default;
        public string? ApplicantName { get; set; } = default;
        public List<CV>? ApplicantCV { get; set; } = default;
        public DateTime NotificationDate { get; set; } = default;

        public Notifications()
        {
            Id = ++staticId;
        }

        public Notifications(int applicantID, string? applicantName, List<CV>? applicantCV, DateTime notificationDate)
        {
            Id = ++staticId;
            ApplicantID = applicantID;
            ApplicantName = applicantName;
            ApplicantCV = applicantCV;
            NotificationDate = notificationDate;
        }

        public void ShowNotification()
        {
            Console.WriteLine($"ID  : {Id}");
            Console.WriteLine($"Applicant ID    : {ApplicantID}");
            Console.WriteLine($"Applicant Name  : {ApplicantName}");

            foreach (var item in ApplicantCV!)
                item.ShowCV();

            Console.WriteLine($"Notification Date  : {NotificationDate}");
        }
    }
}
