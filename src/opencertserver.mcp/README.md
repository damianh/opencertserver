# OpenCertServer MCP

Model Context Protocol server for OpenCertServer.

This project uses the official `ModelContextProtocol` .NET SDK with:

- `AddMcpServer().WithStdioServerTransport()`
- Attribute-discovered tools (`[McpServerToolType]` + `[McpServerTool]`)

The server runs over stdio and exposes certificate query, issuance, and revocation tools.
