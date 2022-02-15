public class OwnerCreationDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Address { get; set; }
    public ICollection<AccountCreationDto>? Accounts { get; set; }
}