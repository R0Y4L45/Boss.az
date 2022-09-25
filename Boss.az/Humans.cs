
namespace Boss.az
{
    public class Human
    {
        static int staticId;
        public int Id { get; set; } = default;
        public string? Name { get; set; } = default;
        public string? Surname { get; set; } = default;
        public string? City { get; set; } = default;
        public string? Phone { get; set; } = default;
        public int Age { get; set; } = default;
        public string? Mail { get; set; } = default;
        public string? Password { get; set; } = default;

        public Human()
        {
            Id = ++staticId;
        }

        public Human(string? name, string? surname, string? city, string? phone, int age, string? mail, string? password)
        {
            Id = ++staticId;
            Name = name;
            Surname = surname;
            City = city;
            Phone = phone;
            Age = age;
            Mail = mail;
            Password = password;
        }

        public override string ToString()
        {
            return $@"Id     : {Id}
Name     : {Name}
Surname  : {Surname}
Age      : {Age}
Phone    : {Phone}
City     : {City}
E-Mail   : {Mail}
Password : {Password}";

        }

    }
}
