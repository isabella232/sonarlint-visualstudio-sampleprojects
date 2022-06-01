namespace CSharp_SDKStyleProject_ConsoleApp.Rules
{
    internal class S4581_WithCodeFix_v8_40
    {
        public void Foo()
        {
            var g1 = new Guid();    // Noncompliant - what's the intent?
            Guid g2 = new();        // Noncompliant
            var g3 = default(Guid); // Noncompliant
            Guid g4 = default;      // Noncompliant
        }
    }
}
