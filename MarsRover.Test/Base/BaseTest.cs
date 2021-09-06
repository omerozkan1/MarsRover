using NUnit.Framework;
using System;

namespace MarsRover.Test.Base
{
    [SetUpFixture]
    public abstract class BaseTest
    {
        protected virtual void BeginTest()
        {
            Console.WriteLine("TestStarting");
        }

        [OneTimeSetUp]
        protected virtual void RunBeforeAnyTests()
        {
            Console.WriteLine("BeforeTest");
        }

        [OneTimeTearDown]
        protected virtual void RunAfterAnyTests()
        {
            Console.WriteLine("AfterTest");
        }

        [SetUp]
        protected virtual void SetUp()
        {
        }
    }
}
