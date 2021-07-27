using NUnit.Framework;
using CodeToTest;


namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5)]
        [TestCase(8)]
        [TestCase(12)]
        public void GivenATimeoBetween5and12Inclusive_Greeting_ReturnsGoodMorning(int time)
        {

            Assert.That(Program.Greeting(time), Is.EqualTo("Good Morning"));

            // arrange 
            //var expectedGreeting = "Good Morning";
            //// act
            //var result = Program.Greeting(time);
            //// assert
            //Assert.That(result, Is.EqualTo(expectedGreeting));
        }


        [TestCase(13)]
        [TestCase(16)]
        [TestCase(18)]
        public void GivenATimesBetween12and18Included_Greeting_ReturnsGoodAfternoon(int time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("Good afternoon"));

            //var expectedGreeting = "Good afternoon";
            //var result = Program.Greeting(time);
            //Assert.That(result, Is.EqualTo(expectedGreeting));
        }


        [TestCase(4)]
        [TestCase(19)]
        [TestCase(21)]
        public void GivenATimeoOutsideBoundries_Greeting_ReturnsGoodEvening(int time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("Good evening"));
            
            //var expectedGreeting = "Good evening";
            //var result = Program.Greeting(time);
            //Assert.That(result, Is.EqualTo(expectedGreeting));
        }











    }

}