// <copyright file="Jobsuche.cs" company="Sascha Manns">
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

using GermanArbeitsamtJobsearchClient.Models;

using RestSharp;

namespace GermanArbeitsamtJobsearchClient;

/// <summary>
/// Class Jobsuche.
/// </summary>
public class Jobsuche
{
  /// <summary>
  /// The endpoint
  /// </summary>
  private readonly string _endpoint = "/pc/v4/jobsuche";

  /// <summary>
  /// Send request as an asynchronous operation.
  /// </summary>
  /// <param name="model">The model.</param>
  /// <returns>A Task&lt;JobSearchResponse&gt; representing the asynchronous operation.</returns>
  public async Task<JobSearchResponse> SendRequestAsync(JobSearchRequest model)
  {

    var parameters = new Dictionary<string, string>
    {
      { "page", model.Page.ToString() },
      { "size", model.Size.ToString() },
      { "was", model.Was },
      { "wo", model.Wo },
      { "berufsfeld", model.Berufsfeld },
      { "arbeitgeber", model.Arbeitgeber },
      { "veroeffentlichtseit", model.VeroeffentlichtSeit.ToString() },
      { "zeitarbeit", model.Zeitarbeit.ToString() },
      { "angebotsart", model.Angebotsart.ToString() },
      { "befristung", model.Befristung.ToString() },
      { "arbeitszeit", model.Arbeitszeit },
      { "behinderung", model.Behinderung.ToString() },
      { "corona", model.Corona.ToString() },
      { "umkreis", model.Umkreis.ToString() }
    };

    var ergebnis = await ApiRequest.SendAsync<JobSearchResponse>(
      resource: _endpoint,
      method: Method.Get,
      parameters: parameters
    );

    return ergebnis;
  }
}
