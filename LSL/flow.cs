using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Codegen
{
    public class Flow
    {
        public static void If(System.Func<bool> evaluator, System.Action thenBlock)
        {
            if (evaluator())
            {
                thenBlock();
            }        
        }
        public static void If(System.Func<bool> evaluator, System.Action thenBlock, System.Action elseBlock)
        {
            if (evaluator())
            {
                thenBlock();
            }
            else
            {
                elseBlock();
            }
        }






        public static void Switch<T>(T comparatorObject, params System.Collections.Generic.KeyValuePair<T, System.Action>[] cases)
        {
            cases.FirstOrDefault(n => n.Key.Equals(comparatorObject)).Value();
        }
        public static void DoWhile(Action action, Func<bool> evaluator) {
            do { action(); } while (evaluator());
        }
        public static void Jump(string anchor) {} // GO TO HELL AND BURN! but if you have to //@anchorName

       
        public static void State(string name) {

        }

        public static void State(string name, Action block)
        {

        }
    }


  

}
