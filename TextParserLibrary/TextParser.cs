using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Text;

namespace TextParserLibrary
{
    public class TextParser
    {
        public static string JsonToText(string json)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(json);

            //try
            //{
            //    JObject obj = JObject.Parse(json);
            //    stringBuilder.AppendLine($"Status: {obj["status"]}.");
            //    stringBuilder.AppendLine($"Response data:");

            //    foreach (var data in obj["data"])
            //    {
            //        stringBuilder.AppendLine($"{data["id"]}\t\t{data["employee_name"]}\t\t\t{data["employee_age"]}\t\t{int.Parse((string)data["employee_salary"]):c0}");
            //    }
            //} catch(Exception e)
            //{
            //    return e.Message;
            //}

            return stringBuilder.ToString();
        }
    }
}
