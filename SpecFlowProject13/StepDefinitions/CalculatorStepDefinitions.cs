using SpecFlowProject13;
using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowProject13.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext scenarioContext;
        private readonly Calculator calculator;
        private int result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calculator = new Calculator();
        }
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.Fnum = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculator.Lnum = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = calculator.Add();
          
        }
        [When("the two numbers are sub")]
        public void WhenTheTwoNumbersAreSub()
        {
            result = calculator.Sub();

        }

        [When("the two numbers are mul")]
        public void WhenTheTwoNumbersAreMul()
        {
            result = calculator.Mul();

        }

        [When("the two numbers are div")]
        public void WhenTheTwoNumbersAreDiv()
        {
            result = calculator.Div();

        }


        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            result.Should().Be(result);
        }
    }
}
