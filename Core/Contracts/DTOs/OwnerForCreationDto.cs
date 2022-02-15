public class OwnerForCreationDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Address { get; set; }
    public ICollection<AccountForCreationDto>? Accounts { get; set; }
}