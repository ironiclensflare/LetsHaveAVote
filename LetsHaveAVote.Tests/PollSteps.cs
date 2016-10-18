using NUnit.Framework;
using TechTalk.SpecFlow;

namespace LetsHaveAVote.Tests
{
    [Binding]
    public class PollSteps
    {
        private int _number1, _number2, _total;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _number1 = p0;
        }
        
        [Given(@"I have then entered (.*) into the calculator")]
        public void GivenIHaveThenEnteredIntoTheCalculator(int p0)
        {
            _number2 = p0;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _total = _number1 + _number2;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(_number1 + _number2, p0);
        }
    }
}
