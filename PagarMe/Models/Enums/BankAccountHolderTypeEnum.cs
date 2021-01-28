using System.Runtime.Serialization;

namespace PagarMe.Models.Enums
{
    /// <summary>
    /// Bank account holder type enum
    /// </summary>
    public enum BankAccountHolderTypeEnum
    {
        [EnumMember(Value = "individual")]
        Individual,

        [EnumMember(Value = "company")]
        Company
    }
}