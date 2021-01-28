using System.Runtime.Serialization;

namespace PagarMe.Models.Enums
{
    /// <summary>
    /// Order status enum
    /// </summary>
    public enum OrderStatusEnum
    {
        [EnumMember(Value = "pending")]
        Pending,

        [EnumMember(Value = "paid")]
        Paid,

        [EnumMember(Value = "canceled")]
        Canceled,

        [EnumMember(Value = "failed")]
        Failed
    }
}