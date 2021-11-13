using System.ComponentModel.DataAnnotations;

namespace Oxit.Core.Utilities
{
    public static class Permissions
    {

        public static class General
        {
            [Display(Name = "Genel Yetki Tanımı")]
            public const string All = "Permissions.General.All";

        }
        public static class Dashboard
        {
            [Display(Name = "Panel")]
            public const string Index = "Permissions.Dashboard.Index";

        }



        public static List<string?> getPermissions()
        {
            List<string?> Permissions = new List<string?>();

            foreach (Type type in typeof(Permissions).GetNestedTypes())
            {
                foreach (var fiels in type.GetFields())
                {
                    Permissions.Add(fiels.GetValue(type)?.ToString());
                };
            }

            return Permissions;
        }
        public static List<PermissionList> getAllPermissions()
        {
            List<PermissionList> Permissions = new List<PermissionList>();

            foreach (Type type in typeof(Permissions).GetNestedTypes())
            {
                foreach (var fiels in type.GetFields())
                {
                    Permissions.Add(new PermissionList
                    {
                        Permission = fiels.GetValue(type)?.ToString(),
                        Description = fiels.GetCustomAttributes(typeof(DisplayAttribute), false).Length > 0 ? ((DisplayAttribute)fiels.GetCustomAttributes(typeof(DisplayAttribute), false)[0]).Name : ""

                    });
                };
            }

            return Permissions;
        }

        public class PermissionList
        {
            public string? Permission { get; set; }
            public string? Description { get; set; }
        }
    }
}
