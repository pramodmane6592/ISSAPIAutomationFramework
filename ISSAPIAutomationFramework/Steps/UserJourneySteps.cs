using FluentAssertions;
using RestSharp;
using System.Net;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ISSAPIAutomationFramework.Steps;

[Binding]
public class UserJourneySteps
{
    private readonly ScenarioContext _scenarioContext;
    private RestClient? _restClient;
    private RestResponse? _response;

    public UserJourneySteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }


    [Given(@"User executes GET request using endpoint (.*)")]
    public async Task GivenUserExecuteGetRequest(string endpoint, Table table)
    {
        dynamic data = table.CreateDynamicInstance();
        _restClient = _scenarioContext.Get<RestClient>("RestClient");

        var request = new RestRequest(endpoint);
        request.AddUrlSegment("id", (int)data.ProductId);

        _response = await _restClient.GetAsync(request);
        _scenarioContext.Set("Response", _response.Content);
    }

    [Then(@"User validates response code is 200 OK")]
    public void ThenUserValidatesResponseCode()
    {
        var response = _scenarioContext.Get<RestResponse>("Response");
        response.Should().Be(HttpStatusCode.OK);
    }
}
