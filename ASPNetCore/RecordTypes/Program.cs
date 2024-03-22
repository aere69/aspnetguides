using System.ComponentModel.DataAnnotations;

namespace RecordTypes;

class Program
{
    public enum Roles
    {
        User = 1,
        Administrator = 2,
        Reviewer = 3,
        [Display(Name = "Super Admin")]
        SuperAdmin = 4
    }

    public static class RolesExtensions {
        public static bool IsAdmin(this Roles roles) => (roles == Roles.Administrator || roles == Roles.SuperAdmin);
    }

    public record RRoles(int id, string Name)
    {
        public static RRoles User { get; } = new(1, "User");
        public static RRoles Administrator { get; } = new(2, "Administrator");
        public static RRoles Reviewer { get; } = new(3, "Reviewer");
        public static RRoles SuperAdmin { get; } = new(4, "Super Admin");
        public override string ToString() => Name;
    }

    static void Main(string[] args)
    {
        //Explicit cast needed.
        int role = (int)Roles.User;

        RRoles admin = RRoles.Administrator;
        RRoles user = RRoles.User;
        RRoles reviewer = RRoles.Reviewer;
        RRoles SuperAdmin = RRoles.SuperAdmin;

        Console.WriteLine("The role is : {0}", SuperAdmin.ToString());
    }
}
