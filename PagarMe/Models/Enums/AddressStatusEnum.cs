using System.Runtime.Serialization;

namespace PagarMe.Models.Enums
{
    /// <summary>
    /// Address status enum
    /// </summary>
    public enum AddressStatusEnum
    {
        [EnumMember(Value = "active")]
        Active,

        [EnumMember(Value = "deleted")]
        Deleted,
    }
}