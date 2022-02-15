public interface IAccountRepository
{
    Task<IEnumerable<Account>> GetByOwnerIdAsync(Guid ownerId, CancellationToken cancellationToken = default);
    Task<Account> GetByIdAsync(Guid accountId, CancellationToken cancellationToken = default);
    void Insert(Account account);
    void Remove(Account account);
}