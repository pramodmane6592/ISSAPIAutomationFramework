﻿using TechTalk.SpecFlow;

namespace ISSAPIAutomationFramework.Hooks;

[Binding]
public class Hooks
{
    private readonly ScenarioContext _scenarioContext;

    public Hooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }


    [BeforeScenario]
    public void InitializeDriver()
    {
        Driver driver = new Driver(_scenarioContext);
    }
}
