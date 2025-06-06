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

public class JobSearchRequest
{
  public string Was { get; set; } // Exapmple: "Softwareentwickler"
  public string Wo { get; set; } // Example: "Berlin"
  public string Berufsfeld { get; set; } // Example: "Informatics"
  public int Page { get; set; } // Example: "1"
  public int Size { get; set; } // Example: "10"
  public string Arbeitgeber { get; set; } // Example: "Deutsche%Telekom%AG"
  public int VeroeffentlichtSeit { get; set; } // Example: "7" (days)
  public bool Zeitarbeit { get; set; } // Example: true (if you want to include temporary jobs)
  public int Angebotsart { get; set; } // Example: 1 (1 for "Arbeit", 2 for "Selbststaendigkeit", 4 for "Ausbildungen", 34 for "Praktikum/Trainee")
  public int Befristung { get; set; } // Example: 0 (1 for "befristet", 2 for "unbefristet")
  public string Arbeitszeit { get; set; } // Example: (vz for "Vollzeit", tz for "Teilzeit", snw for "Schicht/Nachtarbeit", ho for "Homeoffice")
  public bool Behinderung { get; set; } // Example: false (if you want to include jobs for people with disabilities)
  public bool Corona { get; set; } // Example: false (if you want to include jobs related to Corona)
  public int Umkreis { get; set; } // Example: 25 (distance in km from the location specified in "Wo")
}
