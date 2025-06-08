// <copyright file="ApiRequest.cs" company="Sascha Manns">
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

using RestSharp;

namespace GermanArbeitsamtJobsearchClient;

/// <summary>
/// Class ApiRequest. Used as main class for sending.
/// </summary>
public static class ApiRequest
{
  private static string _baseUrl = "https://rest.arbeitsagentur.de/jobboerse/jobsuche-service";
  private static string _apiKey = "jobboerse-jobsuche";

  /// <summary>
  /// Sendet einen API-Request mit RestSharp.
  /// </summary>
  /// <typeparam name="TResponse">Expected Response-Type.</typeparam>
  /// <param name="resource">The API-Endpoint (z.B. "/stellenangebote").</param>
  /// <param name="method">HTTP-Method (GET, POST, etc.).</param>
  /// <param name="parameters">The serialized JobSearchRequest data.</param>
  /// <returns>Deserialized response object of type TResponse.</returns>
  public static async Task<TResponse?> SendAsync<TResponse>(
    string resource,
    Method method,
    Dictionary<string, string>? parameters = null)
  {
    var options = new RestClientOptions(_baseUrl);
    using var client = new RestClient(options);
    var request = new RestRequest(resource, method);
    request.AddHeader("X-API-Key", _apiKey);

    if (parameters != null)
    {
      foreach (var param in parameters)
        request.AddQueryParameter(param.Key, param.Value);
    }

    var response = await client.ExecuteAsync<TResponse>(request);

    if (!response.IsSuccessful)
      throw new ApiException((int?)response.StatusCode, response.ErrorMessage ?? response.StatusDescription);

    return response.Data;
  }
}
