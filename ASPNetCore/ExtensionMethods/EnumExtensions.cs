namespace EnumExtensions
{
    public enum Roles
    {
        User = 1,
        Administrator = 2,
        Reviewer = 3,
        SuperAdmin = 4
    }

    public static class RolesExtensions {
        public static bool IsAdmin(this Roles roles) => (roles == Roles.Administrator || roles == Roles.SuperAdmin);
    }
}