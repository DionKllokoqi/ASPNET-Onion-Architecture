public interface IRepositoryManager
{
    IOwnerRepository OwnerRepository { get; }

    IAccountRepository AccountRepository { get; }
}