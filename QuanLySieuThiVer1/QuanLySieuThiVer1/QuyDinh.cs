using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiVer1
{
   public class QuyDinh
    {

        public String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "00000" + autoNum;
            else if (autoNum >= 10 && autoNum < 100000)
                return "0000" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "000" + autoNum;
            else if (autoNum >= 10000 && autoNum < 100000)
                return "00" + autoNum;
            else if (autoNum >= 10000 && autoNum < 100000)
                return "0" + autoNum;
            else if (autoNum >= 10000 && autoNum < 100000)
                return "" + autoNum;
            else
                return "";
        }
    }
}
