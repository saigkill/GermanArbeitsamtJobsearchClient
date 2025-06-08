using GermanArbeitsamtJobsearchClient;
using GermanArbeitsamtJobsearchClient.Models;

using Moq;

using RestSharp;

namespace GermanArbeitsamtJobsearchClientTests;

[TestClass]
public class JobsucheTests
{
  [TestMethod]
  public async Task SendRequestAsync_ReturnsExpectedResponseAsync()
  {
    // Arrange
    var expectedResponse = new JobSearchResponse
    {
      Stellenangebote = new List<JobSearchOffer>
            {
                new JobSearchOffer
                {
                    HashId = "testHashId",
                    Beruf = "Softwareentwickler",
                    RefNr = "12345",
                    Arbeitgeber = "Test AG"
                }
            },
      MaxErgebnisse = "1",
      Page = "1",
      Size = "10",
      Facetten = null
    };

    var requestModel = new JobSearchRequest
    {
      Was = "Softwareentwickler",
      Wo = "Berlin",
      Berufsfeld = "Informatik",
      Page = 1,
      Size = 10,
      Arbeitgeber = "Test AG",
      VeroeffentlichtSeit = 7,
      Zeitarbeit = false,
      Angebotsart = 1,
      Befristung = 0,
      Arbeitszeit = "vz",
      Behinderung = false,
      Corona = false,
      Umkreis = 10
    };

    // Mock ApiRequest.SendAsync
    var apiRequestMock = new Mock<IApiRequestWrapper>();
    apiRequestMock
        .Setup(x => x.SendAsync<JobSearchResponse>(
            It.IsAny<string>(),
            It.IsAny<Method>(),
            It.IsAny<Dictionary<string, string>>()))
        .ReturnsAsync(expectedResponse);

    // SUT mit Dependency Injection
    var jobsuche = new Jobsuche(apiRequestMock.Object);

    // Act
    var result = await jobsuche.SendRequestAsync(requestModel);

    // Assert
    Assert.IsNotNull(result);
    Assert.IsNotNull(result.Stellenangebote);
    Assert.AreEqual("Softwareentwickler", result.Stellenangebote[0].Beruf);
    Assert.AreEqual("Test AG", result.Stellenangebote[0].Arbeitgeber);
    Assert.AreEqual("1", result.MaxErgebnisse);
  }
}
