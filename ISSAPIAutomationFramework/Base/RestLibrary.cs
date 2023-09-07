using ISSAPIAutomationFramework.Base.Interfaces;
using RestSharp;

namespace ISSAPIAutomationFramework.Base;

public class RestLibrary : IRestLibrary
{
    public RestClient RestClient { get; }
    public RestLibrary()
    {
        var _restClientOptions = new RestClientOptions
        {
            BaseUrl = new Uri("https://localhost:5001/"),
            RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
        };

        RestClient = new RestClient(_restClientOptions);
    }
}
