# GermanArbeitsamtJobsearchClient


## DESCRIPTION

This Class helps finding a new job with the help of the German Arbeitsamt Jobsearch API. It can be used to find jobs, get job details and more. It is part of the JobApplicationManager project, which is a web application that helps users manage their job applications.

GermanArbeitsamtJobsearchClient is released under the MIT License, see the file `LICENSE.md` for more information.

|What|Where|
|-----|-------------------------------------------------------------------------------------|
|Code  | (https://dev.azure.com/saigkill/GermanArbeitsamtJobsearchClient) |
|Docs | (https://moongladesm.blob.core.windows.net/arbeitsamt-docs/_site/index.html) |
|Bugs & feature requests Azure  | (https://dev.azure.com/saigkill/GermanArbeitsamtJobsearchClient/_workitems/recentlyupdated/) |
|Bugs & feature requests Github | (https://github.com/saigkill/GermanArbeitsamtJobsearchClient/issues) |

| What | Status |
|-------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|Code quality | [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=saigkill_GermanArbeitsamtJobsearchClient&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=saigkill_GermanArbeitsamtJobsearchClient) |
|Continuous integration Dev | [![Build status](https://dev.azure.com/saigkill/GermanArbeitsamtJobsearchClient/_apis/build/status/GermanArbeitsamtJobsearchClient-.NET%20Desktop-CI-stage)](https://dev.azure.com/saigkill/GermanArbeitsamtJobsearchClient/_build/latest?definitionId=72) |
|Continuous integration Prod | [![Build status](https://dev.azure.com/saigkill/GermanArbeitsamtJobsearchClient/_apis/build/status/GermanArbeitsamtJobsearchClient-ASP.NET-CI-prod)](https://dev.azure.com/saigkill/GermanArbeitsamtJobsearchClient/_build/latest?definitionId=-1) |
|Open Issues Github | ![GitHub issues](https://img.shields.io/github/issues/saigkill/GermanArbeitsamtJobsearchClient) |
|Open Issues Azure | [![Board Status](https://dev.azure.com/saigkill/89fe1d4e-90f8-4c34-85af-3e743770fa37/5415414b-f4bb-4147-bf8f-6bc4138a8661/_apis/work/boardbadge/0186270a-5a5a-4947-9d4b-6f612fe34f0f)](https://dev.azure.com/saigkill/89fe1d4e-90f8-4c34-85af-3e743770fa37/_boards/board/t/5415414b-f4bb-4147-bf8f-6bc4138a8661/Stories/)|

## FEATURES

* Find a new job through German Arbeitsamt Jobsearch Api


## Prerequisites

Install the nuget package: "Saigkill.GermanArbeitsamtJobsearch" Client, and add it to your project.

## Usage
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
    Arbeitgeber = "Deutsche%20Bahn%20AG",
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

All example entries can be found in the Model files.