public interface IServiceManager
{
    IOwnerService OwnerService { get; }

    IAccountService AccountService { get; }
}