# Getting Started

Getting started with our project is easy! Follow these steps to set up your development environment and start contributing.

## Prerequisites

Install the nuget package: "Saigkill.GermanArbeitsamtJobsearch" Client, and add it to your project.

## Usage

Under the directory "models" you will find the models that are used to deserialize the data from the API.

You will send your request in the following way:
```csharp
using GermanArbeitsamtJobsearchClient.Models;

private JobSearchResponse SendJobSearchRequest(JobSearchRequest request)
{
    var request = new JobSearchRequest
{
    Was = "Softwareentwickler",
    Wo = "Berlin",
    Berufsfeld = "Informatik",
    Page = 1,
    Size = 10,
    Arbeitgeber = "Deutsche Telekom AG",
    VeroeffentlichtSeit = 7,         // Jobs der letzten 7 Tage
    Zeitarbeit = false,
    Angebotsart = 1,                 // 1 = Arbeit
    Befristung = 0,                  // 0 = alle, 1 = befristet, 2 = unbefristet
    Arbeitszeit = "vz",              // vz = Vollzeit
    Behinderung = false,
    Corona = false,
    Umkreis = 25                     // 25 km Umkreis
};

var ergebnis = await ApiRequest.SendAsync<JobSearchResponse>(
      resource: _endpoint,
      method: Method.Get,
      parameters: parameters
    );
}
```