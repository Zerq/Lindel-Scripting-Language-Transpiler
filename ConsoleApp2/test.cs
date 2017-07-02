
using Codegen;


namespace  TestScript
{
    public class ScriptBody : LSL.LSLTarget
    {
        public class Global
        {
            public static int testint = 5;
            public static System.Func<string, string, string> concatTest = (string a, string b) =>
            {
                return a + b;
            };
        }
        public System.Action run = () =>
        {
            Flow.State("default", () =>
            {
                var x = Global.testint == 3;
                Flow.If(() => Global.testint == 3, () =>
                {
                    Math.Abs(4);
                });

                List myList = new List("", 2, new Vector(4, 3, 1));
                myList.ForEach<string>(n =>
                {
                    Communication.Say(0, n);
                });
            });

        };
    }
}
