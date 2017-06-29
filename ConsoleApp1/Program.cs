using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Dynamic;

namespace ConsoleApp1 {



    public class Loader {
        public static List<Funk> Load() {
            var functions = File.ReadAllText(@"%userprofile%\documents\visual studio 2017\Projects\LSL\ConsoleApp1\test.json");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Funk>>(functions).Where(n => !string.IsNullOrEmpty(n.Name)).ToList();



        }
        public static string SAFE(string name) {
            switch (name)
            {
                case "object":
                    return "obj3ct";
                case "params":
                    return "paramz";
                case "base":
                    return "baze";
                case "checked":
                    return "ch3cked";

                default:
                    return name;
            }

          
        }
        public static string VOID(Types type){
            if (type == Types.Void) {
                return "void";
            }
            else {
               return type.ToString();
            }
        }
    }





    public enum Types {
        Integer, Float, Vector, Rotation, List, Void, Key, String
    }

    public class Parameter {
        public Types Type { get; set; }
        public string Name { get; set; }
    }

    public class Funk {
        public Types ReturnParam;
        public string Name;
        public List<Parameter> Parameters { get; set; }
    }
    class Program
    {

        static Types getType(string x) {
            var y = "";
            if (x == "") {
                 y = "Void";
            }
            else {
                 y = x.Substring(0, 1).ToUpper() + x.Substring(1, x.Count() - 1);
            }
            return (Types)Enum.Parse(typeof(Types), y); 
        }
        static void Main(string[] args)
        {


            var functions = File.ReadAllText("test.json");


            
   
 
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Funk>>(functions);
            obj.Where(p => !string.IsNullOrEmpty(p.Name)).ToList().ForEach(n => { });
            

                var data = File.ReadAllText("HTMLPage1.html").Split(new String[] { "\n" }, StringSplitOptions.None).ToList();
            List<Funk> funcs = new List<Funk>();
                data.ForEach(n => {

                  var index = n.LastIndexOf("/")+1;
                   var name = n.Substring(index);
                    var path = $@"C:\lslDumps\{name}.html";
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.Load(path);
                    var item = doc.GetElementbyId("Summary");
                    var html = item.InnerHtml;
                    var text = item.InnerText;

                    Regex rex = new Regex(@"Function: ([^\s]*)\s([^(]*)\(([^)]*)\);");
                    var match = rex.Match(text);
                    Funk result = new Funk();
                    result.ReturnParam = getType(match.Groups[1].Value);
                    result.Name = match.Groups[2].Value;


                    result.Parameters = match.Groups[3].Value.Split(',').Where(x=> x.Count() > 0).Select(x =>
                    {
                        var temp = x.Split(' ');
                        return new Parameter { Type = getType(temp[1]), Name = temp[2] };
                    }).ToList();
               
            


                    funcs.Add(result);

            //        System.Threading.Thread.Sleep(400);
            //        Console.Clear();
            //        Console.Write(data.IndexOf(n)/ data.Count );
                });


            //var data = File.ReadAllText("HTMLPage1.html").Split(new String[] { "\n" }, StringSplitOptions.None).ToList();
            //using (System.Net.WebClient clinet = new System.Net.WebClient()) {
            //    data.ForEach(n => {

            //        var index = n.LastIndexOf("/")+1;
            //        var name = n.Substring(index);
            //        clinet.DownloadFile(n, $@"C:\lslDumps\{name}.html");
            //        System.Threading.Thread.Sleep(400);
            //        Console.Clear();
            //        Console.Write(data.IndexOf(n)/ data.Count );
            //    });

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(funcs);
            File.WriteAllText(json, "1.txt");
            var lobj = Newtonsoft.Json.JsonConvert.DeserializeObject(json, typeof(List<Funk>) );

               



        }

    }
    
}
