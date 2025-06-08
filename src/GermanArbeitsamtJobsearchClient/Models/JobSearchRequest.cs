// <copyright file="JobSearchRequest.cs" company="Sascha Manns">
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

namespace GermanArbeitsamtJobsearchClient.Models;

/// <summary>
/// Class JobSearchRequest.
/// </summary>
public class JobSearchRequest
{
  /// <summary>
  /// Gets or sets the was. Exapmple: "Softwareentwickler"
  /// </summary>
  /// <value>The was.</value>
  public string Was { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the wo. Example: "Berlin"
  /// </summary>
  /// <value>The wo.</value>
  public string Wo { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the berufsfeld. Example: "Informatik"
  /// </summary>
  /// <value>The berufsfeld.</value>
  public string Berufsfeld { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the page. Example: "1"
  /// </summary>
  /// <value>The page.</value>
  public int Page { get; set; }

  /// <summary>
  /// Gets or sets the size. Example: "10"
  /// </summary>
  /// <value>The size.</value>
  public int Size { get; set; }

  /// <summary>
  /// Gets or sets the arbeitgeber. Example: "Deutsche%Telekom%AG"
  /// </summary>
  /// <value>The arbeitgeber.</value>
  public string Arbeitgeber { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the veroeffentlicht seit. Example: "7" (days)
  /// </summary>
  /// <value>The veroeffentlicht seit.</value>
  public int VeroeffentlichtSeit { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether this <see cref="JobSearchRequest"/> is zeitarbeit.
  /// </summary>
  /// <value><c>true</c> if zeitarbeit; otherwise, <c>false</c>.</value>
  public bool Zeitarbeit { get; set; }

  /// <summary>
  /// Gets or sets the angebotsart. Example: 1 (1 for "Arbeit", 2 for "Selbststaendigkeit", 4 for "Ausbildungen", 34 for "Praktikum/Trainee")
  /// </summary>
  /// <value>The angebotsart.</value>
  public int Angebotsart { get; set; }

  /// <summary>
  /// Gets or sets the befristung. Example: 0 (1 for "befristet", 2 for "unbefristet")
  /// </summary>
  /// <value>The befristung.</value>
  public int Befristung { get; set; }

  /// <summary>
  /// Gets or sets the arbeitszeit. // Example: (vz for "Vollzeit", tz for "Teilzeit", snw for "Schicht/Nachtarbeit", ho for "Homeoffice")
  /// </summary>
  /// <value>The arbeitszeit.</value>
  public string Arbeitszeit { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets a value indicating whether this <see cref="JobSearchRequest"/> is behinderung. Example: false (if you want to include jobs for people with disabilities)
  /// </summary>
  /// <value><c>true</c> if behinderung; otherwise, <c>false</c>.</value>
  public bool Behinderung { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether this <see cref="JobSearchRequest"/> is corona. Example: false (if you want to include jobs related to Corona)
  /// </summary>
  /// <value><c>true</c> if corona; otherwise, <c>false</c>.</value>
  public bool Corona { get; set; }

  /// <summary>
  /// Gets or sets the umkreis. Example: 25 (distance in km from the location specified in "Wo")
  /// </summary>
  /// <value>The umkreis.</value>
  public int Umkreis { get; set; }
}
