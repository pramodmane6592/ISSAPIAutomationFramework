using RestSharp;

namespace ISSAPIAutomationFramework.Base.Interfaces;
public interface IRestBuilder
{
    RestRequest RestRequest { get; set; }
    IRestBuilder WithRequest(string request);
    IRestBuilder WithHeader(string name, string value);
    IRestBuilder WithQueryParameter(string name, string value);
    IRestBuilder WithURLSegment(string name, string value);
    IRestBuilder WithBody(object body);
    Task<T?> WithGet<T>();
    Task<T?> WithPost<T>();
    Task<RestResponse> WithPost();
    Task<T?> WithPut<T>();
    Task<T?> WithDelete<T>();
    Task<T?> WithPatch<T>();
}
