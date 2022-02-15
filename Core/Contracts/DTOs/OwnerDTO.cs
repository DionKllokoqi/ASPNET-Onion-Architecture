public class OwnerDto
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Address { get; set; }
    public ICollection<AccountDto>? Accounts { get; set; }
}