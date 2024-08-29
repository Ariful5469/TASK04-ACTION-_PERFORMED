using Microsoft.AspNetCore.Identity;
using System;

namespace MyLibrary.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public bool IsBlocked { get; set; } = false; // Default to not blocked
        public DateTime? LastLoginTime { get; set; } // Nullable to handle users who haven't logged in yet
    }
}
