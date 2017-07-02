using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Codegen
{
    // implementations are not really important or nessesary.. i've just done them to verify that they should work...
    //this is just here to be reflected and translated into 
    public static class Flow
    {

        public static void ForEach<T>(this Codegen.List list, Action<T> action) {
           
        }

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

       

        public static void For(int start, Func<int, bool> evaluator, Action<int> incrementor, Action<int> block) {
            for (int cnt = start; evaluator(cnt); incrementor(cnt)) {
                block(cnt);
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
