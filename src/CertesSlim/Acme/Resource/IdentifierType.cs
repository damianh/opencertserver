namespace CertesSlim.Acme.Resource;

using System.Runtime.Serialization;

/// <summary>
/// Represents type of <see cref="Identifier"/>.
/// </summary>
public enum IdentifierType
{
    /// <summary>
    /// The DNS type.
    /// </summary>
    [EnumMember(Value = "dns")]
    Dns
}