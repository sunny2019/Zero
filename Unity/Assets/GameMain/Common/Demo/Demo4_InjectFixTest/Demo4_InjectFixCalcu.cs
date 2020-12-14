
using IFix;

namespace GameMain
{
    public class Demo4_InjectFixCalcu
    {
        //[Patch]
        public int Add(int a, int b)
        {
            return a * b;
        }

        //[Patch] 
        public int Sub(int a, int b)
        {
            return a / b;
        }
    }
}