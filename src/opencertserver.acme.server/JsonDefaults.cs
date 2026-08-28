namespace OpenCertServer.Acme.Server;

using System.Text.Json.Serialization;
using CertesSlim.Json;
using OpenCertServer.Acme.Abstractions.HttpModel.Requests;
using OpenCertServer.Acme.Abstractions.Model;

[JsonSourceGenerationOptions(
    UseStringEnumConverter = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWriting,
    WriteIndented = false,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
[JsonSerializable(typeof(Account))]
[JsonSerializable(typeof(ExternalAccountKey))]
[JsonSerializable(typeof(AcmeHeader))]
[JsonSerializable(typeof(JwsPayload))]
[JsonSerializable(typeof(CreateOrGetAccount))]
[JsonSerializable(typeof(UpdateAccountRequest))]
[JsonSerializable(typeof(CreateOrderRequest))]
[JsonSerializable(typeof(UpdateAuthorizationRequest))]
[JsonSerializable(typeof(FinalizeOrderRequest))]
[JsonSerializable(typeof(KeyChangeRequest))]
[JsonSerializable(typeof(RevokeCertificateRequest))]
[JsonSerializable(typeof(DeviceAttestChallengeAnswer))]
public partial class AcmeSerializerContext : JsonSerializerContext
{
}