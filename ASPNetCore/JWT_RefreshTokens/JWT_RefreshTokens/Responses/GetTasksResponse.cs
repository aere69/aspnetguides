#nullable disable

using JWT_RefreshTokens.Entities;

namespace JWT_RefreshTokens.Responses
{
    public class GetTasksResponse : BaseResponse
    {
        public List<Entities.Task> Tasks { get; set; }
    }
}
