// <copyright file="OpenApiException.cs" company="Sascha Manns">
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
  /// <summary>
  /// Initializes a new instance of the <see cref="OpenApiException"/> class.
  /// </summary>
  public OpenApiException() { }

  /// <summary>
  /// Initializes a new instance of the <see cref="OpenApiException"/> class.
  /// </summary>
  /// <param name="message">The message that describes the error.</param>
  public OpenApiException(string message) : base(message) { }

  /// <summary>
  /// Initializes a new instance of the <see cref="OpenApiException"/> class.
  /// </summary>
  /// <param name="message">The message.</param>
  /// <param name="inner">The inner.</param>
  public OpenApiException(string message, Exception inner) : base(message, inner) { }
}

/// <summary>
/// Exception für Typfehler.
/// </summary>
public class ApiTypeErrorException : OpenApiException
{
  /// <summary>
  /// Gets the path to item.
  /// </summary>
  /// <value>The path to item.</value>
  public IList<object>? PathToItem { get; }

  /// <summary>
  /// Gets the valid classes.
  /// </summary>
  /// <value>The valid classes.</value>
  public Type[]? ValidClasses { get; }

  /// <summary>
  /// Gets a value indicating whether [key type].
  /// </summary>
  /// <value><c>null</c> if [key type] contains no value, <c>true</c> if [key type]; otherwise, <c>false</c>.</value>
  public bool? KeyType { get; }

  /// <summary>
  /// Initializes a new instance of the <see cref="ApiTypeErrorException"/> class.
  /// </summary>
  /// <param name="message">The message.</param>
  /// <param name="pathToItem">The path to item.</param>
  /// <param name="validClasses">The valid classes.</param>
  /// <param name="keyType">if set to <c>true</c> [key type].</param>
  public ApiTypeErrorException(string message, IList<object>? pathToItem = null, Type[]? validClasses = null, bool? keyType = null)
      : base(FormatMessage(message, pathToItem))
  {
    PathToItem = pathToItem;
    ValidClasses = validClasses;
    KeyType = keyType;
  }

  /// <summary>
  /// Formats the message.
  /// </summary>
  /// <param name="message">The message.</param>
  /// <param name="pathToItem">The path to item.</param>
  /// <returns>System.String.</returns>
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
public class ApiValueErrorException : OpenApiException
{
  /// <summary>
  /// Gets the path to item.
  /// </summary>
  /// <value>The path to item.</value>
  public IList<object>? PathToItem { get; }

  /// <summary>
  /// Initializes a new instance of the <see cref="ApiValueErrorException"/> class.
  /// </summary>
  /// <param name="message">The message.</param>
  /// <param name="pathToItem">The path to item.</param>
  public ApiValueErrorException(string message, IList<object>? pathToItem = null)
      : base(FormatMessage(message, pathToItem))
  {
    PathToItem = pathToItem;
  }

  /// <summary>
  /// Formats the message.
  /// </summary>
  /// <param name="message">The message.</param>
  /// <param name="pathToItem">The path to item.</param>
  /// <returns>System.String.</returns>
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
public class ApiAttributeErrorException : OpenApiException
{
  /// <summary>
  /// Gets the path to item.
  /// </summary>
  /// <value>The path to item.</value>
  public IList<object>? PathToItem { get; }

  /// <summary>
  /// Initializes a new instance of the <see cref="ApiAttributeErrorException"/> class.
  /// </summary>
  /// <param name="message">The message.</param>
  /// <param name="pathToItem">The path to item.</param>
  public ApiAttributeErrorException(string message, IList<object>? pathToItem = null)
      : base(FormatMessage(message, pathToItem))
  {
    PathToItem = pathToItem;
  }

  /// <summary>
  /// Formats the message.
  /// </summary>
  /// <param name="message">The message.</param>
  /// <param name="pathToItem">The path to item.</param>
  /// <returns>System.String.</returns>
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
public class ApiKeyErrorException : OpenApiException
{
  /// <summary>
  /// Gets the path to item.
  /// </summary>
  /// <value>The path to item.</value>
  public IList<object>? PathToItem { get; }

  /// <summary>
  /// Initializes a new instance of the <see cref="ApiKeyErrorException"/> class.
  /// </summary>
  /// <param name="message">The message.</param>
  /// <param name="pathToItem">The path to item.</param>
  public ApiKeyErrorException(string message, IList<object>? pathToItem = null)
      : base(FormatMessage(message, pathToItem))
  {
    PathToItem = pathToItem;
  }

