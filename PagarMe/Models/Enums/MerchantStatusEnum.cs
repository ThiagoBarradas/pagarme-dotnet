using System.Runtime.Serialization;

namespace PagarMe.Models.Enums
{
    /// <summary>
    /// Merchant status enum
    /// </summary>
    public enum MerchantStatusEnum
    {
        [EnumMember(Value = "active")]
        Active,

        [EnumMember(Value = "inactive")]
        Inactive,
    }
}