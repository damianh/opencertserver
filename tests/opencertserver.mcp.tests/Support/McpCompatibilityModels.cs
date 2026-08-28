namespace OpenCertServer.Mcp.Tests.Support;

public enum McpErrorCode
{
    ToolNotFound = -32601
}

public sealed class McpToolDefinition
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string InputSchema { get; set; }
}

public sealed class McpToolResult
{
    public bool IsSuccess { get; }
    public object? Content { get; }
    public string? ErrorMessage { get; }
    public int ErrorCode { get; }

    public McpToolResult(bool success, object? content = null, string? errorMessage = null, int errorCode = 0)
    {
        IsSuccess = success;
        Content = content;
        ErrorMessage = errorMessage;
        ErrorCode = errorCode;
    }

    public static McpToolResult Ok(object content) => new(true, content);

    public static McpToolResult Fail(string message, int code = 400) => new(false, null, message, code);
}
