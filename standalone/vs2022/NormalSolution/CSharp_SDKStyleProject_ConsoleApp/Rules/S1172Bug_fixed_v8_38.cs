namespace CSharp_SDKStyleProject_ConsoleApp.Rules
{
    // RSPEC examples:
    // https://sonarsource.github.io/rspec/#/rspec/S1172/csharp

    public class RspecS1172NonCompliant
    {

        private void DoSomething(int a, int b) // "b" is unused
        {
            Compute(a);
        }

        private void DoSomething2(int a) // value of "a" is unused
        {
            a = 10;
            Compute(a);
        }
        private static void Compute(int a) { Console.WriteLine(a); }
    }

    public class RspecS1172Compliant
    {
        private void DoSomething(int a)
        {
            Compute(a);
        }

        private void DoSomething2()
        {
            var a = 10;
            Compute(a);
        }

        private static void Compute(int a) { Console.WriteLine(a); }
    }

    // Example from bug: https://github.com/SonarSource/sonar-dotnet/issues/5491
    public class Class1
    {
        public static void Main(string[] args) // Should not see S1172 here
        {
            new Class1().DoSth("Test");
        }

        private void DoSth(string param) // Should not see S1172 here
        {
            Console.Out.WriteLine(param);
        }
    }
}