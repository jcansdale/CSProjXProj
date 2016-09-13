namespace Tests
{
    using Targets;
    using NUnit.Framework;

    public class TargetTests
    {
        [Test]
        public void Foo()
        {
            Assert.That(Target.Foo(), Is.EqualTo("Bar"));
        }
    }
}
