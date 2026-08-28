namespace OpenCertServer.Est.Tests;

using OpenCertServer.Est.Server.Response;

using System.Security.Claims;
using Server.Handlers;

internal class TestCsrAttributesLoader : ICsrTemplateLoader
{
    public async Task<CsrAttributesResponse> GetTemplate(
        string? profileName,
        ClaimsPrincipal? user,
        CancellationToken cancellationToken)
    {
        await Task.Yield();
        return CsrAttributesResponse.Unavailable();
    }
}