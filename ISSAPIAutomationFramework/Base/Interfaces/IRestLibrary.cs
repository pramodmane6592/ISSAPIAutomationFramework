using RestSharp;

namespace ISSAPIAutomationFramework.Base.Interfaces;
public interface IRestLibrary
{
    RestClient RestClient { get; }
}
