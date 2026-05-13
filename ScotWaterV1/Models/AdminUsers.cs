using System.ComponentModel.DataAnnotations;

public class AdminUsers
{
    //Dean Caldwell
    [Key]
    public int AdminUserID { get; set; }

    [Required]
    public string AdminUsername { get; set; }

    [Required]
    public string AdminPassword { get; set; }
}


