using System.ComponentModel.DataAnnotations;

public class AdminUsers
{
    [Key]
    public int AdminUserID { get; set; }

    [Required]
    public string AdminUsername { get; set; }

    [Required]
    public string AdminPassword { get; set; }

    //Failed login attempts and lockout properties to enhance security
    public int FailedLoginAttempts { get; set; } = 0;
    public bool IsLocked { get; set; } = false;
}
