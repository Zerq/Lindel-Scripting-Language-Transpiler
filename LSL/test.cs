
using Codegen;


namespace LSL
{
    public class test
    {
        public static int testInt = 13;

        public void run() {

            testInt  -= 10;

            Flow.State("default", () => {
              
                var x = test.testint == 3;

                Flow.If(() => test.testint == 3, () => {
                    Math.llAbs(4);
                   
                });

            });

        }
    }
}
