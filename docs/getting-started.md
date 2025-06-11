# Getting Started

Getting started with our project is easy! Follow these steps to set up your development environment and start contributing.

## Prerequisites

Install the nuget package: "Saigkill.GermanArbeitsamtJobsearch" Client, and add it to your project.
You can find the package here: [Azure Artifacts](https://pkgs.dev.azure.com/saigkill/GermanArbeitsamtJobsearchClient/_packaging/GermanArbeitsamatJobsearchClient-Prod/nuget/v3/index.json).

## Usage

Under the directory "models" you will find the models that are used to deserialize the data from the API.

You will send your request in the following way:
```csharp
using GermanArbeitsamtJobsearchClient.Models;

// Your example class
public async Task GetJobs(){
    
    //Define your model
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

    var jobs = await SendJobSearchRequest(request);
    // Do something with the jobs, e.g. display them in a list or save them to a database
}
```

All example entries can be found in the Model files.