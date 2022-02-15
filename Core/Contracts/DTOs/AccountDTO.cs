public class AccountDto
{
    #region Public Properties

    public DateTime DateCreated { get; set; }
    public string? AccountType { get; set; }
    public Guid OwnerId { get; set; }
    
    #endregion
}