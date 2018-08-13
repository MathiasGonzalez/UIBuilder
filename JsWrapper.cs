using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFETest
{
    public class JsWrapper
    {
        public pra pra { get; set; }


        public JsWrapper()
        {
            pra = new pra();
            pra.LoadCatalog();
        }


        public List<string> loadCatalog(string path)
        {
            //MessageBox.Show(path);


            return pra.rawLines;
        }
    }
}
