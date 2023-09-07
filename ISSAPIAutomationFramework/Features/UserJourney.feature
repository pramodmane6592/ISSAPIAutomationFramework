Feature: UserJourney

List of API test scenarios for User Journey

@UserJourney @Hub
Scenario: Execute GET request and validates the results for User Journey endpoint
	Given User executes GET request using endpoint Product/GetProductById/{id}
		| ProductId |
		| 1         |	
	 Then User validates response code is 200 OK