namespace Taint_CSharp_NetCore_WebAppReact
{
    // TODO 1 : S1135 - not suppressed

    // TODO 2: S1135 - suppressed on server

    public class Suppressions_CSharp
    {
        public void EmptyMethod1() // S1186 - not suppressed 
        {
        }

        public void EmptyMethod2() // S1186 - suppressed on server
        {
        }
    }
}
