using System.Runtime.Serialization;

namespace PagarMe.Models.Enums
{
    /// <summary>
    /// Bank account holder type enum
    /// </summary>
    public enum BankAccountTypeEnum
    {
        [EnumMember(Value = "checking")]
        Checking,

        [EnumMember(Value = "savings")]
        Savings
    }
}