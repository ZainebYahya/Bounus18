using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounus18
{
    class Certified :UsedCar
    {
        protected string certificatioinnumber;
        public string Certificationnumber { set; get; }

        public Certified(string carmake,string carmodel,int caryear,double carprice,double carmialage,string carcertification)
            :base( carmake, carmodel, caryear,  carprice, carmialage)
        {
            Certificationnumber = carcertification;
        }

    }
}
