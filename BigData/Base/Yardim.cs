using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigData.Base
{
    public class Yardim
    {
        public void TryCatchKullan(Action _action)
        {
            try
            {
                _action();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
