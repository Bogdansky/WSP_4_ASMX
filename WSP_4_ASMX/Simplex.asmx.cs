using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using Newtonsoft.Json;

namespace WSP_4_ASMX
{
    /// <summary>
    /// Сводное описание для Simplex
    /// </summary>
    [WebService(Namespace = "http://KBA.org/", Description = "ASMX-сервис для лабораторной №4")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    [System.Web.Script.Services.ScriptService]
    public class Simplex : System.Web.Services.WebService
    {
        [WebMethod(Description = "Привет, мир!", MessageName = "KBA.HelloWorld")]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        [WebMethod(Description = "Сумма x и y", MessageName = "KBA.Add")]
        public int Add(int x, int y)
        {
            return x + y;
        }

        [WebMethod(Description = "Конкатенация строки s и числа с двумя знаками после запятой d", MessageName = "KBA.Concat")]
        public string Concat(string s, double d)
        {
            return string.Concat(s, d);
        }
        
        [WebMethod(Description = "Сумма объектов класса A", MessageName = "KBA.Sum")]
        public A Sum(A first, A second)
        {
            if (!(first is A) || !(second is A))
            {
                return null;
            }
            var firstA = first as A;
            var secondA = second as A;
            return new A
            {
                S = firstA.S + secondA.S,
                K = firstA.K + secondA.K,
                F = firstA.F + secondA.F
            };
        }

        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod(Description = "Сложение чисел (AJAX)", MessageName = "KBA.AddS")]
        public string AddS(int x, int y)
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
            return JsonConvert.SerializeObject(x + y);
        }
    }
    [DataContract]
    public class A
    {
        [DataMember]
        public string S { get; set; }
        [DataMember]
        public int K { get; set; }
        [DataMember]
        public float F { get; set; }
    }
}
