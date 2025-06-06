// <copyright file="JobDetails.cs" company="Sascha Manns">
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
/// Repräsentiert die Details eines Stellenangebots aus der Arbeitsagentur Jobsuche API.
/// </summary>
public class JobOfferDetails
{
  public DateTime? AktuelleVeroeffentlichungsdatum { get; set; }
  public string? Angebotsart { get; set; }
  public string? Arbeitgeber { get; set; }
  public string? Branchengruppe { get; set; }
  public string? Branche { get; set; }
  public string? ArbeitgeberHashId { get; set; }
  public List<string>? Arbeitsorte { get; set; }
  public List<string>? Arbeitszeitmodelle { get; set; }
  public string? Befristung { get; set; }
  public bool? Uebernahme { get; set; }
  public string? Betriebsgroesse { get; set; }
  public DateTime? Eintrittsdatum { get; set; }
  public DateTime? ErsteVeroeffentlichungsdatum { get; set; }
  public string? Allianzpartner { get; set; }
  public string? AllianzpartnerUrl { get; set; }
  public string? Titel { get; set; }
  public string? HashId { get; set; }
  public string? Beruf { get; set; }
  public string? ModifikationsTimestamp { get; set; }
  public string? Stellenbeschreibung { get; set; }
  public string? RefNr { get; set; }
  public bool? FuerFluechtlingeGeeignet { get; set; }
  public bool? NurFuerSchwerbehinderte { get; set; }
  public int? AnzahlOffeneStellen { get; set; }
  public ArbeitgeberAdresse? ArbeitgeberAdresse { get; set; }
  public List<Fertigkeit>? Fertigkeiten { get; set; }
  public Mobilitaet? Mobilitaet { get; set; }
  public Fuehrungskompetenzen? Fuehrungskompetenzen { get; set; }
  public string? Verguetung { get; set; }
  public string? ArbeitgeberdarstellungUrl { get; set; }
  public string? Arbeitgeberdarstellung { get; set; }
  public string? HauptDkz { get; set; }
  public bool? IstBetreut { get; set; }
  public bool? IstGoogleJobsRelevant { get; set; }
  public bool? AnzeigeAnonym { get; set; }
}

/// <summary>
/// Adresse des Arbeitgebers.
/// </summary>
public class ArbeitgeberAdresse
{
  public string? Land { get; set; }
  public string? Region { get; set; }
  public string? Plz { get; set; }
  public string? Ort { get; set; }
  public string? Strasse { get; set; }
  public string? StrasseHausnummer { get; set; }
}

/// <summary>
/// Fertigkeit eines Stellenangebots.
/// </summary>
public class Fertigkeit
{
  public string? Bezeichnung { get; set; }
  public string? Niveau { get; set; }
  public string? Kategorie { get; set; }
}

/// <summary>
/// Mobilitätsangaben.
/// </summary>
public class Mobilitaet
{
  public string? Reisebereitschaft { get; set; }
}

/// <summary>
/// Führungskompetenzen.
/// </summary>
public class Fuehrungskompetenzen
{
  public bool? HatVollmacht { get; set; }
  public bool? HatBudgetverantwortung { get; set; }
}
