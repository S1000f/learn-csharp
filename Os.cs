using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    class Os {

        protected String osName;
        protected String osVersion;
        
        public Os(String name, String ver) {
            this.osName = name;
            this.osVersion = ver;
        }

        public String getOsName() {
            return osName;
        }

        public void setOsName(String name) {
            this.osName = name;
        }

        public void runOs() {

        }
    }
}
