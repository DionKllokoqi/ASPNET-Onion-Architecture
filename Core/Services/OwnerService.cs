internal sealed class OwnerService : IOwnerService
{
    private readonly IRepositoryManager _repositoryManager;

    public OwnerService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

    public Task<OwnerDto> CreateAsync(OwnerForCreationDto ownerCreationDto, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid ownerId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<OwnerDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var owners = await _repositoryManager.OwnerRepository.GetAllAsync(cancellationToken);

        var ownerDto = owners.Adapt<OwnerDto>();

        return ownerDto;
    }

    public Task<OwnerDto> GetByIdAsync(Guid ownerId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid ownerId, OwnerForUpdateDto ownerForUpdateDto, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}