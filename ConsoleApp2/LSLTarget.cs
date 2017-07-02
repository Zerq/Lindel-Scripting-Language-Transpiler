using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using ICSharpCode.Decompiler;
using Mono.Cecil;
using System.IO;

namespace LSL
{
    public  class LSLTarget
    {
        public string Transpile() {

            var meType = this.GetType();

            var global = meType.GetNestedType("Global");
       
            var fields = global.GetFields(BindingFlags.Static | BindingFlags.Public).Where(n=> !n.FieldType.Name.StartsWith("Func`") && !n.FieldType.Name.StartsWith("Action`")).Select(n => {
                return new { Name = n.Name, Type = n.FieldType.Name };
            }).ToList();


            var methods = global.GetFields(BindingFlags.Static | BindingFlags.Public).Where(n => n.FieldType.Name.StartsWith("Func`") || n.FieldType.Name.StartsWith("Action`")).Select(n => {
            var temp = n.FieldType.GetGenericArguments();
            List<dynamic> parameters = new List<dynamic>();
            for (int i = 0; i < temp.Length; i++) {
                parameters.Add(new { Type = temp[i].Name, Name = "p" + i}); 
             }
                return new { Name = n.Name, Type = n.FieldType.Name, Parameters = parameters };
            }).ToList();

            var methods2 = global.GetMethods(BindingFlags.Static | BindingFlags.Public).Select(n => {
                return new {
                    Name = n.Name,
                    Type = n.ReturnType.Name,
                    Parameters =
                    n.GetParameters().Select(p =>
                    {
                        return new { Name = p.Name, Type = p.ParameterType.Name };
                    }).ToList(),
                   
                    Body = methodBodyToString(n)
                };
            }).ToList();

            return "";
        }

        private string methodBodyToString(MethodInfo method)
        {
       

            return "";
        }
    }
}
