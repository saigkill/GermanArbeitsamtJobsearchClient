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
  public List<JobSearchOffer>? Stellenangebote { get; set; }
  public string? MaxErgebnisse { get; set; }
  public string? Page { get; set; }
  public string? Size { get; set; }
  public List<JobFacet>? Facetten { get; set; }
}

/// <summary>
/// Einzelnes Stellenangebot in der Suchergebnisliste.
/// </summary>
public class JobSearchOffer
{
  public string? HashId { get; set; }
  public string? Beruf { get; set; }
  public string? RefNr { get; set; }
  public string? Arbeitgeber { get; set; }
  public DateTime? AktuelleVeroeffentlichungsdatum { get; set; }
  public DateTime? Eintrittsdatum { get; set; }
  public Arbeitsort? Arbeitsort { get; set; }
  public string? ModifikationsTimestamp { get; set; }
}

/// <summary>
/// Arbeitsort eines Stellenangebots.
/// </summary>
public class Arbeitsort
{
  public string? Land { get; set; }
  public string? Region { get; set; }
  public string? Plz { get; set; }
  public string? Ort { get; set; }
  public string? Strasse { get; set; }
  public string? StrasseHausnummer { get; set; }
}

/// <summary>
/// Facette (Filter) der Jobsuche.
/// </summary>
public class JobFacet
{
  public FacetCounts? Befristung { get; set; }
  public FacetCounts? Behinderung { get; set; }
  public FacetCounts? Pav { get; set; }
  public FacetCounts? Berufsfeld { get; set; }
  public FacetCounts? Arbeitsort { get; set; }
  public FacetCounts? Ausbildungsart { get; set; }
  public FacetCounts? Veroeffentlichtseit { get; set; }
  public FacetCounts? Schulbildung { get; set; }
  public FacetCounts? ArbeitsortPlz { get; set; }
  public FacetCounts? Arbeitgeber { get; set; }
  public FacetCounts? Beruf { get; set; }
  public FacetCounts? Branche { get; set; }
  public FacetCounts? Arbeitszeit { get; set; }
  public FacetCounts? Eintrittsdatum { get; set; }
  public FacetCounts? Zeitarbeit { get; set; }
  public FacetCounts? Corona { get; set; }
}

/// <summary>
/// Zählt Werte für eine Facette.
/// </summary>
public class FacetCounts
{
  public Dictionary<string, int>? Counts { get; set; }
  public int? MaxCount { get; set; }
}
