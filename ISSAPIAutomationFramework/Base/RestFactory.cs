using ISSAPIAutomationFramework.Base.Interfaces;

namespace ISSAPIAutomationFramework.Base;

public class RestFactory : IRestFactory
{
    private readonly IRestBuilder _restBuilder;

    public RestFactory(IRestBuilder restBuilder)
    {
        _restBuilder = restBuilder;
    }

    public IRestBuilder Create()
    {
        return _restBuilder;
    }
}
