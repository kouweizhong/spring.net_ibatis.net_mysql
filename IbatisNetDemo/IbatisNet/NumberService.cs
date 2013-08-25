using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IbatisNet.Entity;

namespace IbatisNet
{
    public class NumberService
    {
        public List<Number> QueryAllNumber()
        {
            return BaseDao.GetMapper().QueryForList<Number>("SelectAll", null) as List<Number>;
        }
    }
}
