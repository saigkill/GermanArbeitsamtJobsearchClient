// <copyright file="JobSearchResponse.cs" company="Sascha Manns">
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
/// Repräsentiert das Ergebnis einer Jobsuche.
/// </summary>
public class JobSearchResponse
{
  /// <summary>
  /// Gets or sets the stellenangebote.
  /// </summary>
  /// <value>The stellenangebote.</value>
  public List<JobSearchOffer>? Stellenangebote { get; set; } = new List<JobSearchOffer>();

  /// <summary>
  /// Gets or sets the maximum ergebnisse.
  /// </summary>
  /// <value>The maximum ergebnisse.</value>
  public string? MaxErgebnisse { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the page.
  /// </summary>
  /// <value>The page.</value>
  public string? Page { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the size.
  /// </summary>
  /// <value>The size.</value>
  public string? Size { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the facetten.
  /// </summary>
  /// <value>The facetten.</value>
  public List<JobFacet>? Facetten { get; set; } = new List<JobFacet>();
}

/// <summary>
/// Einzelnes Stellenangebot in der Suchergebnisliste.
/// </summary>
public class JobSearchOffer
{
  /// <summary>
  /// Gets or sets the hash identifier. Example: "WBTAiM10b25rJgZqiLhVIHzAF9e0rnV_DXdsRZtlb54="
  /// </summary>
  /// <value>The hash identifier.</value>
  public string? HashId { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the beruf. Example: "Software-Entwickler/in"
  /// </summary>
  /// <value>The beruf.</value>
  public string? Beruf { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the reference nr. Example: "10000-1184867112-S"
  /// </summary>
  /// <value>The reference nr.</value>
  public string? RefNr { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the arbeitgeber. Example: "Oltermann Sicherheits- und Elektrotechnik GmbH"
  /// </summary>
  /// <value>The arbeitgeber.</value>
  public string? Arbeitgeber { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the aktuelle veroeffentlichungsdatum.
  /// </summary>
  /// <value>The aktuelle veroeffentlichungsdatum.</value>
  public DateTime? AktuelleVeroeffentlichungsdatum { get; set; } = DateTime.UtcNow;

  /// <summary>
  /// Gets or sets the eintrittsdatum.
  /// </summary>
  /// <value>The eintrittsdatum.</value>
  public DateTime? Eintrittsdatum { get; set; } = DateTime.UtcNow;

  /// <summary>
  /// Gets or sets the arbeitsort.
  /// </summary>
  /// <value>The arbeitsort.</value>
  public Arbeitsort? Arbeitsort { get; set; } = new Arbeitsort();

  /// <summary>
  /// Gets or sets the modifikations timestamp.
  /// </summary>
  /// <value>The modifikations timestamp.</value>
  public string? ModifikationsTimestamp { get; set; } = string.Empty;
}

/// <summary>
/// Arbeitsort eines Stellenangebots.
/// </summary>
public class Arbeitsort
{
  /// <summary>
  /// Gets or sets the land.
  /// </summary>
  /// <value>The land.</value>
  public string? Land { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the region.
  /// </summary>
  /// <value>The region.</value>
  public string? Region { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the PLZ.
  /// </summary>
  /// <value>The PLZ.</value>
  public string? Plz { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the ort.
  /// </summary>
  /// <value>The ort.</value>
  public string? Ort { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the strasse.
  /// </summary>
  /// <value>The strasse.</value>
  public string? Strasse { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the strasse hausnummer.
  /// </summary>
  /// <value>The strasse hausnummer.</value>
  public string? StrasseHausnummer { get; set; } = string.Empty;
}

/// <summary>
/// Facette (Filter) der Jobsuche.
/// </summary>
public class JobFacet
{
  /// <summary>
  /// Gets or sets the befristung.
  /// </summary>
  /// <value>The befristung.</value>
  public FacetCounts? Befristung { get; set; }

  /// <summary>
  /// Gets or sets the behinderung.
  /// </summary>
  /// <value>The behinderung.</value>
  public FacetCounts? Behinderung { get; set; }

  /// <summary>
  /// Gets or sets the pav.
  /// </summary>
  /// <value>The pav.</value>
  public FacetCounts? Pav { get; set; }

  /// <summary>
  /// Gets or sets the berufsfeld.
  /// </summary>
  /// <value>The berufsfeld.</value>
  public FacetCounts? Berufsfeld { get; set; }

  /// <summary>
  /// Gets or sets the arbeitsort.
  /// </summary>
  /// <value>The arbeitsort.</value>
  public FacetCounts? Arbeitsort { get; set; }

  /// <summary>
  /// Gets or sets the ausbildungsart.
  /// </summary>
  /// <value>The ausbildungsart.</value>
  public FacetCounts? Ausbildungsart { get; set; }

  /// <summary>
  /// Gets or sets the veroeffentlichtseit.
  /// </summary>
  /// <value>The veroeffentlichtseit.</value>
  public FacetCounts? Veroeffentlichtseit { get; set; }

  /// <summary>
  /// Gets or sets the schulbildung.
  /// </summary>
  /// <value>The schulbildung.</value>
  public FacetCounts? Schulbildung { get; set; }

  /// <summary>
  /// Gets or sets the arbeitsort PLZ.
  /// </summary>
  /// <value>The arbeitsort PLZ.</value>
  public FacetCounts? ArbeitsortPlz { get; set; }

  /// <summary>
  /// Gets or sets the arbeitgeber.
  /// </summary>
  /// <value>The arbeitgeber.</value>
  public FacetCounts? Arbeitgeber { get; set; }

  /// <summary>
  /// Gets or sets the beruf.
  /// </summary>
  /// <value>The beruf.</value>
  public FacetCounts? Beruf { get; set; }

  /// <summary>
  /// Gets or sets the branche.
  /// </summary>
  /// <value>The branche.</value>
  public FacetCounts? Branche { get; set; }

  /// <summary>
  /// Gets or sets the arbeitszeit.
  /// </summary>
  /// <value>The arbeitszeit.</value>
  public FacetCounts? Arbeitszeit { get; set; }

  /// <summary>
  /// Gets or sets the eintrittsdatum.
  /// </summary>
  /// <value>The eintrittsdatum.</value>
  public FacetCounts? Eintrittsdatum { get; set; }

  /// <summary>
  /// Gets or sets the zeitarbeit.
  /// </summary>
  /// <value>The zeitarbeit.</value>
  public FacetCounts? Zeitarbeit { get; set; }

  /// <summary>
  /// Gets or sets the corona.
  /// </summary>
  /// <value>The corona.</value>
  public FacetCounts? Corona { get; set; }
}

/// <summary>
/// Zählt Werte für eine Facette.
/// </summary>
public class FacetCounts
{
  /// <summary>
  /// Gets or sets the counts.
  /// </summary>
  /// <value>The counts.</value>
  public Dictionary<string, int>? Counts { get; set; } = new Dictionary<string, int>();

  /// <summary>
  /// Gets or sets the maximum count.
  /// </summary>
  /// <value>The maximum count.</value>
  public int? MaxCount { get; set; } = null;
}
