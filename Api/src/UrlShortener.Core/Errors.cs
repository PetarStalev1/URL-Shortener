namespace UrlShortener.Core;

public static class Errors
{
    public static Error MissingCreatedBy => new Error(Code: "Missing_value", Description: "Created by is required");
}