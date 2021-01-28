using System.Runtime.Serialization;

namespace PagarMe.Models.Enums
{
    /// <summary>
    /// Customer type enum
    /// </summary>
    public enum CustomerTypeEnum
    {
        [EnumMember(Value = "individual")]
        Individual,

        [EnumMember(Value = "company")]
        Company
    }
}