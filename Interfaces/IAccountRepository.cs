﻿using BankRestApi.Models;

namespace BankRestApi.Services;

public interface IAccountRepository
{
    Task<Account?> GetById(Guid? id);
    Task<Account> Insert(Account account);
    Task<Account?> Update(Account account);
}