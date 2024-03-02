#nullable disable

namespace JWT_RefreshTokens.Entities
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TokenHash { get; set; }
        public string TokenSalt { get; set; }
        public DateTime Ts { get; set; }
        public DateTime ExpiryDate { get; set; }
                
        //Reference to foreign Key User Id
        public virtual User User { get; set; }
    }
}
