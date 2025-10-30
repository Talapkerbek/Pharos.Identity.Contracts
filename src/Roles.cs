namespace Pharos.Identity.Contracts;

public static class Roles
{
    public const string SuperAdmin = "SuperAdmin";
    public const string TenantMainAdmin = "TenantMainAdmin";
    
    public static List<string> ListOfRoles = [Roles.SuperAdmin, Roles.TenantMainAdmin];
}