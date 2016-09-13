namespace Tests
{
    using NUnit.Framework;
    using Targets;

    public class TargetTests
    {
        [Test]
        public void Foo()
        {
            Assert.That(Target.Foo(), Is.EqualTo("Bar"));
        }
    }
}
