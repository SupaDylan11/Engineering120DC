using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using CalculatorLib;

namespace BDDCalculator
{
    [Binding]
    public class CalculatorStepDefinitions {


        private Exception _divideEception;
        private Calculator _calculator;
        private int _result;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        [Given(@"I enter (.*) and (.*) in the calculator")]
        public void GivenIEnterAndInTheCalculator(int a, int b)
        {
            _calculator.Num1 = a;
            _calculator.Num2 = b;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _result = _calculator.Subtract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            _result = _calculator.Multiply();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            
            try
            {
                _result = _calculator.Divide();
            } catch (Exception ex)
            {
                _divideEception = ex;
            }
        }

        [Then(@"the exception should have the message ""([^""]*)""")]
        public void ThenTheExceptionShouldHaveTheMessage(string expectedMsg)
        {
            Assert.That(() => _calculator.Divide, 
                Throws.TypeOf<DivideByZeroException>().With.Message.Contain(expectedMsg));
        }

        [Then(@"a DivideByZero Exception should be thrown")]
        public void ThenADivideByZeroExceptionShouldBeThrown()
        {
            Assert.That(() => _calculator.Divide, Throws.TypeOf<DivideByZeroException>());
        }

    }
}
