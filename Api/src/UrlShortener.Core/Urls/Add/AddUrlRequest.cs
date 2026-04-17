namespace UrlShortener.Api.Core.Tests;

public record AddUrlRequest(Uri LongUri, string CreatedBy);