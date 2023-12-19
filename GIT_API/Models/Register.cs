namespace GIT_API.Models
{
    public class Register
    {
        public int Id { get; set; }
        public string Employee_Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public UserLogin UserLogin { get; set; }
        public int EmployeeId { get; set; }
    }
}
