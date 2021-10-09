using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrLab2.Data;

namespace PrLab2.Logic{
    class Empresa{
        DataB dt = new DataB();
        public Boolean register_new_emp(int nit, String name,String date) {
            return dt.reg_emp(nit, name, date);
        }
    }
}
