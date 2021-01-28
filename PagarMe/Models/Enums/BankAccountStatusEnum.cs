﻿using System.Runtime.Serialization;

namespace PagarMe.Models.Enums
{
    /// <summary>
    /// Bank account status enum
    /// </summary>
    public enum BankAccountStatusEnum
    {
        [EnumMember(Value = "active")]
        Active,

        [EnumMember(Value = "inactive")]
        Inactive,
    }
}