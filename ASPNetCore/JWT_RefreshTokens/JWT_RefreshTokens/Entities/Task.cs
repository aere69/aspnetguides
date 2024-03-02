#nullable disable
using System;
using System.Collections.Generic;

namespace JWT_RefreshTokens.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Ts { get; set; }

        //Reference to foreign Key User Id
        public virtual User User { get; set; }
    }
}
