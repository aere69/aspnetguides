#nullable disable

namespace JWT_RefreshTokens.Responses
{
    public class SaveTaskResponse : BaseResponse
    {
        public Entities.Task Task { get; set; } 
    }
}
