// <copyright file="Exceptions.cs" company="Sascha Manns">
// Copyright (c) 2025 Sascha Manns.
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
// associated documentation files (the “Software”), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial
// portions of the Software.
// 
// THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
// PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN
// ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>

namespace GermanArbeitsamtJobsearchClient;

/// <summary>
/// Basisklasse für alle OpenAPI-Ausnahmen.
/// </summary>
public class OpenApiException : Exception
{
  public OpenApiException() { }
  public OpenApiException(string message) : base(message) { }
  public OpenApiException(string message, Exception inner) : base(message, inner) { }
}

/// <summary>
/// Exception für Typfehler.
/// </summary>
public class ApiTypeError : OpenApiException
{
  public IList<object>? PathToItem { get; }
  public Type[]? ValidClasses { get; }
  public bool? KeyType { get; }

  public ApiTypeError(string message, IList<object>? pathToItem = null, Type[]? validClasses = null, bool? keyType = null)
      : base(FormatMessage(message, pathToItem))
  {
    PathToItem = pathToItem;
    ValidClasses = validClasses;
    KeyType = keyType;
  }

  private static string FormatMessage(string message, IList<object>? pathToItem)
  {
    if (pathToItem != null && pathToItem.Count > 0)
      return $"{message} at {ExceptionUtils.RenderPath(pathToItem)}";
    return message;
  }
}

/// <summary>
/// Exception für ungültige Werte.
/// </summary>
public class ApiValueError : OpenApiException
{
  public IList<object>? PathToItem { get; }

  public ApiValueError(string message, IList<object>? pathToItem = null)
      : base(FormatMessage(message, pathToItem))
  {
    PathToItem = pathToItem;
  }

  private static string FormatMessage(string message, IList<object>? pathToItem)
  {
    if (pathToItem != null && pathToItem.Count > 0)
      return $"{message} at {ExceptionUtils.RenderPath(pathToItem)}";
    return message;
  }
}

/// <summary>
/// Exception für Attributfehler.
/// </summary>
public class ApiAttributeError : OpenApiException
{
  public IList<object>? PathToItem { get; }

  public ApiAttributeError(string message, IList<object>? pathToItem = null)
      : base(FormatMessage(message, pathToItem))
  {
    PathToItem = pathToItem;
  }

  private static string FormatMessage(string message, IList<object>? pathToItem)
  {
    if (pathToItem != null && pathToItem.Count > 0)
      return $"{message} at {ExceptionUtils.RenderPath(pathToItem)}";
    return message;
  }
}

/// <summary>
/// Exception für Key-Fehler.
/// </summary>
public class ApiKeyError : OpenApiException
{
  public IList<object>? PathToItem { get; }

  public ApiKeyError(string message, IList<object>? pathToItem = null)
      : base(FormatMessage(message, pathToItem))
  {
    PathToItem = pathToItem;
  }

  private static string FormatMessage(string message, IList<object>? pathToItem)
  {
    if (pathToItem != null && pathToItem.Count > 0)
      return $"{message} at {ExceptionUtils.RenderPath(pathToItem)}";
    return message;
  }
}

/// <summary>
/// Exception für HTTP-Fehler.
/// </summary>
public class ApiException : OpenApiException
{
  public int? Status { get; }
  public string? Reason { get; }
  public string? Body { get; }
  public IDictionary<string, IEnumerable<string>>? Headers { get; }

  public ApiException(int? status = null, string? reason = null, HttpResponseMessage? httpResp = null)
      : base(BuildMessage(status, reason, httpResp))
  {
    if (httpResp != null)
    {
      Status = (int)httpResp.StatusCode;
      Reason = httpResp.ReasonPhrase;
      Body = httpResp.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
      Headers = httpResp.Headers.ToDictionary(h => h.Key, h => h.Value);
    }
    else
    {
      Status = status;
      Reason = reason;
      Body = null;
      Headers = null;
    }
  }

  private static string BuildMessage(int? status, string? reason, HttpResponseMessage? httpResp)
  {
    var msg = $"Status Code: {status}\nReason: {reason}\n";
    if (httpResp != null)
    {
      msg += $"HTTP response headers: {string.Join(", ", httpResp.Headers.Select(h => $"{h.Key}: {string.Join(";", h.Value)}"))}\n";
      var body = httpResp.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
      if (!string.IsNullOrEmpty(body))
        msg += $"HTTP response body: {body}\n";
    }
    return msg;
  }

  public override string ToString() => Message;
}

public class NotFoundException : ApiException
{
  public NotFoundException(int? status = null, string? reason = null, HttpResponseMessage? httpResp = null)
      : base(status, reason, httpResp) { }
}

public class UnauthorizedException : ApiException
{
  public UnauthorizedException(int? status = null, string? reason = null, HttpResponseMessage? httpResp = null)
      : base(status, reason, httpResp) { }
}

public class ForbiddenException : ApiException
{
  public ForbiddenException(int? status = null, string? reason = null, HttpResponseMessage? httpResp = null)
      : base(status, reason, httpResp) { }
}

public class ServiceException : ApiException
{
  public ServiceException(int? status = null, string? reason = null, HttpResponseMessage? httpResp = null)
      : base(status, reason, httpResp) { }
}
