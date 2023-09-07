using RestSharp;
using TechTalk.SpecFlow;

namespace ISSAPIAutomationFramework;
public class Driver
{
    public Driver(ScenarioContext scenarioContext)
    {
        var _restClientOptions = new RestClientOptions
        {
            BaseUrl = new Uri("https://localhost:5001/"),
            RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
        };

        var restClient = new RestClient(_restClientOptions);

        scenarioContext.Add("RestClient", restClient);
    }
}
