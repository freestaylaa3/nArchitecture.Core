﻿using Core.Persistence.Repositories;
using Core.Security.Enums;
using System.Numerics;

namespace Core.Security.Entities;

public class User : Entity<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public bool Status { get; set; } = true;
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public AuthenticatorType AuthenticatorType { get; set; }

    public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; } = null!;
    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = null!;
    public virtual ICollection<EmailAuthenticator> EmailAuthenticators { get; set; } = null!;
    public virtual ICollection<OtpAuthenticator> OtpAuthenticators { get; set; } = null!;

    public User()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        PasswordHash = Array.Empty<byte>();
        PasswordSalt = Array.Empty<byte>();
    }

    public User(
        string firstName,
        string lastName,
        string email,
        string? phone,
        bool status,
        byte[] passwordSalt,
        byte[] passwordHash,
        AuthenticatorType authenticatorType
    )
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Status = status;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        AuthenticatorType = authenticatorType;
    }

    public User(
        int id,
        string firstName,
        string lastName,
        string email,
        string? phone,
        bool status,
        byte[] passwordSalt,
        byte[] passwordHash,
        AuthenticatorType authenticatorType
    )
        : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Status = status;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        AuthenticatorType = authenticatorType;
    }
}
