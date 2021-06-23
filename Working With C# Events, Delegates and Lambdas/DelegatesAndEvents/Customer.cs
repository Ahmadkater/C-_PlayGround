using System ; 

namespace DelegatesAndEvents
{
    public class Customer 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public Customer(int id , string fname , string lname , string city)
        {
            Id = id ; 
            FirstName = fname ;
            LastName = lname ;
            City = city ;
        }

        public override string ToString() => $"Id: {Id} \nName: {FirstName} {LastName}\nCity: {City}\n";
    }
}