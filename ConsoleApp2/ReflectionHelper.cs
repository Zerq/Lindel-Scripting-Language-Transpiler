using System;
using System.Collections.Generic;
using System.Text;

namespace LSL
{
    public class ReflectionHelper
    {
        public static bool IsValidType(Type type)
        {


            if (type == typeof(int))
            {
                return true;
            }
            else
            if (type == typeof(float))
            {
                return true;
            }
            else
            if (type == typeof(string))
            {
                return true;
            }
            else
            if (type == typeof(Codegen.Vector))
            {
                return true;
            }
            else
            if (type == typeof(Codegen.Rotation))
            {
                return true;
            }
            else
            if (type == typeof(Guid))
            {
                return true;
            }
            else {
                return false;
            }

        }

    }
}
