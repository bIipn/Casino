using System;

namespace CasinoExamples
{
    public static class PermissionChecker
    {
        // Evaluates permission string and numeric access level and returns a human message.
        public static string Check(string permission, int level)
        {
            if (string.IsNullOrEmpty(permission)) return "You don't have access to this page.";

            bool isAdmin = permission.Contains("Admin", StringComparison.OrdinalIgnoreCase);
            bool isManager = permission.Contains("Manager", StringComparison.OrdinalIgnoreCase);

            if (isAdmin && level < 55)
                return "Welcome, Super Admin user.";
            if (isAdmin && level >= 55)
                return "Welcome, Admin user.";
            if (isManager && level < 20)
                return "Welcome, Manager user.";
            // default fallback
            return "You don't have access to this page.";
        }
    }
}
