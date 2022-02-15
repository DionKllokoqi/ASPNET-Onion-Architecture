public static class GenericAdapter
{
    public static IEnumerable<T> Adapt<T>(this IEnumerable<Account> converters)
    {
        List<T> converted = new List<T>(converters.Count());

        foreach (var converter in converters)
        {
            if (typeof(T) == typeof(AccountDto))
            {
                var value = new AccountDto 
                {
                    DateCreated = converter.DateCreated,
                    AccountType = converter.AccountType,
                    OwnerId = converter.OwnerId
                };

                converted.Add((T)Convert.ChangeType(value, typeof(T)));
            }
            else if (typeof(T) == typeof(AccountCreationDto))
            {
                var value = new AccountCreationDto 
                {
                    Id = converter.Id,
                    DateCreated = converter.DateCreated,
                    AccountType = converter.AccountType,
                    OwnerId = converter.OwnerId
                };

                converted.Add((T)Convert.ChangeType(value, typeof(T)));
            }
        }

        return converted;
    }

    public static IEnumerable<T> Adapt<T>(this IEnumerable<AccountCreationDto> converters)
    {
        List<T> converted = new List<T>(converters.Count());

        foreach (var converter in converters)
        {
            if (typeof(T) == typeof(Account))
            {
                var value = new Account
                {
                    Id = converter.Id,
                    DateCreated = converter.DateCreated,
                    AccountType = converter.AccountType,
                    OwnerId = converter.OwnerId
                };

                converted.Add((T)Convert.ChangeType(value, typeof(T)));
            }
            else if (typeof(T) == typeof(AccountDto))
            {
                var value = new AccountDto
                {
                    DateCreated = converter.DateCreated,
                    AccountType = converter.AccountType,
                    OwnerId = converter.OwnerId
                };

                converted.Add((T)Convert.ChangeType(value, typeof(T)));
            }
        }

        return converted;
    }
}