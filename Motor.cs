using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaTagCCM
{
    class Motor
    {
        public string ccm { get; set; }
        public string coluna { get; set; }
        public string tag { get; set; }
        public string motores { get; set; }

        public Motor(string ccm, string coluna, string tag, string motores)
        {
            this.ccm = ccm.Trim();
            this.coluna = coluna.Trim();
            this.tag = tag.Trim();
            this.motores = motores.Trim();
        }
    }
}