  /// <summary>
  /// Formats the message.
  /// </summary>
  /// <param name="message">The message.</param>
  /// <param name="pathToItem">The path to item.</param>
  /// <returns>System.String.</returns>

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
  /// <summary>
  /// Gets the status.
  /// </summary>
  /// <value>The status.</value>
  public int? Status { get; }

  /// <summary>
  /// Gets the reason.
  /// </summary>
  /// <value>The reason.</value>
  public string? Reason { get; }

  /// <summary>
  /// Gets the body.
  /// </summary>
  /// <value>The body.</value>
  public string? Body { get; }

  /// <summary>
  /// Gets the headers.
  /// </summary>
  /// <value>The headers.</value>
  public IDictionary<string, IEnumerable<string>>? Headers { get; }

  /// <summary>
  /// Initializes a new instance of the <see cref="ApiException"/> class.
  /// </summary>
  /// <param name="status">The status.</param>
  /// <param name="reason">The reason.</param>
  /// <param name="httpResp">The HTTP resp.</param>
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

  /// <summary>
  /// Builds the message.
  /// </summary>
  /// <param name="status">The status.</param>
  /// <param name="reason">The reason.</param>
  /// <param name="httpResp">The HTTP resp.</param>
  /// <returns>System.String.</returns>
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

  /// <summary>
  /// Returns a <see cref="System.String" /> that represents this instance.
  /// </summary>
  /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
  public override string ToString() => Message;
}

/// <summary>
/// Class NotFoundException.
/// Implements the <see cref="GermanArbeitsamtJobsearchClient.ApiException" />
/// </summary>
/// <seealso cref="GermanArbeitsamtJobsearchClient.ApiException" />
public class NotFoundException : ApiException
{
  /// <summary>
  /// Initializes a new instance of the <see cref="NotFoundException"/> class.
  /// </summary>
  /// <param name="status">The status.</param>
  /// <param name="reason">The reason.</param>
  /// <param name="httpResp">The HTTP resp.</param>
  public NotFoundException(int? status = null, string? reason = null, HttpResponseMessage? httpResp = null)
      : base(status, reason, httpResp) { }
}

/// <summary>
/// Class UnauthorizedException.
/// Implements the <see cref="GermanArbeitsamtJobsearchClient.ApiException" />
/// </summary>
/// <seealso cref="GermanArbeitsamtJobsearchClient.ApiException" />
public class UnauthorizedException : ApiException
{
  /// <summary>
  /// Initializes a new instance of the <see cref="UnauthorizedException"/> class.
  /// </summary>
  /// <param name="status">The status.</param>
  /// <param name="reason">The reason.</param>
  /// <param name="httpResp">The HTTP resp.</param>
  public UnauthorizedException(int? status = null, string? reason = null, HttpResponseMessage? httpResp = null)
      : base(status, reason, httpResp) { }
}

/// <summary>
/// Class ForbiddenException.
/// Implements the <see cref="GermanArbeitsamtJobsearchClient.ApiException" />
/// </summary>
/// <seealso cref="GermanArbeitsamtJobsearchClient.ApiException" />
public class ForbiddenException : ApiException
{
  /// <summary>
  /// Initializes a new instance of the <see cref="ForbiddenException"/> class.
  /// </summary>
  /// <param name="status">The status.</param>
  /// <param name="reason">The reason.</param>
  /// <param name="httpResp">The HTTP resp.</param>
  public ForbiddenException(int? status = null, string? reason = null, HttpResponseMessage? httpResp = null)
      : base(status, reason, httpResp) { }
}

/// <summary>
/// Class ServiceException.
/// Implements the <see cref="GermanArbeitsamtJobsearchClient.ApiException" />
/// </summary>
/// <seealso cref="GermanArbeitsamtJobsearchClient.ApiException" />
public class ServiceException : ApiException
{
  /// <summary>
  /// Initializes a new instance of the <see cref="ServiceException"/> class.
  /// </summary>
  /// <param name="status">The status.</param>
  /// <param name="reason">The reason.</param>
  /// <param name="httpResp">The HTTP resp.</param>
  public ServiceException(int? status = null, string? reason = null, HttpResponseMessage? httpResp = null)
      : base(status, reason, httpResp) { }
}
