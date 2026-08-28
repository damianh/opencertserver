namespace OpenCertServer.Mcp.Tools;

using System.Security.Cryptography.X509Certificates;

public class McpOcspCheckResult
{
    public required string SerialNumber { get; set; }
    public required McpCertificateStatus Status { get; set; }
    public X509RevocationReason? RevocationReason { get; set; }
    public DateTimeOffset? RevocationTime { get; set; }
    public required DateTimeOffset ThisUpdate { get; set; }
    public required DateTimeOffset NextUpdate { get; set; }
}