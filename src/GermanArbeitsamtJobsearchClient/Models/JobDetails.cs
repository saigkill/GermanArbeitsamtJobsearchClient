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
  /// <summary>
  /// Gets or sets the aktuelle veroeffentlichungsdatum.
  /// </summary>
  /// <value>The aktuelle veroeffentlichungsdatum.</value>
  public DateTime? AktuelleVeroeffentlichungsdatum { get; set; } = DateTime.UtcNow;

  /// <summary>
  /// Gets or sets the angebotsart. As Example "ARBEIT"
  /// </summary>
  /// <value>The angebotsart.</value>
  public string? Angebotsart { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the arbeitgeber. As Example "Firma XYZ GmbH"
  /// </summary>
  /// <value>The arbeitgeber.</value>
  public string? Arbeitgeber { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the branchengruppe. As Example "IT, Computer, Telekommunikation"
  /// </summary>
  /// <value>The branchengruppe.</value>
  public string? Branchengruppe { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the branche. As Example "Softwareentwicklung"
  /// </summary>
  /// <value>The branche.</value>
  public string? Branche { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the arbeitgeber hash identifier. As Example "dj32HpGiU3tdrYi6ohcMOtUhtBLPvwGIRiRlcvDsebg="
  /// </summary>
  /// <value>The arbeitgeber hash identifier.</value>
  public string? ArbeitgeberHashId { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the arbeitsorte. 
  /// </summary>
  /// <value>The arbeitsorte.</value>
  public Arbeitsorte Arbeitsorte { get; set; } = new Arbeitsorte();

  /// <summary>
  /// Gets or sets the arbeitszeitmodelle. As Example ["VOLLZEIT", "Teilzeit"]
  /// </summary>
  /// <value>The arbeitszeitmodelle.</value>
  public List<string>? Arbeitszeitmodelle { get; set; } = new List<string>();

  /// <summary>
  /// Gets or sets the befristung. As Example "UNBEFRISTET"
  /// </summary>
  /// <value>The befristung.</value>
  public string? Befristung { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets a value indicating whether this <see cref="JobOfferDetails"/> is uebernahme.
  /// </summary>
  /// <value><c>true</c> if [uebernahme] contains no value, <c>true</c> if [uebernahme]; otherwise, <c>false</c>.</value>
  public bool? Uebernahme { get; set; } = true;

  /// <summary>
  /// Gets or sets the betriebsgroesse. As Example "2"
  /// </summary>
  /// <value>The betriebsgroesse.</value>
  public string? Betriebsgroesse { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the eintrittsdatum.
  /// </summary>
  /// <value>The eintrittsdatum.</value>
  public DateTime? Eintrittsdatum { get; set; } = DateTime.UtcNow;

  /// <summary>
  /// Gets or sets the erste veroeffentlichungsdatum.
  /// </summary>
  /// <value>The erste veroeffentlichungsdatum.</value>
  public DateTime? ErsteVeroeffentlichungsdatum { get; set; } = DateTime.UtcNow;

  /// <summary>
  /// Gets or sets the allianzpartner. As Example  "arbeitsagentur.de
  /// </summary>
  /// <value>The allianzpartner.</value>
  public string? Allianzpartner { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the allianzpartner URL. As Example "http://www.arbeitsagentur.de"
  /// </summary>
  /// <value>The allianzpartner URL.</value>
  public string? AllianzpartnerUrl { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the titel. As Example "Softwareentwickler (m/w/d)"
  /// </summary>
  /// <value>The titel.</value>
  public string? Titel { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the hash identifier. As Example "VK2qoXBe0s-UAdH_qxLDRrZrY5iY8a1PJt3MjJCXsdo="
  /// </summary>
  /// <value>The hash identifier.</value>
  public string? HashId { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the beruf. As Example "Wissenschaftliche/r Mitarbeiter/in (Hochschule)"
  /// </summary>
  /// <value>The beruf.</value>
  public string? Beruf { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the modifikations timestamp.
  /// </summary>
  /// <value>The modifikations timestamp.</value>
  public string? ModifikationsTimestamp { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the stellenbeschreibung. 
  /// </summary>
  /// <value>The stellenbeschreibung reference nr.</value>
  public string? StellenbeschreibungRefNr { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the reference nr. As Example "10000-1183999289-S"
  /// </summary>
  /// <value>The reference nr.</value>
  public string? RefNr { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets a value indicating whether [fuer fluechtlinge geeignet].
  /// </summary>
  /// <value><c>true</c> if [fuer fluechtlinge geeignet] contains no value, <c>true</c> if [fuer fluechtlinge geeignet]; otherwise, <c>false</c>.</value>
  public bool? FuerFluechtlingeGeeignet { get; set; } = true;

  /// <summary>
  /// Gets or sets a value indicating whether [nur fuer schwerbehinderte].
  /// </summary>
  /// <value><c>false</c> if [nur fuer schwerbehinderte] contains no value, <c>true</c> if [nur fuer schwerbehinderte]; otherwise, <c>false</c>.</value>
  public bool? NurFuerSchwerbehinderte { get; set; } = false;

  /// <summary>
  /// Gets or sets the anzahl offene stellen. As Example "1"
  /// </summary>
  /// <value>The anzahl offene stellen.</value>
  public int? AnzahlOffeneStellen { get; set; } = 0;

  /// <summary>
  /// Gets or sets the arbeitgeber adresse.
  /// </summary>
  /// <value>The arbeitgeber adresse.</value>
  public ArbeitgeberAdresse? ArbeitgeberAdresse { get; set; } = new ArbeitgeberAdresse();

  /// <summary>
  /// Gets or sets the fertigkeiten.
  /// </summary>
  /// <value>The fertigkeiten.</value>
  public List<Fertigkeit>? Fertigkeiten { get; set; } = new List<Fertigkeit>();

  /// <summary>
  /// Gets or sets the mobilitaet.
  /// </summary>
  /// <value>The mobilitaet.</value>
  public Mobilitaet? Mobilitaet { get; set; } = new Mobilitaet();

  /// <summary>
  /// Gets or sets the fuehrungskompetenzen.
  /// </summary>
  /// <value>The fuehrungskompetenzen.</value>
  public Fuehrungskompetenzen? Fuehrungskompetenzen { get; set; } = new Fuehrungskompetenzen();

  /// <summary>
  /// Gets or sets the verguetung. Example "Entgeltgruppe 13 TV-L"
  /// </summary>
  /// <value>The verguetung.</value>
  public string? Verguetung { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the arbeitgeberdarstellung URL. Example: "http://www.friseur-nickel.de"
  /// </summary>
  /// <value>The arbeitgeberdarstellung URL.</value>
  public string? ArbeitgeberdarstellungUrl { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the arbeitgeberdarstellung.
  /// </summary>
  /// <value>The arbeitgeberdarstellung.</value>
  public string? Arbeitgeberdarstellung { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the haupt DKZ.
  /// </summary>
  /// <value>The haupt DKZ.</value>
  public string? HauptDkz { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets a value indicating whether [ist betreut].
  /// </summary>
  /// <value><c>false</c> if [ist betreut] contains no value, <c>true</c> if [ist betreut]; otherwise, <c>false</c>.</value>
  public bool? IstBetreut { get; set; } = false;

  /// <summary>
  /// Gets or sets a value indicating whether [ist google jobs relevant].
  /// </summary>
  /// <value><c>false</c> if [ist google jobs relevant] contains no value, <c>true</c> if [ist google jobs relevant]; otherwise, <c>false</c>.</value>
  public bool? IstGoogleJobsRelevant { get; set; } = false;

  /// <summary>
  /// Gets or sets a value indicating whether [anzeige anonym].
  /// </summary>
  /// <value><c>false</c> if [anzeige anonym] contains no value, <c>true</c> if [anzeige anonym]; otherwise, <c>false</c>.</value>
  public bool? AnzeigeAnonym { get; set; } = false;
}

/// <summary>
/// Class Arbeitsorte.
/// </summary>
public class Arbeitsorte
{
  /// <summary>
  /// Gets or sets the land. Example "Deutschland"
  /// </summary>
  /// <value>The land.</value>
  public string? Land { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the region. Example "Nordrhein-Westfalen"
  /// </summary>
  /// <value>The region.</value>
  public string? Region { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the PLZ. Example "12345"
  /// </summary>
  /// <value>The PLZ.</value>
  public string? Plz { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the ort. Example "Berlin"
  /// </summary>
  /// <value>The ort.</value>
  public string? Ort { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the strasse. Example "Musterstrasse 1"
  /// </summary>
  /// <value>The strasse.</value>
  public string? Strasse { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the koordinaten.
  /// </summary>
  /// <value>The koordinaten.</value>
  public Koordinaten Koordinaten { get; set; } = new Koordinaten();
}

/// <summary>
/// Class Koordinaten.
/// </summary>
public class Koordinaten
{
  /// <summary>
  /// Gets or sets the lat. Example "52.5200"
  /// </summary>
  /// <value>The lat.</value>
  public double? Lat { get; set; } = null;

  /// <summary>
  /// Gets or sets the lon. Example "13.4050"
  /// </summary>
  /// <value>The lon.</value>
  public double? Lon { get; set; } = null;
}

/// <summary>
/// Adresse des Arbeitgebers.
/// </summary>
public class ArbeitgeberAdresse
{
  /// <summary>
  /// Gets or sets the land. Example "Deutschland"
  /// </summary>
  /// <value>The land.</value>
  public string? Land { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the region. Example "Nordrhein-Westfalen"
  /// </summary>
  /// <value>The region.</value>
  public string? Region { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the PLZ. Example "12345"
  /// </summary>
  /// <value>The PLZ.</value>
  public string? Plz { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the ort. Example "Berlin"
  /// </summary>
  /// <value>The ort.</value>
  public string? Ort { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the strasse. Example "Musterstrasse 1"
  /// </summary>
  /// <value>The strasse.</value>
  public string? Strasse { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the strasse hausnummer. Example "Musterstrasse 1"
  /// </summary>
  /// <value>The strasse hausnummer.</value>
  public string? StrasseHausnummer { get; set; } = string.Empty;
}

/// <summary>
/// Fertigkeit eines Stellenangebots.
/// </summary>
public class Fertigkeit
{
  /// <summary>
  /// Gets or sets the bezeichnung. Example "Soziales, Erziehung, Gesundheit, Sport"
  /// </summary>
  /// <value>The bezeichnung.</value>
  public string? HierarchieName { get; set; } = string.Empty;
}

/// <summary>
/// Mobilitätsangaben.
/// </summary>
public class Mobilitaet
{
  /// <summary>
  /// Gets or sets the reisebereitschaft. Example "1"
  /// </summary>
  /// <value>The reisebereitschaft.</value>
  public string? Reisebereitschaft { get; set; } = string.Empty;
}

/// <summary>
/// Führungskompetenzen.
/// </summary>
public class Fuehrungskompetenzen
{
  /// <summary>
  /// Gets or sets a value indicating whether [hat vollmacht].
  /// </summary>
  /// <value><c>false</c> if [hat vollmacht] contains no value, <c>true</c> if [hat vollmacht]; otherwise, <c>false</c>.</value>
  public bool? HatVollmacht { get; set; } = false;

  /// <summary>
  /// Gets or sets a value indicating whether [hat budgetverantwortung].
  /// </summary>
  /// <value><c>false</c> if [hat budgetverantwortung] contains no value, <c>true</c> if [hat budgetverantwortung]; otherwise, <c>false</c>.</value>
  public bool? HatBudgetverantwortung { get; set; } = false;
}
