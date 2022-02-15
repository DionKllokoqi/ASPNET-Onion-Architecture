using System.Collections.Generic;
using Xunit;

namespace Contracts.Tests;

public class GenericAdapter_AdaptShould
{
    [Fact]
    public void Adapt_InputIsListOfAccount_ShouldReturnListOfAccountDto()
    {
        // Arrange
        Account a1 = new Account 
        {
            Id = System.Guid.NewGuid(),
            DateCreated = System.DateTime.Now,
            AccountType = "Test-Acc",
            OwnerId = System.Guid.NewGuid()
        };

        Account a2 = new Account 
        {
            Id = System.Guid.NewGuid(),
            DateCreated = System.DateTime.Now,
            AccountType = "Test-Acc",
            OwnerId = System.Guid.NewGuid()
        };

        List<Account> accs = new List<Account>{a1, a2};

        // Act
        var accountsDto = (List<AccountDto>)accs.Adapt<AccountDto>();

        // Assert
        Assert.Equal(accs.Count, accountsDto.Count);
    }
}