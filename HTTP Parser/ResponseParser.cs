using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpParser
{

    class HttpResponseParser
    {

        public static Dictionary<string, string> Parse(string filename)
        {
            var temp = new Dictionary<string, string>();
            using (StreamReader file = new StreamReader(filename))
            {
                string ln = file.ReadLine();
                string[] s = ln.Split(new[] { ' ' }, 2);
                temp.Add("HttpAndVersion", s[0]);
                temp.Add("StatusCode", s[1]);

                while ((ln = file.ReadLine()) != null)
                {

                    if (ln.Contains(":"))
                    {
                        string[] sp = ln.Split(new[] { ':' }, 2);
                        temp.Add(sp[0], sp[1]);
                    }
                    else
                    {
                        break;
                    }

                }

                string data = file.ReadToEnd();
                temp.Add("Payload", data);
                file.Close();

            }

            return temp;
        }



    }
}