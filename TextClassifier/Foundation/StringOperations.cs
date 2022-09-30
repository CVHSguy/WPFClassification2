using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextClassification.Foundation
{
    public class StringOperations
    {
        const int EXTENSIONLENGTH = 4;
        public static string getFileName(string path)
        {
            // a) skipping the extension .txt (4 chars)
            string name = path.Substring(0,path.Length-EXTENSIONLENGTH);

            // b) skipping the front part
            int startPos = name.LastIndexOf('\\')+1;
            name = name.Substring(startPos,name.Length-startPos);

            return name;
        }
    }
}
