
using Codegen;


namespace LSL
{

    public class test2 {
        public static int testzor = 5;
    }
    public class test
    {
        public static int testInt = 13;

        public void run() {

            testInt  -= 10;

            Flow.State("default", () => {
              
                var x = testint == 3;
                test2.testzor = 4;
                var b6x = test2.testzor == 4;

                Flow.If(() => test.testint == 3, () => {
                    Math.llAbs(4);
                   
                });

            });

        }
    }
}
