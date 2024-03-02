#nullable disable

namespace JWT_RefreshTokens.Responses
{
    public class TaskResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Ts { get; set; }
    }
}
