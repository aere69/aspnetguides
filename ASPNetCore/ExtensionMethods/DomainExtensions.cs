namespace DomainExtensions 
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public static class UserEntityExtensions
    {
        public static string FullName(this UserEntity value)
            => $"{value.FirstName} {value.LastName}";
    }
}
