﻿#nullable disable

using System.Text.Json.Serialization;

namespace JWT_RefreshTokens.Responses
{
    public class BaseResponse
    {
        [JsonIgnore()]
        public bool Success { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ErrorCode { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Error { get; set; }
    }
}
