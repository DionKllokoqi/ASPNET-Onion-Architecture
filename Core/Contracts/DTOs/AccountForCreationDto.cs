public class AccountForCreationDto
{
    #region Public Properties

    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public string? AccountType { get; set; }
    public Guid OwnerId { get; set; }
    
    #endregion
}