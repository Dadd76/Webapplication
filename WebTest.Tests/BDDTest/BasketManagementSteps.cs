using System;
using TechTalk.SpecFlow;

namespace WebTest.Tests.BDDTest
{
    [Binding]
    public class BasketManagementSteps
    {
        [Given(@"user's empty basket")]
        public void GivenUserSEmptyBasket()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a item wich price (.*)")]
        public void GivenAItemWichPriceHT(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered (.*) into the cal")]
        public void GivenIHaveEnteredIntoTheCal(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the  total customer basket price should be (.*)€ TTC")]
        public void ThenTheTotalCustomerBasketPriceShouldBeTTC(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the TTC total customer basket price should be (.*)€ TTC")]
        public void ThenTheTTCTotalCustomerBasketPriceShouldBeTTC(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
